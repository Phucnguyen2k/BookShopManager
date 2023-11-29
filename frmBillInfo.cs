using BookShopManager.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmBillInfo : Form
    {
        public frmBillInfo()
        {
            InitializeComponent();
        }
        BookShopDataContext db = new BookShopDataContext();

        private void frmBillInfo_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        private void FormLoad()
        {
            bsBill.DataSource = db.BookTbls
                .Select(b => new { ID = b.BId, Title = b.BTitle, Qty = b.BQty, Price = b.BPrice })
                .ToList();

            dvBooks.DataSource = bsBill;
            dvBooks.Columns[0].Width = 50;
            dvBooks.Columns[1].Width = 300;
            dvBooks.Columns[2].Width = 50;
            dvBooks.Columns[3].Width = 50;

            lbUserName.Text = frmLogin.UserName;

            //todo: load hinh anh
            //UpdateImage();
            ShowPic();
            ShowAvatar();

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
        int Amount = 0, PriceBook = 0, SumBooks = 0;
        private void AddCart()
        {
            string id = dvBooks.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
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

        private void ShowBook()
        {
            bsBill.DataSource = db.BookTbls
                .Select(b => new { ID = b.BId, Title = b.BTitle, Qty = b.BQty, Price = b.BPrice })
                .ToList();
            dvBooks.DataSource = bsBill;
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

                CBill existingBill = bill.FirstOrDefault(b => b.Name == TitleBook);

                if (existingBill != null)
                {
                    // Đối tượng CBill đã tồn tại trong danh sách, cập nhật giá và số lượng
                    existingBill.Quantity += Amount;
                    existingBill.Price = Price;
                }
                else
                {
                    // Đối tượng CBill chưa tồn tại trong danh sách, thêm mới
                    CBill BillBook = new CBill(TitleBook, Amount, Price);
                    bill.Add(BillBook);
                }
                dvBillBook.DataSource = null;
                dvBillBook.DataSource = bill;

                SumPriceBooks += Price * Amount;
                //lbSumPrice.Text = SumPriceBooks.ToString();
                btnPrintBillBook.Text = SumPriceBooks.ToString();
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
        //Hien thi thong tin sach
        int stock = 0;
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


        private void bsBill_PositionChanged(object sender, EventArgs e)
        {
            //UpdateImage();
            ShowPic();

            Reset();
            lbPriceBook.DataBindings.Clear();
            lbPriceBook.DataBindings.Add("Text", dvBooks.DataSource, "Price");

            UpdatePosition();
        }
        private void UpdatePosition()
        {
            int index = bsBill.Position + 1;
            int count = bsBill.Count;
            txtIDBooks.Text = $"{index}/{count}";
        }
        private void Reset()
        {
            txtAmount.Text = "0";
            btnBuy.Text = "0";
            Amount = 0;
            PriceBook = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private static string currentDirectory = Directory.GetCurrentDirectory();
        private string projectRootDirectory = Directory.GetParent(currentDirectory).Parent.FullName;

        private void ShowAvatar()
        {
            string name = lbUserName.Text;
            UserTbl user = db.UserTbls.Where(u => u.UName.Equals(name)).FirstOrDefault();
            if (user.UAvatar != null)
            {
                MemoryStream stream = new MemoryStream(user.UAvatar.ToArray());
                picUser.Image = Image.FromStream(stream);
            }
        }
        private void ShowPic()
        {
            if (dvBooks.SelectedCells.Count == 0)
                return;
            //doc pic tu coso du lieu trong display
            string id = dvBooks.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            BookTbl book = db.BookTbls.Where(p => p.BId.Equals(id)).FirstOrDefault();
            if (book.BPic != null)
            {
                MemoryStream stream = new MemoryStream(book.BPic.ToArray());
                picBook.Image = Image.FromStream(stream);
            }
        }
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

        private void btnLastBook_Click(object sender, EventArgs e) => bsBill.MoveLast();

        private void btnPreviousBook_Click(object sender, EventArgs e) => bsBill.MovePrevious();

        private void btnNextBook_Click(object sender, EventArgs e) => bsBill.MoveNext();

        private void btnFirstBook_Click(object sender, EventArgs e) => bsBill.MoveFirst();

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

    }
}
