using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MacInventoryManagement
{
    public partial class CashierMainF : Form
    {
        public CashierMainF()
        {
            InitializeComponent();
            adminDashboard1.Visible = true;
            adminAddProduct2.Visible = false;
            cashierOrder2.Visible = false;
            cashierCostumer1.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Hide();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProduct2.Visible = false;
            cashierOrder2.Visible = true;
            cashierCostumer1.Visible = false;
        }

        private void btn_product_Click(object sender, EventArgs e)
        {

            adminDashboard1.Visible = false;
            adminAddProduct2.Visible = true;
            cashierOrder2.Visible = false;
            cashierCostumer1.Visible = false;

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProduct2.Visible = false;
            cashierOrder2.Visible = false;
            cashierCostumer1.Visible = false;
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProduct2.Visible = false;
            cashierOrder2.Visible = false;
            cashierCostumer1.Visible = true;
        }
    }
}
