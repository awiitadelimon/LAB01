public class Persona
{
    public Direccion Direccion { get; }

    public Persona(Direccion direccion)
    {
        if (direccion == null)
        {
            throw new ArgumentNullException(nameof(direccion));
        }

        Direccion = direccion;
    }

    public string DireccionCompleta()
    {
        return $"{Direccion.Calle} {Direccion.Numero}, {Direccion.Ciudad}";
    }
}