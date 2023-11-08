using System;
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

        public static string UserName = "";
        private void CheckLogin()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            var user = db.UserTbls.SingleOrDefault(u => u.UName == username && u.UPass == password);

            if (user != null)
            {
                UserName = user.UName;
                Billing obj = new Billing();
                obj.Show();
                this.Hide();
                NotificationHelper.ShowNotification("Login", "Login Successful", ToolTipIcon.Info);
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

        private void label3_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            obj.Show();
            this.Hide();
        }

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
    }
}
