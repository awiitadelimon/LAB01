namespace INF513.Lab27;

public class RegistroEdad
{
    public int Edad { get; }

    private RegistroEdad(int edad)
    {
        Edad = edad;
    }

    public static bool TryCrear(int edad, out RegistroEdad? registro)
    {
        if (edad < 0 || edad > 120)
        {
            registro = null;
            return false;
        }

        registro = new RegistroEdad(edad);
        return true;
    }

    public static int Parsear(string texto)
    {
        return int.Parse(texto);
    }
}
