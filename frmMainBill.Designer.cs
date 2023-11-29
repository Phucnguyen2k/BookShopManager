namespace BookShopManager
{
    partial class frmMainBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainBill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvBill = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvBillDetail = new System.Windows.Forms.DataGridView();
            this.bsBill = new System.Windows.Forms.BindingSource(this.components);
            this.bsBillDetail = new System.Windows.Forms.BindingSource(this.components);
            this.txtIDBill = new System.Windows.Forms.TextBox();
            this.btnNextBook = new System.Windows.Forms.Button();
            this.btnLastBook = new System.Windows.Forms.Button();
            this.btnFirstBook = new System.Windows.Forms.Button();
            this.btnPreviousBook = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBill)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBillDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBillDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvBill);
            this.groupBox1.Location = new System.Drawing.Point(26, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // dvBill
            // 
            this.dvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvBill.BackgroundColor = System.Drawing.Color.White;
            this.dvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBill.GridColor = System.Drawing.Color.White;
            this.dvBill.Location = new System.Drawing.Point(6, 22);
            this.dvBill.MultiSelect = false;
            this.dvBill.Name = "dvBill";
            this.dvBill.ReadOnly = true;
            this.dvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBill.Size = new System.Drawing.Size(601, 271);
            this.dvBill.TabIndex = 0;
            this.dvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvBill_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvBillDetail);
            this.groupBox2.Location = new System.Drawing.Point(26, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 272);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // dvBillDetail
            // 
            this.dvBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvBillDetail.BackgroundColor = System.Drawing.Color.White;
            this.dvBillDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBillDetail.GridColor = System.Drawing.Color.White;
            this.dvBillDetail.Location = new System.Drawing.Point(3, 19);
            this.dvBillDetail.MultiSelect = false;
            this.dvBillDetail.Name = "dvBillDetail";
            this.dvBillDetail.ReadOnly = true;
            this.dvBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBillDetail.Size = new System.Drawing.Size(841, 250);
            this.dvBillDetail.TabIndex = 0;
            // 
            // bsBill
            // 
            this.bsBill.PositionChanged += new System.EventHandler(this.bsBill_PositionChanged);
            // 
            // txtIDBill
            // 
            this.txtIDBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDBill.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBill.Location = new System.Drawing.Point(117, 48);
            this.txtIDBill.Name = "txtIDBill";
            this.txtIDBill.Size = new System.Drawing.Size(65, 22);
            this.txtIDBill.TabIndex = 20;
            this.txtIDBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNextBook
            // 
            this.btnNextBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBook.Location = new System.Drawing.Point(188, 40);
            this.btnNextBook.Name = "btnNextBook";
            this.btnNextBook.Size = new System.Drawing.Size(30, 30);
            this.btnNextBook.TabIndex = 16;
            this.btnNextBook.Text = ">";
            this.btnNextBook.UseVisualStyleBackColor = true;
            this.btnNextBook.Click += new System.EventHandler(this.btnNextBook_Click);
            // 
            // btnLastBook
            // 
            this.btnLastBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastBook.Location = new System.Drawing.Point(224, 40);
            this.btnLastBook.Name = "btnLastBook";
            this.btnLastBook.Size = new System.Drawing.Size(45, 30);
            this.btnLastBook.TabIndex = 17;
            this.btnLastBook.Text = ">>";
            this.btnLastBook.UseVisualStyleBackColor = true;
            this.btnLastBook.Click += new System.EventHandler(this.btnLastBook_Click);
            // 
            // btnFirstBook
            // 
            this.btnFirstBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstBook.Location = new System.Drawing.Point(26, 40);
            this.btnFirstBook.Name = "btnFirstBook";
            this.btnFirstBook.Size = new System.Drawing.Size(46, 30);
            this.btnFirstBook.TabIndex = 18;
            this.btnFirstBook.Text = "<<";
            this.btnFirstBook.UseVisualStyleBackColor = true;
            this.btnFirstBook.Click += new System.EventHandler(this.btnFirstBook_Click);
            // 
            // btnPreviousBook
            // 
            this.btnPreviousBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousBook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousBook.Location = new System.Drawing.Point(78, 40);
            this.btnPreviousBook.Name = "btnPreviousBook";
            this.btnPreviousBook.Size = new System.Drawing.Size(30, 30);
            this.btnPreviousBook.TabIndex = 19;
            this.btnPreviousBook.Text = "<";
            this.btnPreviousBook.UseVisualStyleBackColor = true;
            this.btnPreviousBook.Click += new System.EventHandler(this.btnPreviousBook_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(665, 115);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(168, 23);
            this.txtUser.TabIndex = 21;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(665, 179);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(168, 23);
            this.txtClient.TabIndex = 21;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(665, 243);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(168, 23);
            this.txtTotal.TabIndex = 21;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(665, 307);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(168, 23);
            this.dtDate.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Người Dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tổng Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ngày Mua";
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.Color.White;
            this.btnDec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDec.Image = ((System.Drawing.Image)(resources.GetObject("btnDec.Image")));
            this.btnDec.Location = new System.Drawing.Point(551, 36);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(38, 37);
            this.btnDec.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnDec, "Sắp Xếp Mới Nhất");
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.White;
            this.btnSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Image = ((System.Drawing.Image)(resources.GetObject("btnSort.Image")));
            this.btnSort.Location = new System.Drawing.Point(595, 36);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(38, 37);
            this.btnSort.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnSort, "Xắp Xếp Cũ Nhất");
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // frmMainBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 684);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtIDBill);
            this.Controls.Add(this.btnNextBook);
            this.Controls.Add(this.btnLastBook);
            this.Controls.Add(this.btnFirstBook);
            this.Controls.Add(this.btnPreviousBook);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainBill";
            this.Load += new System.EventHandler(this.frmMainBill_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBill)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBillDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBillDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvBill;
        private System.Windows.Forms.DataGridView dvBillDetail;
        private System.Windows.Forms.BindingSource bsBill;
        private System.Windows.Forms.BindingSource bsBillDetail;
        private System.Windows.Forms.TextBox txtIDBill;
        private System.Windows.Forms.Button btnNextBook;
        private System.Windows.Forms.Button btnLastBook;
        private System.Windows.Forms.Button btnFirstBook;
        private System.Windows.Forms.Button btnPreviousBook;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}