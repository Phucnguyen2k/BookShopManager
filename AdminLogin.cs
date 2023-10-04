using System;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "admin")
            {
                Books obj = new Books();
                obj.Show();
                this.Hide();
            }
            else MessageBox.Show("Wrong Password Contact The Admin");
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
