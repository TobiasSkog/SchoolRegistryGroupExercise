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

        public Person(string firstName, string lastName, int personalNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Invalid;
            PersonalNumber = personalNumber;
        }

        public abstract void PrintInfo();
    }
}
