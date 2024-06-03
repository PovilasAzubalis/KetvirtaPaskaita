using _6SestaUzduotis_RestoranoValdymoSistema.Services;
using SestaUzduotis_RestoranoValdymoSistema.Models;

namespace SestaUzduotis_RestoranoValdymoSistema.Services
{
    public class UI
        {
                public static void Main(string[] args)
                {
                        meniuText();
                        bool meniuInputCheck = int.TryParse(Console.ReadLine(), out int MeniuInput);

                        while (meniuInputCheck == true)
                        {
                                Restoranas restoranas1 = new Restoranas();
                                Uzsakymas uzsakymas1 = new Uzsakymas();
                                
                                meniuText();
                                int.TryParse(Console.ReadLine(), out MeniuInput);

                                switch (MeniuInput)
                                {
                                        case 0:
                                                Environment.Exit(0);
                                                break;
                                        case 1:
                                                restoranas1.PerziuretiMeniu();
                                                break;
                                        case 2:
                                                restoranas1.PridetiPatiekalaIMeniu();
                                                break;
                                        case 3:
                                                restoranas1.IstrintiPatiekalaIsMeniu();
                                                break;
                                        case 4:
                                                

                                }
                        }

                }

                public static void meniuText()
                {

                        Console.WriteLine("1 - Perziureti restorano meniu");
                        Console.WriteLine("2 - Prideti patiekala i meniu.");
                        Console.WriteLine("3 - Istrinti patiekala is meniu");

                        Console.WriteLine("4 - Perziureti uzsakymu sarasa");
                        Console.WriteLine("5 - Prideti uzsakyma");
                        Console.WriteLine("6 - Pakeisti uzsakymo busena");
                        Console.WriteLine("7 - Perziureti uzsakyma pagal ID");
                        Console.WriteLine("8 - Istrinti uzsakyma");

                        Console.WriteLine("0 - baigti darba.");
                }
        }


}
