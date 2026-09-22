public class Empleado
{
    public int Codigo { get; }
    public string Nombre { get; }
    public decimal Salario { get; }

    public Empleado(int codigo, string nombre, decimal salario)
    {
        if (codigo <= 0)
            throw new ArgumentException("El código debe ser positivo.", nameof(codigo));

        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío.", nameof(nombre));

        if (salario < 0)
            throw new ArgumentException("El salario no puede ser negativo.", nameof(salario));

        Codigo = codigo;
        Nombre = nombre;
        Salario = salario;
    }
}