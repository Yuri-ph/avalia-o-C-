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
