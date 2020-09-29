using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    class Court
    { 
        //constructors
        public  Court (int Size_, Location Basket1_, Location Basket2_, Location Ball_, Location Ref_, List<Person> Allpersons_)//Person Red1_, Person Red2_, Person Red3_, Person Blue1_, Person Blue2_, Person Blue3_)
        {
            this.Size = Size_;
            this.Basket1 = Basket1_;
            this.Basket2 = Basket2_;
            this.Ball = Ball_;
            this.Ref = Ref_;
            this.AllPersons = Allpersons_;
        }
        
        
        public int Size { get; set; }
        public Location Basket1 { get; set; }
        public Location Basket2 { get; set; }
        public Location Ball { get; set; }
        public Location Ref { get; set; }
        public List<Person> AllPersons { get; set; }

        
        public void RandoLoc()
        {
            Random rnd = new Random();
            int loc = (rnd.Next(-10, 11));      
        }


        Person Red1 = new Person(-1 ,-1);

        Person Red2 = new Person(-1,-7);

        Person Red3 = new Person(2,-6);

        Person Blue1 = new Person(1,1);

        Person Blue2 = new Person(-2,3);

        Person Blue3 = new Person(1,8);

        public void GenerateTeams()
        {
            AllPersons.Add(Red1);
            AllPersons.Add(Red2);        
            AllPersons.Add(Red3);       
            AllPersons.Add(Blue1); 
            AllPersons.Add(Blue1);
            AllPersons.Add(Blue1);
        }

        public void DisplayTeam()
        {
            Console.WriteLine("Players grouped by team");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Player: Red1  Location: " +   Red1.ToString());
            Console.WriteLine("Player: Red2  Location: " +   Red2.ToString());
            Console.WriteLine("Player: Red3  Location: " +   Red3.ToString());
            Console.WriteLine();
            Console.WriteLine("Player: Blue1 Location: " +   Blue1.ToString());
            Console.WriteLine("Player: Blue2 Location: " +   Blue2.ToString());
            Console.WriteLine("Player: Blue3 Location: " +   Blue3.ToString());
            Console.WriteLine();

        }

        public void DisplayLocations()
        {
            List<Double> distances = new List<double>();
            Console.WriteLine("Players distances from Referee");
            Console.WriteLine("------------------------------");
            foreach (Person p in AllPersons)
            {
                double distance = 0;

                distance = Math.Sqrt(Math.Pow(Ref.PositionX - p.PositionX, 2) + Math.Pow(Ref.PositionY - p.PositionY, 2));
                distances.Add(distance);
                distances.Sort();
            }
            foreach (Double d in distances)
            {
                string s = String.Format("{0:N4}", d);
                Console.WriteLine(s);
            }
        }

        public void CalcScore()
        {
            int score1 = 0;
            int score2 = 0;
            int x = Ball.PositionX;
            int y = Ball.PositionY;
            Console.WriteLine();
            Console.WriteLine("Score Tracking");
            Console.WriteLine("--------------");

            if (Enumerable.Range(-1, 1).Contains(x) && Enumerable.Range(4, 5).Contains(y))
            {
                score1++;              
            }
            Console.WriteLine("Points scored in Basket 1: " + score1);

            if (Enumerable.Range(-1, 1).Contains(x) && Enumerable.Range(-4, -5).Contains(y))
            {
                score2++;
            }
            Console.WriteLine("Points scored in Basket 2: " + score2);

        }
    }
}
