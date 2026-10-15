

using INF513.Lab28;

namespace INF513.Lab28.Tests;

public class ArchivoTextoTests : IDisposable
{
    private readonly string _directorio;
    private readonly ArchivoTexto _archivo = new();

    public ArchivoTextoTests()
    {
        _directorio = Path.Combine(
            Path.GetTempPath(),
            Guid.NewGuid().ToString());

        Directory.CreateDirectory(_directorio);
    }

    [Fact]
    public async Task GuardarAsync_CreaArchivo()
    {
        string ruta = Path.Combine(_directorio, "prueba.txt");

        await _archivo.GuardarAsync(ruta, "Hola mundo");

        Assert.True(File.Exists(ruta));
        Assert.Equal("Hola mundo", await File.ReadAllTextAsync(ruta));
    }

    [Fact]
    public async Task LeerAsync_LeeContenido()
    {
        string ruta = Path.Combine(_directorio, "lectura.txt");
        await File.WriteAllTextAsync(ruta, "Contenido de prueba");

        string resultado = await _archivo.LeerAsync(ruta);

        Assert.Equal("Contenido de prueba", resultado);
    }

    [Fact]
    public async Task GuardarAsync_SobrescribeArchivo()
    {
        string ruta = Path.Combine(_directorio, "existente.txt");
        await File.WriteAllTextAsync(ruta, "Anterior");

        await _archivo.GuardarAsync(ruta, "Nuevo");

        Assert.Equal("Nuevo", await File.ReadAllTextAsync(ruta));
    }

    [Fact]
    public async Task GuardarAsync_AceptaContenidoVacio()
    {
        string ruta = Path.Combine(_directorio, "vacio.txt");

        await _archivo.GuardarAsync(ruta, "");

        Assert.Equal("", await File.ReadAllTextAsync(ruta));
    }

    [Fact]
    public async Task GuardarAsync_RechazaRutaVacia()
    {
        await Assert.ThrowsAsync<ArgumentException>(
            () => _archivo.GuardarAsync("", "contenido"));
    }

    [Fact]
    public async Task GuardarAsync_RechazaContenidoNulo()
    {
        string ruta = Path.Combine(_directorio, "nulo.txt");

        await Assert.ThrowsAsync<ArgumentNullException>(
            () => _archivo.GuardarAsync(ruta, null!));
    }

    [Fact]
    public async Task LeerAsync_FallaSiArchivoNoExiste()
    {
        string ruta = Path.Combine(_directorio, "inexistente.txt");

        await Assert.ThrowsAsync<FileNotFoundException>(
            () => _archivo.LeerAsync(ruta));
    }

    public void Dispose()
    {
        if (Directory.Exists(_directorio))
            Directory.Delete(_directorio, recursive: true);
    }
}
