using BookShopManager.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            FormLoad();

        }

        private void FormLoad()
        {
            // TODO: This line of code loads data into the 'bOOKSHOPSDBDataSet.BillDetailTbl' table. You can move, or remove it, as needed.
            this.billDetailTblTableAdapter.Fill(this.bOOKSHOPSDBDataSet.BillDetailTbl);
            // TODO: This line of code loads data into the 'bOOKSHOPSDBDataSet.BillTbl' table. You can move, or remove it, as needed.
            this.billTblTableAdapter.Fill(this.bOOKSHOPSDBDataSet.BillTbl);
            //// TODO: This line of code loads data into the 'bOOKSHOPSDBDataSet.BookTbl' table. You can move, or remove it, as needed.
            //this.bookTblTableAdapter.Fill(this.bOOKSHOPSDBDataSet.BookTbl);
            bookTblBindingSource1.DataSource = db.BookTbls
                                 .Select(b => new { ID = b.BId, Title = b.BTitle, Qty = b.BQty, Price = b.BPrice })
                                  .ToList();

            bsBill.DataSource = db.BookTbls
                                 .Select(b => new { ID = b.BId, Title = b.BTitle, Qty = b.BQty, Price = b.BPrice })
                                  .ToList();
            dvBooks.DataSource = bookTblBindingSource1;

            lbUserName.Text = frmLogin.UserName;

            //todo: load hinh anh
            //UpdateImage();
            NameBook();
        }

        private void NameBook()
        {
            string id = dvBooks.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            string Title = db.BookTbls.Where(b => b.BId.Equals(id)).Select(b => b.BTitle).FirstOrDefault();
            string Author = db.BookTbls.Where(b => b.BId.Equals(id)).Select(b => b.BAuthor).FirstOrDefault();
            string Cate = db.BookTbls.Where(b => b.BId.Equals(id)).Select(b => b.BCat).FirstOrDefault();
            int Publisher = db.BookTbls.Where(b => b.BId.Equals(id)).Select(b => b.BYear).FirstOrDefault();
            int Qty = db.BookTbls.Where(b => b.BId.Equals(id)).Select(b => b.BQty).FirstOrDefault();
            int price = db.BookTbls.Where(b => b.BId.Equals(id)).Select(b => b.BPrice).FirstOrDefault();

            string InforBook = "Ten Sach: " + Title + "\n" +
                               "Tac Gia:  " + Author + "\n" +
                               "The Loai: " + Cate + "\n" +
                               "Nam XB:   " + Publisher + "\n" +
                               "So Luong: " + Qty + "\n" +
                               "Gia ban:  " + price + "\n";

            ttMain.SetToolTip(picBook, InforBook);
        }
        BookShopDataContext db = new BookShopDataContext();

        int Amount = 0, PriceBook = 0, SumBooks = 0;
        private void AddCart()
        {
            string id = dvBooks.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            //int QtyBook = db.BookTbls.Where(b => b.BId.Equals(id)).Select(b => b.BQty).FirstOrDefault();
            //PriceBook = Amount * QtyBook;
            int Price = 0;
            bool prace = int.TryParse(lbPriceBook.Text, out Price);
            PriceBook = Amount * Price;

            btnBuy.Text = PriceBook.ToString();

            txtAmount.Text = Amount.ToString();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            string id = dvBooks.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            int QtyBook = db.BookTbls.Where(b => b.BId.Equals(id)).Select(b => b.BQty).FirstOrDefault();

            Amount += 1;
            if (Amount >= QtyBook)
            {
                Amount = QtyBook;
                //NotificationHelper.ShowNotification("Bill", "Số lượng sách tối đa", ToolTipIcon.Warning);
            }

            AddCart();
        }

        private void btnMiBook_Click(object sender, EventArgs e)
        {
            Amount -= 1;
            if (Amount < 0)
                Amount = 0;

            AddCart();
        }


        private static string currentDirectory = Directory.GetCurrentDirectory();
        private static string projectRootDirectory = Directory.GetParent(currentDirectory).Parent.FullName;

        private void UpdateImage()
        {

            if (dvBooks.SelectedCells.Count > 0)
            {
                try
                {
                    // Kiểm tra null cho đối tượng trước khi truy cập
                    if (dvBooks.SelectedCells[0].OwningRow.Cells[0] != null)
                    {
                        string id = dvBooks.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

                        // Sử dụng một câu truy vấn duy nhất để lấy dữ liệu từ cơ sở dữ liệu
                        var bookInfo = db.BookTbls
                                        .Where(predicate: p => p.BId.Equals(id))
                                        .Select(p => new { PathImage = p.BImage, Price = p.BPrice })
                                        .FirstOrDefault();

                        if (bookInfo != null)
                        {
                            string pathImage = bookInfo.PathImage;
                            decimal priceBook = bookInfo.Price;
                            // Sử dụng Path.Combine một cách an toàn
                            string pathFolder = Path.Combine(projectRootDirectory, "Images");

                            if (pathImage == null)
                            {
                                // Set một hình ảnh mặc định trong trường hợp có lỗi
                                picBook.Image = Image.FromFile(Path.Combine(pathFolder, "NoImage.png"));
                                picBook.ImageLocation = Path.Combine(pathFolder, "NoImage.png");
                                return;
                            }
                            string fullPath = Path.Combine(pathFolder, pathImage);

                            //lbIdBook.Text = id;
                            //lbPriceBook.Text = priceBook.ToString();

                            try
                            {
                                picBook.Image = Image.FromFile(fullPath);
                            }
                            catch
                            {
                                // Set một hình ảnh mặc định trong trường hợp có lỗi
                                picBook.Image = Image.FromFile(Path.Combine(pathFolder, "NoImage.png"));
                                picBook.ImageLocation = Path.Combine(pathFolder, "NoImage.png");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void ShowBook()
        {
            //dvBooks.DataSource = db.BookTbls;
            //dvBooks.DataSource = db.BookTbls.ToList();
            //// TODO: This line of code loads data into the 'bOOKSHOPSDBDataSet.BookTbl' table. You can move, or remove it, as needed.
            //this.bookTblTableAdapter.Fill(this.bOOKSHOPSDBDataSet.BookTbl);
            dvBooks.DataSource = bookTblBindingSource1;
        }

        static List<CBill> bill = new List<CBill>();
        int SumPriceBooks;
        private void AddBill()
        {
            if (txtAmount.Text == "0")
                return;

            if (dvBooks.SelectedRows.Count > 0)
            {
                int IDBook = dvBooks.SelectedRows[0].Cells[0].Value.ToString() == "" ? 0 : int.Parse(dvBooks.SelectedRows[0].Cells[0].Value.ToString());

                string TitleBook = dvBooks.SelectedRows[0].Cells[1].Value.ToString();
                int Price = int.Parse(dvBooks.SelectedRows[0].Cells[3].Value.ToString());

                CBill BillBook = new CBill(TitleBook, Amount, Price);
                bill.Add(BillBook);
                dvBillBook.DataSource = null;
                dvBillBook.DataSource = bill;

                SumPriceBooks += Price * Amount;
                lbSumPrice.Text = SumPriceBooks.ToString();
            }
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            AddBill();
        }
        private void btnPrintBillBook_Click(object sender, EventArgs e)
        {
            string name = txtClientName.Text;
            if (string.IsNullOrEmpty(txtClientName.Text) || string.IsNullOrEmpty(lbUserName.Text))
            {
                MessageBox.Show("Dữ liệu chưa đầy đủ");
                return;
            }
            //dvBill.DataSource = bsBill
            dvBillBook.DataSource = null;
            PrintBills();
            BillDetails();
            bill.Clear();
            dvBillBook.DataSource = bill;
            ShowBook();
        }



        static int IdBill;
        private void PrintBills()
        {
            BillTbl bill = new BillTbl
            {
                UName = lbUserName.Text,
                ClineName = txtClientName.Text,
                Amount = SumPriceBooks,
                UDate = DateTime.Now
            };

            db.BillTbls.InsertOnSubmit(bill);
            db.SubmitChanges();
            IdBill = bill.BillId;
            NotificationHelper.ShowNotification("Bill", "Bill Saved Successfully", ToolTipIcon.Info);
        }
        //todo: them vao bill roi moi them vao bildetail
        private void BillDetails()
        {
            foreach (var item in bill)
            {
                BillDetailTbl detail = new BillDetailTbl();
                detail.NameBook = item.Name;
                detail.PriceBook = item.Price;
                detail.Quanlity = item.Quantity;
                detail.Total = item.Total;
                detail.IdBill = IdBill;
                db.BillDetailTbls.InsertOnSubmit(detail);
                db.SubmitChanges();

                //So luong sach sau khi khach hang mua
                var Key = db.BookTbls.Where(b => b.BTitle == item.Name).Select(b => b.BId).FirstOrDefault();

                var book = db.BookTbls.Where(b => b.BTitle == item.Name).FirstOrDefault();
                stock = book.BQty;
                int newQty = stock - item.Quantity;

                book.BQty = newQty;
                db.SubmitChanges();
            }
        }


        //Hien thi thong tin sach
        int stock = 0;
        private void bsBill_PositionChanged(object sender, EventArgs e)
        {
            UpdateImage();
            Reset();
        }
        //Thoat Ung Dung
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void bookTblBindingSource1_PositionChanged(object sender, EventArgs e)
        {
            UpdateImage();
            Reset();
        }


        private void btnNextBook_Click(object sender, EventArgs e) => bookTblBindingSource1.MoveNext();

        private void btnFirstBook_Click(object sender, EventArgs e) => bookTblBindingSource1.MoveFirst();

        private void btnPreviousBook_Click(object sender, EventArgs e) => bookTblBindingSource1.MovePrevious();

        private void btnLastBook_Click(object sender, EventArgs e) => bookTblBindingSource1.MoveLast();



        private void Reset()
        {
            txtAmount.Text = "0";
            btnBuy.Text = "0";
            Amount = 0;
            PriceBook = 0;
        }

        private void btnReset_Click(object sender, EventArgs e) => Reset();
    }
}
