using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmLogin : Form
    {
        //code move windown
        private Point startPoint;
        private bool isDragging = false;
        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location;
            }
        }

        private void lbTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point endPoint = PointToScreen(e.Location);
                Location = new Point(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            }
        }
        //State Window
        private void lbTitle_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-59C9UNMJ\KI;Initial Catalog=BOOKSHOPSDB;Integrated Security=True");
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string UserName = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserTbl WHERE UName='" + txtUserName.Text + "' AND UPass='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                UserName = txtUserName.Text;
                Billing obj = new Billing();
                //frmMain obj = new frmMain();
                obj.Show();
                //dung this.clos se tat ung dung
                this.Hide();
                con.Close();
                NotificationHelper.ShowNotification("Login", "Login Sussecfull", ToolTipIcon.Info);

            }
            else
            {
                MessageBox.Show("Wrong Username or Password",
                    "Wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }

            con.Close();
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
