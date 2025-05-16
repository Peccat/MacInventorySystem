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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MacInventoryManagement
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = DatabaseString.GetConnection();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if(tb_username.Text == "" || tb_password.Text == "" || tb_cpassword.Text == "")
            {
                MessageBox.Show("Töltse ki az összes mezőt!","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnect())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM users WHERE username = @username"; 

                        using(SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", tb_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(tb_username.Text.Trim() + " már foglalt!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if(tb_password.Text.Length < 8)
                            {
                                MessageBox.Show("Rövid a jelszó! Legyen minimum 8 karakter!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }else if(tb_password.Text.Trim() != tb_cpassword.Text.Trim())
                            {

                            }
                            else
                            {

                                string insertData = "INSERT INTO users(username, password, role, status, date)" + "VALUES(@username,@password,@role,@status,@date)";
                                

                                using (SqlCommand insertD = new SqlCommand(insertData, connect)) {
                                    insertD.Parameters.AddWithValue("@username", tb_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@password", tb_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", cb_role.Text);
                                    insertD.Parameters.AddWithValue("@status", "Elfogadasra var");

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    MessageBox.Show("Regisztráció sikeres!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginform = new Form1();
                                    loginform.Show();

                                    this.Hide();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A kapcsolat nem sikerült!" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool checkConnect()
        {
            if(connect.State == ConnectionState.Closed)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void cb_passShow_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_passShow.Checked ? '\0' : '*';
            tb_cpassword.PasswordChar = cb_passShow.Checked ? '\0' : '*';
        }
    }
}
