using Xunit;
using INF513.Lab08;

namespace INF513.Lab08.Tests;

public class ConversorTemperaturaTests
{
    [Fact]
    public void DescribirCelsius_DebeDescribirTemperatura()
    {
        var conversor = new ConversorTemperatura(25);

        var resultado = conversor.DescribirCelsius();

        Assert.Equal("La temperatura es 25 °C.", resultado);
    }

    [Fact]
    public void CelsiusAFahrenheit_DebeConvertirCorrectamente()
    {
        var resultado = ConversorTemperatura.CelsiusAFahrenheit(0);

        Assert.Equal(32, resultado);
    }

    [Fact]
    public void FahrenheitACelsius_DebeConvertirCorrectamente()
    {
        var resultado = ConversorTemperatura.FahrenheitACelsius(212);

        Assert.Equal(100, resultado);
    }

    [Fact]
    public void CelsiusAFahrenheit_DebeConvertirTemperaturaNegativa()
    {
        var resultado = ConversorTemperatura.CelsiusAFahrenheit(-40);

        Assert.Equal(-40, resultado);
    }
}