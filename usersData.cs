using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Web;

namespace MacInventoryManagement
{
    internal class usersData
    {

        public int ID { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public string role { set; get; }
        public string status { set; get; }
        public string date { set; get; }

        public List<usersData> allUsers()
        {
            List<usersData> listData = new List<usersData>();

            using (SqlConnection connect = DatabaseString.GetConnection())
            {
                connect.Open();

                string selectDat = "SELECT * FROM users ";

                using (SqlCommand cmd = new SqlCommand(selectDat, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        usersData data = new usersData();
                        data.ID = (int)reader["id"];
                        data.username = (string)reader["username"];
                        data.password = (string)reader["password"];
                        data.status = (string)reader["status"];
                        data.date = reader["date"].ToString();
                        data.role = (string)reader["role"];

                        listData.Add(data);

                    }

                }

            }
            return listData;


        }
    }
}
