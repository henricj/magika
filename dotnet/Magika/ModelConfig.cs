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

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Magika;

/// <summary>
///     Configuration for the Magika model.
/// </summary>
public sealed partial class ModelConfig
{
    public const int DefaultBegSize = 1024;
    public const int DefaultEndSize = 1024;
    public const int DefaultMinFileSizeForDl = 8;
    public const int DefaultPaddingToken = 256;
    public const int DefaultBlockSize = 4096;
    public const float DefaultMediumConfidenceThreshold = 0.5f;

    [JsonPropertyName("beg_size")]
    public int BegSize { get; set; } = DefaultBegSize;

    [JsonPropertyName("mid_size")]
    public int MidSize { get; set; }

    [JsonPropertyName("end_size")]
    public int EndSize { get; set; } = DefaultEndSize;

    [JsonPropertyName("min_file_size_for_dl")]
    public int MinFileSizeForDl { get; set; } = DefaultMinFileSizeForDl;

    [JsonPropertyName("padding_token")]
    public int PaddingToken { get; set; } = DefaultPaddingToken;

    [JsonPropertyName("block_size")]
    public int BlockSize { get; set; } = DefaultBlockSize;

    [JsonPropertyName("medium_confidence_threshold")]
    public float MediumConfidenceThreshold { get; set; } = DefaultMediumConfidenceThreshold;

    [JsonPropertyName("target_labels_space")]
    public string[] TargetLabelsSpace { get; set; } = [];

    [JsonPropertyName("thresholds")]
    public Dictionary<string, float>? Thresholds { get; set; }

    [JsonPropertyName("overwrite_map")]
    public Dictionary<string, string>? OverwriteMap { get; set; }

    public int FeaturesSize => BegSize + MidSize + EndSize;

    public static ModelConfig LoadFromStream(Stream stream)
    {
        return JsonSerializer.Deserialize(stream, ModelConfigSerializerContext.Default.ModelConfig)
            ?? throw new InvalidOperationException("Failed to deserialize model config");
    }

    [JsonSourceGenerationOptions(JsonSerializerDefaults.Web)]
    [JsonSerializable(typeof(ModelConfig))]
    internal partial class ModelConfigSerializerContext : JsonSerializerContext;
}