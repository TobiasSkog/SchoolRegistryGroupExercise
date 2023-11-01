using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistryGroupExercise.Classes
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int PersonalNumber { get; set; }

        public Person(string firstname, string lastname, string role, int personalnumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = role;
            PersonalNumber = personalnumber;
        }

        public virtual void PrintInfo()
        {

        }
    }
}
