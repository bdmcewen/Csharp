using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    class Item
    {
        public Item(String itemname,int size, Location position)
        {
            this.ItemName = itemname;
            this.Size = size;
            this.Position = Position;
        }
        public String ItemName { get; set; }
        public int Size { get; set; }
        public Location Position { get; set; }
        
    }
}
