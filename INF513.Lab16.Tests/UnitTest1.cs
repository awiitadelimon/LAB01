
using Xunit;
using INF513.Lab16;

namespace INF513.Lab16.Tests;

public class UnitTest1
{
    [Fact]
    public void Estudiante_ConservaLasPropiedadesHeredadas()
    {
        var estudiante = new Estudiante
        {
            Nombre = "Francisco",
            Edad = 22
        };

        Assert.Equal("Francisco", estudiante.Nombre);
        Assert.Equal(22, estudiante.Edad);
    }

    [Fact]
    public void Estudiante_PuedeAlmacenarSuMatricula()
    {
        var estudiante = new Estudiante
        {
            Matricula = "100012345"
        };

        Assert.Equal("100012345", estudiante.Matricula);
    }

    [Fact]
    public void Estudiante_EsUnaPersona()
    {
        var estudiante = new Estudiante();

        Assert.IsAssignableFrom<Persona>(estudiante);
    }

    [Fact]
    public void Estudiante_PermiteMatriculaVacia()
    {
        var estudiante = new Estudiante
        {
            Matricula = string.Empty
        };

        Assert.Equal(string.Empty, estudiante.Matricula);
    }
}
