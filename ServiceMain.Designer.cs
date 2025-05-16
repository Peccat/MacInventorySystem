namespace MacInventoryManagement
{
    partial class ServiceMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dashboard = new System.Windows.Forms.Button();
            this.btn_macs = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.serviceMac1 = new MacInventoryManagement.ServiceMac();
            this.adminDashboard1 = new MacInventoryManagement.AdminDashboard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1028, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_macs);
            this.panel1.Controls.Add(this.lbl_dashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 649);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szia Szervizes!";
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.Location = new System.Drawing.Point(48, 151);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(129, 34);
            this.lbl_dashboard.TabIndex = 1;
            this.lbl_dashboard.Text = "Statisztika";
            this.lbl_dashboard.UseVisualStyleBackColor = true;
            this.lbl_dashboard.Click += new System.EventHandler(this.lbl_dashboard_Click);
            // 
            // btn_macs
            // 
            this.btn_macs.Location = new System.Drawing.Point(48, 216);
            this.btn_macs.Name = "btn_macs";
            this.btn_macs.Size = new System.Drawing.Size(129, 34);
            this.btn_macs.TabIndex = 2;
            this.btn_macs.Text = "Gépek";
            this.btn_macs.UseVisualStyleBackColor = true;
            this.btn_macs.Click += new System.EventHandler(this.btn_macs_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Location = new System.Drawing.Point(48, 609);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(129, 34);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Kijelentkezés";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // serviceMac1
            // 
            this.serviceMac1.Location = new System.Drawing.Point(259, 61);
            this.serviceMac1.Name = "serviceMac1";
            this.serviceMac1.Size = new System.Drawing.Size(807, 600);
            this.serviceMac1.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(259, 61);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(807, 600);
            this.adminDashboard1.TabIndex = 2;
            // 
            // ServiceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 667);
            this.Controls.Add(this.serviceMac1);
            this.Controls.Add(this.adminDashboard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lbl_dashboard;
        private System.Windows.Forms.Button btn_macs;
        private System.Windows.Forms.Button btn_logout;
        private AdminDashboard adminDashboard1;
        private ServiceMac serviceMac1;
    }
}