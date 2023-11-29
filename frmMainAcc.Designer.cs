namespace BookShopManager
{
    partial class frmMainAcc
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
            System.Windows.Forms.Label lbAdmin;
            System.Windows.Forms.Label uIdLabel;
            System.Windows.Forms.Label uNameLabel;
            System.Windows.Forms.Label uPhoneLabel;
            System.Windows.Forms.Label uAddLabel;
            System.Windows.Forms.Label uPassLabel;
            System.Windows.Forms.Label uYobLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIDBooks = new System.Windows.Forms.TextBox();
            this.btnNextBook = new System.Windows.Forms.Button();
            this.btnLastBook = new System.Windows.Forms.Button();
            this.btnFirstBook = new System.Windows.Forms.Button();
            this.btnPreviousBook = new System.Windows.Forms.Button();
            this.tcbAdmin = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dtpYob = new System.Windows.Forms.DateTimePicker();
            this.dvAcc = new System.Windows.Forms.DataGridView();
            this.bsAcc = new System.Windows.Forms.BindingSource(this.components);
            this.picAcc = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.openPicBook = new System.Windows.Forms.OpenFileDialog();
            lbAdmin = new System.Windows.Forms.Label();
            uIdLabel = new System.Windows.Forms.Label();
            uNameLabel = new System.Windows.Forms.Label();
            uPhoneLabel = new System.Windows.Forms.Label();
            uAddLabel = new System.Windows.Forms.Label();
            uPassLabel = new System.Windows.Forms.Label();
            uYobLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbAdmin.Location = new System.Drawing.Point(410, 204);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new System.Drawing.Size(36, 16);
            lbAdmin.TabIndex = 27;
            lbAdmin.Text = "Type:";
            // 
            // uIdLabel
            // 
            uIdLabel.AutoSize = true;
            uIdLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uIdLabel.Location = new System.Drawing.Point(242, 77);
            uIdLabel.Name = "uIdLabel";
            uIdLabel.Size = new System.Drawing.Size(21, 16);
            uIdLabel.TabIndex = 15;
            uIdLabel.Text = "ID:";
            // 
            // uNameLabel
            // 
            uNameLabel.AutoSize = true;
            uNameLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uNameLabel.Location = new System.Drawing.Point(228, 127);
            uNameLabel.Name = "uNameLabel";
            uNameLabel.Size = new System.Drawing.Size(35, 16);
            uNameLabel.TabIndex = 17;
            uNameLabel.Text = "User: ";
            // 
            // uPhoneLabel
            // 
            uPhoneLabel.AutoSize = true;
            uPhoneLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uPhoneLabel.Location = new System.Drawing.Point(218, 167);
            uPhoneLabel.Name = "uPhoneLabel";
            uPhoneLabel.Size = new System.Drawing.Size(45, 16);
            uPhoneLabel.TabIndex = 19;
            uPhoneLabel.Text = "Phone:";
            // 
            // uAddLabel
            // 
            uAddLabel.AutoSize = true;
            uAddLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uAddLabel.Location = new System.Drawing.Point(396, 79);
            uAddLabel.Name = "uAddLabel";
            uAddLabel.Size = new System.Drawing.Size(50, 16);
            uAddLabel.TabIndex = 21;
            uAddLabel.Text = "Địa chỉ:";
            // 
            // uPassLabel
            // 
            uPassLabel.AutoSize = true;
            uPassLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uPassLabel.Location = new System.Drawing.Point(385, 126);
            uPassLabel.Name = "uPassLabel";
            uPassLabel.Size = new System.Drawing.Size(61, 16);
            uPassLabel.TabIndex = 23;
            uPassLabel.Text = "Password:";
            // 
            // uYobLabel
            // 
            uYobLabel.AutoSize = true;
            uYobLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uYobLabel.Location = new System.Drawing.Point(385, 167);
            uYobLabel.Name = "uYobLabel";
            uYobLabel.Size = new System.Drawing.Size(61, 16);
            uYobLabel.TabIndex = 25;
            uYobLabel.Text = "Năm Sinh:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowser);
            this.splitContainer1.Panel1.Controls.Add(this.picAcc);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtIDBooks);
            this.splitContainer1.Panel1.Controls.Add(this.btnNextBook);
            this.splitContainer1.Panel1.Controls.Add(this.btnLastBook);
            this.splitContainer1.Panel1.Controls.Add(this.btnFirstBook);
            this.splitContainer1.Panel1.Controls.Add(this.btnPreviousBook);
            this.splitContainer1.Panel1.Controls.Add(lbAdmin);
            this.splitContainer1.Panel1.Controls.Add(this.tcbAdmin);
            this.splitContainer1.Panel1.Controls.Add(uIdLabel);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(uNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.txtUser);
            this.splitContainer1.Panel1.Controls.Add(uPhoneLabel);
            this.splitContainer1.Panel1.Controls.Add(this.txtPhone);
            this.splitContainer1.Panel1.Controls.Add(uAddLabel);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddress);
            this.splitContainer1.Panel1.Controls.Add(uPassLabel);
            this.splitContainer1.Panel1.Controls.Add(this.txtPassword);
            this.splitContainer1.Panel1.Controls.Add(uYobLabel);
            this.splitContainer1.Panel1.Controls.Add(this.dtpYob);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dvAcc);
            this.splitContainer1.Size = new System.Drawing.Size(907, 645);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelet);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(597, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 172);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnDelet
            // 
            this.btnDelet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelet.Location = new System.Drawing.Point(157, 35);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(112, 44);
            this.btnDelet.TabIndex = 34;
            this.btnDelet.Text = "Deletel";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(157, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 44);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(15, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 44);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(15, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 44);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtIDBooks
            // 
            this.txtIDBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDBooks.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBooks.Location = new System.Drawing.Point(103, 20);
            this.txtIDBooks.Name = "txtIDBooks";
            this.txtIDBooks.Size = new System.Drawing.Size(65, 22);
            this.txtIDBooks.TabIndex = 33;
            this.txtIDBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNextBook
            // 
            this.btnNextBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBook.Location = new System.Drawing.Point(174, 12);
            this.btnNextBook.Name = "btnNextBook";
            this.btnNextBook.Size = new System.Drawing.Size(30, 30);
            this.btnNextBook.TabIndex = 29;
            this.btnNextBook.Text = ">";
            this.btnNextBook.UseVisualStyleBackColor = true;
            this.btnNextBook.Click += new System.EventHandler(this.btnNextBook_Click);
            // 
            // btnLastBook
            // 
            this.btnLastBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastBook.Location = new System.Drawing.Point(210, 12);
            this.btnLastBook.Name = "btnLastBook";
            this.btnLastBook.Size = new System.Drawing.Size(45, 30);
            this.btnLastBook.TabIndex = 30;
            this.btnLastBook.Text = ">>";
            this.btnLastBook.UseVisualStyleBackColor = true;
            this.btnLastBook.Click += new System.EventHandler(this.btnLastBook_Click);
            // 
            // btnFirstBook
            // 
            this.btnFirstBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstBook.Location = new System.Drawing.Point(12, 12);
            this.btnFirstBook.Name = "btnFirstBook";
            this.btnFirstBook.Size = new System.Drawing.Size(46, 30);
            this.btnFirstBook.TabIndex = 31;
            this.btnFirstBook.Text = "<<";
            this.btnFirstBook.UseVisualStyleBackColor = true;
            this.btnFirstBook.Click += new System.EventHandler(this.btnFirstBook_Click);
            // 
            // btnPreviousBook
            // 
            this.btnPreviousBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousBook.Location = new System.Drawing.Point(64, 12);
            this.btnPreviousBook.Name = "btnPreviousBook";
            this.btnPreviousBook.Size = new System.Drawing.Size(30, 30);
            this.btnPreviousBook.TabIndex = 32;
            this.btnPreviousBook.Text = "<";
            this.btnPreviousBook.UseVisualStyleBackColor = true;
            this.btnPreviousBook.Click += new System.EventHandler(this.btnPreviousBook_Click);
            // 
            // tcbAdmin
            // 
            this.tcbAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcbAdmin.Location = new System.Drawing.Point(465, 201);
            this.tcbAdmin.Name = "tcbAdmin";
            this.tcbAdmin.Size = new System.Drawing.Size(104, 24);
            this.tcbAdmin.TabIndex = 28;
            this.tcbAdmin.Text = "Admin";
            this.tcbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(281, 74);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(93, 21);
            this.txtID.TabIndex = 16;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(281, 123);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(93, 21);
            this.txtUser.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(281, 164);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(93, 21);
            this.txtPhone.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(452, 76);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(117, 21);
            this.txtAddress.TabIndex = 22;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(452, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(117, 21);
            this.txtPassword.TabIndex = 24;
            // 
            // dtpYob
            // 
            this.dtpYob.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYob.Location = new System.Drawing.Point(452, 162);
            this.dtpYob.Name = "dtpYob";
            this.dtpYob.Size = new System.Drawing.Size(117, 21);
            this.dtpYob.TabIndex = 26;
            // 
            // dvAcc
            // 
            this.dvAcc.BackgroundColor = System.Drawing.Color.White;
            this.dvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAcc.Location = new System.Drawing.Point(12, 12);
            this.dvAcc.MultiSelect = false;
            this.dvAcc.Name = "dvAcc";
            this.dvAcc.ReadOnly = true;
            this.dvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvAcc.Size = new System.Drawing.Size(883, 403);
            this.dvAcc.TabIndex = 0;
            // 
            // bsAcc
            // 
            this.bsAcc.PositionChanged += new System.EventHandler(this.bsAcc_PositionChanged);
            // 
            // picAcc
            // 
            this.picAcc.Location = new System.Drawing.Point(39, 70);
            this.picAcc.Name = "picAcc";
            this.picAcc.Size = new System.Drawing.Size(129, 113);
            this.picAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcc.TabIndex = 36;
            this.picAcc.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(210, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 172);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // btnBrowser
            // 
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.Location = new System.Drawing.Point(39, 197);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(129, 28);
            this.btnBrowser.TabIndex = 38;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // openPicBook
            // 
            this.openPicBook.FileName = "openFileDialog1";
            // 
            // frmMainAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 645);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainAcc";
            this.Load += new System.EventHandler(this.frmMainAcc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dvAcc;
        private System.Windows.Forms.CheckBox tcbAdmin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DateTimePicker dtpYob;
        private System.Windows.Forms.TextBox txtIDBooks;
        private System.Windows.Forms.Button btnNextBook;
        private System.Windows.Forms.Button btnLastBook;
        private System.Windows.Forms.Button btnFirstBook;
        private System.Windows.Forms.Button btnPreviousBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bsAcc;
        private System.Windows.Forms.PictureBox picAcc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.OpenFileDialog openPicBook;
    }
}