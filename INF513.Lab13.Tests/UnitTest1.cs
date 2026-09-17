public class CursoTests
{
    [Fact]
    public void CursoNuevo_DebeTenerCantidadCero()
    {
        var curso = new Curso();

        Assert.Equal(0, curso.Cantidad);
    }

    [Fact]
    public void AgregarEstudiante_DebeIncrementarCantidad()
    {
        var curso = new Curso();
        var estudiante = new Estudiante();

        curso.AgregarEstudiante(estudiante);

        Assert.Equal(1, curso.Cantidad);
    }

    [Fact]
    public void AgregarVariosEstudiantes_DebeContarlosCorrectamente()
    {
        var curso = new Curso();

        curso.AgregarEstudiante(new Estudiante());
        curso.AgregarEstudiante(new Estudiante());
        curso.AgregarEstudiante(new Estudiante());

        Assert.Equal(3, curso.Cantidad);
    }

    [Fact]
    public void Estudiantes_DebeContenerLosEstudiantesAgregados()
    {
        var curso = new Curso();
        var estudiante = new Estudiante();

        curso.AgregarEstudiante(estudiante);

        Assert.Contains(estudiante, curso.Estudiantes);
    }
}