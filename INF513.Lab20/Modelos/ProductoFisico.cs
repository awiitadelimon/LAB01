
namespace INF513.Lab20.Modelos;

public class ProductoFisico : Producto
{
    public double Peso { get; }

    public ProductoFisico(
        string codigo,
        string nombre,
        decimal precio,
        double peso)
        : base(codigo, nombre, precio)
    {
        if (double.IsNaN(peso) || double.IsInfinity(peso) || peso <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(peso), "El peso debe ser positivo y finito.");

        Peso = peso;
    }

    public override string Describir()
    {
        return $"{base.Describir()}, Peso: {Peso:F2} kg";
    }
}
