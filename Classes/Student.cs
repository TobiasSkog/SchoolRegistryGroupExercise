namespace SchoolRegistryGroupExercise.Classes
{
    internal class Student : Person
    {
        public string Course { get; set; }

        public Student(string course, string firstName, string lastName, int personalNumber)
            : base(firstName, lastName, personalNumber)
        {
            Course = course;
            Role = Role.Student;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Förnamn: {FirstName} Efternamn: {LastName}  Roll: {Role} Kurs: {Course} Personnummer: {PersonalNumber}");
        }
    }
}
