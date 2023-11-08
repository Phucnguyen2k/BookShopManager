using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();

            ShowBook();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            lbUserName.Text = frmLogin.UserName;

            //Cang Chinh Bang
            dvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        BookShopDataContext db = new BookShopDataContext();

        private void ShowBook()
        {
            dvBooks.DataSource = db.BookTbls;
        }
        private void UpdateBook()
        {
            //So luong sach sau khi khach hang mua
            int newQty = stock - Convert.ToInt32(txtQty.Value);

            var bookToUpdate = db.BookTbls.SingleOrDefault(b => b.BId == key);

            if (bookToUpdate != null)
            {
                bookToUpdate.BQty = newQty;
                db.SubmitChanges();
                ShowBook();
            }
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
                newRow.Cells[1].Value = txtTitle.Text.Trim();
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

        //Hien thi thong tin sach
        int key = 0, stock = 0;
        private void dvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //reset bill
            btnReset_Click(sender, e);
            txtTitle.Text = dvBooks.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Value = decimal.Parse(dvBooks.SelectedRows[0].Cells[5].Value.ToString());

            //string s;
            //s = dvBooks.SelectedRows[0].Cells[3].Value.ToString();
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
        private void PrintBill()
        {
            //Tao Doi Tuong Hoa Don
            BillTbl newBill = new BillTbl
            {
                UName = lbUserName.Text,
                ClineName = txtClientName.Text,
                Amount = GrdTotal,
                UDate = DateTime.Now
            };

            //Them Hoa Don Vao Co So Du Lieu
            db.BillTbls.InsertOnSubmit(newBill);
            db.SubmitChanges();

            NotificationHelper.ShowNotification("Bill", "Bill Saved Successfully", ToolTipIcon.Info);

            //In ra hoa don
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 600, 800);

            printPreviewDialog1.PointToScreen(Cursor.Position);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintBill();
        }


        //Thoat Ung Dung
        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }

        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;

        /// <summary>
        /// In Bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Dang Xua 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
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
