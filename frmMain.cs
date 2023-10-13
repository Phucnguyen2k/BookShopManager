using System.Drawing;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pMain.Controls.Add(childForm);
            pMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private Color ColorSecond = Color.LightSkyBlue;
        private Color ColorMain = Color.AntiqueWhite;
        void changeColor()
        {
            pBook.BackColor = ColorMain;
            pUser.BackColor = ColorMain;
            pLogout.BackColor = ColorMain;
            pDashboard.BackColor = ColorMain;

        }

        private void lbUser_Click(object sender, System.EventArgs e)
        {
            pBook.BackColor = ColorMain;
            pUser.BackColor = ColorSecond;
            pLogout.BackColor = ColorMain;
            pDashboard.BackColor = ColorMain;

            OpenChildForm(new frmUsers());
        }

        private void lbBooks_Click(object sender, System.EventArgs e)
        {
            pBook.BackColor = ColorSecond;
            pUser.BackColor = ColorMain;
            pLogout.BackColor = ColorMain;
            pDashboard.BackColor = ColorMain;

            OpenChildForm(new frmBooks());
        }

        private void lbDashboard_Click(object sender, System.EventArgs e)
        {
            pBook.BackColor = ColorMain;
            pUser.BackColor = ColorMain;
            pLogout.BackColor = ColorMain;
            pDashboard.BackColor = ColorSecond;

            OpenChildForm(new frmDashboard());
        }

        private void lbLogout_Click(object sender, System.EventArgs e)
        {
            pBook.BackColor = ColorMain;
            pUser.BackColor = ColorMain;
            pLogout.BackColor = ColorSecond;
            pDashboard.BackColor = ColorMain;

            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmBooks());
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
