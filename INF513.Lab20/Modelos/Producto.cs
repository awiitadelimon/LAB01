
namespace INF513.Lab20.Modelos;

public abstract class Producto
{
    public string Codigo { get; }
    public string Nombre { get; }
    public decimal Precio { get; }

    protected Producto(string codigo, string nombre, decimal precio)
    {
        if (string.IsNullOrWhiteSpace(codigo))
            throw new ArgumentException("El código no puede estar vacío.", nameof(codigo));

        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío.", nameof(nombre));

        if (precio <= 0)
            throw new ArgumentOutOfRangeException(nameof(precio), "El precio debe ser positivo.");

        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
    }

    public virtual string Describir()
    {
        return $"Código: {Codigo}, Nombre: {Nombre}, Precio: {Precio:F2}";
    }
}
