public class Biblioteca
{
    private List<Libro> libros = new List<Libro>();
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Prestamo> prestamos = new List<Prestamo>();

    public void RegistrarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    public bool Prestar(Libro libro, Usuario usuario)
    {
        if (!libros.Contains(libro))
            return false;

        if (!usuarios.Contains(usuario))
            return false;

        if (prestamos.Any(p => p.Libro == libro))
            return false;

        prestamos.Add(new Prestamo
        {
            Libro = libro,
            Usuario = usuario
        });

        return true;
    }

    public bool Devolver(Libro libro)
    {
        Prestamo? prestamo = prestamos.FirstOrDefault(p => p.Libro == libro);

        if (prestamo == null)
            return false;

        prestamos.Remove(prestamo);

        return true;
    }
}