using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Location Basket1 = new Location(0, 4);
            Location Basket2 = new Location(0, -4);
            Location Ball = new Location(0, 0);
            Location Ref = new Location(5, 2);
            List<Person> AllPersons = new List<Person>();
            Court floor = new Court(10, Basket1, Basket2, Ball, Ref, AllPersons);

            //Console.WriteLine(Ref.PositionX.ToString(),Ref.PositionY.ToString());

            floor.GenerateTeams();
            floor.DisplayTeam();
            floor.DisplayLocations();
            floor.CalcScore();

            Console.ReadLine();
        }

      
    }
}
