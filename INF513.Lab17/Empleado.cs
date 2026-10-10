
namespace INF513.Lab17;

public class Empleado
{
    protected decimal PagoBase { get; set; }

    public virtual decimal CalcularPago()
    {
        return PagoBase;
    }
}
