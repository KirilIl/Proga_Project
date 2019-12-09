using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        public Item(string name, double price,string type)
        {
            Name = name;
            Price = price;
            Type = type;
        }
    }
}
