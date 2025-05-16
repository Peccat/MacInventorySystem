using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MacInventoryManagement
{
    internal class Orders
    {

        public int ID { set; get; }
        public string prod_id { set; get; }
        public string prod_name { set; get; }
        public string category { set; get; }
        public int quantity { set; get; }
        public int price { set; get; }
        public int customer_id { set; get; }
        public int total_price { set; get; }
        public int cost { set; get; }

        

        SqlConnection connect = DatabaseString.GetConnection();

        public List<Orders> allOrders()
        {
            List<Orders> listData = new List<Orders>();

            if(connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    int custID = 0;
                    string selectDat = "SELECT MAX(customer_id) FROM orders ";

                    using (SqlCommand cmd = new SqlCommand(selectDat, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {

                                custID = 0;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error ID!", "Error Message", MessageBoxButtons.OK);
                        }
                    }

                    string selectedData = "SELECT * FROM orders WHERE customer_id = @customer_id";

                    using (SqlCommand cmd2 = new SqlCommand(selectedData, connect))
                    {
                        cmd2.Parameters.AddWithValue("customer_id",custID);
                        SqlDataReader reader = cmd2.ExecuteReader();

                        while (reader.Read())
                        {
                            Orders data = new Orders();
                            data.ID = (int)reader["id"];
                            data.prod_id = (string)reader["prod_id"];
                            data.prod_name = (string)reader["prod_name"];
                            data.category = (string)reader["category"];
                            data.quantity = (int)reader["quantity"];
                            data.price = (int)reader["price"];
                            data.customer_id = (int)reader["customer_id"];
                            data.total_price = (int)reader["total_price"];

                            listData.Add(data);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Orders.csA kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
