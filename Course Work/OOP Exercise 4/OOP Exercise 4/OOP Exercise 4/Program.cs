using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Team newTeam = new Team("Arizona", "Cardinals");
            List<Player> roster = new List<Player>();

            /*
            //Populates list with set number of undefined members
            for (int i = 0; i < 15; i++)
            {
                Player member = new Player("undefined",0, " position");
                
                roster.Add(member);
            }
            */

            /*
            // New Player Template
            Player player# = new Player("", 27, "");
            roster.Add(player#);
            */



            Player player1 = new Player("Cliff Kingsbury", 27, "Coach");
            roster.Add(player1);
            Player player2 = new Player("Oday Aboushi", 27, "Quarterback");
            roster.Add(player2);
            Player player3 = new Player("Robert Alford", 27, "Running Back");
            roster.Add(player3);
            Player player4 = new Player("David Amerson", 27, "Running Back");
            roster.Add(player4);
            Player player5 = new Player("Budda Baker", 27, "Wide Receiver");
            roster.Add(player5);
            Player player6 = new Player("Joe Barksdale", 27, "Wide Receiver");
            roster.Add(player6);
            Player player7 = new Player("Antoine Betha", 27, "Tight End");
            roster.Add(player7);
            Player player8 = new Player("Tre Boston", 27, "Corner Back");
            roster.Add(player8);
            Player player9 = new Player("Aaron Brewer", 27, "Corner Back");
            roster.Add(player9);
            Player player10 = new Player("Deone Bucannon", 27, "Safety");
            roster.Add(player10);
            Player player11 = new Player("Chalres Clay", 27, "Safety");
            roster.Add(player11);
            Player player12 = new Player("Mason Cole", 27, "Defensive Tackle");
            roster.Add(player12);
            Player player13 = new Player("Derrell Daniels", 27, "Defensive End");
            roster.Add(player13);
            Player player14 = new Player("Justin Evans", 27, "Line Backer");
            roster.Add(player14);
            Player player15 = new Player("Larry Fitzgerald", 27, "Kicker");
            roster.Add(player15);


            //calls methods to display info
            Console.WriteLine(newTeam.PrintTeamHeader());
            Console.WriteLine(newTeam.TeamHeaderSeperator());
            Console.WriteLine(newTeam.ToString());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(newTeam.PrintPlayerHeader());
            Console.WriteLine(newTeam.PlayerHeaderSeperator());
            foreach (Player p in roster)
            {
                Console.WriteLine(p.ToString());
            }

            // to keep window open
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.Write("Press any key to exit");
            Console.Read();
        }
    }
}
