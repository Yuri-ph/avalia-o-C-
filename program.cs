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