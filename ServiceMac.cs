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
using System.Runtime.Remoting.Contexts;
using System.Drawing.Printing;
using System.Drawing;

namespace MacInventoryManagement
{
    public partial class ServiceMac : UserControl
    {
        public ServiceMac()
        {
            InitializeComponent();
            displayAllAvailableProd();
            displayAllOrders();
            displayTotalP();
            displayProdID();

        }

        public void displayAllAvailableProd()
        {
            AddProduct data = new AddProduct();
            List<AddProduct> dataList = data.allServiceProducts();

            dg_product.DataSource = dataList;

            
        }
        SqlConnection connect = DatabaseString.GetConnection();

        public void displayProdID()
        {
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string selectData = $"SELECT * FROM products WHERE category = @category AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Elerheto");
                        cmd.Parameters.AddWithValue("@category", "szerviz");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string value = reader["prod_id"].ToString();
                                cb_productID.Items.Add(value);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
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

        

        public void displayAllOrders()
        {
            Orders order = new Orders();
            List<Orders> orders = order.allOrders();

            dg_orders.DataSource = orders;
        }
        private float totalP = 0;

        private void displayTotalP()
        {
            idGen();
            if (checkConnect())
            {
                try
                {
                    connect.Open();

                    string selectedData = "SELECT SUM(total_price) FROM orders WHERE customer_id = @customer_id";

                    using (SqlCommand cmd = new SqlCommand(selectedData, connect))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", genID);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalP = Convert.ToSingle(result);

                            lbl_total.Text = totalP.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CashierOrders.cs A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }
        private void ClearFields()
        {
            cb_productID.SelectedIndex = -1;
            lbl_prodName.Text = "Termék neve";
            lbl_price.Text = "0 Ft";
            tb_pieces.Value = 0;


        }
        private int genID;
        public void idGen()
        {
            using (SqlConnection connect = DatabaseString.GetConnection())
            {
                connect.Open();

                string selectData = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            genID = 1;
                        }
                        else
                        {
                            genID = temp + 1;
                        }
                    }
                    else
                    {
                        genID = 1;
                    }
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            idGen();

            if ( cb_productID.SelectedIndex == -1 || lbl_prodName.Text == "" || lbl_price.Text == "" || tb_pieces.Value == 0)
            {
                MessageBox.Show("Először válassz ki egy terméket!", "Information Message", MessageBoxButtons.OK);

            }
            else
            {
                if (checkConnect())
                {
                    try
                    {
                        connect.Open();

                        float Price = 0;
                        string selectOrder = "SELECT * FROM products WHERE prod_id = @prod_id";

                        using (SqlCommand cmd = new SqlCommand(selectOrder, connect))
                        {
                            cmd.Parameters.AddWithValue("@prod_id", cb_productID.SelectedItem);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["price"];

                                    if (rawValue != DBNull.Value)
                                    {
                                        Price = Convert.ToSingle(rawValue);
                                    }
                                }
                            }
                        }
                        string insertData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, quantity, price, order_date, total_price )" +
                                                        "VALUES (@cust_id , @prod_id, @prod_name, @category, @quantity, @price, @order_date, @total_price)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cust_id", genID);
                            cmd.Parameters.AddWithValue("@prod_id", cb_productID.SelectedItem);
                            cmd.Parameters.AddWithValue("@prod_name", lbl_prodName.Text.Trim());
                            cmd.Parameters.AddWithValue("@category", "szerviz");
                            cmd.Parameters.AddWithValue("@quantity", tb_pieces.Value);
                            cmd.Parameters.AddWithValue("@price", Price);

                            int totalPrice = (int)(Price * (int)tb_pieces.Value);
                            cmd.Parameters.AddWithValue("@total_price", totalPrice);

                            DateTime date = DateTime.Today;
                            cmd.Parameters.AddWithValue("@order_date", date);

                            cmd.ExecuteNonQuery();


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayAllOrders();
            displayTotalP();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Először válassz ki egy terméket a rendelésből!", "Information Message", MessageBoxButtons.OK);

            }
            else
            {
                if (checkConnect())
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM orders WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", prodID);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Az elem törölve!! " + prodID, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayAllOrders();
            displayTotalP();
            displayAllAvailableProd();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {

            idGen();
            if (lbl_total.Text == "" || dg_orders.Rows.Count < 0)
            {
                MessageBox.Show("Nincs megrendelés!!! ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    connect.Open();

                    string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, order_date) VALUES (@customer_id, @total_price, @amount, @change, @order_date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", genID);
                        //cmd.Parameters.AddWithValue("@prod_id", cb_productID.SelectedItem);
                        cmd.Parameters.AddWithValue("@total_price", lbl_total.Text);
                        cmd.Parameters.AddWithValue("@amount", tb_payed.Text);
                        cmd.Parameters.AddWithValue("@change", lbl_change.Text);

                        DateTime time = DateTime.Today;
                        cmd.Parameters.AddWithValue("order_date", time);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kifizetve!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayTotalP();
                        ClearFields();
                        tb_discount.ResetText();
                        lbl_withDiscount.Text = "";
                        lbl_total.Text = "";
                        tb_payed.Text = "0";
                        totalP = 0;
                        displayAllOrders();
                        lbl_change.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }

            }


        }

        

        private void cb_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = cb_productID.SelectedItem as string;
            if (selectItem != null)
            {
                if (checkConnect())
                {
                    try
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM products WHERE prod_id = '{selectItem}' AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Elérheto");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    string prodPrice = reader["price"].ToString();

                                    lbl_prodName.Text = prodName;
                                    lbl_price.Text = prodPrice;



                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A kapcsolat nem jött létre! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private int prodID = 0;
        

        private void dg_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dg_orders.Rows[e.RowIndex];

                prodID = (int)row.Cells[0].Value;


            }
        }

        private void tb_amount_ValueChanged(object sender, EventArgs e)
        {

            int amount = (int)tb_discount.Value;
            int charge = (int)(totalP * ((100 - amount) / 100.0f));


            lbl_withDiscount.Text = charge.ToString();

        }

        private void tb_payed_TextChanged(object sender, EventArgs e)
        {
            int price = 0;
            if (lbl_withDiscount.Text != "")
            {
                price = int.Parse(lbl_withDiscount.Text);
            }
            else
            {
                price = (int)totalP;
            }

            lbl_change.Text = (int.Parse(tb_payed.Text) - price).ToString();


        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            if (dg_orders.Rows.Count < 0)
            {

                MessageBox.Show("Adjon hozzá a rendeléshez termékeket! ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
        private int rowIndex = 0;
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (tb_payed.Text == "")
            {
                MessageBox.Show("Adja meg a kapott összeget!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                displayTotalP();

                float y = 0;
                int count = 0;
                int colWidth = 150;

                int headerMargin = 10;
                int tableMargin = 70;

                Font font = new Font("Arial", 12);
                Font bold = new Font("Arial", 12, FontStyle.Bold);
                Font headerFont = new Font("Arial", 16, FontStyle.Bold);
                Font labelFont = new Font("Arial", 14, FontStyle.Bold);

                float margin = e.MarginBounds.Top;

                StringFormat alignCenter = new StringFormat();
                alignCenter.Alignment = StringAlignment.Center;
                alignCenter.LineAlignment = StringAlignment.Center;

                string headerText = "Mac Műhely";
                y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);

                e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (dg_orders.Columns.Count / 2) * colWidth - 40, y, alignCenter);

                count++;
                y += tableMargin;

                string[] header = { "Kód", "Megnevezés", "Kategória", "db", "ár/db" };

                for (int i = 0; i < header.Length; i++)
                {
                    y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;

                float rSpace = e.MarginBounds.Bottom - y;

                while (rowIndex < dg_orders.Rows.Count)
                {
                    DataGridViewRow row = dg_orders.Rows[rowIndex];

                    for (int i = 0; i < dg_orders.Columns.Count; i++)
                    {
                        if (i == 0 || i == 6 || i == 7 || i == 9)
                        {

                        }
                        else
                        {
                            object cellValue = row.Cells[i].Value;
                            string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                            y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                            e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + (i - 1) * colWidth, y, alignCenter);
                        }
                    }
                    count++;
                    rowIndex++;

                    if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }

                int labelMargin = (int)Math.Min(rSpace, 200);


                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width;

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Végösszeg: \t" + totalP.ToString("0 000") + " Ft\nFizetett: \t"
                    + int.Parse(tb_payed.Text).ToString("0 000") + " Ft\n\t\t------------\nVisszajáró: \t" + int.Parse(lbl_change.Text).ToString("0 000") + "Ft", labelFont, Brushes.Black, labelX, y);

                labelMargin = (int)Math.Min(rSpace, -40);

            }

        }

        private void dg_product_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dg_product.Rows[e.RowIndex];
            if (e.RowIndex != -1)
            {


                prodID = (int)row.Cells[0].Value;


            }
            
            cb_productID.SelectedItem = row.Cells[2].Value;
            lbl_prodName.Text = row.Cells[1].Value.ToString();
            lbl_price.Text = row.Cells[4].Value.ToString();
        }
    }
}
