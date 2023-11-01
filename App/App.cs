using SchoolRegistryGroupExercise.Classes;

namespace SchoolRegistryGroupExercise
{
    public class App
    {
        private List<Person> Register { get; set; }
        //private Return Return { get; set; }
        private bool RunApp { get; set; }

        public App()
        {
            Register = new List<Person>();
            RunApp = true;
            //Return = new Return();

        }
        private void Quit()
        {
            RunApp = false;
        }
        public void Run()
        {
            while (RunApp)
            {

            }
        }


    }
}
