

using INF513.Lab06;

namespace INF513.Lab06.Tests;

public class InventarioItemTests
{
    [Fact]
    public void DebeCrearItemConDatosIniciales()
    {
        var item = new InventarioItem("A001", "Teclado", 10);

        Assert.Equal("A001", item.Codigo);
        Assert.Equal("Teclado", item.Nombre);
        Assert.Equal(10, item.Existencia);
    }

    [Fact]
    public void AgregarDebeAumentarExistencia()
    {
        var item = new InventarioItem("A001", "Teclado", 10);

        item.Agregar(5);

        Assert.Equal(15, item.Existencia);
    }

    [Fact]
    public void AgregarCeroDebeLanzarExcepcion()
    {
        var item = new InventarioItem("A001", "Teclado", 10);

        Assert.Throws<ArgumentException>(() => item.Agregar(0));
    }

    [Fact]
    public void AgregarCantidadNegativaDebeLanzarExcepcion()
    {
        var item = new InventarioItem("A001", "Teclado", 10);

        Assert.Throws<ArgumentException>(() => item.Agregar(-5));
    }
}