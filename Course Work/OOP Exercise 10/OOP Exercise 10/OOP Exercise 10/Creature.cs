using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_10
{
    class Creature: Monster, IStrength, IShapeshift
    {
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
