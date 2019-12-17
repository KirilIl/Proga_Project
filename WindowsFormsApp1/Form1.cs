using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Storage storage { get; set; }
        public void PopulateListView(ListViewItem item) // populates listview
        {
            ItemType itemType = new ItemType();
            item.SubItems.Add(ProductAmount.Text);
            string selected = ProductName.GetItemText(ProductName.SelectedItem);
            double price = 0;
            foreach (var product in storage.Products)
            {
                if (product.Name == selected)
                {
                    price = product.Price;
                }
            }
            double amount = double.Parse(ProductAmount.Value.ToString());
            price *= Double.Parse(ProductAmount.Value.ToString());
            item.SubItems.Add(price.ToString());

            item.SubItems.Add(selected);

            double temp = 0;
            foreach (var product in storage.Products)
            {
                if (selected == product.Name)
                {
                    itemType = product.Type;
                }
            }

            if (itemType == ItemType.Grocery)
            {
                foreach (Grocery product in storage.Products.Where(prod => prod.Type == ItemType.Grocery))
                {
                    if (product.Name == selected)
                    {
                        temp = product.Weight;
                    }
                }
                if (amount > temp)
                {
                    throw new StorageException("Стільки товару немає на складі!");
                }

                // Storage.ProductsFromCheque.Add(new Grocery(selected, price, type, amount));
            }

            else if (itemType == ItemType.Drink)
            {
                foreach (Drinks product in storage.Products.Where(prod => prod.Type == ItemType.Drink))
                {
                    if (product.Name == selected)
                    {
                        temp = product.Volume;
                    }
                }
                if (amount > temp)
                {
                    throw new StorageException("Стільки товару немає на складі!");
                }
            }
            //   Storage.ProductsFromCheque.Add(new Drinks(selected, price, type, amount));

            listView1.Items.Add(item);
        }

        public Form1()
        {
            InitializeComponent();
            storage = new Storage();
            storage.AddAllItems();
            foreach (var item in storage.Products)
            {
                ProductName.Items.Add(item.Name);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(ProductName.Text) || string.IsNullOrEmpty(ProductAmount.Text)))
            {
                ListViewItem item = new ListViewItem(ProductName.Text);
                try
                {
                    PopulateListView(item);

                }
                catch (StorageException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                //var item=new 
                //Storage.ProductsFromCheque.Remove()
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            List<CheckItem> Check = new List<CheckItem>();
            double totalPrice = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                    Check.Add(new CheckItem(item.SubItems[0].Text, double.Parse(item.SubItems[2].Text), double.Parse(item.SubItems[1].Text)));   
                
            }

            DateTime dateTime = DateTime.Now;
            var culture = new CultureInfo("en-US");
            string curDate = dateTime.ToString();
            BinaryFormatter formatter = new BinaryFormatter();
            curDate = curDate.Replace(' ', ']');
            curDate = curDate.Replace(':', ',');
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            string path = "";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowser.SelectedPath + @"\[";
            }
            foreach (var item in Check)
            {
                totalPrice += item.Price;
            }
            using (FileStream sw = new FileStream(path + curDate + "Check.dat", FileMode.Create)) 
            {
                foreach (var item in Check)
                {
                    formatter.Serialize(sw, item);
                    formatter.Serialize(sw, $"Загальна сума: {totalPrice} грн.");
                    //sw.WriteLine(item);
                    //sw.WriteLine($"Загальна сума: {totalPrice} грн.");
                }
            }
        }

    }
}
