namespace MacInventoryManagement
{
    partial class Form1
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
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_signin = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.cb_passShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(212, 224);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(105, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Bejelentkezés";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Üdvözöllek! Kérlek jelentkezz be!";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(158, 117);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(128, 20);
            this.tb_username.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.Location = new System.Drawing.Point(377, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(23, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "X";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(73, 224);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(105, 23);
            this.btn_signin.TabIndex = 7;
            this.btn_signin.Text = "Regisztráció";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(158, 157);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(128, 20);
            this.tb_password.TabIndex = 2;
            // 
            // cb_passShow
            // 
            this.cb_passShow.AutoSize = true;
            this.cb_passShow.Location = new System.Drawing.Point(184, 183);
            this.cb_passShow.Name = "cb_passShow";
            this.cb_passShow.Size = new System.Drawing.Size(102, 17);
            this.cb_passShow.TabIndex = 8;
            this.cb_passShow.Text = "Mutasd a jelszót";
            this.cb_passShow.UseVisualStyleBackColor = true;
            this.cb_passShow.CheckedChanged += new System.EventHandler(this.cb_passShow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 268);
            this.Controls.Add(this.cb_passShow);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.CheckBox cb_passShow;
    }
}

