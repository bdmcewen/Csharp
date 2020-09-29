using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    class Location
    {
        public Location(int positionx, int positiony)
        {
            this.PositionX = positionx;
            this.PositionY = positiony;
        }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
