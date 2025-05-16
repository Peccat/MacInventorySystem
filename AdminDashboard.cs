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
using System.Runtime.Remoting.Contexts;

namespace MacInventoryManagement
{
    public partial class AdminDashboard : UserControl
    {
        public AdminDashboard()
        {
            InitializeComponent();

            
        }

        public void displayAllTodCustomer()
        {
            CustomersD customerD = new CustomersD();
            List<CustomersD> listData = customerD.allCustomersToday();

            dataGridView1.DataSource = listData;
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
        public void displayAllUsers()
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string selectDat = "SELECT COUNT(id) FROM users WHERE status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectDat, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Aktiv");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int count = Convert.ToInt32(reader[0]);
                                lbl_users.Text = count.ToString();
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

        public void displayAllCustomers()
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string selectDat = "SELECT COUNT(id) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectDat, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int count = Convert.ToInt32(reader[0]);
                                lbl_customers.Text = count.ToString();
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
    
        public void displayTodIncome()
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string selectDat = "SELECT SUM(total_price) FROM customers WHERE order_date = @date";

                    using (SqlCommand cmd = new SqlCommand(selectDat, connect))
                    {
                        DateTime tod = DateTime.Today;
                        string today = tod.ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@date",tod);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                object value = reader[0];
                                if (value != DBNull.Value)
                                {
                                    int count = Convert.ToInt32(reader[0]);
                                    lbl_DailyIncome.Text = count.ToString() + "Ft";
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

        public void displayTotalIncome()
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string selectDat = "SELECT SUM(total_price) FROM customers";

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
                                    lbl_monthlyIncome.Text = count.ToString() + "Ft";
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

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            displayAllUsers();
            displayAllTodCustomer();
            displayAllCustomers();
            displayTodIncome();
            displayTotalIncome();
        }
    }
}
