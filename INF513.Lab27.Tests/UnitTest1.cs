using INF513.Lab27;

namespace INF513.Lab27.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(0)]
    [InlineData(25)]
    [InlineData(120)]
    public void TryCrear_EdadValida_CreaRegistro(int edad)
    {
        bool resultado = RegistroEdad.TryCrear(edad, out RegistroEdad? registro);

        Assert.True(resultado);
        Assert.NotNull(registro);
        Assert.Equal(edad, registro.Edad);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(121)]
    public void TryCrear_EdadFueraDeRango_RetornaFalse(int edad)
    {
        bool resultado = RegistroEdad.TryCrear(edad, out RegistroEdad? registro);

        Assert.False(resultado);
        Assert.Null(registro);
    }

    [Theory]
    [InlineData("25", 25)]
    [InlineData("0", 0)]
    [InlineData("120", 120)]
    public void Parsear_TextoNumerico_RetornaEdad(string texto, int esperado)
    {
        int resultado = RegistroEdad.Parsear(texto);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData("abc")]
    [InlineData("")]
    public void Parsear_TextoInvalido_LanzaFormatException(string texto)
    {
        Assert.Throws<FormatException>(() => RegistroEdad.Parsear(texto));
    }
}
