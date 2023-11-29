using System;
using System.Linq;
using System.Windows.Forms;

namespace BookShopManager
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void categoryTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            UpDateData();
        }

        private void UpDateData()
        {
            this.Validate();
            this.categoryTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bOOKSHOPSDBDataSet);
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bOOKSHOPSDBDataSet.CategoryTbl' table. You can move, or remove it, as needed.
            this.categoryTblTableAdapter.Fill(this.bOOKSHOPSDBDataSet.CategoryTbl);

        }

        BookShopDataContext db = new BookShopDataContext();
        private void AddCategory()
        {
            if (txtCate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter category name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                string category = txtCate.Text.Trim();
                bool categoryExists = db.CategoryTbls.Any(c => c.Category == category);

                if (categoryExists)
                {
                    MessageBox.Show("Category already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CategoryTbl categoryTbl = new CategoryTbl();
                    categoryTbl.Category = category;
                    db.CategoryTbls.InsertOnSubmit(categoryTbl);
                    db.SubmitChanges();

                    MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory();
            this.categoryTblTableAdapter.Fill(this.bOOKSHOPSDBDataSet.CategoryTbl);
        }

        private void DeletCate()
        {
            if (MessageBox.Show("Are you sure want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dvCategory.SelectedCells.Count > 0)
                {
                    string id = dvCategory.SelectedCells[1].Value.ToString();

                    CategoryTbl cate = db.CategoryTbls.Where(pv => pv.Category.Equals(id)).FirstOrDefault();

                    if (cate != null)
                    {
                        db.CategoryTbls.DeleteOnSubmit(cate);

                        db.SubmitChanges();
                        this.categoryTblTableAdapter.Fill(this.bOOKSHOPSDBDataSet.CategoryTbl);
                    }
                }
            }
        }

        private void btnDeleCategory_Click(object sender, EventArgs e)
        {
            DeletCate();
        }

        //todo: Them nut sua
        private void EditCategory()
        {
            if (dvCategory.SelectedCells.Count > 0)
            {
                string id = dvCategory.SelectedCells[1].Value.ToString();

                CategoryTbl cate = db.CategoryTbls.Where(pv => pv.Category.Equals(id)).FirstOrDefault();

                if (cate != null)
                {
                    cate.Category = txtCate.Text;
                    db.SubmitChanges();
                    this.categoryTblTableAdapter.Fill(this.bOOKSHOPSDBDataSet.CategoryTbl);

                    MessageBox.Show("Category edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Category not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void categoryTblBindingSource_PositionChanged(object sender, EventArgs e)
        {
            txtCate.DataBindings.Clear();
            txtCate.DataBindings.Add("Text", categoryTblBindingSource, "Category");
        }
    }
}
