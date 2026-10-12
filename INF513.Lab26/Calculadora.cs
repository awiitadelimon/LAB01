
namespace INF513.Lab26;

public class Calculadora
{
    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir entre cero.");
        }

        return a / b;
    }
}
