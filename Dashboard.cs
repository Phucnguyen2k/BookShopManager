using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookShopManager
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmBooks obj = new frmBooks();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmUsers obj = new frmUsers();
            obj.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-59C9UNMJ\KI;Initial Catalog=BOOKSHOPSDB;Integrated Security=True");
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
            string stringWithoutSpaces = originalString.Replace(" ", string.Empty);
            lbUserMost.Text = stringWithoutSpaces;

            //chart Bill
            string query = "SELECT UName, Amount FROM BillTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt5 = new DataTable();
            adapter.Fill(dt5);
            chart1.Series.Clear(); // Clear existing series if any

            // Create a new series
            Series series1 = new Series("BillData");
            series1.XValueMember = "UName";
            series1.YValueMembers = "Amount";
            series1.ToolTip = "#VALX: #VAL"; // Display both UName and Amount in the tooltip
            series1.ChartType = SeriesChartType.Line;

            chart1.Series.Add(series1);

            chart1.DataSource = dt5;
            chart1.DataBind();

            // Chart Books
            string query2 = "SELECT BTitle, BQty FROM BookTbl";
            SqlCommand command = new SqlCommand(query2, con);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command);
            adapter2.Fill(dataTable);

            chart2.DataSource = dataTable;

            chart2.Series.Clear();
            Series series = new Series("Books");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.XValueMember = "BTitle";
            series.YValueMembers = "BQty";
            chart2.Series.Add(series);

            // Change Title Hirizon
            chart2.ChartAreas[0].AxisX.Title = "Book Title";
            chart2.ChartAreas[0].AxisY.Title = "Quantity";
            chart2.DataBind();


            //chart User
            // Retrieve data from the database
            string query3 = "SELECT UName, SUM(Amount) AS TotalAmount FROM BillTbl GROUP BY UName";
            SqlDataAdapter adapter3 = new SqlDataAdapter(query3, con);
            DataTable dt6 = new DataTable();
            adapter3.Fill(dt6);

            // Set up the chart
            chart3.Series.Clear();
            chart3.Palette = ChartColorPalette.Pastel; // You can change the palette as desired

            foreach (DataRow row in dt6.Rows)
            {
                string uname = row["UName"].ToString();
                int totalAmount = Convert.ToInt32(row["TotalAmount"]);

                // Add data points to the chart
                Series seriesItem = new Series(uname); // Use a different variable name
                seriesItem.Points.AddXY(uname, totalAmount);
                seriesItem.IsValueShownAsLabel = true; // Show values as labels on the pie slices
                //seriesItem.ChartType = SeriesChartType.Pie; // Set the chart type to Pie
                chart3.Series.Add(seriesItem);
                seriesItem.Points.Last().ToolTip = uname;
            }

            string query4 = "SELECT * FROM BillTbl";

            SqlDataAdapter adapter4 = new SqlDataAdapter(query4, con);

            DataTable dataTable4 = new DataTable();

            adapter4.Fill(dataTable4);

            dvHistory.DataSource = dataTable4;
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
