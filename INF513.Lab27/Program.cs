using INF513.Lab27;

if (RegistroEdad.TryCrear(25, out RegistroEdad? registro))
{
    Console.WriteLine($"Registro creado. Edad: {registro!.Edad}");
}
else
{
    Console.WriteLine("Edad fuera del rango permitido.");
}

try
{
    int edad = RegistroEdad.Parsear("abc");
    Console.WriteLine($"Edad parseada: {edad}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Error de formato: {ex.Message}");
}
