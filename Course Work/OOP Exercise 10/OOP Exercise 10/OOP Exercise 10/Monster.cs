using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_10
{
    class Monster
    {
        public int Strength { get; set; }
        public bool Undead { get; set; }
        public int Speed { get; set; }


        public Monster(int strength, bool undead, int speed)
        {
            this.Strength = strength;
            this.Undead = undead;
            this.Speed = speed;           
        }
        public Monster()
        {
            
        }

    }
}
