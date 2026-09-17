public class Curso
{
    private readonly List<Estudiante> estudiantes = new();

    public void AgregarEstudiante(Estudiante estudiante)
    {
        estudiantes.Add(estudiante);
    }

    public IReadOnlyList<Estudiante> Estudiantes
    {
        get { return estudiantes; }
    }

    public int Cantidad
    {
        get { return estudiantes.Count; }
    }
}