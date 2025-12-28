namespace Magika;

public sealed class MagikaLoader
{
    /// <summary>
    ///     Creates a new Magika detector with a custom model path.
    /// </summary>
    /// <param name="modelPath">Path to the ONNX model file.</param>
    /// <param name="configPath">Path to the config.json file.</param>
    public static MagikaDetector Load(string modelPath, string configPath)
    {
        return new(File.ReadAllBytes(modelPath), LoadConfigFromFile(configPath));
    }

    private static ModelConfig LoadConfigFromFile(string path)
    {
        using var stream = File.OpenRead(path);
        return ModelConfig.LoadFromStream(stream);
    }
}