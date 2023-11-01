using SchoolRegistryGroupExercise.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistryGroupExercise.Logic
{
    public static class PrintAllStudents
    {
        public static void PrintStudents(List<Person> Register)
        {

            foreach (Student student in Register)
                if (student != null)
                {
                    {
                        Console.WriteLine(student.FirstName + student.LastName); //Bara namn eller all info?
                    }
                }
                else { Console.WriteLine("Det finns inga studenter i registret"); }
        }
    }
}
