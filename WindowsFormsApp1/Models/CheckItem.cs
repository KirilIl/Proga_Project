using System;

namespace WindowsFormsApp1
{
    [Serializable]
    public class CheckItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }

        public CheckItem(string name, double price, double amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Назва товару: {Name} x{Amount}\nЦіна: {Price} грн.\n ";
        }
    }
}
