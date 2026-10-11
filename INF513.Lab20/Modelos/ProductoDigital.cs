
namespace INF513.Lab20.Modelos;

public class ProductoDigital : Producto
{
    public double TamanoMB { get; }

    public ProductoDigital(
        string codigo,
        string nombre,
        decimal precio,
        double tamanoMB)
        : base(codigo, nombre, precio)
    {
        if (double.IsNaN(tamanoMB) ||
            double.IsInfinity(tamanoMB) ||
            tamanoMB <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(tamanoMB), "El tamaño debe ser positivo y finito.");
        }

        TamanoMB = tamanoMB;
    }

    public override string Describir()
    {
        return $"{base.Describir()}, Tamaño: {TamanoMB:F2} MB";
    }
}
