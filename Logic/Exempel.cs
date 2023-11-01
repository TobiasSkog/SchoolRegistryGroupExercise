using SchoolRegistryGroupExercise.Classes;

namespace SchoolRegistryGroupExercise.Logic
{
    internal class Exempel
    {
        public List<Person> Register { get; set; }
        public Exempel()
        {
            Logic.Return.CreateClassBaseOnUserInput(Role.Teacher);

            Register = new List<Person>();

            hej(Register);
        }
        public void hej(List<Person> register)
        {

        }
    }
}
