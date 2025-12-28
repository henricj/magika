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

namespace Magika;

/// <summary>
///     Reason why a content type was overwritten.
/// </summary>
public enum OverwriteReason
{
    /// <summary>No overwrite occurred.</summary>
    None,

    /// <summary>The inference score was too low for the inferred content type.</summary>
    LowConfidence,

    /// <summary>The inferred content type is mapped to a different canonical type.</summary>
    OverwriteMap
}

/// <summary>
///     Result of file type identification.
/// </summary>
public sealed class MagikaResult
{
    /// <summary>
    ///     The identified content type.
    /// </summary>
    public required ContentType ContentType { get; init; }

    /// <summary>
    ///     The confidence score (0.0 to 1.0).
    ///     For rule-based identification, this is always 1.0.
    /// </summary>
    public required float Score { get; init; }

    /// <summary>
    ///     Whether the result was determined by the AI model or by rules.
    /// </summary>
    public required bool IsModelResult { get; init; }

    /// <summary>
    ///     The original inferred type before any overwrite.
    ///     Only set if an overwrite occurred.
    /// </summary>
    public ContentType? InferredType { get; init; }

    /// <summary>
    ///     The reason for the overwrite, if any.
    /// </summary>
    public OverwriteReason OverwriteReason { get; init; } = OverwriteReason.None;

    /// <summary>
    ///     Gets metadata information for the identified content type.
    /// </summary>
    public ContentTypeInfo Info => ContentTypeData.GetInfo(ContentType);

    /// <summary>
    ///     Creates a rule-based result.
    /// </summary>
    internal static MagikaResult Ruled(ContentType contentType) => new()
    {
        ContentType = contentType,
        Score = 1.0f,
        IsModelResult = false
    };

    /// <summary>
    ///     Creates an inference result.
    /// </summary>
    internal static MagikaResult Inferred(
        ContentType contentType,
        float score,
        ContentType? inferredType = null,
        OverwriteReason overwriteReason = OverwriteReason.None) => new()
    {
        ContentType = contentType,
        Score = score,
        IsModelResult = true,
        InferredType = inferredType,
        OverwriteReason = overwriteReason
    };
}