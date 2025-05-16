using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MacInventoryManagement
{
    internal class CustomersD
    {
        SqlConnection connect = DatabaseString.GetConnection();

        public int customer_id { set; get; }
        public string total_price { set; get; }
        public string amount { set; get; }
        public string change { set; get; }

        public List<CustomersD> allCustomersData()
        {
            List<CustomersD> listData = new List<CustomersD>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomersD cData = new CustomersD();

                            cData.customer_id = (int)reader["customer_id"];
                            cData.total_price = reader["total_price"].ToString();
                            cData.amount = reader["amount"].ToString();
                            cData.change = reader["change"].ToString();
                            listData.Add(cData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CustomerD.cs A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;

        }
        public List<CustomersD> allCustomersToday()
        {
            List<CustomersD> listData = new List<CustomersD>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    DateTime today = DateTime.Today;
                    string selectData = "SELECT * FROM customers WHERE order_date = @date";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@date", today);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomersD cData = new CustomersD();

                            cData.customer_id = (int)reader["customer_id"];
                            cData.total_price = reader["total_price"].ToString();
                            cData.amount = reader["amount"].ToString();
                            cData.change = reader["change"].ToString();
                            listData.Add(cData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CustomerD.cs A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;

        }

    }
}
