namespace KetvirtaUzduotis_StudentuAdministravimas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurti programą, kuri atliks šias užduotis:
                        // Sukurkite klasę Studentas su šiais laukais: vardas(string), pavarde(string), amzius(int),
                        // balai int masyvas, vidurkis double.
                        //
                        // Sukurkite meniu(1.Sukurti studenta, 2.Istrinti studenta, 3.Isvesti studentus i ekrana)
                        // Klasėje Studentas sukurkite funkciją kuri skaičiuoja studento vidurkį
                        // Prieš išvedant studentą į ekraną, visada iškviesti šią funkciją, kad ji suskaičiuotų studento vidurkį. (Override'e ToString)

                        List<Studentas> studentuSarasas = new List<Studentas>();
                        meniu();
                        bool ivestiesCheck = int.TryParse(Console.ReadLine(), out int num);
                        while (ivestiesCheck == true)
                        {

                                switch (num)
                                {
                                        case 1:
                                                {
                                                        Console.Write("Iveskite studento varda: ");
                                                        string vardasCase1 = Console.ReadLine();

                                                        Console.Write("Iveskite studento pavarde: ");
                                                        string pavardeCase1 = Console.ReadLine();

                                                        Console.Write("Iveskite studento amziu: ");
                                                        int.TryParse(Console.ReadLine(), out int amziusCase1);

                                                        Studentas studentas = new Studentas(vardasCase1, pavardeCase1, amziusCase1);
                                                        studentuSarasas.Add(studentas);

                                                        Console.WriteLine("Studentas pridetas");
                                                        break;
                                                }
                                        case 2:
                                                Console.WriteLine("Iveskite studento, kuri norite istrinti eilutes numeri:");

                                                bool check = int.TryParse(Console.ReadLine(), out int idStudentuSarase);
                                                if (check == true)
                                                {
                                                        studentuSarasas.RemoveAt(idStudentuSarase -1);
                                                }
                                                break;
                                        case 3:
                                                Console.WriteLine("Studentu sarasas:");
                                                foreach (Studentas s in studentuSarasas)
                                                {
                                                        Console.WriteLine(s.ToString());
                                                }
                                                break;
                                        case 4:
                                                Environment.Exit(0);
                                                break;
                                        default:
                                                Console.WriteLine("Nera tokio pasirinkimo, rinkites is naujo.");
                                                break;
                                }
                                int.TryParse(Console.ReadLine(), out num);
                                meniu();
                        }

                }
                public static void meniu()
                {
                        Console.WriteLine("1 - Sukurti studenta\n2 - Istrinti studenta\n3 - Isvesti studentus i ekrana\n4 - baigti darba");
                }
                public class Studentas
                {
                        public string vardas;
                        public string pavarde;
                        int amzius;
                        int[] balai;
                        double vidurkis;

                        public Studentas(string vardas, string pavarde, int amzius)
                        {
                                this.vardas = vardas;
                                this.pavarde = pavarde;
                                this.amzius = amzius;
                                balai = BaluIrasymas();
                                vidurkis = VidurkioSkaiciavimas();
                        }

                        public int[] BaluIrasymas()
                        {
                                Console.Write("Iveskite kiek studentas gavo pazymiu: ");
                                int.TryParse(Console.ReadLine(), out int baluSkaicius);
                                int[] balai = new int[baluSkaicius];

                                for (int i = 0; i < balai.Length; i++)
                                {

                                        bool ivestiesCheck = int.TryParse(Console.ReadLine(), out int ivestis);
                                        if (ivestiesCheck == true)
                                        {
                                                balai[i] = ivestis;
                                        }
                                        else
                                        {
                                                Console.WriteLine("Neteisinga ivestis");
                                                i--;
                                        }
                                }

                                return balai;
                        }

                        public double VidurkioSkaiciavimas()
                        {
                                int baluSuma = 0;

                                foreach (int balas in balai)
                                {
                                        baluSuma += balas;
                                }

                                double vidurkis = (double)baluSuma / (double)(balai.Length);
                                return vidurkis;
                        }

                        public string ToString()
                        {
                                return $"Studentas: {vardas} {pavarde} ({amzius}) {vidurkis}";
                        }

                }
        }
}