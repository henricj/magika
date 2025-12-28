namespace Magika;

public interface IMagikaDetector
{
    /// <summary>
    ///     Identifies the content type from a stream.
    /// </summary>
    /// <param name="stream">The stream to identify. Must be seekable.</param>
    /// <returns>The identification result.</returns>
    MagikaResult IdentifyStream(Stream stream);

    /// <summary>
    ///     Identifies the content type from byte content.
    /// </summary>
    /// <param name="content">The content bytes.</param>
    /// <returns>The identification result.</returns>
    MagikaResult IdentifyBytes(ReadOnlySpan<byte> content);
}