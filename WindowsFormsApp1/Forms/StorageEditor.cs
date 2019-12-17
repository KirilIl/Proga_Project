using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class StorageEditor : Form
    {
        Storage storage { get; set; }
        public StorageEditor(Storage storage)
        {
            InitializeComponent();
            this.storage = storage;
            comboBoxItemType.Items.Add("Grocery");
            comboBoxItemType.Items.Add("Drinks");
        }

        public Storage GetStorage()
        {
            return storage;
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            //string name = textBoxName.Text;
            //double price = double.Parse(textBoxPrice.Text);
            //int amount = int.Parse(numericUpDownAmount.Value.ToString());

            ListViewItem item = new ListViewItem(textBoxName.Text);
            item.SubItems.Add(textBoxPrice.Text);
            item.SubItems.Add(numericUpDownAmount.Value.ToString());
            try
            {
            if(comboBoxItemType.SelectedItem.ToString()=="Grocery")
            {
                ItemType itemType = ItemType.Grocery;
                storage.Products.Add(new Grocery(textBoxName.Text, double.Parse(textBoxPrice.Text), itemType ,double.Parse(numericUpDownAmount.Value.ToString())));
            }
            else
            {
                ItemType itemType = ItemType.Drink;
                storage.Products.Add(new Drinks(textBoxName.Text, double.Parse(textBoxPrice.Text), itemType, double.Parse(numericUpDownAmount.Value.ToString())));
            }

            listViewStorage.Items.Add(item);

            textBoxName.Clear();
            textBoxPrice.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ви не обрали категорію товару!");
            }
        }
    }
}
