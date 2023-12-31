﻿using SchoolRegistryGroupExercise.Classes;

namespace SchoolRegistryGroupExercise.Logic
{
    public static class PrintAllTeachers
    {
        public static void PrintTeachers(List<Person> Register)
        {
            if (Register.Count != 0)
            {
                foreach (var teacher in Register)
                {
                    if (teacher.Role == Role.Student)
                    {
                        teacher.PrintInfo();
                    }
                }
            }
            else
            {
                Console.WriteLine("Det finns inga lärare i registret");
            }
            Console.WriteLine("Tryck på valfri knapp för att fortsätta");
            Console.ReadKey();
        }
    }
}
