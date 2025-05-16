namespace MacInventoryManagement
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_cpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_passShow = new System.Windows.Forms.CheckBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(191, 272);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(105, 23);
            this.btn_signin.TabIndex = 4;
            this.btn_signin.Text = "Regisztráció";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.Location = new System.Drawing.Point(336, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(23, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "X";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(117, 129);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(128, 20);
            this.tb_password.TabIndex = 2;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(117, 89);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(128, 20);
            this.tb_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Regisztrálj új fiókot!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jelszó";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Felhasználónév";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(38, 272);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(105, 23);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Bejelentkezés";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_cpassword
            // 
            this.tb_cpassword.Location = new System.Drawing.Point(117, 155);
            this.tb_cpassword.Name = "tb_cpassword";
            this.tb_cpassword.PasswordChar = '*';
            this.tb_cpassword.Size = new System.Drawing.Size(128, 20);
            this.tb_cpassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Jelszó";
            // 
            // cb_passShow
            // 
            this.cb_passShow.AutoSize = true;
            this.cb_passShow.Location = new System.Drawing.Point(194, 181);
            this.cb_passShow.Name = "cb_passShow";
            this.cb_passShow.Size = new System.Drawing.Size(102, 17);
            this.cb_passShow.TabIndex = 18;
            this.cb_passShow.Text = "Mutasd a jelszót";
            this.cb_passShow.UseVisualStyleBackColor = true;
            this.cb_passShow.CheckedChanged += new System.EventHandler(this.cb_passShow_CheckedChanged);
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Elado",
            "Szervizes"});
            this.cb_role.Location = new System.Drawing.Point(117, 220);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(121, 21);
            this.cb_role.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Munkakör:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 307);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.cb_passShow);
            this.Controls.Add(this.tb_cpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_cpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_passShow;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label5;
    }
}