
using INF513.Lab17;
using Xunit;

namespace INF513.Lab17.Tests;

public class UnitTest1
{
    [Fact]
    public void CalcularPago_MultiplicaHorasPorTarifa()
    {
        var empleado = new EmpleadoPorHora
        {
            Horas = 40,
            Tarifa = 150
        };

        Assert.Equal(6000m, empleado.CalcularPago());
    }

    [Fact]
    public void CalcularPago_ConCeroHoras_RetornaCero()
    {
        var empleado = new EmpleadoPorHora
        {
            Horas = 0,
            Tarifa = 150
        };

        Assert.Equal(0m, empleado.CalcularPago());
    }

    [Fact]
    public void CalcularPago_ConTarifaCero_RetornaCero()
    {
        var empleado = new EmpleadoPorHora
        {
            Horas = 8,
            Tarifa = 0
        };

        Assert.Equal(0m, empleado.CalcularPago());
    }

    [Fact]
    public void HorasNegativas_LanzaExcepcion()
    {
        var empleado = new EmpleadoPorHora();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => empleado.Horas = -1);
    }

    [Fact]
    public void TarifaNegativa_LanzaExcepcion()
    {
        var empleado = new EmpleadoPorHora();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => empleado.Tarifa = -1);
    }

    [Fact]
    public void EmpleadoPorHora_EsUnEmpleado()
    {
        var empleado = new EmpleadoPorHora();

        Assert.IsAssignableFrom<Empleado>(empleado);
    }
}
