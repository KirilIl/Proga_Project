using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public class Grocery : Item
    {
        public double Weight { get; set; }

        public Grocery(string name, double price,ItemType type, double weight) :
            base(name, price,type)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Назва товару:{Name}\nЦіна:{Price}\nВага:{Weight} кг.";
        }
    }
}
