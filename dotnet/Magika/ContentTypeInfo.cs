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
///     Metadata information about a content type.
/// </summary>
public sealed class ContentTypeInfo
{
    /// <summary>
    ///     The unique label identifying this content type.
    /// </summary>
    public required string Label { get; init; }

    /// <summary>
    ///     The MIME type for this content type.
    /// </summary>
    public required string MimeType { get; init; }

    /// <summary>
    ///     The group/category this content type belongs to.
    /// </summary>
    public required string Group { get; init; }

    /// <summary>
    ///     A human-readable description of this content type.
    /// </summary>
    public required string Description { get; init; }

    /// <summary>
    ///     Common file extensions for this content type.
    /// </summary>
    public required string[] Extensions { get; init; }

    /// <summary>
    ///     Whether this content type represents text content.
    /// </summary>
    public required bool IsText { get; init; }
}