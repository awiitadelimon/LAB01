namespace INF513.Lab11;

public class Pedido
{
    public int Numero { get; set; }
    public decimal Total { get; set; }
    public Cliente ClienteAsignado { get; set; }

    public Pedido(int numero, decimal total, Cliente cliente)
    {
        if (numero <= 0)
            throw new ArgumentException("El número de pedido debe ser mayor que 0.");

        if (total < 0)
            throw new ArgumentException("El total no puede ser negativo.");

        if (cliente == null)
            throw new ArgumentNullException(nameof(cliente));

        Numero = numero;
        Total = total;
        ClienteAsignado = cliente;
    }

    public string Resumen()
    {
        return $"Pedido #{Numero} - Cliente: {ClienteAsignado.Nombre} - Total: RD${Total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}";
    }
}