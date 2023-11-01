using SchoolRegistryGroupExercise.Classes;
using System.ComponentModel.Design;

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

        public void Run()
        {
            while (RunApp)
            {
                
            }
        }


    }
}
