using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistryGroupExercise.Logic
{
    internal class Return
    {
        public void PrintRoleInfo(string role)
        {
            Console.WriteLine($"Förnamn: {FirstName}, Efternamn: {LastName}, Roll: {Role}, Personnummer: {PersonalNumber}");
            switch (role)
            {
                case "Lärare":
                    Console.WriteLine("Detta är en lärare. Ämne: " + Role);
                    break;
                case "Student":
                    Console.WriteLine("Detta är en student. Kurs: " + Role);
                    break;                   
            }
        }
    }
}
