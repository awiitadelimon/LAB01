using INF513.Lab11;

namespace INF513.Lab11.Tests;

public class PedidoTests
{
    [Fact]
    public void CrearPedido_ConCliente_DevuelveResumenCorrecto()
    {
        var cliente = new Cliente("Ana");
        var pedido = new Pedido(101, 2500.50m, cliente);

        var resumen = pedido.Resumen();

        Assert.Equal(
            "Pedido #101 - Cliente: Ana - Total: RD$2500.50",
            resumen
        );
    }
    [Fact]
public void CrearPedido_ConCliente_GuardaElClienteCorrectamente()
{
    var cliente = new Cliente("Carlos");
    var pedido = new Pedido(102, 1500m, cliente);

    Assert.Same(cliente, pedido.ClienteAsignado);
}

[Fact]
public void CrearPedido_ConNumeroInvalido_LanzaExcepcion()
{
    var cliente = new Cliente("Carlos");

    Assert.Throws<ArgumentException>(
        () => new Pedido(0, 1500m, cliente)
    );
}

[Fact]
public void CrearPedido_ConClienteNulo_LanzaExcepcion()
{
    Assert.Throws<ArgumentNullException>(
        () => new Pedido(103, 1500m, null!)
    );
}

[Fact]
public void CrearPedido_ConTotalNegativo_LanzaExcepcion()
{
    var cliente = new Cliente("Pedro");

    Assert.Throws<ArgumentException>(
        () => new Pedido(104, -500m, cliente)
    );
}
}