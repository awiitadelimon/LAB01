public class EmpleadoTests
{
    [Fact]
    public void Constructor_DatosValidos_CreaEmpleado()
    {
        var empleado = new Empleado(1, "Juan", 25000);

        Assert.Equal(1, empleado.Codigo);
        Assert.Equal("Juan", empleado.Nombre);
        Assert.Equal(25000, empleado.Salario);
    }

    [Fact]
    public void Constructor_CodigoNoPositivo_LanzaExcepcion()
    {
        Assert.Throws<ArgumentException>(() =>
            new Empleado(0, "Juan", 25000));
    }

    [Fact]
    public void Constructor_NombreVacio_LanzaExcepcion()
    {
        Assert.Throws<ArgumentException>(() =>
            new Empleado(1, "", 25000));
    }

    [Fact]
    public void Constructor_SalarioNegativo_LanzaExcepcion()
    {
        Assert.Throws<ArgumentException>(() =>
            new Empleado(1, "Juan", -500));
    }
}