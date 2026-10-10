namespace INF513.Lab19.Modelos;

public class Circulo : Figura
{
private readonly double _radio;

public Circulo(double radio)
{
    if (radio <= 0)
        throw new ArgumentOutOfRangeException(nameof(radio), "El radio debe ser positivo.");

    _radio = radio;
}

public override double Area()
{
    return Math.PI * _radio * _radio;
}

}