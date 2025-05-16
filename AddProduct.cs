using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace MacInventoryManagement
{
    internal class AddProduct
    {
        public int ID { set; get; }

        public string prodName { set; get; }
        public string prodID { set; get; }
        public string Category { set; get; }
        public float price { set; get; }
        public int stock { set; get; }
        public string status { set; get; }
        public string date { set; get; }
        public int cost {  set; get; }

        public List<AddProduct> allProduct()
        {
            List<AddProduct> products = new List<AddProduct>();

            using (SqlConnection connect = DatabaseString.GetConnection())
            {
                connect.Open();

                string selectDat = "SELECT * FROM products ";

                using (SqlCommand cmd = new SqlCommand(selectDat, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AddProduct data = new AddProduct();
                        data.ID = (int)reader["id"];
                        data.prodID = (string)reader["prod_id"];
                        data.prodName = (string)reader["prod_name"];
                        data.Category = (string)reader["category"];
                        data.price= (int)reader["price"];
                        data.stock = (int)reader["stock"];
                        data.status = (string)reader["status"];
                        data.date = reader["date"].ToString();
                        data.cost = (int)reader["cost"];


                        products.Add(data);

                    }

                }

            }
            return products;

        }

        public List<AddProduct> allAvailableProducts()
        {
            List<AddProduct > products = new List<AddProduct>();

            using (SqlConnection connect = DatabaseString.GetConnection())
            {
                connect.Open();

                string selectDat = "SELECT * FROM products WHERE status = @status";

                using (SqlCommand cmd = new SqlCommand(selectDat, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "elerheto");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AddProduct data = new AddProduct();
                        data.ID = (int)reader["id"];
                        data.prodID = (string)reader["prod_id"];
                        data.prodName = (string)reader["prod_name"];
                        data.Category = (string)reader["category"];
                        data.price = (int)reader["price"];
                        data.stock = (int)reader["stock"];
                        data.status = (string)reader["status"];
                        data.date = reader["date"].ToString();
                        data.cost = (int)reader["cost"];


                        products.Add(data);

                    }

                }

            }



            return products;
        }

        public List<AddProduct> allServiceProducts()
        {
            List<AddProduct> products = new List<AddProduct>();

            using (SqlConnection connect = DatabaseString.GetConnection())
            {
                connect.Open();

                string selectDat = "SELECT * FROM products WHERE category = @category";

                using (SqlCommand cmd = new SqlCommand(selectDat, connect))
                {
                    cmd.Parameters.AddWithValue("@category", "szerviz");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AddProduct data = new AddProduct();
                        data.ID = (int)reader["id"];
                        data.prodID = (string)reader["prod_id"];
                        data.prodName = (string)reader["prod_name"];
                        data.Category = (string)reader["category"];
                        data.price = (int)reader["price"];
                        data.stock = (int)reader["stock"];
                        data.status = (string)reader["status"];
                        data.date = reader["date"].ToString();
                        data.cost = (int)reader["cost"];


                        products.Add(data);

                    }

                }

            }



            return products;
        }
    }
}
