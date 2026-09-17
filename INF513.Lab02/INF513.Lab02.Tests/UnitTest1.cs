namespace INF513.Lab02.Tests;

// Pruebas de la clase Persona
public class PersonaTests
{
    [Fact]
    public void Persona_ConservaLosValoresAsignados()
    {
        // Crear un objeto de tipo Persona
        Persona persona = new Persona();

        // Asignar valores a sus propiedades
        persona.Nombre = "Francisco";
        persona.Edad = 22;

        // Comprobar que conserva los valores asignados
        Assert.Equal("Francisco", persona.Nombre);
        Assert.Equal(22, persona.Edad);
    }
}