namespace SchoolRegistryGroupExercise.ConsoleOut
{
    public static class Meny
    {
        public static void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n***** Skolregistret *****\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(1) Lägg till lärare");
            Console.WriteLine("(2) Lägg till elev");
            Console.WriteLine("(3) Skriv ut alla lärare");
            Console.WriteLine("(4) Skriv ut alla studerande");
            Console.WriteLine("(5) Skriv ut alla i registret");
            Console.WriteLine("\n (0/exit) Avsluta\n");
        }
    }
}
