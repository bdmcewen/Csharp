using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    class Player : Employee
    {
        public Player() : base (0,0)
        {

        }

        public Player(int PositionX_, int PositionY_) : base(PositionX_, PositionY_)
        {
        }
    }
}
