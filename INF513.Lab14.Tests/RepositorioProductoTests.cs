using Xunit;

public class RepositorioProductoTests
{
    [Fact]
    public void Agregar_NoPermiteCodigosDuplicados()
    {
        var repositorio = new RepositorioProducto();

        repositorio.Agregar(new Producto("P001", "Teclado"));

        Assert.Throws<InvalidOperationException>(() =>
            repositorio.Agregar(new Producto("P001", "Mouse")));
    }

    [Fact]
    public void BuscarPorCodigo_EncuentraProducto()
    {
        var repositorio = new RepositorioProducto();
        var producto = new Producto("P001", "Teclado");

        repositorio.Agregar(producto);

        var resultado = repositorio.BuscarPorCodigo("P001");

        Assert.Same(producto, resultado);
    }

    [Fact]
    public void BuscarPorCodigo_NoEncuentraProducto_DevuelveNull()
    {
        var repositorio = new RepositorioProducto();

        var resultado = repositorio.BuscarPorCodigo("P999");

        Assert.Null(resultado);
    }

    [Fact]
    public void Eliminar_ProductoExistente_DevuelveTrue()
    {
        var repositorio = new RepositorioProducto();

        repositorio.Agregar(new Producto("P001", "Teclado"));

        var resultado = repositorio.Eliminar("P001");

        Assert.True(resultado);
        Assert.Null(repositorio.BuscarPorCodigo("P001"));
    }

    [Fact]
    public void Eliminar_ProductoInexistente_DevuelveFalse()
    {
        var repositorio = new RepositorioProducto();

        var resultado = repositorio.Eliminar("P999");

        Assert.False(resultado);
    }
}