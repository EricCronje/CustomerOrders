namespace WindowsFormsSales
{
    partial class FrmOrders
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
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            this.LblProducts = new System.Windows.Forms.Label();
            this.CbProducts = new System.Windows.Forms.ComboBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.NudQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DgProductsSelected = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblSalesWithDiscountVAT = new System.Windows.Forms.Label();
            this.LblResultSalesWithDiscountVAT = new System.Windows.Forms.Label();
            this.LblSalesWithoutDiscountVAT = new System.Windows.Forms.Label();
            this.LblResultSalesWithoutDiscountVAT = new System.Windows.Forms.Label();
            this.LblDiscountPercentage = new System.Windows.Forms.Label();
            this.LblResultDiscountPercentage = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductsSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Location = new System.Drawing.Point(13, 13);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(86, 13);
            this.LblCustomerName.TabIndex = 0;
            this.LblCustomerName.Text = "Customer name :";
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Location = new System.Drawing.Point(102, 10);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.Size = new System.Drawing.Size(169, 20);
            this.TbCustomerName.TabIndex = 1;
            // 
            // LblProducts
            // 
            this.LblProducts.AutoSize = true;
            this.LblProducts.Location = new System.Drawing.Point(12, 48);
            this.LblProducts.Name = "LblProducts";
            this.LblProducts.Size = new System.Drawing.Size(58, 13);
            this.LblProducts.TabIndex = 2;
            this.LblProducts.Text = "Products : ";
            // 
            // CbProducts
            // 
            this.CbProducts.FormattingEnabled = true;
            this.CbProducts.Location = new System.Drawing.Point(102, 45);
            this.CbProducts.Name = "CbProducts";
            this.CbProducts.Size = new System.Drawing.Size(169, 21);
            this.CbProducts.TabIndex = 3;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(13, 87);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(55, 13);
            this.LblQuantity.TabIndex = 4;
            this.LblQuantity.Text = "Quantity : ";
            // 
            // NudQuantity
            // 
            this.NudQuantity.Location = new System.Drawing.Point(102, 79);
            this.NudQuantity.Name = "NudQuantity";
            this.NudQuantity.Size = new System.Drawing.Size(169, 20);
            this.NudQuantity.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(15, 116);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DgProductsSelected
            // 
            this.DgProductsSelected.AllowUserToAddRows = false;
            this.DgProductsSelected.AllowUserToDeleteRows = false;
            this.DgProductsSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductsSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.Cost,
            this.SubTotalCost});
            this.DgProductsSelected.Location = new System.Drawing.Point(16, 159);
            this.DgProductsSelected.Name = "DgProductsSelected";
            this.DgProductsSelected.ReadOnly = true;
            this.DgProductsSelected.Size = new System.Drawing.Size(513, 129);
            this.DgProductsSelected.TabIndex = 7;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // SubTotalCost
            // 
            this.SubTotalCost.HeaderText = "SubTotalCost";
            this.SubTotalCost.Name = "SubTotalCost";
            this.SubTotalCost.ReadOnly = true;
            // 
            // LblSalesWithDiscountVAT
            // 
            this.LblSalesWithDiscountVAT.AutoSize = true;
            this.LblSalesWithDiscountVAT.Location = new System.Drawing.Point(16, 295);
            this.LblSalesWithDiscountVAT.Name = "LblSalesWithDiscountVAT";
            this.LblSalesWithDiscountVAT.Size = new System.Drawing.Size(127, 13);
            this.LblSalesWithDiscountVAT.TabIndex = 8;
            this.LblSalesWithDiscountVAT.Text = "Sales With Discount VAT";
            // 
            // LblResultSalesWithDiscountVAT
            // 
            this.LblResultSalesWithDiscountVAT.AutoSize = true;
            this.LblResultSalesWithDiscountVAT.Location = new System.Drawing.Point(177, 295);
            this.LblResultSalesWithDiscountVAT.Name = "LblResultSalesWithDiscountVAT";
            this.LblResultSalesWithDiscountVAT.Size = new System.Drawing.Size(16, 13);
            this.LblResultSalesWithDiscountVAT.TabIndex = 9;
            this.LblResultSalesWithDiscountVAT.Text = "...";
            // 
            // LblSalesWithoutDiscountVAT
            // 
            this.LblSalesWithoutDiscountVAT.AutoSize = true;
            this.LblSalesWithoutDiscountVAT.Location = new System.Drawing.Point(16, 319);
            this.LblSalesWithoutDiscountVAT.Name = "LblSalesWithoutDiscountVAT";
            this.LblSalesWithoutDiscountVAT.Size = new System.Drawing.Size(142, 13);
            this.LblSalesWithoutDiscountVAT.TabIndex = 10;
            this.LblSalesWithoutDiscountVAT.Text = "Sales Without Discount VAT";
            // 
            // LblResultSalesWithoutDiscountVAT
            // 
            this.LblResultSalesWithoutDiscountVAT.AutoSize = true;
            this.LblResultSalesWithoutDiscountVAT.Location = new System.Drawing.Point(177, 319);
            this.LblResultSalesWithoutDiscountVAT.Name = "LblResultSalesWithoutDiscountVAT";
            this.LblResultSalesWithoutDiscountVAT.Size = new System.Drawing.Size(16, 13);
            this.LblResultSalesWithoutDiscountVAT.TabIndex = 11;
            this.LblResultSalesWithoutDiscountVAT.Text = "...";
            // 
            // LblDiscountPercentage
            // 
            this.LblDiscountPercentage.AutoSize = true;
            this.LblDiscountPercentage.Location = new System.Drawing.Point(324, 295);
            this.LblDiscountPercentage.Name = "LblDiscountPercentage";
            this.LblDiscountPercentage.Size = new System.Drawing.Size(63, 13);
            this.LblDiscountPercentage.TabIndex = 12;
            this.LblDiscountPercentage.Text = "Discount %:";
            // 
            // LblResultDiscountPercentage
            // 
            this.LblResultDiscountPercentage.AutoSize = true;
            this.LblResultDiscountPercentage.Location = new System.Drawing.Point(405, 295);
            this.LblResultDiscountPercentage.Name = "LblResultDiscountPercentage";
            this.LblResultDiscountPercentage.Size = new System.Drawing.Size(16, 13);
            this.LblResultDiscountPercentage.TabIndex = 13;
            this.LblResultDiscountPercentage.Text = "...";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(16, 355);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblResultDiscountPercentage);
            this.Controls.Add(this.LblDiscountPercentage);
            this.Controls.Add(this.LblResultSalesWithoutDiscountVAT);
            this.Controls.Add(this.LblSalesWithoutDiscountVAT);
            this.Controls.Add(this.LblResultSalesWithDiscountVAT);
            this.Controls.Add(this.LblSalesWithDiscountVAT);
            this.Controls.Add(this.DgProductsSelected);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.NudQuantity);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.CbProducts);
            this.Controls.Add(this.LblProducts);
            this.Controls.Add(this.TbCustomerName);
            this.Controls.Add(this.LblCustomerName);
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductsSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.Label LblProducts;
        private System.Windows.Forms.ComboBox CbProducts;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.NumericUpDown NudQuantity;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DgProductsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalCost;
        private System.Windows.Forms.Label LblSalesWithDiscountVAT;
        private System.Windows.Forms.Label LblResultSalesWithDiscountVAT;
        private System.Windows.Forms.Label LblSalesWithoutDiscountVAT;
        private System.Windows.Forms.Label LblResultSalesWithoutDiscountVAT;
        private System.Windows.Forms.Label LblDiscountPercentage;
        private System.Windows.Forms.Label LblResultDiscountPercentage;
        private System.Windows.Forms.Button BtnClose;
    }
}