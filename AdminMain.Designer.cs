namespace MacInventoryManagement
{
    partial class AdminMain
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
            this.btn_statistic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_logput = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cashierCostumer1 = new MacInventoryManagement.CashierCostumer();
            this.adminAddUsersUC1 = new MacInventoryManagement.AdminAddUsersUC();
            this.adminDashboard1 = new MacInventoryManagement.AdminDashboard();
            this.adminAddProduct1 = new MacInventoryManagement.AdminAddProduct();
            this.adminAddCategories1 = new MacInventoryManagement.AdminAddCategories();
            this.SuspendLayout();
            // 
            // btn_statistic
            // 
            this.btn_statistic.Location = new System.Drawing.Point(41, 184);
            this.btn_statistic.Margin = new System.Windows.Forms.Padding(2);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(94, 33);
            this.btn_statistic.TabIndex = 0;
            this.btn_statistic.Text = "Statisztika";
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Készletérték";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Összesen:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.Location = new System.Drawing.Point(77, 141);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(82, 13);
            this.lbl_stock.TabIndex = 14;
            this.lbl_stock.Text = "1 568 555Ft";
            this.lbl_stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(12, 222);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(147, 23);
            this.btn_customers.TabIndex = 15;
            this.btn_customers.Text = "Vásárlások";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_users
            // 
            this.btn_users.Location = new System.Drawing.Point(12, 251);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(147, 23);
            this.btn_users.TabIndex = 16;
            this.btn_users.Text = "Felhasználó hozzáadása";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Kategória hozzáadása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addCat_Click);
            // 
            // btn_prod
            // 
            this.btn_prod.Location = new System.Drawing.Point(12, 309);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(147, 23);
            this.btn_prod.TabIndex = 18;
            this.btn_prod.Text = "Termék hozzáadása";
            this.btn_prod.UseVisualStyleBackColor = true;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // btn_logput
            // 
            this.btn_logput.BackColor = System.Drawing.Color.Red;
            this.btn_logput.Location = new System.Drawing.Point(39, 588);
            this.btn_logput.Name = "btn_logput";
            this.btn_logput.Size = new System.Drawing.Size(101, 35);
            this.btn_logput.TabIndex = 19;
            this.btn_logput.Text = "Kijelentkezés";
            this.btn_logput.UseVisualStyleBackColor = false;
            this.btn_logput.Click += new System.EventHandler(this.btn_logput_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(953, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cashierCostumer1
            // 
            this.cashierCostumer1.Location = new System.Drawing.Point(190, 45);
            this.cashierCostumer1.Margin = new System.Windows.Forms.Padding(2);
            this.cashierCostumer1.Name = "cashierCostumer1";
            this.cashierCostumer1.Size = new System.Drawing.Size(807, 593);
            this.cashierCostumer1.TabIndex = 26;
            // 
            // adminAddUsersUC1
            // 
            this.adminAddUsersUC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminAddUsersUC1.Location = new System.Drawing.Point(190, 45);
            this.adminAddUsersUC1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsersUC1.Name = "adminAddUsersUC1";
            this.adminAddUsersUC1.Size = new System.Drawing.Size(800, 587);
            this.adminAddUsersUC1.TabIndex = 22;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(174, 32);
            this.adminDashboard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(807, 600);
            this.adminDashboard1.TabIndex = 20;
            // 
            // adminAddProduct1
            // 
            this.adminAddProduct1.BackColor = System.Drawing.Color.PaleGreen;
            this.adminAddProduct1.Location = new System.Drawing.Point(190, 45);
            this.adminAddProduct1.Name = "adminAddProduct1";
            this.adminAddProduct1.Size = new System.Drawing.Size(800, 587);
            this.adminAddProduct1.TabIndex = 24;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.adminAddCategories1.Location = new System.Drawing.Point(190, 45);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(800, 593);
            this.adminAddCategories1.TabIndex = 25;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 635);
            this.ControlBox = false;
            this.Controls.Add(this.cashierCostumer1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_logput);
            this.Controls.Add(this.btn_prod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_users);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_statistic);
            this.Controls.Add(this.adminAddUsersUC1);
            this.Controls.Add(this.adminDashboard1);
            this.Controls.Add(this.adminAddProduct1);
            this.Controls.Add(this.adminAddCategories1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button btn_logput;
        private AdminDashboard adminDashboard1;
        private System.Windows.Forms.Button button4;
        private AdminAddUsersUC adminAddUsersUC1;
        private AdminAddProduct adminAddProduct1;
        private AdminAddCategories adminAddCategories1;
        private CashierCostumer cashierCostumer1;
    }
}