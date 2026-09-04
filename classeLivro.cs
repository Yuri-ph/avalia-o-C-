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
