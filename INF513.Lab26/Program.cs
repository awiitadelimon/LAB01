
using INF513.Lab26;

Calculadora calculadora = new();

try
{
    double resultado = calculadora.Dividir(10, 2);
    Console.WriteLine($"Resultado: {resultado}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Operación finalizada.");
}
