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

        /// <summary>
        /// Tao form con
        /// </summary>
        /// <param name="childForm"></param>
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
        private Color ColorMain = Color.FromArgb(152, 94, 255);
        private Color ColorSecond = Color.FromArgb(219, 178, 255);


        private void btnHome_Click(object sender, System.EventArgs e)
        {

            OpenChildForm(new frmHome());
        }
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmHome());
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, System.EventArgs e) => OpenChildForm(new frmMainAcc());

        private void btnDashboard_Click(object sender, System.EventArgs e) => OpenChildForm(new frmDashboard());

        private void btnInfo_Click(object sender, System.EventArgs e) => OpenChildForm(new frmInfo());

        private void btnBooks_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmBooks());
            //OpenChildForm(new frmMainBooks());
        }
        private void btnExit_Click(object sender, System.EventArgs e) => Application.Exit();


        private void btnHistory_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmMainBill());
        }

        private void btnExit_Click_1(object sender, System.EventArgs e) => Application.Exit();

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void pMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
