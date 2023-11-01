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
        public enum Roles
        {
           Teacher, 
           Student,
           Invalid
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int PersonalNumber { get; set; }

        public Person(string firstname, string lastname, string role, int personalnumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = Role.Invalid;
            PersonalNumber = personalnumber;
        }

        public abstract void PrintInfo();
    }
}
