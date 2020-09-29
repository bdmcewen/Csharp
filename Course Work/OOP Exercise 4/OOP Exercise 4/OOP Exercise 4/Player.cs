using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_4
{
    class Player
    {
        /*
        //Attributes
        string playerName = "";
        int playerAge = 0;
        string playerPosition = "";
        */

        //Constructors
        public Player(string name, int age, string position)
        {          
            this.PlayerName = name;
            this.PlayerAge = age;
            this.PlayerPosition = position;
        }
        
        //Basic get/set methods
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
        public string PlayerPosition { get; set; }

        //Other Methods


        public override string ToString()
        {
            return string.Format("{0,-16} {1,-16} {2,-16} ", PlayerName, PlayerAge, PlayerPosition);
        }
    }
}
