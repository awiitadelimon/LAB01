public class RepositorioProducto
{
    private List<Producto> productos = new List<Producto>();

    public void Agregar(Producto producto)
    {
        if (productos.Any(p => p.Codigo == producto.Codigo))
        {
            throw new InvalidOperationException("El código ya existe.");
        }

        productos.Add(producto);
    }

    public Producto? BuscarPorCodigo(string codigo)
    {
        return productos.FirstOrDefault(p => p.Codigo == codigo);
    }
    public bool Eliminar(string codigo)
{
    Producto? producto = BuscarPorCodigo(codigo);

    if (producto == null)
    {
        return false;
    }

    productos.Remove(producto);
    return true;
}
}