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

        //Tao lop truy cap vao database
        BookShopDataContext db = new BookShopDataContext();

        private void CardView()
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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CardView();

            //datagridview lish su giao dich
            dvHistory.DataSource = db.BillTbls.Select(p => p);

            ChartLichSuGiaoDich();
            ChartSoLuongSachConLaiTrongKho();
            ChartDoanhThuTungNhaVien();
        }

        private void ChartLichSuGiaoDich()
        {
            // Chart Bill
            var billData = db.BillTbls.Select(b => new { UName = b.UName, Amount = b.Amount }).ToList();

            //Xoa Tat Ca Du Lieu Hien Co Ten Ban
            cInCome.Series.Clear();

            //Tao dai du lieu BillData
            Series series1 = new Series("BillData");
            //Xac dinh truc x, y cho du lieu
            series1.XValueMember = "UName";
            series1.YValueMembers = "Amount";

            series1.ToolTip = "#VALX: #VAL";
            //Dung Bieu Do chart
            series1.ChartType = SeriesChartType.Line;

            //Them du lieu vao bieu do
            cInCome.Series.Add(series1);

            //Them nguon Du lieu
            cInCome.DataSource = billData;

            //Hien Thi Bieu Do
            cInCome.DataBind();
        }
        private void ChartSoLuongSachConLaiTrongKho()
        {
            // Chart Books
            //Lay Ten Sach Va So Luong Con Lai Trong Sach
            var bookData = db.BookTbls.Select(b => new { BTitle = b.BTitle, BQty = b.BQty }).ToList();

            //Gan nguon Du lieu
            cBookStorage.DataSource = bookData;

            cBookStorage.Series.Clear();

            Series series = new Series("Books");
            series.ChartType = SeriesChartType.Column;

            series.XValueMember = "BTitle";
            series.YValueMembers = "BQty";

            cBookStorage.Series.Add(series);

            cBookStorage.ChartAreas[0].AxisX.Title = "Book Title";
            cBookStorage.ChartAreas[0].AxisY.Title = "Quantity";

            //Hien Thi Du Lieu
            cBookStorage.DataBind();

        }

        /// <summary>
        /// Bieu Do Co doanh Thu cua tung nguoi 
        /// </summary>
        private void ChartDoanhThuTungNhaVien()
        {
            //Xoa tat ca du lieu truoc do
            cRevenuePerUser.Series.Clear();

            //Cho mau bieu do
            cRevenuePerUser.Palette = ChartColorPalette.Pastel;

            //Lay Doanh Thu Tu nguoi Tu co so du lieu
            var userAmountData = db.BillTbls
                .GroupBy(b => b.UName)
                .Select(g => new
                {
                    UName = g.Key,
                    TotalAmount = g.Sum(b => b.Amount)
                })
                .ToList();

            //duyen tung nguoi dung va theo cok CSDL 
            foreach (var item in userAmountData)
            {
                string uname = item.UName;

                Series seriesItem = new Series(uname);
                seriesItem.Points.AddXY(uname, item.TotalAmount);
                seriesItem.IsValueShownAsLabel = true;
                cRevenuePerUser.Series.Add(seriesItem);
                seriesItem.Points.Last().ToolTip = uname;
            }
        }
        //Dang Xuat
        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Close();
        }

        //Thoat Ung Dung
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
