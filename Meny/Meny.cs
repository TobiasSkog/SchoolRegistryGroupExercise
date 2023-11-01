using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistryGroupExercise.Meny
{
    internal class Meny
    {
        public void Switch()
        {
            string menuchoice = "";

            while (menuchoice != "4")
            {
                Menu();

                menuchoice = Console.ReadLine();

                switch (menuchoice)
                {
                    case "1":
                        break;
                    case "2":
                      
                        break;
                    case "3":
                        
                        break;

                    case "4":
                        break;

                    case "5":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tack för idag!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Välj någon av kategorierna ovan.");
                        break;
                }
            }
        }
        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***** Skolregistret *****");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Lägg till lärare");
            Console.WriteLine("2. Lägg till elev");
            Console.WriteLine("3. Skriv ut alla lärare");
            Console.WriteLine("4. skriv ut alla studerande");
            Console.WriteLine("\n 5. Avsluta");
        }
    }
}
