using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Models
{
    class ManageStorage
    {
        public void MinusUserAmountFromItemAmout(ItemType itemType, string name, double amount, Storage storage)
        {
            if (itemType == ItemType.Grocery)
            {
                foreach (Grocery storageProduct in storage.Products.Where(prod => prod.Type == ItemType.Grocery))
                {
                    if (storageProduct.Name == name)
                    {
                        storageProduct.Weight -= amount;
                    }
                }
            }
            else if (itemType == ItemType.Drink)
            {
                foreach (Drinks storageProduct in storage.Products.Where(prod => prod.Type == ItemType.Drink))
                {
                    if (storageProduct.Name == name)
                    {
                        storageProduct.Volume -= amount;
                    }
                }
            }
        }
        public void CheckStorageHasGoods(ItemType itemType, string name, double amount, double amountOfUserProduct, Storage storage)
        {
            if (itemType == ItemType.Grocery)
            {
                foreach (Grocery product in storage.Products.Where(prod => prod.Type == ItemType.Grocery))
                {
                    if (product.Name == name)
                    {
                        amountOfUserProduct = product.Weight;
                    }
                }
                if (amount > amountOfUserProduct)
                {
                    throw new StorageException("Такої кількості товару немає на складі!");
                }
            }
            else if (itemType == ItemType.Drink)
            {
                foreach (Drinks product in storage.Products.Where(prod => prod.Type == ItemType.Drink))
                {
                    if (product.Name == name)
                    {
                        amountOfUserProduct = product.Volume;
                    }
                }
                if (amount > amountOfUserProduct)
                {
                    throw new StorageException("Такої кількості немає на складі!");
                }
            }
        }
        public void PlusUserAmountToItemAmount(ItemType itemType, ListViewItem itemToDelete, Storage storage)
        {
            if (itemType == ItemType.Grocery)
            {
                foreach (Grocery storageProduct in storage.Products.Where(prod => prod.Type == ItemType.Grocery))
                {
                    if (storageProduct.Name == itemToDelete.SubItems[0].Text)
                    {
                        storageProduct.Weight += double.Parse(itemToDelete.SubItems[1].Text);
                    }
                }
            }
            else if (itemType == ItemType.Drink)
            {
                foreach (Drinks storageProduct in storage.Products.Where(prod => prod.Type == ItemType.Drink))
                {
                    if (storageProduct.Name == itemToDelete.SubItems[0].Text)
                    {
                        storageProduct.Volume += double.Parse(itemToDelete.SubItems[1].Text);
                    }
                }
            }
        }
        public void SerializeChequeViaUserPath(List<CheckItem> Check)
        {
            double totalPrice = 0;
            DateTime dateTime = DateTime.Now;
            var cultureInfo = new CultureInfo("en-US");

            string currentDate = "[" + dateTime.ToString();
            currentDate = currentDate.Replace(' ', ';');
            currentDate = currentDate.Replace(':', ';');
            currentDate = currentDate.Replace('/', ';');

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            string path = "";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowser.SelectedPath + @"\";
            }
            foreach (var item in Check)
            {
                totalPrice += item.Price;
            }
            path += currentDate + "]Check.dat";

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream sw = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(sw, "Чек покупок у магазині");
                foreach (var item in Check)
                {
                    formatter.Serialize(sw, item);
                }
                formatter.Serialize(sw, $"Загальна сума: {totalPrice} грн.");
            }
        }
        public void SaveChequeInFile(List<CheckItem> Check)
        {
            double totalPrice = 0;
            DateTime dateTime = DateTime.Now;
            var cultureInfo = new CultureInfo("en-US");

            string currentDate = "[" + dateTime.ToString();
            currentDate = currentDate.Replace(' ', ';');
            currentDate = currentDate.Replace(':', ';');
            currentDate = currentDate.Replace('/', ';');

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            string path = "";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowser.SelectedPath + @"\";
            }
            foreach (var item in Check)
            {
                totalPrice += item.Price;
            }
            path += currentDate + "]Check.txt";

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Чек покупок у магазині");
                foreach (var item in Check)
                {
                    sw.WriteLine(item);
                }
                sw.WriteLine($"Загальна сума: {totalPrice} грн.\n Дата та час: {dateTime}");
            }
        }
    }
}
