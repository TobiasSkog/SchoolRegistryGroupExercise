using SchoolRegistryGroupExercise.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistryGroupExercise.Logic
{
    public static class PrintAllTeachers
    {
        public static void PrintTeachers(List<Person>Register)
        {
            foreach (Teacher teacher in Register)
                if (teacher != null)
                {
                    {
                        Console.WriteLine(teacher.FirstName + " " +teacher.LastName); //Bara namn eller all info?
                    }
                }
                else { Console.WriteLine("Det finns inga lärare i registret"); }
        }
    }
}
