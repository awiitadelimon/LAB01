
using INF513.Lab18;
using Xunit;

namespace INF513.Lab18.Tests;

public class UnitTest1
{
    [Fact]
    public void Automovil_ConstructorInicializaMarcaModeloYPuertas()
    {
        var auto = new Automovil("Toyota", "Corolla", 4);

        Assert.Equal("Toyota", auto.Marca);
        Assert.Equal("Corolla", auto.Modelo);
        Assert.Equal(4, auto.CantidadPuertas);
    }

    [Fact]
    public void Automovil_EsUnVehiculo()
    {
        var auto = new Automovil("Honda", "Civic", 4);

        Assert.IsAssignableFrom<Vehiculo>(auto);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-4)]
    public void Automovil_CantidadPuertasInvalida_LanzaExcepcion(int puertas)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new Automovil("Toyota", "Corolla", puertas));
    }

    [Fact]
    public void Vehiculo_ConstructorInicializaMarcaYModelo()
    {
        var vehiculo = new Vehiculo("Honda", "Civic");

        Assert.Equal("Honda", vehiculo.Marca);
        Assert.Equal("Civic", vehiculo.Modelo);
    }
}
