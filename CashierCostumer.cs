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
    public partial class CashierCostumer : UserControl
    {
        public CashierCostumer()
        {
            InitializeComponent();
            displayCustomer();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            
        }

        public void displayCustomer()
        {
            CustomersD cData = new CustomersD();

            List<CustomersD> listData = cData.allCustomersData();

            dataGridView1.DataSource = listData;
        }
    }
}
