namespace SchoolRegistryGroupExercise
{

    public enum Role
    {
        Teacher,
        Student
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            App SchoolRegister = new();
            SchoolRegister.Run();
        }
    }
}