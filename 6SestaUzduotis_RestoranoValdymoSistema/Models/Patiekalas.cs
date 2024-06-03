namespace SestaUzduotis_RestoranoValdymoSistema.Models
{       // Sukurkite klasę Patiekalas su šiais laukais:
        // Id(int)
        // Pavadinimas(string)
        // Kaina(double)
        // Busena(string) – gali būti "Laukiama", "Ruošiama", "Paruošta"

        internal class Patiekalas
        {
                public int IdPatiekalas { get; set; }
                public string Pavadinimas { get; set; }
                public double Kaina { get; set; }
                public string Busena { get; set; }

                public Patiekalas(string Pavadinimas, double Kaina)
                {
                        this.Pavadinimas = Pavadinimas;
                        this.Kaina = Kaina;
                }
                public Patiekalas(int IdPatiekalas)
                {
                        this.IdPatiekalas = IdPatiekalas;
                }

                public Patiekalas(int IdPatiekalas, string Pavadinimas, double Kaina, string Busena)
                {
                        this.IdPatiekalas = IdPatiekalas;
                        this.Pavadinimas = Pavadinimas;
                        this.Kaina = Kaina;
                        this.Busena = Busena;
                }

        }
}
