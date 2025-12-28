using System.Reflection;

namespace Magika;

public static class MagikaStandardV3_3
{
    /// <summary>
    ///     Model name.
    /// </summary>
    public const string ModelName = "standard_v3_3";

    /// <summary>
    ///     Model major version.
    /// </summary>
    public const int ModelMajorVersion = 3;


    /// <summary>
    ///     Creates a new Magika detector using the embedded model.
    /// </summary>
    public static MagikaDetector Load()
    {
        return new(LoadEmbeddedModel(), LoadEmbeddedConfig());
    }

    private static byte[] LoadEmbeddedModel()
    {
        var assembly = Assembly.GetExecutingAssembly();
        const string resourceName = "Magika.Models.model.onnx";

        using var stream = assembly.GetManifestResourceStream(resourceName)
            ?? throw new InvalidOperationException($"Embedded model not found: {resourceName}");

        var buffer = new byte[stream.Length];

        stream.ReadExactly(buffer);

        return buffer;
    }


    private static ModelConfig LoadEmbeddedConfig()
    {
        var assembly = Assembly.GetExecutingAssembly();
        const string resourceName = "Magika.Models.config.json";

        using var stream = assembly.GetManifestResourceStream(resourceName)
            ?? throw new InvalidOperationException($"Embedded config not found: {resourceName}");

        return ModelConfig.LoadFromStream(stream);
    }
}