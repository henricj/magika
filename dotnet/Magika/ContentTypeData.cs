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

using System.Collections.Frozen;

namespace Magika;

/// <summary>
///     Provides metadata for all supported content types.
/// </summary>
public static partial class ContentTypeData
{
    private static readonly FrozenDictionary<string, ContentType> LabelToContentType;

    static ContentTypeData()
    {
        // Build label-to-ContentType dictionary from the info array
        LabelToContentType = Info
            .ToFrozenDictionary(kvp => kvp.Value.Label, kvp => kvp.Key, StringComparer.OrdinalIgnoreCase);
    }

    /// <summary>
    ///     Gets metadata information for a content type.
    /// </summary>
    public static ContentTypeInfo GetInfo(ContentType contentType) => Info[contentType];

    /// <summary>
    ///     Gets metadata information for a content type, or null if not found.
    /// </summary>
    public static ContentTypeInfo? TryGetInfo(ContentType contentType) =>
        Info.GetValueOrDefault(contentType);

    /// <summary>
    ///     Gets a content type by its label (case-insensitive).
    /// </summary>
    /// <param name="label">The label to look up.</param>
    /// <returns>The content type, or <see cref="ContentType.Unknown" /> if not found.</returns>
    public static ContentType GetContentType(string label) =>
        LabelToContentType.GetValueOrDefault(label, ContentType.Unknown);

    /// <summary>
    ///     Tries to get a content type by its label (case-insensitive).
    /// </summary>
    /// <param name="label">The label to look up.</param>
    /// <param name="contentType">The content type if found.</param>
    /// <returns>True if found, false otherwise.</returns>
    public static bool TryGetContentType(string label, out ContentType contentType) =>
        LabelToContentType.TryGetValue(label, out contentType);
}