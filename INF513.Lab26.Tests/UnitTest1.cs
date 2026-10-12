using INF513.Lab26;

namespace INF513.Lab26.Tests;

public class UnitTest1
{
    private readonly Calculadora _calculadora = new();

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(9, 3, 3)]
    [InlineData(-10, 2, -5)]
    public void Dividir_ConDivisorDistintoDeCero_RetornaResultado(
        double a, double b, double esperado)
    {
        double resultado = _calculadora.Dividir(a, b);

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void Dividir_ConDivisorCero_LanzaExcepcion()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calculadora.Dividir(10, 0));
    }
}
