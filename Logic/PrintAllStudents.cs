using SchoolRegistryGroupExercise.Classes;

namespace SchoolRegistryGroupExercise.Logic
{
    public static class PrintAllStudents
    {
        public static void PrintStudents(List<Person> Register)
        {
            if (Register.Count != 0)
            {
                foreach (var student in Register)
                {
                    if (student.Role == Role.Student)
                    {
                        student.PrintInfo();
                    }
                }
            }
            else
            {
                Console.WriteLine("Det finns inga elever i registret");
            }
            Console.WriteLine("Tryck på valfri knapp för att fortsätta");
            Console.ReadKey();
        }
    }
}
