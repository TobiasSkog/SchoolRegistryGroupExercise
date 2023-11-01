using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistryGroupExercise.Meny
{
    internal class Meny
    {
        public void Menu()
        {
            string menuchoice = "";

            while (menuchoice != "6")
            {
                Menu();

                menuchoice = Console.ReadLine();

                switch (menuchoice)
                {
                    case "1":
                        //lägg till lärare
                        break;
                    case "2":
                      //lägg till elev
                        break;
                    case "3":
                        //skriver ut alla lärare
                        break;
                    case "4":
                        //skriv ut alla studerande
                        break;
                    case "5":
                        //skriv ut alla
                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tack för idag!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Välj någon av kategorierna ovan.\n");
                        break;
                }
            }
        }
        public void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***** Skolregistret *****");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Lägg till lärare");
            Console.WriteLine("2. Lägg till elev");
            Console.WriteLine("3. Skriv ut alla lärare");
            Console.WriteLine("4. Skriv ut alla studerande");
            Console.WriteLine("5. Skriv ut alla i registret");
            Console.WriteLine("\n 6. Avsluta\n");
        }
    }
}
