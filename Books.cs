using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus\OneDrive\Tài liệu\BookShopsDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtQty.Text == "" || txtPrice.Value == 0 || cbCate.SelectedIndex == -1)
                MessageBox.Show("Missing Infor Books");
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BookTbl values('" + txtTitle.Text + "','" + txtAuthor.Text + "','" + cbCate.SelectedItem.ToString() + "','" + txtQty.Text + "','" + txtPrice.Value + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

    }
}
