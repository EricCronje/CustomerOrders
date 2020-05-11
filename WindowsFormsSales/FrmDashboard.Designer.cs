namespace WindowsFormsSales
{
    partial class FrmDashboard
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
            this.DgOrders = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesWithDiscountVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesWithoutDiscountVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCreateOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // DgOrders
            // 
            this.DgOrders.AllowUserToAddRows = false;
            this.DgOrders.AllowUserToDeleteRows = false;
            this.DgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustomerName,
            this.SalesWithDiscountVat,
            this.SalesWithoutDiscountVat,
            this.DiscountPercentage});
            this.DgOrders.Location = new System.Drawing.Point(12, 12);
            this.DgOrders.Name = "DgOrders";
            this.DgOrders.ReadOnly = true;
            this.DgOrders.Size = new System.Drawing.Size(682, 219);
            this.DgOrders.TabIndex = 0;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // SalesWithDiscountVat
            // 
            this.SalesWithDiscountVat.HeaderText = "Sales With Discount Vat";
            this.SalesWithDiscountVat.Name = "SalesWithDiscountVat";
            this.SalesWithDiscountVat.ReadOnly = true;
            // 
            // SalesWithoutDiscountVat
            // 
            this.SalesWithoutDiscountVat.HeaderText = "Sales Without Discount Vat";
            this.SalesWithoutDiscountVat.Name = "SalesWithoutDiscountVat";
            this.SalesWithoutDiscountVat.ReadOnly = true;
            // 
            // DiscountPercentage
            // 
            this.DiscountPercentage.HeaderText = "Discount Percentage";
            this.DiscountPercentage.Name = "DiscountPercentage";
            this.DiscountPercentage.ReadOnly = true;
            // 
            // BtnCreateOrders
            // 
            this.BtnCreateOrders.Location = new System.Drawing.Point(13, 253);
            this.BtnCreateOrders.Name = "BtnCreateOrders";
            this.BtnCreateOrders.Size = new System.Drawing.Size(137, 23);
            this.BtnCreateOrders.TabIndex = 1;
            this.BtnCreateOrders.Text = "Create orders";
            this.BtnCreateOrders.UseVisualStyleBackColor = true;
            this.BtnCreateOrders.Click += new System.EventHandler(this.BtnCreateOrders_Click);
            // 
            // FrmDashboard
            // 
            this.AcceptButton = this.BtnCreateOrders;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCreateOrders);
            this.Controls.Add(this.DgOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesWithDiscountVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesWithoutDiscountVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercentage;
        private System.Windows.Forms.Button BtnCreateOrders;
    }
}