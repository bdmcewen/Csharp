using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    class Employee
    {
        public Employee(int PositionX_,int PositionY_)
        {
            this.PositionX = PositionX_;
            this.PositionY = PositionY_;
        }

        public Employee() { }

        public int PositionX { get; set; }
        public int PositionY { get; set; }

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public string ToString()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            string s = "(" + PositionX.ToString() + "," + PositionY.ToString() + ")";
            return s;
        }

        
    }
}
