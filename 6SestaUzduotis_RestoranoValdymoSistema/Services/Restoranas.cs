using SestaUzduotis_RestoranoValdymoSistema.Models;

namespace _6SestaUzduotis_RestoranoValdymoSistema.Services
{       // Sukurkite klasę Restoranas, kuri turės metodus:
        // PridetiPatiekalaIPateikaluSarasa(Patiekalas patiekalas): Prideda patiekalą į restorano meniu.
        // RodytiVisusPatiekalus(): Išspausdina visų patiekalų sąrašą.
        // PridetiUzsakyma(Uzsakymas uzsakymas): Prideda naują užsakymą.
        // KeistiPatiekaloBusena(int uzsakymoId, int patiekaloId, string naujaBusena):Keičia patiekalo būseną užsakyme.
        // RodytiVisusUzsakymus(): Išspausdina visų užsakymų sąrašą.
        // RodytiUzsakyma(int uzsakymoId): Išspausdina konkretaus užsakymo informaciją.
    internal class Restoranas
    {
        public List<Patiekalas> MeniuRestorano { get; set; }
        public List<Uzsakymas> UzsakymuSarasas { get; set; }

        public Restoranas()
        {

        }
        public Patiekalas PridetiPatiekala()
        {
            Console.WriteLine("Iveskite patiekalo pavadinima:");
            string patiekaloPavadinimas = Console.ReadLine();

            Console.WriteLine("Iveskite patiekalo kaina:");
            int.TryParse(Console.ReadLine(), out int patiekaloKaina);

            Patiekalas patiekalas = new Patiekalas(patiekaloPavadinimas, patiekaloKaina);
            return patiekalas;
        }

        public void PridetiPatiekalaIMeniu()
        {
            MeniuRestorano.Add(PridetiPatiekala());
        }

        public void PerziuretiMeniu()
        {
            foreach (Patiekalas patiekalas in MeniuRestorano)
            {
                Console.WriteLine($"\n| {patiekalas.Pavadinimas}| {patiekalas.Kaina}|\n");
            }
        }

        public void IstrintiPatiekalaIsMeniu()
        {
            Console.WriteLine("Iveskite patiekalo id:");
            int.TryParse(Console.ReadLine(),out int idIvestis);

            MeniuRestorano.Remove(MeniuRestorano.Find(x => x.IdPatiekalas == idIvestis));
        }




    }
}
