﻿using SchoolRegistryGroupExercise.Classes;
using SchoolRegistryGroupExercise.ConsoleOut;
using SchoolRegistryGroupExercise.Logic;

namespace SchoolRegistryGroupExercise
{
    public class App
    {
        private List<Person> Register { get; set; } //Privet fält
        //private Return Return { get; set; }       
        private bool RunApp { get; set; }

        public App() // konstruktor
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
                Console.Clear();
                if (Register.Count == 0)
                {
                    // Print Add To List Meny
                    Meny.PrintMenuEmptyRegister();

                    string menuChoice = Console.ReadLine();

                    switch (menuChoice)
                    {
                        case "1":
                            //lägg till lärare
                            var teacher = Return.CreateClassBaseOnUserInput(Role.Teacher);
                            Register.Add(teacher);

                            break;
                        case "2":
                            //lägg till elev
                            var student = Return.CreateClassBaseOnUserInput(Role.Student);
                            Register.Add(student);
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
                else
                {
                    Meny.PrintFullMenu();

                    string menuChoice = Console.ReadLine();

                    switch (menuChoice)
                    {
                        case "1":
                            //lägg till lärare
                            var teacher = Return.CreateClassBaseOnUserInput(Role.Teacher);
                            Register.Add(teacher);

                            break;
                        case "2":
                            //lägg till elev
                            var student = Return.CreateClassBaseOnUserInput(Role.Student);
                            Register.Add(student);
                            break;
                        case "3":
                            //skriver ut alla lärare
                            PrintAllTeachers.PrintTeachers(Register);
                            break;
                        case "4":
                            //skriv ut alla studerande
                            PrintAllStudents.PrintStudents(Register);
                            break;
                        case "5":
                            //skriv ut alla
                            PrintEverything.PrintEveryone(Register);
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

