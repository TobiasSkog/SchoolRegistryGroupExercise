﻿using SchoolRegistryGroupExercise.Classes;

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
                string menuchoice = "";

                while (menuchoice != "0" || menuchoice != "exit")
                {
                    Meny.Meny.PrintMenu();

                    menuchoice = Console.ReadLine();

                    switch (menuchoice)
                    {
                        case "1":
                            //lägg till lärare
                            var teacher = Logic.Return.CreateClassBaseOnUserInput(Role.Teacher);
                            Register.Add(teacher);

                            break;
                        case "2":
                            //lägg till elev
                            var student = Logic.Return.CreateClassBaseOnUserInput(Role.Student);
                            Register.Add(student);
                            break;
                        case "3":
                            //skriver ut alla lärare
                            PrintAllTeachers();
                            break;
                        case "4":
                            //skriv ut alla studerande
                            PrintAllStudents();
                            break;
                        case "5":
                            //skriv ut alla
                            PrintEveryone();
                            break;
                        case "0":
                        case "exit":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tack för idag!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Quit();
                            break;
                        default:
                            Console.WriteLine("Välj någon av kategorierna ovan.\n");
                            break;
                    }
                }

            }
        }


    }
}
