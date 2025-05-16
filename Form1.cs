using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MacInventoryManagement
{
    public partial class Form1 : Form
    {
        SqlConnection connect = DatabaseString.GetConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//btn_login
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect)) 
                    {
                        cmd.Parameters.AddWithValue("@username", tb_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", tb_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Aktiv");

                        int rowCount = (int)cmd.ExecuteScalar();

                        

                        if (rowCount > 0)
                        {

                            string selectRole = "SELECT role FROM users WHERE username = @username AND password = @password";

                            using(SqlCommand cmdR = new SqlCommand(selectRole, connect))
                            {
                                cmdR.Parameters.AddWithValue("@username", tb_username.Text.Trim());
                                cmdR.Parameters.AddWithValue("@password", tb_password.Text.Trim());

                                string userRole = cmdR.ExecuteScalar() as string;

                                if (userRole == "Admin")
                                {
                                    MessageBox.Show("Bejelentkezés sikeres!", "Information Message", MessageBoxButtons.OK);
                                    AdminMain adminF = new AdminMain();
                                    adminF.Show();

                                    this.Hide();
                                }else if(userRole == "Elado")
                                {
                                    MessageBox.Show("Bejelentkezés sikeres!", "Information Message", MessageBoxButtons.OK);
                                    CashierMainF cashierMF = new CashierMainF();
                                    cashierMF.Show();

                                    this.Hide();
                                }
                                else if (userRole == "Szervizes")
                                {
                                    MessageBox.Show("Bejelentkezés sikeres!", "Information Message", MessageBoxButtons.OK);
                                    ServiceForm servicerF = new ServiceForm();
                                    servicerF.Show();

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Bejelentkezés sikertelen!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                            }

                        
                        }
                        else {

                            MessageBox.Show("Helytelen felhasználónév vagy jelszó!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A kapcsoalt nem sikerült " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_passShow_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_passShow.Checked ? '\0' : '*';
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
    }
}
