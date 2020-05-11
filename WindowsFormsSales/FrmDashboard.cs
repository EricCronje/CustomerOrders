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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                using (SalesUtility.SalesUtility salesUtility = new SalesUtility.SalesUtility())
                {
                    List<Order> orders = salesUtility.GetOrders();
                    try
                    {
                        foreach (Order order in orders)
                        {
                            DgOrders.Rows.Add(order.Id, order.CustomerName, order.SalesWithDiscountVAT, order.SalesWithoutDiscountVAT, order.SalesDiscountPercentage);
                        }
                    }
                    catch (Exception Ex)
                    {
                        throw Ex;
                    }
                    finally
                    {
                        orders = null;
                    }

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error on grid - " + Ex.Message);
            }
        }

        private void BtnCreateOrders_Click(object sender, EventArgs e)
        {
            
            FrmOrders frmOrders = new FrmOrders();
            frmOrders.Show();
            this.Close();
        }
    }
}
