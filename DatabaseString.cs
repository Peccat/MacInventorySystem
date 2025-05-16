using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MacInventoryManagement
{
    internal class DatabaseString
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\simon\source\repos\MacInventoryManagement\inventory.mdf; Integrated Security = True; Connect Timeout = 30");

        
        }
    }
}
