﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BookShopManager
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
            ShowDataBaseUser();

            dvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dvUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        BookShopDataContext db = new BookShopDataContext();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Phuong Thuc Hien thi database
        /// </summary>
        private void ShowDataBaseUser()
        {
            dvUser.DataSource = db.UserTbls.Select(p => p);
        }
        private void addUser()
        {
            if (txtUser.Text == "" || txtPassword.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || dtYob.Value == null)
            {
                NotificationHelper.ShowNotification("Miss", "Missing Infor User", ToolTipIcon.Info);
            }
            else
            {
                UserTbl user = new UserTbl();

                user.UName = txtUser.Text.Trim();
                user.UPass = txtPassword.Text.Trim();
                user.UPhone = txtPhone.Text.Trim();
                user.UAdd = txtAddress.Text.Trim();
                user.UYob = dtYob.Value;

                db.UserTbls.InsertOnSubmit(user);
                db.SubmitChanges();
                NotificationHelper.ShowNotification("Success", "Add User Success", ToolTipIcon.Info);

                ShowDataBaseUser();
            }
        }
        private void btnSave_Click(object sender, EventArgs e) => addUser();

        /// <summary>
        /// Phuong thuc reset cac textbox
        /// </summary>
        private void Reset()
        {
            txtUser.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            ShowDataBaseUser();
        }
        private void DeleteUser()
        {
            if (dvUser.SelectedRows.Count == 0)
                return;
            string id = dvUser.SelectedCells[0].OwningRow.Cells["UId"].Value.ToString();
            UserTbl delete = db.UserTbls.Where(p => p.UId.Equals(id)).FirstOrDefault();
            db.UserTbls.DeleteOnSubmit(delete);
            db.SubmitChanges();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            DeleteUser();
            ShowDataBaseUser();
        }

        /// <summary>
        /// Hien thi thong tin nguoi dung khi nhan vao ban
        /// </summary>
        private void DisplaySelectedUserDetails()
        {
            txtUser.Text = dvUser.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = dvUser.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dvUser.SelectedRows[0].Cells[3].Value.ToString();
            txtPassword.Text = dvUser.SelectedRows[0].Cells[4].Value.ToString();
            string dateString = dvUser.SelectedRows[0].Cells[5].Value.ToString();
            if (DateTime.TryParse(dateString, out DateTime date))
                dtYob.Value = date;
        }
        private void dvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySelectedUserDetails();
        }
        private void EditUser()
        {
            string id = dvUser.SelectedCells[0].OwningRow.Cells["UId"].Value.ToString();
            UserTbl user = db.UserTbls.Where(p => p.UId.Equals(id)).FirstOrDefault();

            user.UName = txtUser.Text;
            user.UPass = txtPassword.Text;
            user.UPhone = txtPhone.Text;
            user.UAdd = txtAddress.Text;
            user.UYob = dtYob.Value;

            db.SubmitChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
            ShowDataBaseUser();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmBooks obj = new frmBooks();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmDashboard obj = new frmDashboard();
            obj.Show();
            this.Hide();
        }


    }
}
