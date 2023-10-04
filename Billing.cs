using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus\OneDrive\Tài liệu\BookShopsDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            try
            {
                con.Open();
                string query = "select * from BookTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dvBooks.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int n = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQty.Value == 0 || Convert.ToInt32(txtQty.Value) > stock)
            {
                MessageBox.Show("No Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(txtQty.Value) * Convert.ToInt32(txtPrice.Value);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dvBill);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtTitle.Text;
                newRow.Cells[2].Value = txtQty.Value;
                newRow.Cells[3].Value = txtPrice.Value;
                newRow.Cells[4].Value = total;
                dvBill.Rows.Add(newRow);
                n++;
            }
        }

        int key = 0, stock = 0;
        private void dvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTitle.Text = dvBooks.SelectedRows[0].Cells[1].Value.ToString();
            //txtAuthor.Text = dvBooks.SelectedRows[0].Cells[2].Value.ToString();
            //cbCate.SelectedItem = dvBooks.SelectedRows[0].Cells[3].Value.ToString();
            //txtQty.Text = dvBooks.SelectedRows[0].Cells[4].Value.ToString();
            txtPrice.Value = decimal.Parse(dvBooks.SelectedRows[0].Cells[5].Value.ToString());

            string s;
            s = dvBooks.SelectedRows[0].Cells[3].Value.ToString();
            if (txtTitle.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(dvBooks.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(dvBooks.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            txtClientName.Text = "";
            txtTitle.Text = "";
            txtQty.Value = 0;
            txtPrice.Value = 0;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
