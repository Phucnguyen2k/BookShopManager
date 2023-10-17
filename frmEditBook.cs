using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmEditBook : Form
    {
        public CBooks EditedBook { get; set; }
        public frmEditBook(CBooks book)
        {
            InitializeComponent();
            EditedBook = book; // Initialize the EditedBook property

            // Load book data when the form is loaded
            txtTitle.Text = EditedBook.Title;
            txtAuthor.Text = EditedBook.Author;
            cbCate.SelectedItem = EditedBook.Cate;
            txtQty.Value = EditedBook.Qty;
            txtPrice.Value = EditedBook.Price;
        }

        public void LoadBookData(CBooks book)
        {
            EditedBook = book; // Set the book you want to edit

            txtTitle.Text = EditedBook.Title;
            txtAuthor.Text = EditedBook.Author;
            cbCate.SelectedItem = EditedBook.Cate;
            txtQty.Value = EditedBook.Qty;
            txtPrice.Value = EditedBook.Price;
        }

        public void UpdateBookData()
        {
            EditedBook.Title = txtTitle.Text;
            EditedBook.Author = txtAuthor.Text;
            if (cbCate.SelectedItem != null)
                EditedBook.Cate = cbCate.SelectedItem.ToString();
            EditedBook.Qty = (int)txtQty.Value;
            EditedBook.Price = (int)txtPrice.Value;
        }

        private void frmEditBook_Load(object sender, System.EventArgs e)
        {
            //LoadBookData(EditedBook);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            UpdateBookData();
            this.Close();
        }
    }
}
