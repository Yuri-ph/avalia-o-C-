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