﻿using SchoolRegistryGroupExercise.Classes;

namespace SchoolRegistryGroupExercise.Logic
{
    internal class Return
    {
        public Person CreateClassBaseOnUserInput(Role role)
        {
            Console.Write("Skriv in förnam: ");
            string firstName = Console.ReadLine();
            Console.Write("Skriv in efternamn: ");
            string lastName = Console.ReadLine();
            Console.Write("Skriv in personummer: ");
            int peronalNumber = int.Parse(Console.ReadLine());


            switch (role)
            {
                case Role.Teacher:
                    Console.Write("Vilken ämne: ");
                    string subject = Console.ReadLine();
                    return new Teacher(subject, firstName, lastName, peronalNumber);

                case Role.Student:
                    Console.Write("Vilken kurs: ");
                    string course = Console.ReadLine();
                    return new Student(course, firstName, lastName, peronalNumber);
            }
            return default;
        }
    }
}
