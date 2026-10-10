namespace INF513.Lab19.Modelos;

public class Rectangulo : Figura
{
private readonly double _ancho;
private readonly double _alto;

public Rectangulo(double ancho, double alto)
{
    if (ancho <= 0)
        throw new ArgumentOutOfRangeException(nameof(ancho), "El ancho debe ser positivo.");

    if (alto <= 0)
        throw new ArgumentOutOfRangeException(nameof(alto), "El alto debe ser positivo.");

    _ancho = ancho;
    _alto = alto;
}

public override double Area()
{
    return _ancho * _alto;
}

}