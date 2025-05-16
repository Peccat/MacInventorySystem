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
    public partial class AdminAddUsersUC : UserControl
    {
        public AdminAddUsersUC()
        {
            InitializeComponent();
            displayAllUser();
        }
        SqlConnection connect = DatabaseString.GetConnection();

        public void displayAllUser()
        {
            usersData data = new usersData();
            List<usersData> listUsers = data.allUsers();
            dataGridView1.DataSource = listUsers;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_password.Text == "" || cb_role.SelectedIndex == -1 || cb_status.SelectedIndex == -1)
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

                        string checkUsername = "SELECT * FROM users WHERE username = @username";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", tb_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dtable = new DataTable();
                            adapter.Fill(dtable);

                            if (dtable.Rows.Count > 0)
                            {
                                MessageBox.Show(tb_username.Text.Trim() + " név foglalt!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username, password, role, status, date) VALUES(@username,@password,@role,@status,@date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@username", tb_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@password", tb_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", cb_role.Text);
                                    insertD.Parameters.AddWithValue("@status", cb_status.Text);

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();

                                    ClearField();
                                    displayAllUser();
                                    MessageBox.Show("Regisztráció sikeres!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tb_username.Text = "";
            tb_password.Text = "";
            cb_role.SelectedIndex = -1;
            cb_status.SelectedIndex = -1;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string checkUsername = "SELECT * FROM users WHERE username = @username";

                    using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", tb_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dtable = new DataTable();
                        adapter.Fill(dtable);

                       
                        string updateData = "UPDATE users SET username = @username, password = @password, role = @role, status = @status WHERE id = @id";

                        using (SqlCommand update_Data = new SqlCommand(updateData, connect))
                        {
                            update_Data.Parameters.AddWithValue("@username", tb_username.Text.Trim());
                            update_Data.Parameters.AddWithValue("@password", tb_password.Text.Trim());
                            update_Data.Parameters.AddWithValue("@role", cb_role.Text);
                            update_Data.Parameters.AddWithValue("@status", cb_status.Text);
                            update_Data.Parameters.AddWithValue("@id", getID);

                            update_Data.ExecuteNonQuery();
                            displayAllUser();
                            ClearField();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                
                getID = (int)row.Cells[0].Value;
                string username = row.Cells[1].Value.ToString();
                string password = row.Cells[2].Value.ToString();
                string role = row.Cells[3].Value.ToString();
                string status = row.Cells[4].Value.ToString();


                tb_username.Text = username;
                tb_password.Text = password;

                cb_role.Text = role;
                cb_status.Text = status;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string checkUsername = "SELECT * FROM users WHERE username = @username";

                    using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", tb_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dtable = new DataTable();
                        adapter.Fill(dtable);


                        string deleteData = "DELETE FROM users WHERE id = @id";

                        using (SqlCommand del_Data = new SqlCommand(deleteData, connect))
                        {
                            del_Data.Parameters.AddWithValue("@id", getID);
                            del_Data.ExecuteNonQuery();
                            displayAllUser();
                            ClearField();
                            MessageBox.Show("Felhasználó törlése megtörtént!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
