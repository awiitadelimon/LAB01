using INF513.Lab01;

namespace INF513.Lab01.Tests;

public class MensajeCursoTests
{
    [Fact]
    public void Obtener_DebeRetornarMensajeEsperado()
    {
        var resultado = MensajeCurso.Obtener();

        Assert.Equal(
            "Entorno INF-513 configurado correctamente.",
            resultado);
    }
}