namespace Magika;

public static class MagikaDetectorExtensions
{
    /// <summary>
    ///     Identifies the content type of a file.
    /// </summary>
    /// <param name="detector"></param>
    /// <param name="path">Path to the file.</param>
    /// <returns>The identification result.</returns>
    public static MagikaResult IdentifyFile(this IMagikaDetector detector, string path)
    {
        var fileInfo = new FileInfo(path);

        if (!fileInfo.Exists)
            throw new FileNotFoundException("File not found", path);

        // Handle special file types
        if (fileInfo.Attributes.HasFlag(FileAttributes.Directory))
            return MagikaResult.Ruled(ContentType.Directory);

        if (fileInfo.Attributes.HasFlag(FileAttributes.ReparsePoint))
            return MagikaResult.Ruled(ContentType.Symlink);

        using var stream = File.OpenRead(path);
        return detector.IdentifyStream(stream);
    }
}