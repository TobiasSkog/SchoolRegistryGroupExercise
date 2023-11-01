using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistryGroupExercise.Classes
{
    public abstract class Person
    {
        public enum Roles
        {
           Teacher, 
           Student,
           Invalid
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles Role { get; set; }
        public int PersonalNumber { get; set; }

        public Person(string firstname, string lastname, Roles role, int personalnumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = role;
            PersonalNumber = personalnumber;
        }

        public abstract void PrintInfo();
    }
}
