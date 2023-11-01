using SchoolRegistryGroupExercise.Classes;

namespace SchoolRegistryGroupExercise
{
    public class App
    {
        private List<Person> Register { get; set; }
        //private Return Return { get; set; }
        private bool RunApp { get; set; }
        //private Meny Meny { get; set; }

        public App()
        {
            Register = new List<Person>();
            RunApp = true;
            //Return = new Return();
            //Meny = new Meny();

        }
        private void Quit()
        {
            RunApp = false;
        }
        public void Run()
        {
            while (RunApp)
            {
<<<<<<< HEAD

=======
                
>>>>>>> c3079063c6c113e80bee15812974c266701db910
            }
        }


    }
}
