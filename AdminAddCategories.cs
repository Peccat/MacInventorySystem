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

namespace MacInventoryManagement
{
    public partial class AdminAddCategories : UserControl
    {
        public AdminAddCategories()
        {
            InitializeComponent();
            displayAllCat();
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

        public void clearField()
        {
            tb_categoryname.Text = "";
        }
        public void displayAllCat()
        {
            CategoriesD cdata = new CategoriesD();
            List<CategoriesD> listCategory = cdata.AllCategoryData();
            dataGridView1.DataSource = listCategory;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_categoryname.Text == "")
            {
                MessageBox.Show("Ne hagyd üresen a mezőt!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnect())
                {
                    try
                    {
                        connect.Open();

                        string checkCategory = "SELECT * FROM categories WHERE category = @category ";//hiba

                        using (SqlCommand cmd = new SqlCommand(checkCategory, connect))
                        {
                            cmd.Parameters.AddWithValue("@category", tb_categoryname.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dtable = new DataTable();

                            adapter.Fill(dtable);

                            if (dtable.Rows.Count > 0)
                            {
                                MessageBox.Show(tb_categoryname.Text.Trim() + " már foglalt!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO categories (category, date) VALUES(@category,@date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@category", tb_categoryname.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearField();
                                    displayAllCat();

                                    MessageBox.Show("Kategória létrehozása sikeres!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string checkCategory = "SELECT * FROM categories WHERE category = @category";

                    using (SqlCommand cmd = new SqlCommand(checkCategory, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", tb_categoryname.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dtable = new DataTable();
                        adapter.Fill(dtable);


                        string updateData = "UPDATE categories SET category = @category WHERE id = @id";

                        using (SqlCommand update_Data = new SqlCommand(updateData, connect))
                        {
                            update_Data.Parameters.AddWithValue("@category", tb_categoryname.Text.Trim());
                            update_Data.Parameters.AddWithValue("@id", getID);

                            update_Data.ExecuteNonQuery();
                            displayAllCat();
                            clearField();
                            MessageBox.Show("Adatok frissítése megtörtént!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private int getID = 0;
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string checkCat = "SELECT * FROM categories WHERE category = @category";

                    using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", tb_categoryname.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dtable = new DataTable();
                        adapter.Fill(dtable);


                        string deleteData = "DELETE FROM categories WHERE id = @id";

                        using (SqlCommand del_Data = new SqlCommand(deleteData, connect))
                        {
                            del_Data.Parameters.AddWithValue("@id", getID);
                            del_Data.ExecuteNonQuery();
                            displayAllCat();
                            clearField();
                            MessageBox.Show("Kategória törlése megtörtént!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;

                string category = row.Cells[1].Value.ToString();
                tb_categoryname.Text = category;

            }
        }
    }
}