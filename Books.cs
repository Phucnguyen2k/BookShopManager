using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmBooks : Form
    {
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public frmBooks()
        {
            InitializeComponent();
            populate();
            dvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
        private void Filter()
        {
            con.Open();
            string query = "select * from BookTbl where Bcat='" + cbFilerBooka.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dvBooks.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtQty.Value == 0 || txtPrice.Value == 0 || cbCate.SelectedIndex == -1)
            {
                //MessageBox.Show("Missing Infor Books");
                NotificationHelper.ShowNotification("Miss", "Missing Infor Books", ToolTipIcon.Info);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BookTbl values('" + txtTitle.Text + "','" + txtAuthor.Text + "','" + cbCate.SelectedItem.ToString() + "','" + txtQty.Value + "','" + txtPrice.Value + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Book Saved Successfully");
                    NotificationHelper.ShowNotification("Success", "Book Save Successfully", ToolTipIcon.Info);
                    con.Close();
                    populate();
                    RestColum();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void cbFilerBook_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
            cbFilerBooka.SelectedIndex = -1;
        }

        private void RestColum()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            cbCate.SelectedIndex = -1;
            txtQty.Value = 0;
            txtPrice.Value = 0;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            RestColum();
            cbFilerBooka.SelectedIndex = -1;
        }

        int key = 0;
        string re;
        private void dvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTitle.Text = dvBooks.SelectedRows[0].Cells[1].Value.ToString();
            txtAuthor.Text = dvBooks.SelectedRows[0].Cells[2].Value.ToString();
            cbCate.SelectedItem = dvBooks.SelectedRows[0].Cells[3].Value.ToString();
            // txtQty.Value = dvBooks.SelectedRows[0].Cells[4].Value.ToString();
            txtQty.Value = decimal.Parse(dvBooks.SelectedRows[0].Cells[4].Value.ToString());
            txtPrice.Value = decimal.Parse(dvBooks.SelectedRows[0].Cells[5].Value.ToString());

            string s;
            s = dvBooks.SelectedRows[0].Cells[3].Value.ToString();
            re = s.Replace(" ", "");
            cbCate.SelectedItem = re;
            if (txtTitle.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dvBooks.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {

                MessageBox.Show("Missing Infor Books");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from BookTbl where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Book deleted Successfully");
                    NotificationHelper.ShowNotification("Success", "Book deleted Successfully", ToolTipIcon.Info);
                    con.Close();
                    populate();
                    RestColum();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtQty.Value == 0 || txtPrice.Value == 0 || cbCate.SelectedIndex == -1)
            {
                //MessageBox.Show("Missing Infor Books");
                NotificationHelper.ShowNotification("Miss", "Missing Infor Books", ToolTipIcon.Info);
            }
            else
            {
                try
                {
                    //con.Open();
                    ////string query = "update BookTbl set BTitle='" + txtTitle.Text + "',BAuthor='" + txtAuthor.Text + "',BCat=" + cbCate.SelectedIndex.ToString() + "',BQty=" + txtQty.Text + ",BPrice" + txtPrice.Value + " where BId" + key + ";";
                    //string query = "update BookTbl set BTitle='" + txtTitle.Text + "', BAuthor='" + txtAuthor.Text + "', BCat=" + cbCate.SelectedItem.ToString() + ", BQty=" + txtQty.Text + ", BPrice=" + txtPrice.Value.ToString() + " where BId=" + key + ";";

                    //SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Book Updated Successfully");
                    //con.Close();
                    //populate();
                    //RestColum();
                    con.Open();

                    string query = "UPDATE BookTbl SET BTitle=@BTitle, BAuthor=@BAuthor, BCat=@BCat, BQty=@BQty, BPrice=@BPrice WHERE BId=@BId";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@BTitle", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@BAuthor", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@BCat", cbCate.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@BQty", txtQty.Value);
                    cmd.Parameters.AddWithValue("@BPrice", txtPrice.Value);
                    cmd.Parameters.AddWithValue("@BId", key);

                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("Book Updated Successfully");
                    NotificationHelper.ShowNotification("Update", "Book Updated Successfully", ToolTipIcon.Info);

                    con.Close();
                    populate();
                    RestColum();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void cbCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmUsers obj = new frmUsers();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmDashboard obj = new frmDashboard();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelet_Click(sender, e);
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dvBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditBook frmEditBook = new frmEditBook();
            frmEditBook.Show();
        }
    }
}
