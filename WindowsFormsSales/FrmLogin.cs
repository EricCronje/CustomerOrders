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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            mainForm = this;
        }

        public static FrmLogin mainForm;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using(SalesUtility.SalesUtility salesUtility = new SalesUtility.SalesUtility()) 
                {
                    if(salesUtility.AuthorizeUser(TbUser.Text, TbPassword.Text)) 
                    {
                        MessageBox.Show("Successfull login");
                        FrmDashboard frmDashboard = new FrmDashboard();
                        frmDashboard.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Failed login");
                    }
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error in login - " + Ex.Message);
            }
        }
    }
}
