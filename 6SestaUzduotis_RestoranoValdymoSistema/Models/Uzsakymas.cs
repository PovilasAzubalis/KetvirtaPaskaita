using _6SestaUzduotis_RestoranoValdymoSistema.Services;

namespace SestaUzduotis_RestoranoValdymoSistema.Models
{       // Sukurkite klasę Uzsakymas su šiais laukais:
        // Id(int)
        // Klientas(string)
        // Patiekalai(List<Patiekalas>)

    internal class Uzsakymas
        {
                public int IdUzsakymas { get; set; }
                public string Klientas { get; set; }
                public List<Patiekalas> Patiekalai { get; set; }

                public Uzsakymas()
                {
                }
                public Uzsakymas(int IdUzsakymas, string Klientas, List<Patiekalas> Patiekalai)
                {
                        this.IdUzsakymas = IdUzsakymas;
                        this.Klientas = Klientas;
                        this.Patiekalai = Patiekalai;
                }
                public void PerziuretiUzsakymus()
                {
                        foreach (Uzsakymas uzsakymas in Restoranas.UzsakymuSarasas)
                        {
                                foreach (Patiekalas patiekalas in Patiekalai)
                                {
                                        Console.WriteLine($"\n| {patiekalas.Pavadinimas}| {patiekalas.Kaina}|\n");
                                }
                        }

                }

                public Patiekalas PridetiUzsakyma()
                {
                        Console.WriteLine("Iveskite uzsakymo id:");
                        int.TryParse(Console.ReadLine(), out int uzsakymoId);

                        Console.WriteLine("Iveskite kliento varda:");
                        string klientas = Console.ReadLine();

                        Uzsakymas uzsakymas = new Uzsakymas(uzsakymoId, klientas);


                        return patiekalas;
                }
        }
}
