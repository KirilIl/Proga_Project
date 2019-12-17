namespace WindowsFormsApp1.Forms
{
    partial class StorageEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewStorage = new System.Windows.Forms.ListView();
            this.AddProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddProductAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewStorage
            // 
            this.listViewStorage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AddProductName,
            this.AddProductPrice,
            this.AddProductAmount});
            this.listViewStorage.HideSelection = false;
            this.listViewStorage.Location = new System.Drawing.Point(12, 94);
            this.listViewStorage.Name = "listViewStorage";
            this.listViewStorage.Size = new System.Drawing.Size(509, 258);
            this.listViewStorage.TabIndex = 0;
            this.listViewStorage.UseCompatibleStateImageBehavior = false;
            this.listViewStorage.View = System.Windows.Forms.View.Details;
            // 
            // AddProductName
            // 
            this.AddProductName.Text = "Назва товару";
            this.AddProductName.Width = 195;
            // 
            // AddProductPrice
            // 
            this.AddProductPrice.Text = "Ціна ";
            this.AddProductPrice.Width = 163;
            // 
            // AddProductAmount
            // 
            this.AddProductAmount.Text = "Кількість";
            this.AddProductAmount.Width = 148;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(218, 12);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 3;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_button.Location = new System.Drawing.Point(218, 40);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(303, 48);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Додати товар";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(401, 12);
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAmount.TabIndex = 5;
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(12, 41);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(125, 24);
            this.comboBoxItemType.TabIndex = 6;
            // 
            // StorageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 373);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listViewStorage);
            this.Name = "StorageEditor";
            this.Text = "StorageEditor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStorage;
        private System.Windows.Forms.ColumnHeader AddProductName;
        private System.Windows.Forms.ColumnHeader AddProductPrice;
        private System.Windows.Forms.ColumnHeader AddProductAmount;
        private System.Windows.Forms.Button Add_button;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.NumericUpDown numericUpDownAmount;
        public System.Windows.Forms.ComboBox comboBoxItemType;
    }
}