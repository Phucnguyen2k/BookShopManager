﻿using System;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        //Mat Khau la admin
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "admin")
            {
                frmMain obj = new frmMain();
                obj.Show();
                NotificationHelper.ShowNotification("Login", "Login Sussecfull", ToolTipIcon.Info);
                this.Hide();
            }
            else MessageBox.Show("Wrong Password Contact The Admin");
        }
        private void label3_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
