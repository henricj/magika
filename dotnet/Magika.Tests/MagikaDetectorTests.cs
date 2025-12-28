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

using System.Text;
using Xunit;

namespace Magika.Tests;

public sealed class MagikaDetectorTests : IDisposable
{
    private static readonly string TestDataBasicPath = Path.Combine("..", "..", "..", "..", "..", "tests_data", "basic");

    private readonly MagikaDetector _detector = MagikaStandardV3_3.Load();

    public void Dispose()
    { }

    [Fact]
    public void IdentifyBytes_EmptyContent_ReturnsEmpty()
    {
        var result = _detector.IdentifyBytes([]);

        Assert.Equal(ContentType.Empty, result.ContentType);
        Assert.False(result.IsModelResult);
        Assert.Equal(1.0f, result.Score);
    }

    [Fact]
    public void IdentifyBytes_SmallTextContent_ReturnsTxt()
    {
        var content = "Hello"u8;
        var result = _detector.IdentifyBytes(content);

        Assert.Equal(ContentType.Txt, result.ContentType);
        Assert.False(result.IsModelResult);
    }

    [Fact]
    public void IdentifyBytes_JsonContent_ReturnsJson()
    {
        const string json =
            """
            {
                "name": "test",
                "value": 123,
                "nested": {
                    "array": [1, 2, 3],
                    "bool": true
                }
            }
            """;
        // Pad to ensure we have enough content for model inference
        var content = Encoding.UTF8.GetBytes(json.PadRight(256, ' '));

        var result = _detector.IdentifyBytes(content);

        Assert.True(result.IsModelResult);
        Assert.Equal(ContentType.Json, result.ContentType);
    }

    [Fact]
    public void IdentifyBytes_PythonSource_ReturnsPython()
    {
        var python =
            """
            #!/usr/bin/env python3
            import os
            import sys

            def main():
                print("Hello, World!")
                return 0

            if __name__ == "__main__":
                sys.exit(main())
            """u8;

        var result = _detector.IdentifyBytes(python);

        Assert.True(result.IsModelResult);
        Assert.Equal(ContentType.Python, result.ContentType);
    }

    [Fact]
    public void IdentifyBytes_HtmlContent_ReturnsHtml()
    {
        var html = """
                   <!DOCTYPE html>
                   <html lang="en">
                   <head>
                       <meta charset="UTF-8">
                       <title>Test Page</title>
                   </head>
                   <body>
                       <h1>Hello, World!</h1>
                       <p>This is a test HTML page.</p>
                   </body>
                   </html>
                   """u8;

        var result = _detector.IdentifyBytes(html);

        Assert.True(result.IsModelResult);
        Assert.Equal(ContentType.Html, result.ContentType);
    }

    [Fact]
    public void ContentTypeInfo_HasCorrectMetadata()
    {
        var info = ContentTypeData.GetInfo(ContentType.Pdf);

        Assert.Equal("pdf", info.Label);
        Assert.Equal("application/pdf", info.MimeType);
        Assert.Equal("document", info.Group);
        Assert.Contains("pdf", info.Extensions);
        Assert.False(info.IsText);
    }

    [Fact]
    public void ContentTypeInfo_TextType_IsTextTrue()
    {
        var info = ContentTypeData.GetInfo(ContentType.Python);

        Assert.True(info.IsText);
        Assert.Equal("code", info.Group);
    }

    [Fact]
    public async Task IdentifyFile_ValidFile_ReturnsResult()
    {
        // Create a temp file with Python content
        var tempFile = Path.GetTempFileName();
        try
        {
            await File.WriteAllTextAsync(tempFile,
                """
                #!/usr/bin/env python3
                import sys
                print("Hello")
                """);

            var result = _detector.IdentifyFile(tempFile);

            Assert.NotNull(result);
            Assert.True(result.Score > 0);
        }
        finally
        {
            File.Delete(tempFile);
        }
    }

    [Theory]
    [MemberData(nameof(GetBasicTestFiles))]
    public void IdentifyBytes_BasicTestFiles_ReturnsExpectedType(string folderName, string filePath, ContentType expectedType)
    {
        if (!File.Exists(filePath))
        {
            // Skip if test data not available
            return;
        }

        var content = File.ReadAllBytes(filePath);
        var result = _detector.IdentifyBytes(content);

        // For empty files, the result is ruled (not model)
        if (expectedType == ContentType.Empty)
        {
            Assert.Equal(ContentType.Empty, result.ContentType);
            return;
        }

        // Assert the detected type matches expected (folderName used in error message)
        Assert.True(result.ContentType == expectedType,
            $"File in '{folderName}' folder detected as {result.ContentType} (score: {result.Score:P}) but expected {expectedType
            }");
    }

    public static IEnumerable<object[]> GetBasicTestFiles()
    {
        var basicPath = Path.GetFullPath(TestDataBasicPath);
        if (!Directory.Exists(basicPath))
        {
            yield break;
        }

        foreach (var folder in Directory.GetDirectories(basicPath))
        {
            var folderName = Path.GetFileName(folder);

            // Use ContentTypeData to map folder name to content type
            if (!ContentTypeData.TryGetContentType(folderName, out var expectedType))
            {
                // Unknown folder, skip
                continue;
            }

            foreach (var file in Directory.GetFiles(folder))
            {
                yield return [folderName, file, expectedType];
            }
        }
    }
}