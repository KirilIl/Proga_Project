using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Storage
    {
        static public List<Item> Products = new List<Item>();


        static public void AddAllItems()
        {
            Products.Add(new Grocery("Морква", 5, "Бакалия" ,20 ));
            Products.Add(new Grocery("Картопля", 15, "Бакалия", 40));
            Products.Add(new Grocery("Цибуля", 23, "Бакалия", 10));
            Products.Add(new Grocery("Помiдори", 35, "Бакалия", 100));
            Products.Add(new Grocery("Салат", 50, "Бакалия", 50));
            Products.Add(new Drinks("Молоко", 125, "Напитки", 90));
            Products.Add(new Drinks("Ряжанка", 20, "Напитки", 25));
            Products.Add(new Drinks("Йогурт", 50, "Напитки", 30));
        }
        
    }
}
