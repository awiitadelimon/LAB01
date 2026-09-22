namespace INF513.Lab08;

public class ConversorTemperatura
{
    public double Celsius { get; }

    public ConversorTemperatura(double celsius)
    {
        Celsius = celsius;
    }

    public string DescribirCelsius()
    {
        return $"La temperatura es {Celsius} °C.";
    }

    public static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}