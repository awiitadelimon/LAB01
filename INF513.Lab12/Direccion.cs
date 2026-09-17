public class Direccion
{
    public string Calle { get; set; }
    public string Numero { get; set; }
    public string Ciudad { get; set; }

    public Direccion(string calle, string numero, string ciudad)
    {
        Calle = calle;
        Numero = numero;
        Ciudad = ciudad;
    }
}