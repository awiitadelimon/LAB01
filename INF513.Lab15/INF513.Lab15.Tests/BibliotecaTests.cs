using Xunit;

public class BibliotecaTests
{
    [Fact]
    public void Prestar_LibroRegistradoYUsuarioRegistrado_RetornaTrue()
    {
        Biblioteca biblioteca = new Biblioteca();

        Libro libro = new Libro
        {
            Titulo = "Cien años de soledad",
            Autor = "Gabriel García Márquez"
        };

        Usuario usuario = new Usuario
        {
            Nombre = "Fran"
        };

        biblioteca.RegistrarLibro(libro);
        biblioteca.RegistrarUsuario(usuario);

        bool resultado = biblioteca.Prestar(libro, usuario);

        Assert.True(resultado);
    }

    [Fact]
    public void Prestar_LibroYaPrestado_RetornaFalse()
    {
        Biblioteca biblioteca = new Biblioteca();

        Libro libro = new Libro
        {
            Titulo = "Cien años de soledad",
            Autor = "Gabriel García Márquez"
        };

        Usuario usuario1 = new Usuario
        {
            Nombre = "Fran"
        };

        Usuario usuario2 = new Usuario
        {
            Nombre = "Pedro"
        };

        biblioteca.RegistrarLibro(libro);
        biblioteca.RegistrarUsuario(usuario1);
        biblioteca.RegistrarUsuario(usuario2);

        biblioteca.Prestar(libro, usuario1);

        bool resultado = biblioteca.Prestar(libro, usuario2);

        Assert.False(resultado);
    }

    [Fact]
    public void Devolver_LibroPrestado_RetornaTrue()
    {
        Biblioteca biblioteca = new Biblioteca();

        Libro libro = new Libro
        {
            Titulo = "Cien años de soledad",
            Autor = "Gabriel García Márquez"
        };

        Usuario usuario = new Usuario
        {
            Nombre = "Fran"
        };

        biblioteca.RegistrarLibro(libro);
        biblioteca.RegistrarUsuario(usuario);

        biblioteca.Prestar(libro, usuario);

        bool resultado = biblioteca.Devolver(libro);

        Assert.True(resultado);
    }

    [Fact]
    public void Devolver_LibroNoPrestado_RetornaFalse()
    {
        Biblioteca biblioteca = new Biblioteca();

        Libro libro = new Libro
        {
            Titulo = "Cien años de soledad",
            Autor = "Gabriel García Márquez"
        };

        bool resultado = biblioteca.Devolver(libro);

        Assert.False(resultado);
    }
}