namespace WindowsFormsApp1
{
    partial class UI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductAmount = new System.Windows.Forms.NumericUpDown();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.ProductsListView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.Add_Item_Button = new System.Windows.Forms.Button();
            this.Remove_Item_Button = new System.Windows.Forms.Button();
            this.Cheque_Serialize_Button = new System.Windows.Forms.Button();
            this.OutPut_Cheque_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear_ListView_Button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductAmount
            // 
            this.ProductAmount.Location = new System.Drawing.Point(212, 98);
            this.ProductAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.Size = new System.Drawing.Size(133, 22);
            this.ProductAmount.TabIndex = 0;
            // 
            // labelProduct
            // 
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct.Location = new System.Drawing.Point(41, 43);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(136, 53);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "Продукт:";
            // 
            // labelAmount
            // 
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(207, 43);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(156, 53);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Кількість:";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(45, 97);
            this.comboBoxProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProductName.TabIndex = 6;
            // 
            // ProductsListView
            // 
            this.ProductsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnAmount,
            this.columnPrice});
            this.ProductsListView.HideSelection = false;
            this.ProductsListView.Location = new System.Drawing.Point(45, 183);
            this.ProductsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductsListView.Name = "ProductsListView";
            this.ProductsListView.Size = new System.Drawing.Size(708, 224);
            this.ProductsListView.TabIndex = 7;
            this.ProductsListView.UseCompatibleStateImageBehavior = false;
            this.ProductsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Назва товару";
            this.columnName.Width = 267;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Кількість";
            this.columnAmount.Width = 137;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Ціна";
            this.columnPrice.Width = 181;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(537, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 53);
            this.label3.TabIndex = 8;
            // 
            // Add_Item_Button
            // 
            this.Add_Item_Button.Location = new System.Drawing.Point(411, 53);
            this.Add_Item_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Item_Button.Name = "Add_Item_Button";
            this.Add_Item_Button.Size = new System.Drawing.Size(136, 25);
            this.Add_Item_Button.TabIndex = 9;
            this.Add_Item_Button.Text = "Додати товар";
            this.Add_Item_Button.UseVisualStyleBackColor = true;
            this.Add_Item_Button.Click += new System.EventHandler(this.Add_Item_Button_Click);
            // 
            // Remove_Item_Button
            // 
            this.Remove_Item_Button.Location = new System.Drawing.Point(411, 97);
            this.Remove_Item_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Remove_Item_Button.Name = "Remove_Item_Button";
            this.Remove_Item_Button.Size = new System.Drawing.Size(136, 25);
            this.Remove_Item_Button.TabIndex = 10;
            this.Remove_Item_Button.Text = "Видалити товар";
            this.Remove_Item_Button.UseVisualStyleBackColor = true;
            this.Remove_Item_Button.Click += new System.EventHandler(this.Remove_Item_Button_Click);
            // 
            // Cheque_Serialize_Button
            // 
            this.Cheque_Serialize_Button.Location = new System.Drawing.Point(47, 415);
            this.Cheque_Serialize_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cheque_Serialize_Button.Name = "Cheque_Serialize_Button";
            this.Cheque_Serialize_Button.Size = new System.Drawing.Size(155, 31);
            this.Cheque_Serialize_Button.TabIndex = 11;
            this.Cheque_Serialize_Button.Text = "Сереалізувати чек";
            this.Cheque_Serialize_Button.UseVisualStyleBackColor = true;
            this.Cheque_Serialize_Button.Click += new System.EventHandler(this.Cheque_Serialize_Button_Click);
            // 
            // OutPut_Cheque_Button
            // 
            this.OutPut_Cheque_Button.Location = new System.Drawing.Point(597, 414);
            this.OutPut_Cheque_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutPut_Cheque_Button.Name = "OutPut_Cheque_Button";
            this.OutPut_Cheque_Button.Size = new System.Drawing.Size(157, 32);
            this.OutPut_Cheque_Button.TabIndex = 12;
            this.OutPut_Cheque_Button.Text = "Зберегти чек";
            this.OutPut_Cheque_Button.UseVisualStyleBackColor = true;
            this.OutPut_Cheque_Button.Click += new System.EventHandler(this.OutPut_Cheque_Button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(331, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Корзина";
            // 
            // Clear_ListView_Button
            // 
            this.Clear_ListView_Button.Location = new System.Drawing.Point(331, 415);
            this.Clear_ListView_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Clear_ListView_Button.Name = "Clear_ListView_Button";
            this.Clear_ListView_Button.Size = new System.Drawing.Size(144, 31);
            this.Clear_ListView_Button.TabIndex = 14;
            this.Clear_ListView_Button.Text = "Очистити кошик";
            this.Clear_ListView_Button.UseVisualStyleBackColor = true;
            this.Clear_ListView_Button.Click += new System.EventHandler(this.Clear_ListView_Button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(617, 64);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(136, 32);
            this.Edit_button.TabIndex = 15;
            this.Edit_button.Text = "Редагувати склад";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Clear_ListView_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutPut_Cheque_Button);
            this.Controls.Add(this.Cheque_Serialize_Button);
            this.Controls.Add(this.Remove_Item_Button);
            this.Controls.Add(this.Add_Item_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductsListView);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.ProductAmount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UI";
            this.Text = "Касірша";
            ((System.ComponentModel.ISupportInitialize)(this.ProductAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Button Add_Item_Button;
        private System.Windows.Forms.Button Remove_Item_Button;
        private System.Windows.Forms.Button Cheque_Serialize_Button;
        public System.Windows.Forms.NumericUpDown ProductAmount;
        public System.Windows.Forms.ComboBox comboBoxProductName;
        public System.Windows.Forms.ListView ProductsListView;
        private System.Windows.Forms.Button OutPut_Cheque_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear_ListView_Button;
        private System.Windows.Forms.Button Edit_button;
    }
}

