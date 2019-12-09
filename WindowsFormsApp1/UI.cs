using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class UI : Form
    {
        Storage storage { get; set; }
        ManageStorage Manager = new ManageStorage();
        public void AddItemToListView(ListViewItem item)
        {
            ItemType itemType = new ItemType();
            item.SubItems.Add(ProductAmount.Text);
            string name = ProductName.GetItemText(ProductName.SelectedItem);
            double price = 0;
            foreach (var product in storage.Products)
            {
                if (product.Name == name)
                {
                    price = product.Price;
                }
            }
            double amount = double.Parse(ProductAmount.Value.ToString());
            price *= double.Parse(ProductAmount.Value.ToString());
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(name);

            double amountOfUserProduct = 0;
            foreach (var product in storage.Products)
            {
                if (name == product.Name)
                {
                    itemType = product.Type;
                }
            }
            Manager.CheckStorageHasGoods(itemType, name, amount, amountOfUserProduct, storage);
            ProductsListView.Items.Add(item);
            Manager.MinusUserAmountFromItemAmout(itemType, name, amount, storage);
        }

        public UI()
        {
            InitializeComponent();
            storage = new Storage();
            storage.AddAllItems();
            foreach (var item in storage.Products)
            {
                ProductName.Items.Add(item.Name);
            }
        }

        private void Add_Item_Button_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(ProductName.Text) || string.IsNullOrEmpty(ProductAmount.Text)))
            {
                ListViewItem item = new ListViewItem(ProductName.Text);
                try
                {
                    AddItemToListView(item);

                }
                catch (StorageException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Remove_Item_Button_Click(object sender, EventArgs e)
        {
            if (ProductsListView.Items.Count > 0)
            {
                ItemType itemType = new ItemType();
                ListViewItem itemToDelete = new ListViewItem();
                itemToDelete = ProductsListView.SelectedItems[0]; // TODO: add exception if item is not selected
                Manager.PlusUserAmountToItemAmount(itemType, itemToDelete, storage);
                ProductsListView.Items.Remove(ProductsListView.SelectedItems[0]);
            }
        }

        private void Cheque_Button_Click(object sender, EventArgs e)
        {
            List<CheckItem> Check = new List<CheckItem>();

            foreach (ListViewItem item in ProductsListView.Items)
            {
                Check.Add(new CheckItem(item.SubItems[0].Text, double.Parse(item.SubItems[2].Text), double.Parse(item.SubItems[1].Text)));
            }
            Manager.SerializeChequeViaUserPath(Check);
        }

        private void OutPut_Cheque_Button_Click(object sender, EventArgs e)
        {
            List<CheckItem> Check = new List<CheckItem>();

            foreach (ListViewItem item in ProductsListView.Items)
            {
                Check.Add(new CheckItem(item.SubItems[0].Text, double.Parse(item.SubItems[2].Text), double.Parse(item.SubItems[1].Text)));
            }
            Manager.SaveChequeInFile(Check);
        }
        private void Clear_ListView_Button_Click(object sender, EventArgs e)
        {
            ProductsListView.Items.Clear();
        }
    }
}
