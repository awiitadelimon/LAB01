using INF513.Lab19.Modelos;

namespace INF513.Lab19.Tests.Modelos;

public class FiguraTests
{
[Theory]
[InlineData(5, 4, 20)]
[InlineData(2.5, 4, 10)]
[InlineData(1, 1, 1)]
public void Rectangulo_Area_DimensionesValidas_RetornaAreaCorrecta(
double ancho, double alto, double areaEsperada)
{
var rectangulo = new Rectangulo(ancho, alto);

    Assert.Equal(areaEsperada, rectangulo.Area());
}

[Theory]
[InlineData(0, 4)]
[InlineData(-2, 4)]
[InlineData(5, 0)]
[InlineData(5, -3)]
public void Rectangulo_DimensionesInvalidas_LanzaExcepcion(
    double ancho, double alto)
{
    Assert.Throws<ArgumentOutOfRangeException>(
        () => new Rectangulo(ancho, alto));
}

[Theory]
[InlineData(1, Math.PI)]
[InlineData(2, 4 * Math.PI)]
[InlineData(0.5, 0.25 * Math.PI)]
public void Circulo_Area_RadioValido_RetornaAreaCorrecta(
    double radio, double areaEsperada)
{
    var circulo = new Circulo(radio);

    Assert.Equal(areaEsperada, circulo.Area(), 10);
}

[Theory]
[InlineData(0)]
[InlineData(-1)]
[InlineData(-2.5)]
public void Circulo_RadioInvalido_LanzaExcepcion(double radio)
{
    Assert.Throws<ArgumentOutOfRangeException>(
        () => new Circulo(radio));
}

}