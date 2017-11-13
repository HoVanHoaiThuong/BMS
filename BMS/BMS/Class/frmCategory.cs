using BUS;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.Class
{
    public partial class frmCategory : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;
        BindingSource ListCategory = new BindingSource();
        public frmCategory()
        {
            InitializeComponent();
        }
        private void frmCategory_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = ListCategory;
            GetCategories();
            LoadCategoryBinding();
            pnCategory.Enabled = false;
            btCancel.Enabled = false;
            btSave.Enabled = false;
            txtCategorySearch.Focus();
        }

        private void GetCategories()
        {
            try
            {
                DataTable dt = CategoriesBUS.Instance.GetCategories();
                ListCategory.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void LoadCategoryBinding()
        {
            txtCategoryNo.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "category_ID", true, DataSourceUpdateMode.Never));
            txtCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "category_Name", true, DataSourceUpdateMode.Never));           
            txtCategoryDiscription.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "category_Description", true, DataSourceUpdateMode.Never));
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pnCategory.Enabled = true;
            btCancel.Enabled = true;
            btSave.Enabled = true;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            ClearInput();
            txtCategoryName.Focus();
        }

        private void ClearInput()
        {
            txtCategoryName.Text = string.Empty;
            txtCategoryDiscription.Text = string.Empty;
            txtCategoryName.Focus();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnCategory.Enabled = true;
            btSave.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            txtCategoryName.Focus();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool result = CategoriesBUS.Instance.RemoveCategory(txtCategoryNo.Text);
                    if (result != false)
                    {
                        pnCategory.Enabled = false;
                        btCancel.Enabled = false;
                        btSave.Enabled = false;
                        GetCategories();
                        objState = EntityState.Unchanged;
                    }
                }
                catch (SqlException ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            pnCategory.Enabled = false;
            btInsert.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
            ListCategory.ResetCurrentItem();
            txtCategorySearch.Focus();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetCategories();
            btRefresh.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryNo = txtCategoryNo.Text;
                string categoryName = txtCategoryName.Text;
                string description = txtCategoryDiscription.Text;
                if (objState == EntityState.Added)
                {
                    if (CategoriesBUS.Instance.InsertCategory(categoryName, description))
                    {
                        GetCategories();
                        ListCategory.MoveLast();
                        pnCategory.Enabled = false;
                        btSave.Enabled = false;
                        btCancel.Enabled = false;
                        btInsert.Enabled = true;
                        btUpdate.Enabled = true;
                        btDelete.Enabled = true;

                        MetroMessageBox.Show(this, "Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (objState == EntityState.Changed)
                {
                    if (CategoriesBUS.Instance.UpdateCategory(categoryNo, categoryName, description))
                    {
                        GetCategories();
                        pnCategory.Enabled = false;
                        btSave.Enabled = false;
                        btCancel.Enabled = false;
                        btInsert.Enabled = true;
                        btDelete.Enabled = true;

                        MetroMessageBox.Show(this, "Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                objState = EntityState.Unchanged;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
