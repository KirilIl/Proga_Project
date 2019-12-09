using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public abstract class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ItemType Type { get; set; }

        public Item(string name, double price,ItemType type)
        {
            Name = name;
            Price = price;
            Type = type;
        }
    }
}
