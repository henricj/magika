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

using System.Buffers;

namespace Magika;

/// <summary>
///     Extracts features from file content for the Magika model.
/// </summary>
internal static class FeatureExtractor
{
    // ASCII whitespace: space, tab, newline, carriage return, form feed, vertical tab
    private static ReadOnlySpan<byte> WhitespaceBytes => [(byte)' ', (byte)'\t', (byte)'\n', (byte)'\r', (byte)'\f', 0x0b];

    /// <summary>
    ///     Extracts features from byte content directly into the provided span.
    /// </summary>
    public static void ExtractFeatures(ReadOnlySpan<byte> content, ModelConfig config, Span<int> features)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(features.Length, config.FeaturesSize);

        features.Fill(config.PaddingToken);

        if (content.Length == 0)
            return;

        var blockSize = Math.Min(config.BlockSize, content.Length);

        // Get beginning content (first block, strip leading whitespace)
        var begContent = content[..blockSize];
        begContent = begContent.TrimStart(WhitespaceBytes);

        // Get ending content (last block, strip trailing whitespace)
        var endOffset = Math.Max(0, content.Length - blockSize);
        var endContent = content[endOffset..];
        endContent = endContent.TrimEnd(WhitespaceBytes);

        // Copy beginning features (left-aligned in the beg region)
        CopyFeatures(features[..config.BegSize], begContent, false);

        // Copy ending features (right-aligned in the end region)
        CopyFeatures(features.Slice(config.BegSize, config.EndSize), endContent, true);
    }

    /// <summary>
    ///     Extracts features from a stream directly into the provided span.
    ///     Also copies the first block into the provided buffer for fallback detection.
    /// </summary>
    /// <param name="stream">The stream to read from.</param>
    /// <param name="config">The model configuration.</param>
    /// <param name="features">The span to write features into.</param>
    /// <param name="firstBlock">
    ///     Buffer to receive the first block (must be at least blockSize).
    ///     The actual bytes read is returned.
    /// </param>
    /// <returns>The number of bytes in the first block.</returns>
    public static int ExtractFeaturesFromStream(Stream stream, ModelConfig config, Span<int> features, Span<byte> firstBlock)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(features.Length, config.FeaturesSize);

        features.Fill(config.PaddingToken);

        var length = checked((int)stream.Length);
        if (length == 0)
            return 0;

        var blockSize = Math.Min(config.BlockSize, length);
        ArgumentOutOfRangeException.ThrowIfLessThan(firstBlock.Length, blockSize);

        var firstBlockSpan = firstBlock[..blockSize];

        // Read beginning block directly into caller's buffer
        stream.Position = 0;
        stream.ReadExactly(firstBlockSpan);

        // For small files (single block), trim both ends and use for both beg and end
        // For large files, we read separate blocks
        if (length <= blockSize)
        {
            var begContent = firstBlockSpan.TrimStart(WhitespaceBytes);
            var endContent = firstBlockSpan.TrimEnd(WhitespaceBytes);

            CopyFeatures(features[..config.BegSize], begContent, false);
            CopyFeatures(features.Slice(config.BegSize, config.EndSize), endContent, true);
        }
        else
        {
            // Copy beginning features (left-aligned)
            var begContent = firstBlockSpan.TrimStart(WhitespaceBytes);
            CopyFeatures(features[..config.BegSize], begContent, false);

            // Rent a buffer for the ending block
            var endBuffer = ArrayPool<byte>.Shared.Rent(blockSize);
            try
            {
                var endBufferSpan = endBuffer.AsSpan(0, blockSize);
                stream.Position = length - blockSize;
                stream.ReadExactly(endBufferSpan);
                var endContent = endBufferSpan.TrimEnd(WhitespaceBytes);
                CopyFeatures(features.Slice(config.BegSize, config.EndSize), endContent, true);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(endBuffer);
            }
        }

        return blockSize;
    }

    private static void CopyFeatures(Span<int> dst, ReadOnlySpan<byte> src, bool alignRight)
    {
        var len = Math.Min(dst.Length, src.Length);
        if (len == 0)
            return;

        var dstOffset = alignRight ? dst.Length - len : 0;
        var srcOffset = alignRight ? src.Length - len : 0;

        for (var i = 0; i < len; i++)
        {
            dst[dstOffset + i] = src[srcOffset + i];
        }
    }
}