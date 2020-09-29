using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_10
{
    class Warewold: Monster, IFly, ISpeed, IStrength, IShapeshift
    {
        public bool CanFly()
       {
            return false;
       }

        public int Superspeed()
        {
            Speed *= 2;
            return Speed;
        }

        public int Superstrength()
        {
            Strength *= 4;
            return Strength;
        }

        public bool CanShapeshift()
        {
            return true;
        }





    }
}
