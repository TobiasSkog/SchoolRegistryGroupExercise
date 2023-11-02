using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolRegistryGroupExercise.Classes;

namespace SchoolRegistryGroupExercise.Logic
{
    static class PrintEverything
    {
        public static void PrintEveryone(List<Person> register)
        {
            if (register.Count == 0)
            {
                Console.WriteLine("Listan är tom!");
                return;
            }
            
            foreach (var person in register)
            {
                person.PrintInfo();
            }
        }
    }
}
