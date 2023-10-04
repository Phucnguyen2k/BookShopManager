using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();

            user = txtUser.Text;
            password = txtPassword.Text;
            address = txtAddress.Text;
            phone = txtPhone.Text;
            dvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dvUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus\OneDrive\Tài liệu\BookShopsDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string user;
        private string password;
        private string address;
        private string phone;

        private void populate()
        {
            try
            {
                con.Open();
                string query = "select * from UserTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dvUser.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtAddress.Text);

            if (user == "" || phone == "" || address == "" || password == "")
                MessageBox.Show("Missing Infor User");
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into UserTbl values('" + txtUser.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + txtPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully");
                    con.Close();
                    populate();
                    //RestColum();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Reset()
        {
            txtUser.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (key == 0)
                MessageBox.Show("Missing Infor Books");
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from UserTbl  where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book deleted Successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        int key = 0;
        private void dvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser.Text = dvUser.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = dvUser.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dvUser.SelectedRows[0].Cells[3].Value.ToString();
            txtPassword.Text = dvUser.SelectedRows[0].Cells[4].Value.ToString();

            string s;
            s = dvUser.SelectedRows[0].Cells[3].Value.ToString();
            if (txtUser.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dvUser.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (user == "" || phone == "" || address == "" || password == "")
                MessageBox.Show("Missing Infor User");
            else
            {
                try
                {
                    con.Open();
                    //string query = "update BookTbl set BTitle='" + txtTitle.Text + "',BAuthor='" + txtAuthor.Text + "',BCat=" + cbCate.SelectedIndex.ToString() + "',BQty=" + txtQty.Text + ",BPrice" + txtPrice.Value + " where BId" + key + ";";
                    string query = "UPDATE UserTbl SET UName='" + txtUser.Text + "', UPhone='" + txtPhone.Text + "', UAdd='" + txtAddress.Text + "', UPass='" + txtPassword.Text + "' WHERE UId=" + key + ";";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
                    con.Close();
                    populate();
                    Reset();
                    //con.Open();

                    //string query = "UPDATE BookTbl SET BTitle=@BTitle, BAuthor=@BAuthor, BCat=@BCat, BQty=@BQty, BPrice=@BPrice WHERE BId=@BId";
                    //SqlCommand cmd = new SqlCommand(query, con);

                    //cmd.Parameters.AddWithValue("@BTitle", txtTitle.Text);
                    //cmd.Parameters.AddWithValue("@BAuthor", txtAuthor.Text);
                    //cmd.Parameters.AddWithValue("@BCat", cbCate.SelectedItem.ToString());
                    //cmd.Parameters.AddWithValue("@BQty", txtQty.Text);
                    //cmd.Parameters.AddWithValue("@BPrice", txtPrice.Value);
                    //cmd.Parameters.AddWithValue("@BId", key);

                    //cmd.ExecuteNonQuery();

                    //MessageBox.Show("Book Updated Successfully");

                    //con.Close();
                    //populate();
                    //Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
