using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus\OneDrive\Tài liệu\BookShopsDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void Dashboard_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(BQty) from BookTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbBooksStock.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(Amount) from BillTbl", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            lbToTalAmount.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select Count(*) from UserTbl", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lbUsers.Text = dt2.Rows[0][0].ToString();
            con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
