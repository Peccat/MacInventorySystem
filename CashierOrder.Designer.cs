namespace MacInventoryManagement
{
    partial class CashierOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            this.dg_product = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.cb_productID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_prodName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_pieces = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dg_orders = new System.Windows.Forms.DataGridView();
            this.tb_discount = new System.Windows.Forms.NumericUpDown();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_receipt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_withDiscount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.tb_payed = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pieces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_discount)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_product
            // 
            this.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_product.Location = new System.Drawing.Point(10, 66);
            this.dg_product.Margin = new System.Windows.Forms.Padding(2);
            this.dg_product.Name = "dg_product";
            this.dg_product.RowTemplate.Height = 28;
            this.dg_product.Size = new System.Drawing.Size(419, 227);
            this.dg_product.TabIndex = 3;
            this.dg_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_product_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Termékek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategóriák";
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(78, 332);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(106, 21);
            this.cb_Category.TabIndex = 6;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // cb_productID
            // 
            this.cb_productID.FormattingEnabled = true;
            this.cb_productID.Location = new System.Drawing.Point(309, 334);
            this.cb_productID.Margin = new System.Windows.Forms.Padding(2);
            this.cb_productID.Name = "cb_productID";
            this.cb_productID.Size = new System.Drawing.Size(106, 21);
            this.cb_productID.TabIndex = 8;
            this.cb_productID.SelectedIndexChanged += new System.EventHandler(this.cb_productID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Termék Cikkszám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Termék neve:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(75, 396);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(0, 13);
            this.lbl_price.TabIndex = 10;
            // 
            // lbl_prodName
            // 
            this.lbl_prodName.AutoSize = true;
            this.lbl_prodName.Location = new System.Drawing.Point(75, 376);
            this.lbl_prodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prodName.Name = "lbl_prodName";
            this.lbl_prodName.Size = new System.Drawing.Size(0, 13);
            this.lbl_prodName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ár (Ft)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 376);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Darabszám:";
            // 
            // tb_pieces
            // 
            this.tb_pieces.Location = new System.Drawing.Point(284, 372);
            this.tb_pieces.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pieces.Name = "tb_pieces";
            this.tb_pieces.Size = new System.Drawing.Size(80, 20);
            this.tb_pieces.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(281, 432);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(83, 41);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Hozzáadás a rendeléshez";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(489, 294);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 20);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Tétel törlése";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(171, 432);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(83, 41);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Mezők törlése";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Kedvezmény:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(698, 294);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(22, 13);
            this.lbl_total.TabIndex = 20;
            this.lbl_total.Text = "0Ft";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(628, 294);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Végösszeg:";
            // 
            // dg_orders
            // 
            this.dg_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_orders.Location = new System.Drawing.Point(492, 49);
            this.dg_orders.Margin = new System.Windows.Forms.Padding(2);
            this.dg_orders.Name = "dg_orders";
            this.dg_orders.RowTemplate.Height = 28;
            this.dg_orders.Size = new System.Drawing.Size(313, 227);
            this.dg_orders.TabIndex = 22;
            this.dg_orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_orders_CellClick);
            // 
            // tb_discount
            // 
            this.tb_discount.AllowDrop = true;
            this.tb_discount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tb_discount.Location = new System.Drawing.Point(701, 314);
            this.tb_discount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(80, 20);
            this.tb_discount.TabIndex = 23;
            this.tb_discount.ValueChanged += new System.EventHandler(this.tb_amount_ValueChanged);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(636, 473);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(169, 22);
            this.btn_pay.TabIndex = 24;
            this.btn_pay.Text = "Kifizetés";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_receipt
            // 
            this.btn_receipt.Location = new System.Drawing.Point(458, 473);
            this.btn_receipt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(169, 22);
            this.btn_receipt.TabIndex = 25;
            this.btn_receipt.Text = "Nyugta";
            this.btn_receipt.UseVisualStyleBackColor = true;
            this.btn_receipt.Click += new System.EventHandler(this.btn_receipt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(607, 336);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kedvezménnyel:";
            // 
            // lbl_withDiscount
            // 
            this.lbl_withDiscount.Location = new System.Drawing.Point(698, 336);
            this.lbl_withDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_withDiscount.Name = "lbl_withDiscount";
            this.lbl_withDiscount.Size = new System.Drawing.Size(90, 13);
            this.lbl_withDiscount.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Rendelés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Adott: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 384);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Vissza:";
            // 
            // lbl_change
            // 
            this.lbl_change.Location = new System.Drawing.Point(696, 382);
            this.lbl_change.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(83, 15);
            this.lbl_change.TabIndex = 31;
            // 
            // tb_payed
            // 
            this.tb_payed.Location = new System.Drawing.Point(698, 360);
            this.tb_payed.Margin = new System.Windows.Forms.Padding(2);
            this.tb_payed.Name = "tb_payed";
            this.tb_payed.Size = new System.Drawing.Size(81, 20);
            this.tb_payed.TabIndex = 32;
            this.tb_payed.TextChanged += new System.EventHandler(this.tb_payed_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_payed);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_withDiscount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_receipt);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.tb_discount);
            this.Controls.Add(this.dg_orders);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_pieces);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_prodName);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_productID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_product);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CashierOrder";
            this.Size = new System.Drawing.Size(807, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pieces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_discount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.ComboBox cb_productID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_prodName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown tb_pieces;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dg_orders;
        private System.Windows.Forms.NumericUpDown tb_discount;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_receipt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_withDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.TextBox tb_payed;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
