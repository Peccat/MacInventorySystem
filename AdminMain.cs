using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MacInventoryManagement
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
            adminDashboard1.Visible = true;
            adminAddProduct1.Visible = false;
            adminAddUsersUC1.Visible = false;
            adminAddCategories1.Visible = false;
            cashierCostumer1.Visible = false;
            displayStockValue();
        }
        SqlConnection connect = DatabaseString.GetConnection();

        public bool checkConnect()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        private void displayStockValue()
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();
                    string selectDat = "SELECT SUM(stock * cost) FROM products";

                    using (SqlCommand cmd = new SqlCommand(selectDat, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                object value = reader[0];
                                if (value != DBNull.Value)
                                {
                                    int count = Convert.ToInt32(reader[0]);
                                    lbl_stock.Text = count.ToString() + "Ft";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("AdminDashboard.cs A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }

            }
        }
        private void lbl_monthly_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//X
        {
            
                Application.Exit();
            
        }

        

        private void btn_logput_Click(object sender, EventArgs e)
        {
            
            Form1 loginF = new Form1();
            loginF.Show();

            this.Hide();
            
        }

        

        private void addCat_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProduct1.Visible = false;
            adminAddUsersUC1.Visible = false;
            adminAddCategories1.Visible = true;
            cashierCostumer1.Visible = false;
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProduct1.Visible = false;
            adminAddUsersUC1.Visible = false;
            adminAddCategories1.Visible = false;
            cashierCostumer1.Visible = true;
        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProduct1.Visible = false;
            adminAddUsersUC1.Visible = false;
            adminAddCategories1.Visible = false;
            cashierCostumer1.Visible = false;
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProduct1.Visible = false;
            adminAddUsersUC1.Visible = true;
            adminAddCategories1.Visible = false;
            cashierCostumer1.Visible = false;
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProduct1.Visible = true;
            adminAddUsersUC1.Visible = false;
            adminAddCategories1.Visible = false;
            cashierCostumer1.Visible = false;
        }
    }
}
