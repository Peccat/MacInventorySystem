using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace MacInventoryManagement
{
    internal class CategoriesD
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public string CategoryDate { set; get; }

        
        public List<CategoriesD> AllCategoryData()
        {
            List<CategoriesD> listData = new List<CategoriesD>();

            using (SqlConnection conn = DatabaseString.GetConnection())
            {
                conn.Open();
                
                string selectedData = "SELECT * FROM dbo.categories";

                using (SqlCommand cmd = new SqlCommand(selectedData, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoriesD catData = new CategoriesD();
                        catData.CategoryID = (int)reader["id"];
                        catData.CategoryName = (string)reader["category"];

                        catData.CategoryDate = reader["date"].ToString();

                        listData.Add(catData);
                    }

                }


                return listData;
            }
        }

    }
}
