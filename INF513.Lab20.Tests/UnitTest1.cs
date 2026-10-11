
using INF513.Lab20.Modelos;

namespace INF513.Lab20.Tests;

public class ProductoTests
{
    [Fact]
    public void ProductoFisico_ConDatosValidos_ConservaPropiedades()
    {
        var producto = new ProductoFisico("FIS001", "Teclado", 1500m, 0.85);

        Assert.Equal("FIS001", producto.Codigo);
        Assert.Equal("Teclado", producto.Nombre);
        Assert.Equal(1500m, producto.Precio);
        Assert.Equal(0.85, producto.Peso);
    }

    [Fact]
    public void ProductoDigital_ConDatosValidos_ConservaPropiedades()
    {
        var producto = new ProductoDigital("DIG001", "Curso C#", 2500m, 120.5);

        Assert.Equal("DIG001", producto.Codigo);
        Assert.Equal("Curso C#", producto.Nombre);
        Assert.Equal(2500m, producto.Precio);
        Assert.Equal(120.5, producto.TamanoMB);
    }

    [Fact]
    public void ProductoFisico_Describir_IncluyeDatosComunesYPeso()
    {
        var producto = new ProductoFisico("FIS001", "Teclado", 1500m, 0.85);

        var descripcion = producto.Describir();

        Assert.Contains("FIS001", descripcion);
        Assert.Contains("Teclado", descripcion);
        Assert.Contains("1500", descripcion);
        Assert.Contains("Peso:", descripcion);
        Assert.Contains("kg", descripcion);
    }

    [Fact]
    public void ProductoDigital_Describir_IncluyeDatosComunesYTamaño()
    {
        var producto = new ProductoDigital("DIG001", "Curso C#", 2500m, 120.5);

        var descripcion = producto.Describir();

        Assert.Contains("DIG001", descripcion);
        Assert.Contains("Curso C#", descripcion);
        Assert.Contains("2500", descripcion);
        Assert.Contains("Tamaño:", descripcion);
        Assert.Contains("MB", descripcion);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void ProductoFisico_CodigoInvalido_LanzaExcepcion(string? codigo)
    {
        Assert.Throws<ArgumentException>(() =>
            new ProductoFisico(codigo!, "Teclado", 1500m, 0.85));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void ProductoDigital_NombreInvalido_LanzaExcepcion(string? nombre)
    {
        Assert.Throws<ArgumentException>(() =>
            new ProductoDigital("DIG001", nombre!, 2500m, 120.5));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void ProductoFisico_PrecioNoPositivo_LanzaExcepcion(decimal precio)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            new ProductoFisico("FIS001", "Teclado", precio, 0.85));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void ProductoDigital_PrecioNoPositivo_LanzaExcepcion(decimal precio)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            new ProductoDigital("DIG001", "Curso C#", precio, 120.5));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(double.NaN)]
    [InlineData(double.PositiveInfinity)]
    [InlineData(double.NegativeInfinity)]
    public void ProductoFisico_PesoInvalido_LanzaExcepcion(double peso)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            new ProductoFisico("FIS001", "Teclado", 1500m, peso));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(double.NaN)]
    [InlineData(double.PositiveInfinity)]
    [InlineData(double.NegativeInfinity)]
    public void ProductoDigital_TamanoInvalido_LanzaExcepcion(double tamanoMB)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            new ProductoDigital("DIG001", "Curso C#", 2500m, tamanoMB));
    }
}
