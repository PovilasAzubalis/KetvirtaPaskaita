namespace PirmaUzduotis_SarasuManipuliacija
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri atliks šias užduotis su sąrašu:
                        // Sukurs sąrašą, kuriame yra šie sveikieji skaičiai: 5, 3, 8, 4, 2.
                        // Išspausdins sąrašo elementus.
                        // Pridės skaičių 10 į sąrašo pabaigą.
                        // Ištrins skaičių 4 iš sąrašo.
                        // Rūšiuos sąrašą didėjančia tvarka.
                        // Išspausdins sąrašą po kiekvieno pakeitimo.

                        List<int> integerSarasas = new List<int> { 5, 3, 8, 4, 2 };

                        foreach (int item in integerSarasas)
                        {
                                Console.Write($"{item} ");
                        }

                        Console.WriteLine();
                        integerSarasas.Add(10);

                        foreach (int item in integerSarasas)
                        {
                                Console.Write($"{item} ");
                        }

                        Console.WriteLine();
                        integerSarasas.Remove(4);

                        foreach (int item in integerSarasas)
                        {
                                Console.Write($"{item} ");
                        }

                        Console.WriteLine();
                        integerSarasas.Sort();

                        foreach (int item in integerSarasas)
                        {
                                Console.Write($"{item} ");
                        }

                        Console.WriteLine("Ar norite prideti elementa? Taip - 1, Ne - 0");
                        int.TryParse(Console.ReadLine(), out int ivestis);

                        while (ivestis == 1 || ivestis == 0)
                                if (ivestis == 0)
                                {
                                        Console.WriteLine("paskutinis issaugotas sarasas");
                                        foreach (int item in integerSarasas)
                                        {
                                                Console.Write($"{item} ");
                                        }
                                        break;

                                }
                                else if (ivestis == 1)
                                {
                                        Console.WriteLine("Iveskite nauja elementa.");
                                        int.TryParse(Console.ReadLine(), out int naujaivestis);
                                        integerSarasas.Add(naujaivestis);
                                        Console.WriteLine("Ar norite prideti elementa? Taip - 1, Ne - 0");
                                        int.TryParse(Console.ReadLine(), out int ivestisLoop);
                                        ivestis = ivestisLoop;

                                }
                                else
                                {
                                        Console.WriteLine("Ivestis neteisinga, bandykite dar karta.");
                                        continue;
                                }
                }
        }
}
