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
            Console.WriteLine("3x3 basket ball");
            Location Basket1 = new Location(0, 4);
            Location Basket2 = new Location(0, -4);
            Location Rock = new Location(0, 0);
            Location Ref = new Location(5, 2);
            List<Player> AllPersons = new List<Player>();
            Court floor = new Court(10, Basket1, Basket2, Rock, Ref, AllPersons);

            //Console.WriteLine(Ref.PositionX.ToString(),Ref.PositionY.ToString());
            
            floor.GenerateTeams();
            floor.DisplayTeam();
            floor.DisplayLocations();
            floor.CalcScore();


            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            
            Console.WriteLine("3x3 Flag football");
            Location Goal1 = new Location(0, 4);
            Location Goal2 = new Location(0, -4);
            Location Pigskin = new Location(0, 0);
            Location Refr = new Location(5, 3);            
            Court field = new Court(10, Basket1, Basket2, Pigskin, Refr, AllPersons);

            //Console.WriteLine(Ref.PositionX.ToString(),Ref.PositionY.ToString());
            AllPersons.Clear();
            field.GenerateTeams();
            field.DisplayTeam();
            field.DisplayLocations();
            field.CalcScore();


            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            
            Console.WriteLine("3x3 soccer");
            Location Net1 = new Location(0, 4);
            Location Net2 = new Location(0, -4);
            Location Ball = new Location(0, 0);
            Location Refer = new Location(4, 2);
            Court field1 = new Court(10, Basket1, Basket2, Pigskin, Refer, AllPersons);

            //Console.WriteLine(Ref.PositionX.ToString(),Ref.PositionY.ToString());
            AllPersons.Clear();
            field1.GenerateTeams();
            field1.DisplayTeam();
            field1.DisplayLocations();
            field1.CalcScore();

            Console.ReadLine();



        }

      
    }
}
