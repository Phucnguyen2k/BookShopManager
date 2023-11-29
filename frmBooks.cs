using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmBooks : Form
    {
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        /// <summary>
        /// Phuong Thuc Hien Tool Tip cho cac button
        /// </summary>
        public frmBooks()
        {
            InitializeComponent();
            ShowDataBase();
        }

        ///khoi tao ket noi linQ
        BookShopDataContext db = new BookShopDataContext();

        /// <summary>
        /// phuong thuc dinh dang lai dataview
        /// </summary>
        private void AutoSizeData()
        {
            dvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dvFilterBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dvFilterBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        //tao co cho button sort
        bool sort = true;

        /// <summary>
        /// Phuong Thuc Hien Database bang LinQ to SQL
        /// </summary>
        private void ShowDataBase()
        {
            bindingSourceBooks.DataSource = db.BookTbls.Select(p => new { ID = p.BId, Title = p.BTitle, Author = p.BAuthor, Category = p.BCat, Qty = p.BQty, Year = p.BYear, Price = p.BPrice, Path = p.BImage }).ToList();

            dvBooks.DataSource = bindingSourceBooks;
            dvBooks.Refresh();

            dvFilterBooks.DataSource = db.BookTbls.Select(p => p);

        }

        private static string currentDirectory = Directory.GetCurrentDirectory();
        private static string projectRootDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
        private void frmBooks_Load(object sender, EventArgs e)
        {
            Console.WriteLine(projectRootDirectory);

            //Hien thi du lieu
            ShowDataBase();

            //Dinh dang lai bang
            AutoSizeData();

            //Dua cac the loai sach vao cac combox
            //todo: xoa category
            //foreach (var item in CBooks.Cate)
            //{
            //    cbFilerBook.Items.Add(item);
            //}

            AddCategoryInToCombox();
            //Hien Thong tin toolTip
            ToolTipMain();
            sort = true;
        }
        private void AddCategoryInToCombox()
        {
            //Theo vao data vao combox
            cbCategory.Items.Clear();
            var CategoryBooks = db.CategoryTbls.Select(p => p.Category).ToList();
            cbCategory.Items.AddRange(CategoryBooks.ToArray());
        }

        private void UpdatePosition()
        {
            int index = bindingSourceBooks.Position + 1;
            int cout = bindingSourceBooks.Count;
            txtIDBooks.Text = index.ToString() + "/" + cout.ToString();
        }

        private void bindingSourceBooks_PositionChanged(object sender, EventArgs e)
        {
            ShowPic();
            UpdatePosition();
            //UpdateImage();
        }

        /// <summary>
        /// Them Sach Vao DataView
        /// </summary>
        private void AddBook()
        {
            if (txtTitle.Text == string.Empty ||
                txtAuthor.Text == string.Empty ||
                txtQty.Value == 0 ||
                txtPrice.Value == 0 ||
                picBook.Image == null
                )
            {
                NotificationHelper.ShowNotification("Miss", "Missing Infor Books", ToolTipIcon.Info);
            }
            else
            {
                //load anh tu folder
                //UploadImageBook();

                //string fileName = Path.GetFileName(picBook.ImageLocation);

                BookTbl insert = new BookTbl();

                if (picBook.Image != null)
                {
                    // Lưu hình ảnh
                    MemoryStream stream = new MemoryStream();
                    picBook.Image.Save(stream, ImageFormat.Jpeg);
                    insert.BPic = stream.ToArray();
                }

                //insert.BImage = fileName;
                insert.BTitle = txtTitle.Text;
                insert.BAuthor = txtAuthor.Text;
                insert.BCat = cbCategory.SelectedItem.ToString();
                insert.BQty = Convert.ToInt32(txtQty.Value);
                insert.BPrice = Convert.ToInt32(txtPrice.Value);
                insert.BYear = Convert.ToInt32(mmYear.Value);

                db.BookTbls.InsertOnSubmit(insert); // Chen du lieu vao database
                db.SubmitChanges(); //Luu thay doi vao data base
                NotificationHelper.ShowNotification("Success", "Book Save Successfully", ToolTipIcon.Info);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddBook();
            ShowDataBase();
        }

        private void btnResetBooks_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtQty.Value = 0;
            cbCategory.SelectedIndex = -1;
            txtPrice.Value = 0;
            mmYear.Value = 0;
        }
        /// <summary>
        /// Phuong Thuc Hien Thi Dua lieu tu DataView len cac truong du lieu
        /// </summary>
        private void DisplaySelectedBookDetails()
        {
            txtTitle.DataBindings.Clear();
            txtAuthor.DataBindings.Clear();
            txtQty.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            mmYear.DataBindings.Clear();
            cbCategory.DataBindings.Clear();


            txtTitle.DataBindings.Add("Text", dvBooks.DataSource, "Title");
            txtAuthor.DataBindings.Add("Text", dvBooks.DataSource, "Author");
            txtQty.DataBindings.Add("Value", dvBooks.DataSource, "Qty");
            txtPrice.DataBindings.Add("Value", dvBooks.DataSource, "Price");
            mmYear.DataBindings.Add("Value", dvBooks.DataSource, "Year");
            cbCategory.DataBindings.Add("Text", dvBooks.DataSource, "Category");

            ShowPic();

        }

        private void ShowPic()
        {
            //doc pic tu coso du lieu trong display
            string id = dvBooks.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            int idCheck = Convert.ToInt32(id);
            if (idCheck == idNull)
                return;

            BookTbl book = db.BookTbls.Where(p => p.BId.Equals(id)).FirstOrDefault();
            if (book.BPic != null)
            {
                MemoryStream stream = new MemoryStream(book.BPic.ToArray());
                picBook.Image = Image.FromStream(stream);
            }
            else picBook.Image = null;
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.ShowDialog();
            AddCategoryInToCombox();
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //OpenFilePic();
            AddPic();
        }

        private void AddPic()
        {
            openPicBook.Filter = "JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg";
            DialogResult result = openPicBook.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = openPicBook.FileName;

                if (string.IsNullOrEmpty(file))
                    return;

                Image myImage = Image.FromFile(file);
                picBook.Image = myImage;
            }
        }

        //luu theo duong dan
        private void OpenFilePic()
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.         
            //openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //Your opendialog box title name.
            openPicBook.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openPicBook.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openPicBook.FilterIndex = 1;
            try
            {
                if (openPicBook.ShowDialog() == DialogResult.OK)
                {
                    if (openPicBook.CheckFileExists)
                    {
                        string path = Path.GetFullPath(openPicBook.FileName);
                        //textBox_Path.Text = path;
                        string filename = openPicBook.SafeFileName;

                        //string pathFolder = @"" + Application.StartupPath.ToString() + "\\Images\\" + filename;
                        string pathFolder = Path.Combine(projectRootDirectory, "Images", filename);
                        if (File.Exists(pathFolder))
                        {
                            MessageBox.Show("Vui lòng chọn file khác");
                            return;
                        }
                        picBook.Image = new Bitmap(openPicBook.FileName);
                        picBook.SizeMode = PictureBoxSizeMode.StretchImage;
                        picBook.ImageLocation = openPicBook.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }

        private void UploadImageBook()
        {
            //txtAuthor.Text = dvBooks.SelectedRows[0].Cells[2].Value.ToString();
            if (dvBooks.SelectedCells.Count > 0)
            {
                string nameFile = picBook.ImageLocation;
                string Newfilename = Path.GetFileName(openPicBook.FileName);
                string pathFolder = Path.Combine(projectRootDirectory, "Images", Newfilename);

                //string pathFolder = @"" + Application.StartupPath + "\\Images\\" + Newfilename;

                //todo: sua loi hinh anh form Book
                //if (!File.Exists(pathFolder))
                //    File.Copy(openPicBook.FileName, pathFolder);
            }
            //string NewFileImageBook = Path.GetFileName(picBook.ImageLocation);
        }

        private void DeleteImageBook()
        {
            try
            {
                string id = dvBooks.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();

                var bookInfo = db.BookTbls
                                .Where(p => p.BId.Equals(id))
                                .Select(p => p.BImage)
                                .FirstOrDefault();

                if (bookInfo != null)
                {
                    string fileName = bookInfo;
                    if (fileName == "NoImage.png") return;
                    //string pathFolder = @"" + Application.StartupPath + "\\Images\\" + fileName;
                    string pathFolder = Path.Combine(projectRootDirectory, "Images", fileName);
                    File.Delete(pathFolder);
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void UpdateImage()
        {

            if (dvBooks.SelectedCells.Count > 0)
            {
                // Kiểm tra null cho đối tượng trước khi truy cập
                if (dvBooks.SelectedCells[0].OwningRow.Cells["ID"] != null)
                {
                    string id = dvBooks.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();

                    // Sử dụng một câu truy vấn duy nhất để lấy dữ liệu từ cơ sở dữ liệu
                    var bookInfo = db.BookTbls
                                    .Where(p => p.BId.Equals(id))
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

                        lbIdBook.Text = id;
                        lbPriceBook.Text = priceBook.ToString();

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
        }
        private void dvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e) => DisplaySelectedBookDetails();

        int idNull;
        /// <summary>
        /// Phuong Thuc Xoa Cuon Sach khi chon vao cuon do
        /// </summary>
        private void DeleteBook()
        {
            if (dvBooks.SelectedRows.Count > 0)
            {
                int vitri = bindingSourceBooks.Position;
                //xoa hinh anh trong foler
                //DeleteImageBook();

                //lay id khi nhan vao 1 hang cua bang
                if (dvBooks.SelectedCells[0].OwningRow.Cells[0].Value != null)
                {
                    // Lấy giá trị ID từ ô đầu tiên của dòng đang chọn
                    string id = dvBooks.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();

                    idNull = Convert.ToInt32(id);

                    BookTbl delete = db.BookTbls.Where(p => p.BId.Equals(id)).FirstOrDefault(); // First or Default: lay gia tri dau tien nieu khog thi null

                    db.BookTbls.DeleteOnSubmit(delete);
                    db.SubmitChanges(); //Luu Database sau khi xoa
                }

                vitri -= 1;
                bindingSourceBooks.Position = vitri;
            }
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            DeleteBook();
            ShowDataBase();
        }

        private void EditBook()
        {
            //hien hinh anh tu foloder
            //UploadImageBook();
            // Lấy giá trị ID từ ô đầu tiên của dòng đang chọn
            string id = dvBooks.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();


            BookTbl edit = db.BookTbls.Where(p => p.BId.Equals(id)).FirstOrDefault(); // First or Default: lay gia tri dau tien nieu khog thi null

            string Newfilename = Path.GetFileName(openPicBook.FileName);

            MemoryStream stream = new MemoryStream();
            picBook.Image.Save(stream, ImageFormat.Jpeg);
            edit.BPic = stream.ToArray();

            //edit.BImage = Newfilename;
            edit.BTitle = txtTitle.Text;
            edit.BAuthor = txtAuthor.Text;
            if (cbCategory.SelectedItem != null)
            {
                edit.BCat = cbCategory.SelectedItem.ToString();
            }
            edit.BQty = Convert.ToInt32(txtQty.Value);
            edit.BPrice = Convert.ToInt32(txtPrice.Value);
            edit.BYear = Convert.ToInt32(mmYear.Value);

            db.SubmitChanges(); //Luu Database sau khi xoa
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditBook();
            ShowDataBase();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e) => ShowDataBase();

        private void btnRefershBooks_Click(object sender, EventArgs e)
        {
            ShowDataBase();
            sort = true;
            btnSortBook.Text = "Az";
        }

        /// <summary>
        /// Phuong Thuc Tim Sach
        /// </summary>
        private void SearchBook()
        {
            if (cbFieldSearchBook.SelectedItem != null && !string.IsNullOrEmpty(txtSearchBox.Text))
            {
                string selectedValue = cbFieldSearchBook.SelectedItem.ToString();
                switch (selectedValue)
                {
                    case "ID":
                        dvFilterBooks.DataSource = db.BookTbls.Where(p => p.BId.Equals(txtSearchBox.Text)).ToList();
                        break;
                    case "Title":
                        dvFilterBooks.DataSource = db.BookTbls.Where(p => p.BTitle.Equals(txtSearchBox.Text)).ToList();
                        break;
                    case "Author":
                        dvFilterBooks.DataSource = db.BookTbls.Where(p => p.BAuthor.Equals(txtSearchBox.Text)).ToList();
                        break;
                    case "Qty":
                        dvFilterBooks.DataSource = db.BookTbls.Where(p => p.BQty.Equals(txtSearchBox.Text)).ToList();
                        break;
                    case "Price":
                        dvFilterBooks.DataSource = db.BookTbls.Where(p => p.BPrice.Equals(txtSearchBox.Text)).ToList();
                        break;
                    case "Year":
                        dvFilterBooks.DataSource = db.BookTbls.Where(p => p.BYear.Equals(txtSearchBox.Text)).ToList();
                        break;
                    default:
                        NotificationHelper.ShowNotification("Error", "Book Not Found", ToolTipIcon.Error);
                        break;
                }

                return;
            }
            NotificationHelper.ShowNotification("Error", "Book Not Found", ToolTipIcon.Error);
        }

        private void cbFieldSearchBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectedComboBox = (ComboBox)sender;
        }

        private void btnSearch_Click(object sender, EventArgs e) => SearchBook();

        /// <summary>
        /// Phuong Thuc Loc Sach Theo Gia
        /// </summary>
        private void FilterPriceBook()
        {
            int min = Convert.ToInt32(mmToPrice.Value);
            int max = Convert.ToInt32(mmFromPrice.Value);

            dvFilterBooks.DataSource = db.BookTbls.Where(pv => pv.BPrice >= min && pv.BPrice <= max).ToList();
        }

        /// <summary>
        /// Phuong Thuc Loc Sach Theo So Luong
        /// </summary>
        private void FilterAmountBook()
        {
            int min = Convert.ToInt32(mmToAmount.Value);
            int max = Convert.ToInt32(mmFromAmount.Value);

            dvFilterBooks.DataSource = db.BookTbls.Where(pv => pv.BQty >= min && pv.BQty <= max).ToList();
        }

        /// <summary>
        /// Ham Loc Sach Theo The loai
        /// </summary>
        private void FilterCategory()
        {
            if (cbFilerBook.SelectedItem == "All")
            {
                //populate();
                ShowDataBase();
                return;
            }
            string cate = cbFilerBook.SelectedItem.ToString();
            dvFilterBooks.DataSource = db.BookTbls.Where(p => p.BCat.Equals(cate));
        }

        private void cbFilerBooka_SelectedIndexChanged(object sender, EventArgs e) => FilterCategory();

        private void btnFilterPriceBooks_Click(object sender, EventArgs e) => FilterPriceBook();

        private void btnFilterAmountBooks_Click(object sender, EventArgs e) => FilterAmountBook();

        //Xap xep sach theo tung danh muc
        private void btnSortBook_Click(object sender, EventArgs e)
        {
            if (sort)
            {
                btnSortBook.Text = "Za";
                sort = false;
            }
            else
            {
                btnSortBook.Text = "Az";
                sort = true;
            }
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            if (sort)
                dvFilterBooks.DataSource = db.BookTbls.OrderBy(p => p.BId).ToList();
            else
                dvFilterBooks.DataSource = db.BookTbls.OrderByDescending(p => p.BId).ToList();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            if (sort)
                dvFilterBooks.DataSource = db.BookTbls.OrderBy(p => p.BTitle).ToList();
            else
                dvFilterBooks.DataSource = db.BookTbls.OrderByDescending(p => p.BTitle).ToList();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            if (sort)
                dvFilterBooks.DataSource = db.BookTbls.OrderBy(p => p.BAuthor).ToList();
            else
                dvFilterBooks.DataSource = db.BookTbls.OrderByDescending(p => p.BAuthor).ToList();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (sort)
                dvFilterBooks.DataSource = db.BookTbls.OrderBy(p => p.BCat).ToList();
            else
                dvFilterBooks.DataSource = db.BookTbls.OrderByDescending(p => p.BCat).ToList();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            if (sort)
                dvFilterBooks.DataSource = db.BookTbls.OrderBy(p => p.BYear).ToList();
            else
                dvFilterBooks.DataSource = db.BookTbls.OrderByDescending(p => p.BYear).ToList();
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            if (sort)
                dvFilterBooks.DataSource = db.BookTbls.OrderBy(p => p.BQty).ToList();
            else
                dvFilterBooks.DataSource = db.BookTbls.OrderByDescending(p => p.BQty).ToList();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            if (sort)
                dvFilterBooks.DataSource = db.BookTbls.OrderBy(p => p.BPrice).ToList();
            else
                dvFilterBooks.DataSource = db.BookTbls.OrderByDescending(p => p.BPrice).ToList();
        }

        //Hien Chu Thich Khi Re Chuot Vao Cac Button
        private void ToolTipMain()
        {
            ttMain.SetToolTip(btnSearch, "Search");
            ttMain.SetToolTip(btnRefershBooks, "Refresh");
            ttMain.SetToolTip(btnFilterAmountBooks, "Loc Sach theo So luong");
            ttMain.SetToolTip(btnFilterPriceBooks, "Loc Sach Theo Gia");

            if (sort)
                ttMain.SetToolTip(btnSortBook, "Sap Xep Tang Dan");
            else
                ttMain.SetToolTip(btnSortBook, "Sap Xep Giam Dan");

            ttMain.SetToolTip(btnID, "Sap Xep Theo ID");
            ttMain.SetToolTip(btnTitle, "Sap Xep Theo Ten Sach");
            ttMain.SetToolTip(btnAuthor, "Sap Xep Theo Tac Gia");
            ttMain.SetToolTip(btnCategory, "Sap Xep Theo The Loai");
            ttMain.SetToolTip(btnYear, "Sap Xep Theo Nam");
            ttMain.SetToolTip(btnPrice, "Sap Xep Theo Gia");
            ttMain.SetToolTip(btnQty, "Sap Xep Theo So Luong");
            ttMain.SetToolTip(cbFieldSearchBook, "Loc Sach theo...");
            ttMain.SetToolTip(txtSearchBox, "Tim Kiem Sach");
        }
        //Hien form Users
        private void label6_Click(object sender, EventArgs e)
        {
            //frmUsers obj = new frmUsers();
            //obj.Show();
            //this.Hide();
        }

        //Hien form Dashboard
        private void label7_Click(object sender, EventArgs e)
        {
            frmDashboard obj = new frmDashboard();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        //Navigation book
        private void btnNextBook_Click(object sender, EventArgs e) => bindingSourceBooks.MoveNext();

        private void btnLastBook_Click(object sender, EventArgs e) => bindingSourceBooks.MoveLast();

        private void btnPreviousBook_Click(object sender, EventArgs e) => bindingSourceBooks.MovePrevious();

        private void btnFirstBook_Click(object sender, EventArgs e) => bindingSourceBooks.MoveFirst();

    }
}
