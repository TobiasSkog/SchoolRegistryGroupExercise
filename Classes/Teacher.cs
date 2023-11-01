using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistryGroupExercise.Classes
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string subject, string firstName, string lastName, int personalNumber)
            : base (firstName, lastName, personalNumber)
        {
            Subject = subject;
            Role = Role.Teacher;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Förnamn: {FirstName} Efternamn: {LastName}  Roll: {Role} Undervisningsämne: {Subject} Personnummer: {PersonalNumber}");
        }

    }
}
