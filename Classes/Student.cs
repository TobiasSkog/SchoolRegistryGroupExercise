using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistryGroupExercise.Classes
{
    internal class Student : Person
    {
        public string Course { get; set; }

        public Student(string course, string firstname, string lastname, int personalnumber)
            : base(firstname, lastname, personalnumber)
        {
            Course = course;
            Role = Role.Student;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Förnamn: {FirstName} Efternamn: {LastName}  Roll: {Role} Kurs: {Course} ID: {PersonalNumber}");
        }
    }
}
