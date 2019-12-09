using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Check
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }

        public Check(string name, double price, double amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }
    }
}
