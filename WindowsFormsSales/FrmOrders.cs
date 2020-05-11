using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSales
{
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }
        SalesUtility.SalesUtility salesUtility;
        private void FrmOrders_Load(object sender, EventArgs e)
        {
            FillProductsComboBox();
            salesUtility = new SalesUtility.SalesUtility();
        }

        private void FillProductsComboBox()
        {
            try
            {
                using( SalesUtility.SalesUtility salesUtility = new SalesUtility.SalesUtility())
                {
                    try
                    {
                        List<Product> products = salesUtility.GetProducts();
                        var productDictionary = products.ToDictionary(x => x.ProductName, y => y.ProductCost);
                        CbProducts.DataSource = new BindingSource(productDictionary, null);
                        CbProducts.DisplayMember = "Key";
                        CbProducts.ValueMember = "Value";
                    }
                    catch (Exception Ex)
                    {
                        throw Ex;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error on loading products - " + Ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            decimal value = ((KeyValuePair<string, Decimal>)CbProducts.SelectedItem).Value;
            decimal subTotal = value * NudQuantity.Value;
            int quantity = Convert.ToInt32(NudQuantity.Value);
            
            DgProductsSelected.Rows.Add(CbProducts.Text, quantity, value, subTotal);
            
            salesUtility.AddToTotalSales(subTotal, quantity);
            LblResultDiscountPercentage.Text = salesUtility.GetDiscount().ToString();
            LblResultSalesWithDiscountVAT.Text =  salesUtility.GetSalesTotalWithDiscountVAT().ToString();
            LblResultSalesWithoutDiscountVAT.Text = salesUtility.GetSalesTotalWitoutDiscountVAT().ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            FrmLogin.mainForm.Close();
        }
    }
}
