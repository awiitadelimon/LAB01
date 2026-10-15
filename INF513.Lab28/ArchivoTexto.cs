
namespace INF513.Lab28;

public class ArchivoTexto
{
    public async Task GuardarAsync(string ruta, string contenido)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(ruta);
        ArgumentNullException.ThrowIfNull(contenido);

        await File.WriteAllTextAsync(ruta, contenido);
    }

    public async Task<string> LeerAsync(string ruta)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(ruta);

        return await File.ReadAllTextAsync(ruta);
    }
}
