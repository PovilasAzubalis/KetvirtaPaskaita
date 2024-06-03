namespace TreciaUzduotis_KartotiniuRadimas_Sarase
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri atliks šias užduotis:
                        // Sugeneruos sveikųjų skaičių sąrašą nuo 1 iki 100.
                        // Naudos ciklą, kad patikrintų kiekvieną skaičių ir išspausdins "Fizz",
                        // jei skaičius dalijasi iš 3, "Buzz", jei dalijasi iš 5, ir "FizzBuzz",
                        // jei dalijasi ir iš 3, ir iš 5.Jei nei viena iš šių sąlygų netinka, išspausdins patį skaičių.

                        List<int> skaiciuSarasas = new List<int>();

                        for (int i = 1; i < 101; i++)
                        {
                                skaiciuSarasas.Add(i);
                        }

                        for (int i = 1; i < 101; i++)
                        {

                                if (i % 3 == 0 && i % 5 != 0)
                                {
                                        Console.WriteLine("Fizz");
                                }
                                else if (i % 5 == 0 && i % 3 != 0)
                                {
                                        Console.WriteLine("Buzz");

                                }
                                else if (i % 3 == 0 && i % 5 == 0)
                                {
                                        Console.WriteLine("FizzBuzz");
                                }
                                else
                                {
                                        Console.WriteLine(i);
                                }


                        }

                }
        }
}