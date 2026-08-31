class Livro
{
    private string titulo;
    private string autor;
    private int numeroPaginas;

public Livro(string titulo, string autor, int numeroPaginas)
}
    {
        titulo = titulo;
        autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    public string titulo
    {
        get { return titulo; }
        set
        {
            titulo = string.IsnullorwhiteSpace(value) ? "Titulo não informado": value;
        }
    }    

    public string Autor
    {
        get { return autor; }
        set
        {
            autor = string.IsnullorwhiteSpace(value) ? "Autor desconhecido": value;
        }
    }

public override string ToString()
{
    return $"[Livro] Titulo: {Titulo} | Autor: {Autor} | Páginas: {NumeroPaginas}";
    }
  }

class Filme 
{
    private string nome;
    private string genero;
    private double duracaoMinutos;

    public Filme(string nome, string genero, double duracaoMinutos)
    {
        Nome = nome;
        Genero = genero;
        DuracaoMinutos = duracaoMinutos;
    }
}

public string Nome
{
    get {  return nome; }
    set
    {
        nome = string.IsnullorwhiteSpace(value) ? "Filme sem Título" : value;
    }
}

    public double DuracaoMinutos
    {
        get { return duracaoMinutos; }
        set
        {
            duracaoMinutos = value <= 0 ? 1 : value;
        }
    }

    public override string ToString()
    {
        return $"[Filme] Nome: {nome} | Gênero: {Genero} | Duração: {duracaoMinutos} min";
    }

claSS Resenha 
{
    private string tituloObra;
    private string tipoObra;
    private string tipoObra; | "Livro" ou "Filme"
    private double nota; | de 0 a 10

    public Resenha(string tituloObra, string tipoObra, double nota)
    {
        tituloObra = tituloObra;
        TipoObra = tipoObra;
        Nota = nota;

        public string tituloObra
        {
            get { return tituloObra; }
            set
            {
                tituloObra = string.IsnullorwhiteSpace(value) ? "Obra sem Título" : value;
            }
        }
    }
}

    public string TipoObra
    {
        get { return tipoObra; }
        set
    }
        {
            if (value != null && (value.Trim().ToLower() == "Livro" || value.Trim().ToLower() == "Filme"))
            tipoObra = value.Trim();
        else
            tipoObra = "Não classficado";
        }

    public souble nota 
    {
        get { return nota; }
        set
        {
            if (value < 0 || value > 10)
                nota = 0;
            else 
                nota = value 
        }
    }

clas program 
    {
        Console.Write("=== TESTANDO CLASSE LIVRO ===")
        Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis", 256);
        Livro livro2 = new Livro("O hobbit", "J.R.R Tolkien", 310);

        Console.WriteLine(livro1);
        Console.WriteLine(livro2);

        livro1.NumeroPaginas = 260;
        livro2.Autor = "J. R. R. Tolkien";

        Console.WriteLine("\nApós alterações:");
        Console.WriteLine(livro1);
        Console.WriteLine(livro2);

        Livro livro3 = new Livro("", "", -50);
        Console.WriteLine("\nTestando dados inválidos:");
        Console.WriteLine(livro3);

        Console.WriteLine("\n==== TESTANDO CALSSE FILMES ===");
        Filme filme1 = new Filme("Deadpool", "Deadpool2", 169);
        Filme filme2 = new Filme("Gente grande", "A maldicção de chucky")

        Console.WriteLine(filme1);
        Console.WriteLine(filme2);

        filme1.DuracaoMinutos = 172;
        filme2.Genero = "Sobrenatural"

        Console.WriteLine("\nApós alterações:");
        Console.WriteLine(filme1);
        Console.WriteLine(filme2)
    }