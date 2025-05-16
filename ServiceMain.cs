using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacInventoryManagement
{
    public partial class ServiceMain : Form
    {
        public ServiceMain()
        {
            InitializeComponent();
            serviceMac1.Visible = false;
            adminDashboard1.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//X
        {
            Application.Exit();
        }

        private void lbl_dashboard_Click(object sender, EventArgs e)
        {
            serviceMac1.Visible = false;
            adminDashboard1.Visible = true;
        }

        private void btn_macs_Click(object sender, EventArgs e)
        {
            serviceMac1.Visible = true;
            adminDashboard1.Visible = false;
        }
    }
}
