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
using System.Web;

namespace MacInventoryManagement
{
    public partial class AdminAddProduct : UserControl
    {
        public AdminAddProduct()
        {
            InitializeComponent();
            
           
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

        public void ClearField()
        {
            tb_price.Text = "";
            tb_prodictID.Text = "";
            tb_productName.Text = "";
            tb_stock.Text = "";
            cb_category.SelectedIndex = -1;
            cb_status.SelectedIndex = -1;
            tb_cost.Text = "";
        }

        public void displayAllCAt()
        {
            cb_category.Items.Clear();
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string selectDat = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectDat,connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cb_category.Items.Add(reader["category"].ToString());
                            }
                        }
                    }


                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }

            }
        }

        public void displayAllProd()
        {
            AddProduct data = new AddProduct();
            List<AddProduct> listProd = data.allProduct();
            dataGridView1.DataSource = listProd;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_prodictID.Text == "" || tb_productName.Text == "" || tb_price.Text == "" || tb_stock.Text == "" || cb_status.SelectedIndex == -1 || cb_category.SelectedIndex == -1)
            {
                MessageBox.Show("Minden mezőt tölts ki!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnect())
                {
                    try
                    {
                        connect.Open();

                        string checkProd = "SELECT * FROM products WHERE prod_id = @prod_id";

                        using (SqlCommand cmd = new SqlCommand(checkProd, connect))
                        {
                            cmd.Parameters.AddWithValue("@prod_id", tb_prodictID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dtable = new DataTable();
                            adapter.Fill(dtable);

                            if (dtable.Rows.Count > 0)
                            {
                                MessageBox.Show(tb_prodictID.Text.Trim() + " id foglalt!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO products(prod_id, prod_name, status, stock, category, price, date, cost) VALUES(@prod_id,@prod_name,@status,@stock, @category, @price, @date, @cost)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@prod_id", tb_prodictID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@prod_name",  tb_productName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@stock", tb_stock.Text);
                                    insertD.Parameters.AddWithValue("@status", cb_status.Text);
                                    insertD.Parameters.AddWithValue("@price", tb_price.Text);
                                    insertD.Parameters.AddWithValue("@category", cb_category.Text);
                                    insertD.Parameters.AddWithValue("@cost", tb_cost.Text);

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();

                                    ClearField();
                                    displayAllProd();
                                    
                                    MessageBox.Show("Termék mentése sikeres!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kapcsolat nem sikerült: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_prodictID.Text == "" || tb_productName.Text == "" || tb_price.Text == "" || tb_stock.Text == "" || cb_status.SelectedIndex == -1 || cb_category.SelectedIndex == -1)
            {
                MessageBox.Show("Minden mezőt tölts ki!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnect())
                {
                    try
                    {
                        connect.Open();

                        
                        string updateData = "UPDATE products SET prod_id = @prod_id, prod_name = @prod_name, category = @category, price = @price, status = @status, cost = @cost, stock = @stock WHERE id = @id";

                        using (SqlCommand updateD = new SqlCommand(updateData, connect))
                        {
                            updateD.Parameters.AddWithValue("@id", getID);
                            updateD.Parameters.AddWithValue("@prod_id", tb_prodictID.Text.Trim());
                            updateD.Parameters.AddWithValue("@prod_name", tb_productName.Text.Trim());
                            updateD.Parameters.AddWithValue("@stock", tb_stock.Text);
                            updateD.Parameters.AddWithValue("@status", cb_status.Text);
                            updateD.Parameters.AddWithValue("@price", tb_price.Text);
                            updateD.Parameters.AddWithValue("@category", cb_category.Text);
                            updateD.Parameters.AddWithValue("@cost", tb_cost.Text);

                            updateD.ExecuteNonQuery();

                            ClearField();
                            displayAllProd();

                            MessageBox.Show("Termék frissítése sikeres!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kapcsolat nem sikerült: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tb_prodictID.Text == "" || tb_productName.Text == "" || tb_price.Text == "" || tb_stock.Text == "" || cb_status.SelectedIndex == -1 || cb_category.SelectedIndex == -1)
            {
                MessageBox.Show("Minden mezőt tölts ki!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnect())
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM products WHERE id = @id";

                        using (SqlCommand delD = new SqlCommand(deleteData, connect))
                        {
                            delD.Parameters.AddWithValue("@id", getID);
                            
                            delD.ExecuteNonQuery();

                            ClearField();
                            displayAllProd();

                            MessageBox.Show("Termék törlése sikeres!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kapcsolat nem sikerült: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                string prodid = row.Cells[1].Value.ToString();
                string prodname = row.Cells[2].Value.ToString();
                string category = row.Cells[3].Value.ToString();
                string price = row.Cells[4].Value.ToString();
                string stock = row.Cells[5].Value.ToString();
                string status = row.Cells[6].Value.ToString();
                string cost = row.Cells[8].Value.ToString();

                tb_prodictID.Text = prodid;
                tb_productName.Text = prodname;
                
                cb_category.Text = category;
                tb_price.Text = price;
                tb_stock.Text = stock;
                cb_status.Text = status;
                tb_cost.Text = cost;


            }
        }

        private void AdminAddProduct_VisibleChanged(object sender, EventArgs e)
        {

            displayAllCAt();
            displayAllProd();
        }
    }
}
