using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            SqlDataAdapter sda3 = new SqlDataAdapter("select max(Amount) from BillTbl", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            lbMost.Text = dt3.Rows[0][0].ToString();

            SqlDataAdapter sda4 = new SqlDataAdapter("SELECT TOP 1 UName, MAX(Amount) AS MaxAmount FROM BillTbl GROUP BY UName ORDER BY MaxAmount DESC", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            string originalString = dt4.Rows[0]["UName"].ToString();
            string stringWithoutSpaces = originalString.Replace(" ", "");
            lbUserMost.Text = stringWithoutSpaces;

            string query = "SELECT UName, Amount FROM BillTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt5 = new DataTable();
            adapter.Fill(dt5);

            chart1.DataSource = dt5;

            chart1.Series[0].XValueMember = "UName"; chart1.Series[0].YValueMembers = "Amount";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.DataBind();

            string query2 = "SELECT BTitle, BQty FROM BookTbl";
            SqlCommand command = new SqlCommand(query2, con);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command);
            adapter2.Fill(dataTable);

            chart2.DataSource = dataTable;

            chart2.Series.Clear();
            Series series = new Series("Storage");
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "BTitle";
            series.YValueMembers = "BQty";
            chart2.Series.Add(series);

            //chart2.ChartAreas[0].AxisX.Title = "Book Title";
            chart2.ChartAreas[0].AxisY.Title = "Quantity";

            chart2.DataBind();

            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

    }
}
