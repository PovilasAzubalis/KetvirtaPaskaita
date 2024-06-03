namespace AntraUzduotis_StudentuSarasas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri atliks šias užduotis:
                        // Sukurkite klasę Studentas su šiais laukais: vardas(string), amzius(int), balas(double).
                        // Sukurkite metodą, kuris grąžina studento informaciją kaip string.
                        // Sukurkite kelis studentų objektus ir pridėkite juos į sąrašą.
                        // Išspausdinkite visų studentų informaciją.
                        
                        Studentas studentas1 = new Studentas("Povilas", 27, 8);
                        Studentas studentas2 = new Studentas("Petras", 20, 7);
                        Studentas studentas3 = new Studentas("Benas", 24, 10);
                        Console.WriteLine(studentas1.GrazinkStudentoDuomenis());

                        List<Studentas> studentuSarasas = new List<Studentas>();

                        studentuSarasas.Add(studentas1);
                        studentuSarasas.Add(studentas2);
                        studentuSarasas.Add(studentas3);

                        foreach (Studentas studentas in studentuSarasas)
                        {
                                Console.WriteLine(studentas.GrazinkStudentoDuomenis());
                        }
                }


        }
        public class Studentas
        {
                string vardas { get; set; }
                int amzius { get; set; }
                double balas { get; set; }

                public Studentas(string vardas, int amzius, double balas)
                {
                        this.vardas = vardas;
                        this.amzius = amzius;
                        this.balas = balas;
                }

                public string GrazinkStudentoDuomenis()
                {
                        string duomenys = $"Studento vardas: {vardas}. Studento amzius: {amzius}. Studento balas: {balas}";
                        return duomenys;
                }
        }
}
