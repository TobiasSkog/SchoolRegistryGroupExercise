namespace SchoolRegistryGroupExercise.Classes
{
    public enum Role
    {
        Teacher,
        Student,
        Invalid
    }
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public int PersonalNumber { get; set; }

        public Person(string firstname, string lastname, int personalnumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = Role.Invalid;
            PersonalNumber = personalnumber;
        }

        public abstract void PrintInfo();
    }
}
