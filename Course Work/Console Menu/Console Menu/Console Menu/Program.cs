using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();

            void DisplayMenu()

            {
                Console.WriteLine();
                Console.WriteLine("Console Menu");
                Console.WriteLine("----------------------");
                Console.WriteLine();

                Console.WriteLine("1. About this Developer");
                Console.WriteLine("2. Quit");

                Console.WriteLine();
                Console.WriteLine("Please, enter a selection");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AboutDeveloper(); break;
                    case "2": ExitApplication(); break;

                }
            }

            void AboutDeveloper()
            {
                Console.Clear();
                Console.WriteLine("About this Developer");
                Console.WriteLine("--------------------");

                Console.WriteLine("    I enjoy working with cars, more specifically, modifying american muscle cars. \n" +
                    "if I could end up in a postion where I was helping  design software for engine \nmanagement systems " +
                    "that would probably be my dream job. However, I do enjoy \ncoding in general so any job related " +
                    "programming or designing software would be \nacceptable to me.");

                ReturnToMain();

            }

            void ExitApplication()
            {
                Environment.Exit(0);
            }

            void ReturnToMain()
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to return to main menu");
                Console.ReadLine();
                Console.Clear();
                DisplayMenu();
            }

        }
    }
}
