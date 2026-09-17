using Xunit;

namespace INF513.Lab12.Tests;

public class PersonaTests
{
    [Fact]
    public void Persona_DebeConservarLaDireccion()
    {
        Direccion direccion = new Direccion(
            "Av. Independencia",
            "123",
            "Santo Domingo"
        );

        Persona persona = new Persona(direccion);

        Assert.Same(direccion, persona.Direccion);
    }

    [Fact]
    public void DireccionCompleta_DebeRetornarLaDireccionFormateada()
    {
        Direccion direccion = new Direccion(
            "Av. Independencia",
            "123",
            "Santo Domingo"
        );

        Persona persona = new Persona(direccion);

        string resultado = persona.DireccionCompleta();

        Assert.Equal(
            "Av. Independencia 123, Santo Domingo",
            resultado
        );
    }

    [Fact]
    public void Persona_SinDireccion_DebeLanzarExcepcion()
    {
        Assert.Throws<ArgumentNullException>(
            () => new Persona(null!)
        );
    }
}