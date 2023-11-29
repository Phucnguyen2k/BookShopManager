﻿namespace BookShopManager
{
    partial class frmBillInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillInfo));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnNextBook = new System.Windows.Forms.Button();
            this.btnLastBook = new System.Windows.Forms.Button();
            this.btnFirstBook = new System.Windows.Forms.Button();
            this.btnPreviousBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lbPriceBook = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.txtIDBooks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvBillBook = new System.Windows.Forms.DataGridView();
            this.btnPrintBillBook = new System.Windows.Forms.Button();
            this.lbSumPrice = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dvBooks = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBookView = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnMiBook = new System.Windows.Forms.Button();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsBill = new System.Windows.Forms.BindingSource(this.components);
            this.tbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBillBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbBookView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1050, 594);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Black;
            this.lbUserName.Location = new System.Drawing.Point(56, 23);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(124, 27);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "UserName";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(409, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(138, 27);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Book Shop";
            // 
            // btnNextBook
            // 
            this.btnNextBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBook.Location = new System.Drawing.Point(176, 63);
            this.btnNextBook.Name = "btnNextBook";
            this.btnNextBook.Size = new System.Drawing.Size(30, 30);
            this.btnNextBook.TabIndex = 57;
            this.btnNextBook.Text = ">";
            this.ttMain.SetToolTip(this.btnNextBook, "Tiếp Theo");
            this.btnNextBook.UseVisualStyleBackColor = true;
            this.btnNextBook.Click += new System.EventHandler(this.btnNextBook_Click);
            // 
            // btnLastBook
            // 
            this.btnLastBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastBook.Location = new System.Drawing.Point(212, 63);
            this.btnLastBook.Name = "btnLastBook";
            this.btnLastBook.Size = new System.Drawing.Size(45, 30);
            this.btnLastBook.TabIndex = 58;
            this.btnLastBook.Text = ">>";
            this.ttMain.SetToolTip(this.btnLastBook, "Cuối Cùng");
            this.btnLastBook.UseVisualStyleBackColor = true;
            this.btnLastBook.Click += new System.EventHandler(this.btnLastBook_Click);
            // 
            // btnFirstBook
            // 
            this.btnFirstBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstBook.Location = new System.Drawing.Point(20, 63);
            this.btnFirstBook.Name = "btnFirstBook";
            this.btnFirstBook.Size = new System.Drawing.Size(46, 30);
            this.btnFirstBook.TabIndex = 59;
            this.btnFirstBook.Text = "<<";
            this.ttMain.SetToolTip(this.btnFirstBook, "Đầu Tiên");
            this.btnFirstBook.UseVisualStyleBackColor = true;
            this.btnFirstBook.Click += new System.EventHandler(this.btnFirstBook_Click);
            // 
            // btnPreviousBook
            // 
            this.btnPreviousBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousBook.Location = new System.Drawing.Point(72, 63);
            this.btnPreviousBook.Name = "btnPreviousBook";
            this.btnPreviousBook.Size = new System.Drawing.Size(30, 30);
            this.btnPreviousBook.TabIndex = 60;
            this.btnPreviousBook.Text = "<";
            this.ttMain.SetToolTip(this.btnPreviousBook, "Về Trước");
            this.btnPreviousBook.UseVisualStyleBackColor = true;
            this.btnPreviousBook.Click += new System.EventHandler(this.btnPreviousBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(192, 271);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(30, 30);
            this.btnAddBook.TabIndex = 56;
            this.btnAddBook.Text = "+";
            this.ttMain.SetToolTip(this.btnAddBook, "Thêm Sách Vào Giỏ Hàng");
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1045, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.ttMain.SetToolTip(this.btnExit, "Close");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Image = global::BookShopManager.Properties.Resources.shopping_cart_FILL0_wght400_GRAD0_opsz24;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(14, 307);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(208, 34);
            this.btnBuy.TabIndex = 56;
            this.btnBuy.Text = "Buy";
            this.ttMain.SetToolTip(this.btnBuy, "Thêm Vào Giỏ Hàng");
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lbPriceBook
            // 
            this.lbPriceBook.BackColor = System.Drawing.Color.Red;
            this.lbPriceBook.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceBook.Image = global::BookShopManager.Properties.Resources.attach_money_FILL0_wght400_GRAD0_opsz24;
            this.lbPriceBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPriceBook.Location = new System.Drawing.Point(170, 242);
            this.lbPriceBook.Name = "lbPriceBook";
            this.lbPriceBook.Size = new System.Drawing.Size(52, 23);
            this.lbPriceBook.TabIndex = 55;
            this.lbPriceBook.Text = "label5";
            this.lbPriceBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttMain.SetToolTip(this.lbPriceBook, "Giá Tiền Của Cuốn Sách");
            // 
            // tbInfo
            // 
            this.tbInfo.AutoScroll = true;
            this.tbInfo.Controls.Add(this.txtIDBooks);
            this.tbInfo.Controls.Add(this.label1);
            this.tbInfo.Controls.Add(this.txtClientName);
            this.tbInfo.Controls.Add(this.groupBox1);
            this.tbInfo.Controls.Add(this.btnNextBook);
            this.tbInfo.Controls.Add(this.btnLastBook);
            this.tbInfo.Controls.Add(this.btnFirstBook);
            this.tbInfo.Controls.Add(this.btnPreviousBook);
            this.tbInfo.Controls.Add(this.dvBooks);
            this.tbInfo.Controls.Add(this.pictureBox3);
            this.tbInfo.Controls.Add(this.label2);
            this.tbInfo.Controls.Add(this.gbBookView);
            this.tbInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(4, 26);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfo.Size = new System.Drawing.Size(1050, 594);
            this.tbInfo.TabIndex = 1;
            this.tbInfo.Text = "Info";
            this.tbInfo.UseVisualStyleBackColor = true;
            // 
            // txtIDBooks
            // 
            this.txtIDBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDBooks.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBooks.Location = new System.Drawing.Point(108, 71);
            this.txtIDBooks.Name = "txtIDBooks";
            this.txtIDBooks.Size = new System.Drawing.Size(65, 22);
            this.txtIDBooks.TabIndex = 64;
            this.txtIDBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Khách Hàng";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(125, 22);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 25);
            this.txtClientName.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvBillBook);
            this.groupBox1.Controls.Add(this.btnPrintBillBook);
            this.groupBox1.Controls.Add(this.lbSumPrice);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Location = new System.Drawing.Point(315, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 263);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill";
            // 
            // dvBillBook
            // 
            this.dvBillBook.BackgroundColor = System.Drawing.Color.White;
            this.dvBillBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBillBook.Location = new System.Drawing.Point(6, 24);
            this.dvBillBook.MultiSelect = false;
            this.dvBillBook.Name = "dvBillBook";
            this.dvBillBook.ReadOnly = true;
            this.dvBillBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBillBook.Size = new System.Drawing.Size(518, 150);
            this.dvBillBook.TabIndex = 51;
            // 
            // btnPrintBillBook
            // 
            this.btnPrintBillBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBillBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBillBook.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBillBook.Image")));
            this.btnPrintBillBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintBillBook.Location = new System.Drawing.Point(238, 201);
            this.btnPrintBillBook.Name = "btnPrintBillBook";
            this.btnPrintBillBook.Size = new System.Drawing.Size(107, 34);
            this.btnPrintBillBook.TabIndex = 50;
            this.btnPrintBillBook.Text = "Print";
            this.btnPrintBillBook.UseVisualStyleBackColor = true;
            this.btnPrintBillBook.Click += new System.EventHandler(this.btnPrintBillBook_Click);
            // 
            // lbSumPrice
            // 
            this.lbSumPrice.AutoSize = true;
            this.lbSumPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbSumPrice.Location = new System.Drawing.Point(351, 208);
            this.lbSumPrice.Name = "lbSumPrice";
            this.lbSumPrice.Size = new System.Drawing.Size(44, 21);
            this.lbSumPrice.TabIndex = 49;
            this.lbSumPrice.Text = "Sum";
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(186, 171);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(209, 27);
            this.lbTotal.TabIndex = 48;
            this.lbTotal.Text = "Total";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvBooks
            // 
            this.dvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBooks.GridColor = System.Drawing.Color.White;
            this.dvBooks.Location = new System.Drawing.Point(315, 63);
            this.dvBooks.MultiSelect = false;
            this.dvBooks.Name = "dvBooks";
            this.dvBooks.ReadOnly = true;
            this.dvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvBooks.RowHeadersWidth = 51;
            this.dvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBooks.Size = new System.Drawing.Size(702, 220);
            this.dvBooks.TabIndex = 50;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(542, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(588, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Book List";
            // 
            // gbBookView
            // 
            this.gbBookView.Controls.Add(this.txtAmount);
            this.gbBookView.Controls.Add(this.btnMiBook);
            this.gbBookView.Controls.Add(this.btnAddBook);
            this.gbBookView.Controls.Add(this.btnBuy);
            this.gbBookView.Controls.Add(this.lbPriceBook);
            this.gbBookView.Controls.Add(this.picBook);
            this.gbBookView.Location = new System.Drawing.Point(20, 109);
            this.gbBookView.Name = "gbBookView";
            this.gbBookView.Size = new System.Drawing.Size(234, 353);
            this.gbBookView.TabIndex = 56;
            this.gbBookView.TabStop = false;
            this.gbBookView.Text = "Book";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(52, 271);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(134, 30);
            this.txtAmount.TabIndex = 57;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMiBook
            // 
            this.btnMiBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMiBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiBook.Location = new System.Drawing.Point(14, 271);
            this.btnMiBook.Name = "btnMiBook";
            this.btnMiBook.Size = new System.Drawing.Size(30, 30);
            this.btnMiBook.TabIndex = 56;
            this.btnMiBook.Text = "-";
            this.btnMiBook.UseVisualStyleBackColor = true;
            this.btnMiBook.Click += new System.EventHandler(this.btnMiBook_Click);
            // 
            // picBook
            // 
            this.picBook.Location = new System.Drawing.Point(14, 20);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(208, 245);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBook.TabIndex = 54;
            this.picBook.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.picUser);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Location = new System.Drawing.Point(193, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 683);
            this.panel2.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbInfo);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 624);
            this.tabControl1.TabIndex = 14;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(7, 13);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(43, 37);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 680);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 640);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(0, 640);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(189, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "Logout";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 62);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bsBill
            // 
            this.bsBill.PositionChanged += new System.EventHandler(this.bsBill_PositionChanged);
            // 
            // frmBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBillInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBillInfo";
            this.Load += new System.EventHandler(this.frmBillInfo_Load);
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBillBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbBookView.ResumeLayout(false);
            this.gbBookView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.Button btnNextBook;
        private System.Windows.Forms.Button btnLastBook;
        private System.Windows.Forms.Button btnFirstBook;
        private System.Windows.Forms.Button btnPreviousBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lbPriceBook;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvBillBook;
        private System.Windows.Forms.Button btnPrintBillBook;
        private System.Windows.Forms.Label lbSumPrice;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridView dvBooks;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBookView;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnMiBook;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.BindingSource bsBill;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDBooks;
    }
}