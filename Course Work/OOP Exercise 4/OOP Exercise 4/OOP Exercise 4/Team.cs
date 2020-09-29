using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_4
{
    class Team
    {
        //attributes
        //List<Player> Roster = new List<Player>(15);

        //Constructors
        public Team(string teamcity, string teamname)
        {
            this.TeamCity = teamcity;
            this.TeamName = teamname;

        }

        public Team(List<Player> roster)
        {
            this.Roster = roster;
        }

        //Basic get/set Methods
        public string TeamName { get; set; }
        public string TeamCity { get; set; }
        public List<Player> Roster { get; set; }
        

        //Other Methods
        public string PrintTeamHeader()
        {
            return String.Format("{0,-16} {1,-16}", "Team City", "Team Name");
        }

        public int RandoAgeGenerator()
        {
            //get Random number
            Random r = new Random();
            int randAge = r.Next(19, 49);
            return randAge;
        }

        public string PrintPlayerHeader()
        {
            return String.Format("{0,-16} {1,-16} {2,-16}", "Player Name", "Player Age", "Players Position");
        }
        public string TeamHeaderSeperator()
        {
            return "---------------------------";
        }
        public string PlayerHeaderSeperator()
        {
            return "---------------------------------------------------";
        }

        public override string ToString()
        {
            return string.Format("{0,-16} {1,-16}", TeamCity, TeamName);
        }

    }
}
