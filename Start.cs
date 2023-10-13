using System;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            MyProcess.Value = startpos;
            lbPrecent.Text = startpos + "%";
            if (MyProcess.Value == 100)
            {
                MyProcess.Value = 0;
                timer1.Stop();
                frmLogin log = new frmLogin();
                log.Show();
                this.Hide();
            }


        }
    }
}
