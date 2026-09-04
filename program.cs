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