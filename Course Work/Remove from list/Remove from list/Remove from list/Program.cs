using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_from_list
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> firstName = new List<string>() { "Mistie", "Mee", "Camelia", "Shanel", "Danny", "Ha", "Dion", "Sergio", "Ivory", "Erminia" };
            firstName.Sort();
            firstName.Reverse();
            DisplayStudents();
            RemoveStudents();


            for (int x = 0; x < (firstName.Count); x++)
            {
                Console.WriteLine((x + 1).ToString() + ": " + firstName[x]);

            }

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
                    Console.WriteLine((i + 1).ToString() + ": " + firstName[i]);

                }


            }

            void RemoveStudents()
            {

                Console.WriteLine();
                Console.WriteLine("Please enter the name of the student you would like to remove.");
                string name = Console.ReadLine();

                for (int i = 0; i <= firstName.Count(); i++)
                {
                    if (name == firstName[i])
                    {
                        firstName.Remove(firstName[i]);
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(name + " has been removed from the roster.");
                Console.WriteLine();
                Console.WriteLine("Press enter to display the modified roster");
                Console.ReadLine();
            }

        }

    }
}
