using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_10
{
    class Mummy: Monster, IFly, ISpeed, IStrength
    {
        public bool CanFly()
       {
            return false;
       }

        public int Superspeed()
        {
            Speed *= 15;
            return Speed;
        }

        public int Superstrength()
        {
            Strength *= 1;
            return Strength;
        }





    }
}
