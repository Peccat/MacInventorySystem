namespace MacInventoryManagement
{
    partial class AdminAddProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tb_prodictID = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 329);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Termékek:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Termék azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 413);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Termék neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 434);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kategória:";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(106, 434);
            this.cb_category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(98, 21);
            this.cb_category.TabIndex = 15;
            // 
            // tb_prodictID
            // 
            this.tb_prodictID.Location = new System.Drawing.Point(106, 394);
            this.tb_prodictID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_prodictID.Name = "tb_prodictID";
            this.tb_prodictID.Size = new System.Drawing.Size(98, 20);
            this.tb_prodictID.TabIndex = 16;
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(106, 413);
            this.tb_productName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(98, 20);
            this.tb_productName.TabIndex = 17;
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(317, 394);
            this.tb_stock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(98, 20);
            this.tb_stock.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Készleten (db):";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(317, 418);
            this.tb_price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(98, 20);
            this.tb_price.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 417);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Eladási ár (Ft):";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Elerheto",
            "Nem elerheto"});
            this.cb_status.Location = new System.Drawing.Point(317, 439);
            this.cb_status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(98, 21);
            this.cb_status.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 439);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Elérhetőség:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(471, 371);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 36);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "Hozzáadás";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(589, 419);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 36);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = "Mezők törlése";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(589, 371);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(77, 36);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Termék törlése";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(471, 417);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 36);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "Frissít";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(317, 372);
            this.tb_cost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(98, 20);
            this.tb_cost.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 375);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Beszerzési ár:";
            // 
            // AdminAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.tb_prodictID);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminAddProduct";
            this.Size = new System.Drawing.Size(800, 475);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox tb_prodictID;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.Label label8;
    }
}
