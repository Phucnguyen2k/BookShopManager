using System;
using System.Data;
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

        //Tao ket noi LinQ
        BookShopDataContext db = new BookShopDataContext();
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //So luong Sach Con Trong Kho
            var totalStock = db.BookTbls.Sum(b => b.BQty);
            lbBooksStock.Text = totalStock.ToString();

            //Tong Doanh Thu
            var totalAmount = db.BillTbls.Sum(b => b.Amount);
            lbToTalAmount.Text = totalAmount.ToString();

            //So luong Nhan Vien
            var userCount = db.UserTbls.Count();
            lbUsers.Text = userCount.ToString();

            //doanh Thu cao nhat
            var maxAmount = db.BillTbls.Max(b => b.Amount);
            lbMost.Text = maxAmount.ToString();

            // Chart Bill
            var billData = db.BillTbls.Select(b => new { UName = b.UName, Amount = b.Amount }).ToList();

            cInCome.Series.Clear();

            Series series1 = new Series("BillData");
            series1.XValueMember = "UName";
            series1.YValueMembers = "Amount";
            series1.ToolTip = "#VALX: #VAL";
            series1.ChartType = SeriesChartType.Line;

            cInCome.Series.Add(series1);

            cInCome.DataSource = billData;
            cInCome.DataBind();

            // Chart Books
            var bookData = db.BookTbls.Select(b => new { BTitle = b.BTitle, BQty = b.BQty }).ToList();

            cBookStorage.DataSource = bookData;

            cBookStorage.Series.Clear();

            Series series = new Series("Books");
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "BTitle";
            series.YValueMembers = "BQty";
            cBookStorage.Series.Add(series);

            cBookStorage.ChartAreas[0].AxisX.Title = "Book Title";
            cBookStorage.ChartAreas[0].AxisY.Title = "Quantity";
            cBookStorage.DataBind();

            //Bieu Do Co doanh Thu cua tung nguoi 
            cRevenuePerUser.Series.Clear();
            cRevenuePerUser.Palette = ChartColorPalette.Pastel;

            var userAmountData = db.BillTbls
                .GroupBy(b => b.UName)
                .Select(g => new
                {
                    UName = g.Key,
                    TotalAmount = g.Sum(b => b.Amount)
                })
                .ToList();

            foreach (var item in userAmountData)
            {
                string uname = item.UName;

                Series seriesItem = new Series(uname);
                seriesItem.Points.AddXY(uname, item.TotalAmount);
                seriesItem.IsValueShownAsLabel = true;
                cRevenuePerUser.Series.Add(seriesItem);
                seriesItem.Points.Last().ToolTip = uname;
            }

            //Char history Bill
            dvHistory.DataSource = db.BillTbls.Select(p => p);
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
