
using INF513.Lab20.Modelos;

ProductoFisico productoFisico = new(
    "FIS001",
    "Teclado",
    1500m,
    0.85);

ProductoDigital productoDigital = new(
    "DIG001",
    "Curso de C#",
    2500m,
    120.5);

Console.WriteLine(productoFisico.Describir());
Console.WriteLine(productoDigital.Describir());
