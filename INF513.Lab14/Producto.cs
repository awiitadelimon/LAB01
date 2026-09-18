public class Producto
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }

    public Producto(string codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
    }
}