using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public class Drinks : Item
    {
        public double Volume { get; set; }

        public Drinks(string name, double price, ItemType type, double volume) :
            base(name, price, type)
        {
            Volume = volume;
        }

        public override string ToString()
        {
            return $"Назва товару:{Name}\nЦіна:{Price}\nОб'єм:{Volume} л.";
        }
    }
}
