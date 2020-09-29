using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_10
{
    class Vampire: Monster, IFly, ISpeed, IStrength, IShapeshift
    {
       public bool CanFly()
       {
            return true;
       }

        public int Superspeed()
        {
            Speed *= 5;
            return Speed;
        }

        public int Superstrength()
        {
            Strength *= 3;
            return Strength;
        }

        public bool CanShapeshift()
        {
            return true;
        }





    }
}
