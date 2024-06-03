namespace PenktaUzduotis_BibliotekosValdymoSistema
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite bibliotekos valdymo sistemą, kuri leis sekti knygas ir jų paskolą.
                        // Sukurkite klasę Knyga su šiais laukais:
                        // Id(int)
                        // Pavadinimas(string)
                        // Autorius(string)
                        // YraPaskolinta(bool)
                        //
                        // Sukurkite klasę Biblioteka, kuri turės metodus:
                        // PridetiKnyga(Knyga knyga): Prideda naują knygą į biblioteką.
                        // SalintiKnyga(int id): Pašalina knygą pagal ID.
                        // PaskolintiKnyga(int id): Pažymi knygą kaip paskolintą, jei ji nėra paskolinta.
                        // GrazintiKnyga(int id): Pažymi knygą kaip grąžintą, jei ji yra paskolinta.
                        // RodytiVisasKnygas(): Išspausdina visų knygų sąrašą.
                        // RodytiPaskolintasKnygas(): Išspausdina tik paskolintų knygų sąrašą.
                        // Sukurkite konsolės programą, kuri leis vartotojui pasirinkti veiksmus
                        // (pvz., pridėti knygą, pašalinti knygą, paskolinti knygą, grąžinti knygą, rodyti visas knygas,
                        // rodyti paskolintas knygas).

                        Biblioteka biblioteka = new Biblioteka();
                        meniu();

                        bool ivestis = int.TryParse(Console.ReadLine(), out int pasirinkimas);
                        while (ivestis == true)
                        {
                                switch (pasirinkimas)
                                {
                                        case 1:
                                                biblioteka.PridetiKnyga();
                                                break;
                                        case 2:
                                                foreach (Knyga i in biblioteka.knyguSarasas)
                                                {
                                                        Console.WriteLine($"{i.KnygaString()}");
                                                }
                                                break;
                                        case 3:
                                                foreach (Knyga i in biblioteka.knyguSarasas)
                                                {
                                                        if (i.YraPaskolinta == true) Console.WriteLine($"{i.KnygaString()}");
                                                }
                                                break;
                                        case 4:
                                                {
                                                        Console.WriteLine("Iveskite knygos id: ");
                                                        int.TryParse(Console.ReadLine(), out int knygosIdPasiskolinti);
                                                        int countId = biblioteka.knyguSarasas.Count;
                                                        Knyga pasiskolintaKnyga = biblioteka.knyguSarasas.ElementAt(knygosIdPasiskolinti);
                                                        pasiskolintaKnyga.PaskolintiKnyga();
                                                }
                                                break;
                                        case 5:
                                                {
                                                        Console.WriteLine("Iveskite knygos id: ");
                                                        int.TryParse(Console.ReadLine(), out int knygosIdGrazinti);
                                                        int countId = biblioteka.knyguSarasas.Count;
                                                        Knyga grazintaKnyga = biblioteka.knyguSarasas.ElementAt(knygosIdGrazinti);
                                                        grazintaKnyga.GrazintiKnyga();
                                                        break;
                                                }
                                        case 9:
                                                {
                                                        Console.WriteLine("Iveskite knygos id: ");
                                                        int.TryParse(Console.ReadLine(), out int knygosIdIstrinti);

                                                        biblioteka.IstrintiKnyga(ref knygosIdIstrinti);
                                                        break;
                                                }
                                        case 0:
                                                {
                                                        Environment.Exit(0);
                                                        break;
                                                }
                                }
                                Console.WriteLine("");
                                meniu();
                                int.TryParse(Console.ReadLine(), out pasirinkimas);

                        }
                }
                public static void meniu()
                {
                        Console.WriteLine("1 - prideti knyga.");
                        Console.WriteLine("2 - perziureti knygu sarasa.");
                        Console.WriteLine("3 - perziureti paskolintu knygu sarasa.");
                        Console.WriteLine("4 - paskolinti knyga.");
                        Console.WriteLine("5 - grazinti knyga.");
                        Console.WriteLine("9 - istrinti knyga.");
                        Console.WriteLine("0 - baigti darba.");
                }
                public class Knyga
                {
                        public int KnygosId { get; set; }
                        string Pavadinimas { get; set; }
                        string Autorius { get; set; }
                        public bool YraPaskolinta { get; set; }


                        public Knyga(int maxId, string Pavadinimas, string Autorius, bool YraPaskolinta)
                        {
                                KnygosId = maxId;
                                this.Pavadinimas = Pavadinimas;
                                this.Autorius = Autorius;
                                this.YraPaskolinta = YraPaskolinta;
                        }

                        public Knyga(int Id, string Pavadinimas, string Autorius)
                        {
                                Id += 1;
                                this.Pavadinimas = Pavadinimas;
                                this.Autorius = Autorius;
                        }

                        public void PaskolintiKnyga()
                        {
                                if (YraPaskolinta == true)
                                {
                                        Console.WriteLine("Knyga yra paskolinta. Rinkites kita knyga.");
                                }
                                else
                                {
                                        YraPaskolinta = true;
                                }
                        }

                        public void GrazintiKnyga()
                        {
                                if (YraPaskolinta == false)
                                {
                                        Console.WriteLine("Knyga nera paskolinta. Rinkites kita knyga.");
                                }
                                else
                                {
                                        YraPaskolinta = false;
                                }
                        }
                        public string KnygaString()
                        {
                                return $"\n{KnygosId}| {Pavadinimas}| {Autorius}| {YraPaskolinta}|\n";
                        }
                }

                public class Biblioteka
                {
                        public List<Knyga> knyguSarasas = new List<Knyga>();

                        public Biblioteka()
                        {
                        }

                        public void PridetiKnyga()
                        {
                                int maxId = knyguSarasas.Count > 0 ? knyguSarasas.Max(X => X.KnygosId) + 1 : 0;
                                bool pridetiPaskolinta = false;
                                Console.WriteLine("Iveskite knygos pavadinima: ");
                                string pridetiPavadinimas = Console.ReadLine();

                                Console.WriteLine("Iveskite knygos autoriu: ");
                                string pridetiAutorius = Console.ReadLine();

                                Knyga knyga = new Knyga(maxId, pridetiPavadinimas, pridetiAutorius, pridetiPaskolinta);
                                knyguSarasas.Add(knyga);
                                Console.WriteLine("Knyga priimta");
                        }
                        public void IstrintiKnyga(ref int knygosIdIstrinti)
                        {
                                Knyga knygaIstrinti = knyguSarasas.ElementAt(knygosIdIstrinti);
                                knyguSarasas.Remove(knygaIstrinti);
                                Console.WriteLine("Knyga istrinta");
                        }
                }
        }
}