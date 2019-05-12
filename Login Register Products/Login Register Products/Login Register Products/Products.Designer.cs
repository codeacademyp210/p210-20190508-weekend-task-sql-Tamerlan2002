namespace Login_Register_Products
{
    partial class Products
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BrandBox = new System.Windows.Forms.ComboBox();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.AdBox = new System.Windows.Forms.TextBox();
            this.StockBox = new System.Windows.Forms.TextBox();
            this.BarcodeBox = new System.Windows.Forms.TextBox();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BrandBox);
            this.panel1.Controls.Add(this.CategoryBox);
            this.panel1.Controls.Add(this.AdBox);
            this.panel1.Controls.Add(this.StockBox);
            this.panel1.Controls.Add(this.BarcodeBox);
            this.panel1.Controls.Add(this.ColorBox);
            this.panel1.Controls.Add(this.PriceBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 426);
            this.panel1.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(56, 348);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // BrandBox
            // 
            this.BrandBox.FormattingEnabled = true;
            this.BrandBox.Items.AddRange(new object[] {
            "Samsung",
            "Apple",
            "Phillips",
            "LG",
            "Asus",
            "Lenovo",
            "Sony",
            "Daewo"});
            this.BrandBox.Location = new System.Drawing.Point(79, 144);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(95, 21);
            this.BrandBox.TabIndex = 3;
            this.BrandBox.Validating += new System.ComponentModel.CancelEventHandler(this.BrandBox_Validating);
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "Technology",
            "Toys and dolls",
            "Clothes",
            "Jewellry",
            "Tools and home improvement"});
            this.CategoryBox.Location = new System.Drawing.Point(79, 106);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(95, 21);
            this.CategoryBox.TabIndex = 2;
            this.CategoryBox.Validating += new System.ComponentModel.CancelEventHandler(this.CategoryBox_Validating);
            // 
            // AdBox
            // 
            this.AdBox.Location = new System.Drawing.Point(79, 302);
            this.AdBox.Name = "AdBox";
            this.AdBox.Size = new System.Drawing.Size(95, 20);
            this.AdBox.TabIndex = 7;
            this.AdBox.Validating += new System.ComponentModel.CancelEventHandler(this.AdBox_Validating);
            // 
            // StockBox
            // 
            this.StockBox.Location = new System.Drawing.Point(79, 260);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(95, 20);
            this.StockBox.TabIndex = 6;
            this.StockBox.Validating += new System.ComponentModel.CancelEventHandler(this.StockBox_Validating);
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Location = new System.Drawing.Point(79, 220);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(95, 20);
            this.BarcodeBox.TabIndex = 5;
            this.BarcodeBox.Validating += new System.ComponentModel.CancelEventHandler(this.BarcodeBox_Validating);
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(79, 182);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(95, 20);
            this.ColorBox.TabIndex = 4;
            this.ColorBox.Validating += new System.ComponentModel.CancelEventHandler(this.ColorBox_Validating);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(79, 67);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(95, 20);
            this.PriceBox.TabIndex = 1;
            this.PriceBox.Validating += new System.ComponentModel.CancelEventHandler(this.PriceBox_Validating);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(79, 31);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(95, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox_Validating);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrName,
            this.PrPrice,
            this.prCategory,
            this.PrBrand,
            this.PrColor,
            this.PrBarcode,
            this.PrStock,
            this.PrAd});
            this.dataGridView1.Location = new System.Drawing.Point(219, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 425);
            this.dataGridView1.TabIndex = 1;
            // 
            // PrName
            // 
            this.PrName.HeaderText = "Name";
            this.PrName.Name = "PrName";
            this.PrName.ReadOnly = true;
            // 
            // PrPrice
            // 
            this.PrPrice.HeaderText = "Price";
            this.PrPrice.Name = "PrPrice";
            this.PrPrice.ReadOnly = true;
            // 
            // prCategory
            // 
            this.prCategory.HeaderText = "Category";
            this.prCategory.Name = "prCategory";
            this.prCategory.ReadOnly = true;
            // 
            // PrBrand
            // 
            this.PrBrand.HeaderText = "Brand";
            this.PrBrand.Name = "PrBrand";
            this.PrBrand.ReadOnly = true;
            // 
            // PrColor
            // 
            this.PrColor.HeaderText = "Color";
            this.PrColor.Name = "PrColor";
            this.PrColor.ReadOnly = true;
            // 
            // PrBarcode
            // 
            this.PrBarcode.HeaderText = "Barcode";
            this.PrBarcode.Name = "PrBarcode";
            this.PrBarcode.ReadOnly = true;
            // 
            // PrStock
            // 
            this.PrStock.HeaderText = "Stock";
            this.PrStock.Name = "PrStock";
            // 
            // PrAd
            // 
            this.PrAd.HeaderText = "Ad";
            this.PrAd.Name = "PrAd";
            this.PrAd.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Products";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BrandBox;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.TextBox AdBox;
        private System.Windows.Forms.TextBox StockBox;
        private System.Windows.Forms.TextBox BarcodeBox;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn prCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrAd;
        private System.Windows.Forms.Button Save;
    }
}