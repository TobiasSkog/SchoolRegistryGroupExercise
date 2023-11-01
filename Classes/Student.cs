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

        public Student(string course, string firstname, string lastname, string role, int personalnumber)
            : base(firstname, lastname, role, personalnumber)
        {
            Course = course;
        }

        public override void PrintInfo()
        {
            Console.WriteLine();
        }
    }
}
