using System;

namespace ResenhasApp
{
    class Livro
    {
        private string titulo;
        private string autor;
        private int numeroPaginas;

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }

        public string Titulo
        {
            get { return titulo; }
            set
            {
                titulo = string.IsNullOrWhiteSpace(value) ? "Título não encontrado" : value;
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                autor = string.IsNullOrWhiteSpace(value) ? "Autor desconhecido" : value;
            }
        }

        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set
            {
                numeroPaginas = value <= 0 ? 1 : value;
            }
        }

        public override string ToString()
        {
            return $"[Livro] Título: {Titulo} | Autor: {Autor} | Páginas: {NumeroPaginas}";
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

        public string Nome
        {
            get { return nome; }
            set
            {
                nome = string.IsNullOrWhiteSpace(value) ? "Filme sem título" : value;
            }
        }

        public string Genero
        {
            get { return genero; }
            set
            {
                genero = string.IsNullOrWhiteSpace(value) ? "Não classificado" : value;
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
            return $"[Filme] Nome: {Nome} | Gênero: {Genero} | Duração: {DuracaoMinutos} min";
        }
    }

    class Resenha
    {
        private string tituloObra;
        private string tipoObra;
        private double nota;

        public Resenha(string tituloObra, string tipoObra, double nota)
        {
            TituloObra = tituloObra;
            TipoObra = tipoObra;
            Nota = nota;
        }

        public string TituloObra
        {
            get { return tituloObra; }
            set
            {
                tituloObra = string.IsNullOrWhiteSpace(value) ? "Obra sem título" : value;
            }
        }

        public string TipoObra
        {
            get { return tipoObra; }
            set
            {
                if (value != null && (value.Trim().ToLower() == "livro" || value.Trim().ToLower() == "filme"))
                    tipoObra = value.Trim();
                else
                    tipoObra = "Não classificado";
            }
        }

        public double Nota
        {
            get { return nota; }
            set
            {
                if (value < 0 || value > 10)
                    nota = 0;
                else
                    nota = value;
            }
        }

        public override string ToString()
        {
            return $"[Resenha] Obra: {TituloObra} | Tipo: {TipoObra} | Nota: {Nota:F1}/10";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TESTANDO CLASSE LIVRO ===");
            Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis", 256);
            Livro livro2 = new Livro("O Hobbit", "J.R.R. Tolkien", 310);

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

            Console.WriteLine("\n=== TESTANDO CLASSE FILME ===");
            Filme filme1 = new Filme("Deadpool", "Ação/Comédia", 108);
            Filme filme2 = new Filme("Chucky", "Terror/Sobrenatural", 87);

            Console.WriteLine(filme1);
            Console.WriteLine(filme2);

            filme1.DuracaoMinutos = 172;
            filme2.Genero = "Sobrenatural";

            Console.WriteLine("\nApós alterações:");
            Console.WriteLine(filme1);
            Console.WriteLine(filme2);

            Filme filme3 = new Filme("", "", -10);
            Console.WriteLine("\nTestando dados inválidos:");
            Console.WriteLine(filme3);

            Console.WriteLine("\n=== TESTANDO CLASSE RESENHA ===");
            Resenha resenha1 = new Resenha("Dom Casmurro", "Livro", 9.5);
            Resenha resenha2 = new Resenha("Chucky", "Filme", 9.8);

            Console.WriteLine(resenha1);
            Console.WriteLine(resenha2);

            resenha1.Nota = 10;
            resenha2.TituloObra = "Chucky (2019)";

            Console.WriteLine("\nApós alterações:");
            Console.WriteLine(resenha1);
            Console.WriteLine(resenha2);

            Resenha resenha3 = new Resenha("", "Série", 15);
            Console.WriteLine("\nTestando dados inválidos:");
            Console.WriteLine(resenha3);

            Console.WriteLine("\n=== FIM DOS TESTES ===");
        }
    }
}