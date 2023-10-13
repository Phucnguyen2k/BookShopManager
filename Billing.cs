using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus\OneDrive\Tài liệu\BookShopsDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            try
            {
                con.Open();
                string query = "select * from BookTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dvBooks.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(txtQty.Value);
            try
            {
                con.Open();
                //string query = "update BookTbl set BTitle='" + txtTitle.Text + "',BAuthor='" + txtAuthor.Text + "',BCat=" + cbCate.SelectedIndex.ToString() + "',BQty=" + txtQty.Text + ",BPrice" + txtPrice.Value + " where BId" + key + ";";
                string query = "update BookTbl set BQty=" + newQty + " where BId=" + key + ";";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //RestColum();
        }

        int n = 0, GrdTotal = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQty.Value == 0 || Convert.ToInt32(txtQty.Value) > stock)
            {
                MessageBox.Show("No Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(txtQty.Value) * Convert.ToInt32(txtPrice.Value);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dvBill);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtTitle.Text;
                newRow.Cells[2].Value = txtQty.Value;
                newRow.Cells[3].Value = txtPrice.Value;
                newRow.Cells[4].Value = total;
                dvBill.Rows.Add(newRow);
                n++;
                UpdateBook();
                GrdTotal = GrdTotal + total;
                lbTotal.Text = "Total $: " + GrdTotal;
            }
        }

        int key = 0, stock = 0;

        private void dvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTitle.Text = dvBooks.SelectedRows[0].Cells[1].Value.ToString();
            //txtAuthor.Text = dvBooks.SelectedRows[0].Cells[2].Value.ToString();
            //cbCate.SelectedItem = dvBooks.SelectedRows[0].Cells[3].Value.ToString();
            //txtQty.Text = dvBooks.SelectedRows[0].Cells[4].Value.ToString();
            txtPrice.Value = decimal.Parse(dvBooks.SelectedRows[0].Cells[5].Value.ToString());

            string s;
            s = dvBooks.SelectedRows[0].Cells[3].Value.ToString();
            if (txtTitle.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(dvBooks.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(dvBooks.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtClientName.Text == "" || txtTitle.Text == "")
                MessageBox.Show("Select Client Name");
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BillTbl values('" +
                        lbUserName.Text +
                        "','" +
                        txtClientName.Text +
                        "'," +
                        GrdTotal +
                        ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Bill Saved Successfully");
                    NotificationHelper.ShowNotification("Bill", "Bill Saved Successfully", ToolTipIcon.Info);
                    con.Close();
                    //populate();
                    //RestColum();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 600, 800);

                printPreviewDialog1.PointToScreen(Cursor.Position);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
            }
        }

        int prodid, prodqty, prodprice, tottal, pos = 60;

        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void Billing_Load(object sender, EventArgs e) { lbUserName.Text = frmLogin.UserName; }

        string prodname;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics
                .DrawString("      Book Shop", new Font("Courier New", 18, FontStyle.Bold), Brushes.Blue, new Point(80, 15));
            e.Graphics
                .DrawString(
                    "ID PRODUCT            PRICE QTY TOTAL",
                    new Font("Courier New", 9, FontStyle.Bold),
                    Brushes.Blue,
                    new Point(26, 40));
            foreach (DataGridViewRow row in dvBill.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                //tottal = Convert.ToInt32(row.Cells[row.Cells["Column5"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics
                    .DrawString(
                        "" + prodid,
                        new Font("Courier New", 9, FontStyle.Bold),
                        Brushes.Black,
                        new Point(26, pos));
                e.Graphics
                    .DrawString(
                        "" + prodname,
                        new Font("Courier New", 9, FontStyle.Bold),
                        Brushes.Black,
                        new Point(45, pos));
                e.Graphics
                    .DrawString(
                        "" + prodprice,
                        new Font("Courier New", 9, FontStyle.Bold),
                        Brushes.Black,
                        new Point(200, pos));
                e.Graphics
                    .DrawString(
                        "" + prodqty,
                        new Font("Courier New", 9, FontStyle.Bold),
                        Brushes.Black,
                        new Point(230, pos));
                e.Graphics
                    .DrawString(
                        "" + tottal,
                        new Font("Courier New", 9, FontStyle.Bold),
                        Brushes.Black,
                        new Point(265, pos));
                pos = pos + 20;
            }
            e.Graphics
                .DrawString(
                    "       Grand ToTal: $" + GrdTotal,
                    new Font("Courier New", 12, FontStyle.Bold),
                    Brushes.Blue,
                    new Point(60, pos + 50));
            e.Graphics
                .DrawString(
                    "       =========== BookStore ===========",
                    new Font("Courier New", 10, FontStyle.Bold),
                    Brushes.Blue,
                    new Point(40, pos + 85));
            dvBill.Rows.Clear();
            dvBill.Refresh();
            pos = 100;
            GrdTotal = 0;
        }

        private void Reset()
        {
            txtClientName.Text = "";
            txtTitle.Text = "";
            txtQty.Value = 0;
            txtPrice.Value = 0;
        }

        private void btnReset_Click(object sender, EventArgs e) { Reset(); }
    }
}
