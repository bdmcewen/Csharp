using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Print
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> firstName = new List<string>() { "Mistie", "Mee", "Camelia", "Shanel", "Danny", "Ha", "Dion", "Sergio", "Ivory", "Erminia"};
            firstName.Sort();
            firstName.Reverse();
            DisplayStudents();

            Console.WriteLine();
            Console.WriteLine("Press enter to Exit.");
            Console.Read();
            Environment.Exit(0);

            void DisplayStudents()
            {
                Console.WriteLine("Roster");
                Console.WriteLine("------");
                Console.WriteLine("There are currently " + firstName.Count + " people in your list");
                Console.WriteLine();

                for (int i = 0; i < (firstName.Count); i++)
                {
                    Console.WriteLine((i+1).ToString() + ": " + firstName[i]);

                }

            }

        }

    }
}
