namespace INF513.Lab06;

public class InventarioItem
{
    public string Codigo { get; }
    public string Nombre { get; }
    public int Existencia { get; private set; }

    public InventarioItem(string codigo, string nombre, int existenciaInicial)
    {
        Codigo = codigo;
        Nombre = nombre;
        Existencia = existenciaInicial;
    }

    public void Agregar(int cantidad)
    {
        if (cantidad <= 0)
        {
            throw new ArgumentException("La cantidad debe ser positiva.");
        }

        Existencia += cantidad;
    }
}