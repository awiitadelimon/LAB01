
using System.Text.Json;

namespace INF513.Lab29;

public class RepositorioJson
{
    private readonly JsonSerializerOptions _opciones = new()
    {
        WriteIndented = true
    };

    public async Task GuardarAsync(
        string ruta,
        IEnumerable<Producto> productos)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(ruta);
        ArgumentNullException.ThrowIfNull(productos);

        string json = JsonSerializer.Serialize(productos, _opciones);
        await File.WriteAllTextAsync(ruta, json);
    }

    public async Task<List<Producto>> CargarAsync(string ruta)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(ruta);

        if (!File.Exists(ruta))
            return new List<Producto>();

        string json = await File.ReadAllTextAsync(ruta);

        return JsonSerializer.Deserialize<List<Producto>>(json)
            ?? new List<Producto>();
    }
}
