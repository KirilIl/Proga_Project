using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Events;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class UI : Form
    {
        Storage storage { get; set; }
        ManageStorage Manager = new ManageStorage();
     
        public void AlertMessage(object sender, StorageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        public UI()
        {
            InitializeComponent();
            storage = new Storage();
            //storage.AddAllItems();
            Manager.OutOfGoodNotify += AlertMessage;
            //foreach (var item in storage.Products)
            //{
            //    ProductName.Items.Add(item.Name);
            //}
            
            
        }
        public void AddItemToListView(ListViewItem item)
        {
            ItemType itemType = new ItemType();
            item.SubItems.Add(ProductAmount.Text);
            string name = comboBoxProductName.GetItemText(comboBoxProductName.SelectedItem);
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

        private void Add_Item_Button_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(comboBoxProductName.Text) || string.IsNullOrEmpty(ProductAmount.Text)))
            {
                ListViewItem item = new ListViewItem(comboBoxProductName.Text);
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

                try
                {
                    itemToDelete = ProductsListView.SelectedItems[0]; 
                    
                    Manager.PlusUserAmountToItemAmount(itemType, itemToDelete, storage);
                    ProductsListView.Items.Remove(ProductsListView.SelectedItems[0]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Ви не обрали товар!");
                }
            }
        }

        private void Cheque_Serialize_Button_Click(object sender, EventArgs e)
        {
            if (ProductsListView.Items.Count > 0)
            {
                List<CheckItem> Check = new List<CheckItem>();

                foreach (ListViewItem item in ProductsListView.Items)
                {
                    Check.Add(new CheckItem(item.SubItems[0].Text, double.Parse(item.SubItems[2].Text), double.Parse(item.SubItems[1].Text)));
                }
                Manager.SerializeChequeViaUserPath(Check);
            }
            else
            {
                MessageBox.Show("Кошик порожній!");
            }

        }

        private void OutPut_Cheque_Button_Click(object sender, EventArgs e)
        {
            if (ProductsListView.Items.Count > 0)
            {
                List<CheckItem> Check = new List<CheckItem>();

                foreach (ListViewItem item in ProductsListView.Items)
                {
                    Check.Add(new CheckItem(item.SubItems[0].Text, double.Parse(item.SubItems[2].Text), double.Parse(item.SubItems[1].Text)));
                }
                Manager.SaveChequeInFile(Check);
            }
            else
            {
                MessageBox.Show("Кошик порожній!");
            }
        }
        private void Clear_ListView_Button_Click(object sender, EventArgs e)
        {
            if (ProductsListView.Items.Count > 0)
            {
                ListViewItem itemToDelete = new ListViewItem();
                ItemType itemType = new ItemType(); 

                foreach (ListViewItem item in ProductsListView.Items)
                {
                    itemToDelete = item;
                    Manager.PlusUserAmountToItemAmount(itemType, itemToDelete, storage);
                }
                ProductsListView.Items.Clear();
            }
            else
            {
                MessageBox.Show("Кошик порожній!");
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            var storageEditor = new StorageEditor(storage);
            storageEditor.ShowDialog();

            storage = storageEditor.GetStorage();

            foreach (var item in storage.Products)
            {
                comboBoxProductName.Items.Add(item.Name);
            }
        }
    }
}