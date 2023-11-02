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
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Det finns inga lärare i registret");
                Console.ReadKey();
            }
        }
    }
}
