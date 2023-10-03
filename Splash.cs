using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class Splash : Form
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
        public Splash()
        {
            InitializeComponent();
        }
    }
}
