﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        //Khoi tao datacontext LinQ
        BookShopDataContext db = new BookShopDataContext();

        //Hien Thi Ten Nguoi dung
        public static string UserName = "";

        //Kiem Tra dang nhap
        private void CheckLogin()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            var user = db.UserTbls.SingleOrDefault(u => u.UName == username && u.UPass == password);
            var checkAdmin = db.UserTbls.SingleOrDefault(u => u.UName == username && u.UType == true);

            if (user != null && checkAdmin == null)
            {
                UserName = user.UName;
                frmBillInfo obj = new frmBillInfo();
                obj.Show();
                this.Hide();

                NotificationHelper.ShowNotification("Login", "Login Successful", ToolTipIcon.Info);
            }
            else if (checkAdmin != null)
            {
                frmMain obj = new frmMain();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        //Show Form dang nhap admin
        private void label3_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        //An/ Hien mat khau
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                btnShowPass.ImageIndex = 1;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                btnShowPass.ImageIndex = 0;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnShowPass.ImageIndex = 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
