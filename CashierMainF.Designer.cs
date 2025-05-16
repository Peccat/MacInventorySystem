namespace MacInventoryManagement
{
    partial class CashierMainF
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
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.cashierCostumer1 = new MacInventoryManagement.CashierCostumer();
            this.adminDashboard1 = new MacInventoryManagement.AdminDashboard();
            this.cashierOrder2 = new MacInventoryManagement.CashierOrder();
            this.adminAddProduct2 = new MacInventoryManagement.AdminAddProduct();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(997, 8);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(21, 21);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_product);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.btn_customers);
            this.panel1.Controls.Add(this.btn_orders);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 619);
            this.panel1.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_logout.Location = new System.Drawing.Point(45, 583);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(105, 25);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Kijelentkezés";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Üdvözöllek, Eladó";
            // 
            // btn_product
            // 
            this.btn_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_product.Location = new System.Drawing.Point(45, 295);
            this.btn_product.Margin = new System.Windows.Forms.Padding(2);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(105, 25);
            this.btn_product.TabIndex = 3;
            this.btn_product.Text = "Termékek";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dashboard.Location = new System.Drawing.Point(45, 252);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(105, 25);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "Irányítópult";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_customers.Location = new System.Drawing.Point(45, 205);
            this.btn_customers.Margin = new System.Windows.Forms.Padding(2);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(105, 25);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "Vásárlók";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_orders.Location = new System.Drawing.Point(45, 155);
            this.btn_orders.Margin = new System.Windows.Forms.Padding(2);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(105, 25);
            this.btn_orders.TabIndex = 0;
            this.btn_orders.Text = "Rendelés";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // cashierCostumer1
            // 
            this.cashierCostumer1.Location = new System.Drawing.Point(219, 27);
            this.cashierCostumer1.Margin = new System.Windows.Forms.Padding(2);
            this.cashierCostumer1.Name = "cashierCostumer1";
            this.cashierCostumer1.Size = new System.Drawing.Size(807, 600);
            this.cashierCostumer1.TabIndex = 4;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(218, 27);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(807, 600);
            this.adminDashboard1.TabIndex = 2;
            // 
            // cashierOrder2
            // 
            this.cashierOrder2.Location = new System.Drawing.Point(216, 27);
            this.cashierOrder2.Margin = new System.Windows.Forms.Padding(1);
            this.cashierOrder2.Name = "cashierOrder2";
            this.cashierOrder2.Size = new System.Drawing.Size(807, 600);
            this.cashierOrder2.TabIndex = 3;
            // 
            // adminAddProduct2
            // 
            this.adminAddProduct2.BackColor = System.Drawing.Color.PaleGreen;
            this.adminAddProduct2.Location = new System.Drawing.Point(233, 41);
            this.adminAddProduct2.Name = "adminAddProduct2";
            this.adminAddProduct2.Size = new System.Drawing.Size(800, 582);
            this.adminAddProduct2.TabIndex = 5;
            // 
            // CashierMainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 635);
            this.Controls.Add(this.adminAddProduct2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.adminDashboard1);
            this.Controls.Add(this.cashierOrder2);
            this.Controls.Add(this.cashierCostumer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CashierMainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private AdminDashboard adminDashboard1;
        private AdminAddProduct adminAddProduct1;
        private CashierOrder cashierOrder1;
        private CashierOrder cashierOrder2;
        private CashierCostumer cashierCostumer1;
        private AdminAddProduct adminAddProduct2;
    }
}