using System.Linq;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmMainBill : Form
    {
        public frmMainBill()
        {
            InitializeComponent();
        }


        private void frmMainBill_Load(object sender, System.EventArgs e)
        {
            FormLoad();
        }
        BookShopDataContext db = new BookShopDataContext();

        private void FormLoad()
        {
            bsBill.DataSource = db.BillTbls.ToList();
            bsBillDetail.DataSource = db.BillDetailTbls
                                        .Select(p => new { ID = p.BillDetailId, Name = p.NameBook, Price = p.PriceBook, Quality = p.Quanlity, ToTal = p.Total, IDBill = p.IdBill })
                                        .ToList();

            dvBill.DataSource = bsBill;
            dvBillDetail.DataSource = bsBillDetail;
        }


        private void bsBill_PositionChanged(object sender, System.EventArgs e)
        {
            if (dvBill.SelectedCells.Count == 0)
                return;

            string id = dvBill.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            bsBillDetail.Clear();
            bsBillDetail.DataSource = db.BillDetailTbls.Where(p => p.IdBill.Equals(id))
                                                        .Select(p => new { ID = p.BillDetailId, Name = p.NameBook, Price = p.PriceBook, Quality = p.Quanlity, ToTal = p.Total, IDBill = p.IdBill })
                                                        .ToList();

            dvBillDetail.DataSource = bsBillDetail;
            UpdatePosition();
        }
        private void btnDec_Click(object sender, System.EventArgs e) => bsBill.DataSource = db.BillTbls
                                .OrderByDescending(p => p.BillId)
                                .ToList();

        private void btnSort_Click(object sender, System.EventArgs e) => bsBill.DataSource = db.BillTbls
                                .OrderBy(p => p.BillId)
                                .ToList();
        private void DisplayBill()
        {
            txtUser.DataBindings.Clear();
            txtClient.DataBindings.Clear();
            txtTotal.DataBindings.Clear();
            dtDate.DataBindings.Clear();

            //txtTitle.DataBindings.Add("Text", dvBooks.DataSource, "Title");
            txtUser.DataBindings.Add("Text", dvBill.DataSource, "UName");
            txtClient.DataBindings.Add("Text", dvBill.DataSource, "ClineName");
            txtTotal.DataBindings.Add("Text", dvBill.DataSource, "Amount");
            dtDate.DataBindings.Add("Value", dvBill.DataSource, "UDate");
        }

        private void dvBill_CellContentClick(object sender, DataGridViewCellEventArgs e) => DisplayBill();
        private void UpdatePosition()
        {
            int index = bsBill.Position + 1;
            int count = bsBill.Count;
            txtIDBill.Text = $"{index}/{count}";
        }
        private void btnLastBook_Click(object sender, System.EventArgs e) => bsBill.MoveLast();

        private void btnPreviousBook_Click(object sender, System.EventArgs e) => bsBill.MovePrevious();

        private void btnNextBook_Click(object sender, System.EventArgs e) => bsBill.MoveNext();

        private void btnFirstBook_Click(object sender, System.EventArgs e) => bsBill.MoveFirst();

    }
}
