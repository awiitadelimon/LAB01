
using INF513.Lab29;

namespace INF513.Lab29.Tests;

public class RepositorioJsonTests : IDisposable
{
    private readonly string _directorio;
    private readonly RepositorioJson _repositorio = new();

    public RepositorioJsonTests()
    {
        _directorio = Path.Combine(
            Path.GetTempPath(),
            Guid.NewGuid().ToString());

        Directory.CreateDirectory(_directorio);
    }

    [Fact]
    public async Task GuardarYCargar_ConservaLosProductos()
    {
        string ruta = Path.Combine(_directorio, "productos.json");

        var productos = new List<Producto>
        {
            new() { Codigo = "P01", Nombre = "Teclado", Precio = 1250.50m },
            new() { Codigo = "P02", Nombre = "Mouse", Precio = 750m }
        };

        await _repositorio.GuardarAsync(ruta, productos);
        List<Producto> resultado = await _repositorio.CargarAsync(ruta);

        Assert.Equal(2, resultado.Count);

        Assert.Equal("P01", resultado[0].Codigo);
        Assert.Equal("Teclado", resultado[0].Nombre);
        Assert.Equal(1250.50m, resultado[0].Precio);

        Assert.Equal("P02", resultado[1].Codigo);
        Assert.Equal("Mouse", resultado[1].Nombre);
        Assert.Equal(750m, resultado[1].Precio);
    }

    [Fact]
    public async Task CargarAsync_SiNoExisteArchivo_DevuelveListaVacia()
    {
        string ruta = Path.Combine(_directorio, "inexistente.json");

        List<Producto> resultado = await _repositorio.CargarAsync(ruta);

        Assert.Empty(resultado);
    }

    [Fact]
    public async Task GuardarAsync_RechazaRutaVacia()
    {
        await Assert.ThrowsAsync<ArgumentException>(
            () => _repositorio.GuardarAsync(
                "",
                new List<Producto>()));
    }

    [Fact]
    public async Task GuardarAsync_RechazaColeccionNula()
    {
        string ruta = Path.Combine(_directorio, "productos.json");

        await Assert.ThrowsAsync<ArgumentNullException>(
            () => _repositorio.GuardarAsync(ruta, null!));
    }

    [Fact]
    public async Task CargarAsync_RechazaJsonMalFormado()
    {
        string ruta = Path.Combine(_directorio, "invalido.json");
        await File.WriteAllTextAsync(ruta, "{ JSON incorrecto");

        await Assert.ThrowsAsync<System.Text.Json.JsonException>(
            () => _repositorio.CargarAsync(ruta));
    }

    public void Dispose()
    {
        if (Directory.Exists(_directorio))
            Directory.Delete(_directorio, recursive: true);
    }
}
