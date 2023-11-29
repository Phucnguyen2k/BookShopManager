using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmMainAcc : Form
    {
        public frmMainAcc()
        {
            InitializeComponent();
        }
        BookShopDataContext db = new BookShopDataContext();

        private void frmMainAcc_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        private void FormLoad()
        {
            bsAcc.DataSource = db.UserTbls.ToList();
            dvAcc.DataSource = bsAcc;
        }

        private void AddUser()
        {
            if (txtUser.Text == "" || txtPassword.Text == "" || picAcc.Image == null)
            {
                MessageBox.Show("Du lieu chua day du");
                return;
            }
            UserTbl user = new UserTbl();

            // Lưu hình ảnh
            MemoryStream stream = new MemoryStream();
            picAcc.Image.Save(stream, ImageFormat.Jpeg);
            user.UAvatar = stream.ToArray();

            user.UName = txtUser.Text;
            user.UYob = dtpYob.Value;
            user.UPhone = txtPhone.Text;
            user.UAdd = txtAddress.Text;
            user.UPass = txtPassword.Text;
            user.UType = tcbAdmin.Checked;

            db.UserTbls.InsertOnSubmit(user);
            db.SubmitChanges();

            FormLoad();
            //Luu thay doi vao data base
            NotificationHelper.ShowNotification("Success", "User Save Successfully", ToolTipIcon.Info);
        }
        private void EditUser()
        {
            if (dvAcc.SelectedRows.Count == 0)
                return;

            string id = dvAcc.SelectedCells[0].Value.ToString();

            //Tao Lop de chinh sua nguoi dung
            UserTbl user = db.UserTbls.Where(p => p.UId.Equals(id)).FirstOrDefault();

            MemoryStream stream = new MemoryStream();
            picAcc.Image.Save(stream, ImageFormat.Jpeg);
            user.UAvatar = stream.ToArray();


            user.UName = txtUser.Text;
            user.UPass = txtPassword.Text;
            user.UPhone = txtPhone.Text;
            user.UAdd = txtAddress.Text;
            user.UYob = dtpYob.Value;
            user.UType = tcbAdmin.Checked;

            db.SubmitChanges();

            FormLoad();
        }

        private void DeleteUser()
        {
            if (dvAcc.SelectedRows.Count == 0)
                return;

            int vitri = bsAcc.Position;
            // Xac Dinh ID nguoi Dung
            //string id = dvUsers.SelectedCells[0].OwningRow.Cells["UId"].Value.ToString();
            string id = txtID.Text;

            //Tao Lop De Xoa Nguoi Dung Trong CSDL
            UserTbl delete = db.UserTbls.Where(p => p.UId.Equals(id)).FirstOrDefault();
            db.UserTbls.DeleteOnSubmit(delete);
            db.SubmitChanges();

            vitri = vitri - 1; // Nhay tới vị trí
            bsAcc.Position = vitri;
            FormLoad();
        }
        private void ClearUser()
        {
            txtID.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            tcbAdmin.Checked = false;

            picAcc.Image = null;
        }
        private void btnDelet_Click(object sender, EventArgs e) => DeleteUser();

        private void btnEdit_Click(object sender, EventArgs e) => EditUser();

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearUser();
        }

        private void btnAdd_Click(object sender, EventArgs e) { AddUser(); }
        private void DisplayUser()
        {
            txtID.DataBindings.Clear();
            txtUser.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            dtpYob.DataBindings.Clear();
            tcbAdmin.DataBindings.Clear();

            txtID.DataBindings.Add("Text", dvAcc.DataSource, "UId");
            txtUser.DataBindings.Add("Text", dvAcc.DataSource, "UName");
            txtPhone.DataBindings.Add("Text", dvAcc.DataSource, "UPhone");
            txtAddress.DataBindings.Add("Text", dvAcc.DataSource, "UAdd");
            txtPassword.DataBindings.Add("Text", dvAcc.DataSource, "UPass");
            dtpYob.DataBindings.Add("Value", dvAcc.DataSource, "UYob");
            tcbAdmin.DataBindings.Add("Checked", dvAcc.DataSource, "UType");

            //doc pic tu coso du lieu trong display
            string id = dvAcc.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            UserTbl User = db.UserTbls.Where(p => p.UId.Equals(id)).FirstOrDefault();
            if (User.UAvatar != null)
            {
                MemoryStream stream = new MemoryStream(User.UAvatar.ToArray());
                picAcc.Image = Image.FromStream(stream);
            }
            else picAcc.Image = null;
        }

        private void btnNextBook_Click(object sender, EventArgs e) => bsAcc.MoveNext();

        private void btnLastBook_Click(object sender, EventArgs e) => bsAcc.MoveLast();

        private void btnPreviousBook_Click(object sender, EventArgs e) => bsAcc.MovePrevious();

        private void btnFirstBook_Click(object sender, EventArgs e) => bsAcc.MoveFirst();

        private void bsAcc_PositionChanged(object sender, EventArgs e)
        {
            DisplayUser();
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            int index = bsAcc.Position + 1;
            int count = bsAcc.Count;
            txtIDBooks.Text = $"{index}/{count}";
        }

        private void btnBrowser_Click(object sender, EventArgs e) => AddPic();
        private void AddPic()
        {
            openPicBook.Filter = "JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg";
            DialogResult result = openPicBook.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = openPicBook.FileName;

                if (string.IsNullOrEmpty(file))
                    return;

                Image myImage = Image.FromFile(file);
                picAcc.Image = myImage;
            }
        }
    }

}
