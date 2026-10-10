
namespace INF513.Lab18;

public class Automovil : Vehiculo
{
    public int CantidadPuertas { get; }

    public Automovil(string marca, string modelo, int cantidadPuertas)
        : base(marca, modelo)
    {
        if (cantidadPuertas <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(cantidadPuertas),
                "La cantidad de puertas debe ser positiva.");
        }

        CantidadPuertas = cantidadPuertas;
    }
}
