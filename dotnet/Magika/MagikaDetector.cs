// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System.Buffers;
using System.Collections.Frozen;
using System.Text.Unicode;

namespace Magika;

/// <summary>
///     File type detection using deep learning.
///     A .NET port of Google's Magika.
/// </summary>
public sealed class MagikaDetector : IDisposable, IMagikaDetector
{
    private readonly ModelConfig _config;
    private readonly ContentType[] _contentTypes;
    private readonly string _inputName;

    // Optimized lookup structures built from config
    private readonly string[] _labels;
    private readonly FrozenDictionary<string, ContentType> _overwriteMap;
    private readonly InferenceSession _session;
    private readonly FrozenDictionary<string, float> _thresholds;
    private bool _disposed;

    /// <summary>
    ///     Creates a new Magika detector with model bytes and config.
    /// </summary>
    /// <param name="modelBytes">The ONNX model bytes.</param>
    /// <param name="config">The model configuration.</param>
    public MagikaDetector(byte[] modelBytes, ModelConfig config)
    {
        _config = config;
        _session = new(modelBytes);
        _inputName = _session.InputMetadata.Keys.First();

        // Build optimized lookup structures from config
        _labels = config.TargetLabelsSpace;
        _contentTypes = new ContentType[_labels.Length];
        for (var i = 0; i < _labels.Length; i++)
        {
            _contentTypes[i] = ContentTypeData.GetContentType(_labels[i]);
        }

        _thresholds = config.Thresholds?.ToFrozenDictionary(StringComparer.Ordinal)
            ?? FrozenDictionary<string, float>.Empty;

        _overwriteMap = config.OverwriteMap?
                .ToFrozenDictionary(
                    kvp => kvp.Key,
                    kvp => ContentTypeData.GetContentType(kvp.Value),
                    StringComparer.Ordinal)
            ?? FrozenDictionary<string, ContentType>.Empty;
    }

    /// <summary>
    ///     Disposes the detector and releases resources.
    /// </summary>
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _session.Dispose();
        _disposed = true;
    }

    /// <summary>
    ///     Identifies the content type from a stream.
    /// </summary>
    /// <param name="stream">The stream to identify. Must be seekable.</param>
    /// <returns>The identification result.</returns>
    public MagikaResult IdentifyStream(Stream stream)
    {
        if (!stream.CanSeek)
            throw new ArgumentException("Stream must be seekable", nameof(stream));

        if (stream.Length == 0)
            return MagikaResult.Ruled(ContentType.Empty);

        // For very small files, use rule-based detection
        if (stream.Length < _config.MinFileSizeForDl)
        {
            var streamLength = checked((int)stream.Length);
            var wholeStreamBuffer = ArrayPool<byte>.Shared.Rent(streamLength);
            var content = wholeStreamBuffer.AsSpan(..streamLength);

            try
            {
                stream.Position = 0;
                stream.ReadExactly(content);
                return IdentifySmallFile(content);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(wholeStreamBuffer);
            }
        }

        // Rent a buffer for the first block (used for fallback detection if needed)
        var firstBlockBuffer = ArrayPool<byte>.Shared.Rent(_config.BlockSize);
        try
        {
            var inputTensor = new DenseTensor<int>([1, _config.FeaturesSize]);

            var features = inputTensor.Buffer.Span;
            var firstBlockSize = FeatureExtractor.ExtractFeaturesFromStream(stream, _config, features, firstBlockBuffer);

            // Check if file is too small for model (padding check)
            if (features[_config.MinFileSizeForDl - 1] == _config.PaddingToken)
            {
                return IdentifySmallFile(firstBlockBuffer.AsSpan(0, firstBlockSize));
            }

            return RunInference(inputTensor);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(firstBlockBuffer);
        }
    }

    /// <summary>
    ///     Identifies the content type from byte content.
    /// </summary>
    /// <param name="content">The content bytes.</param>
    /// <returns>The identification result.</returns>
    public MagikaResult IdentifyBytes(ReadOnlySpan<byte> content)
    {
        if (content.Length == 0)
            return MagikaResult.Ruled(ContentType.Empty);

        if (content.Length < _config.MinFileSizeForDl)
            return IdentifySmallFile(content);

        // Extract features directly into the tensor
        var inputTensor = new DenseTensor<int>([1, _config.FeaturesSize]);
        var features = inputTensor.Buffer.Span;
        FeatureExtractor.ExtractFeatures(content, _config, features);

        // Check if file is too small for model
        if (features[_config.MinFileSizeForDl - 1] == _config.PaddingToken)
        {
            var blockSize = Math.Min(_config.BlockSize, content.Length);
            return IdentifySmallFile(content[..blockSize]);
        }

        return RunInference(inputTensor);
    }

    private static MagikaResult IdentifySmallFile(ReadOnlySpan<byte> content)
    {
        // For small files, check if it's valid UTF-8 text
        return MagikaResult.Ruled(Utf8.IsValid(content)
            ? ContentType.Txt
            : ContentType.Unknown);
    }

    private MagikaResult RunInference(DenseTensor<int> inputTensor)
    {
        var onnxValue = NamedOnnxValue.CreateFromTensor(_inputName, inputTensor);

        // Run inference
        using var results = _session.Run([onnxValue]);
        var output = results.First().AsTensor<float>();

        // Output shape is [1, num_labels] - find best prediction
        var numLabels = output.Dimensions[1];
        var bestIdx = 0;
        var bestScore = float.MinValue;
        for (var i = 0; i < numLabels; i++)
        {
            var score = output[0, i];
            if (score > bestScore)
            {
                bestScore = score;
                bestIdx = i;
            }
        }

        var label = _labels[bestIdx];
        var inferredType = _contentTypes[bestIdx];
        var threshold = _thresholds.GetValueOrDefault(label, _config.MediumConfidenceThreshold);

        // Apply threshold check
        if (bestScore < threshold)
        {
            var info = ContentTypeData.GetInfo(inferredType);
            var fallbackType = info.IsText ? ContentType.Txt : ContentType.Unknown;
            return MagikaResult.Inferred(
                fallbackType,
                bestScore,
                inferredType,
                OverwriteReason.LowConfidence);
        }

        // Apply overwrite map
        if (_overwriteMap.TryGetValue(label, out var overwriteType) && overwriteType != inferredType)
        {
            return MagikaResult.Inferred(
                overwriteType,
                bestScore,
                inferredType,
                OverwriteReason.OverwriteMap);
        }

        return MagikaResult.Inferred(inferredType, bestScore);
    }
}