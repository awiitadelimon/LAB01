
namespace INF513.Lab17;

public class EmpleadoPorHora : Empleado
{
    private decimal _horas;
    private decimal _tarifa;

    public decimal Horas
    {
        get => _horas;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(
                    nameof(Horas), "Las horas no pueden ser negativas.");

            _horas = value;
        }
    }

    public decimal Tarifa
    {
        get => _tarifa;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(
                    nameof(Tarifa), "La tarifa no puede ser negativa.");

            _tarifa = value;
        }
    }

    public override decimal CalcularPago()
    {
        return Horas * Tarifa;
    }
}
