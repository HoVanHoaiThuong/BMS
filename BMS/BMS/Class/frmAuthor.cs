using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace BMS.Class
{
    public partial class frmAuthor : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;
        BindingSource ListAuthor = new BindingSource();
        DataTable dtAuthors;
        public frmAuthor()
        {
            InitializeComponent();
        }
        private void frmAuthor_Load(object sender, EventArgs e)
        {
            dgvAuthor.DataSource = ListAuthor;
            GetAuthors();
            LoadAuthorBinding();
            pnAuthor.Enabled = false;
            btCancel.Enabled = false;
            btSave.Enabled = false;
            txtAuthorSearch.Focus();
        }
        private void LoadAuthorBinding()
        {
            txtAuthorNo.DataBindings.Add(new Binding("Text", dgvAuthor.DataSource, "author_ID", true, DataSourceUpdateMode.Never));
            txtAuthorName.DataBindings.Add(new Binding("Text", dgvAuthor.DataSource, "author_Full_Name", true, DataSourceUpdateMode.Never));
            txtAuthorDescription.DataBindings.Add(new Binding("Text", dgvAuthor.DataSource, "author_Description", true, DataSourceUpdateMode.Never));
        }
        private void GetAuthors()
        {
            try
            {
                dtAuthors = AuthorsBUS.Instance.GetAuthors();
                ListAuthor.DataSource = dtAuthors;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pnAuthor.Enabled = true;
            btCancel.Enabled = true;
            btSave.Enabled = true;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            ClearInput();
            txtAuthorName.Focus();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnAuthor.Enabled = true;
            btSave.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            txtAuthorName.Focus();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if(MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool result = AuthorsBUS.Instance.RemoveAuthor(txtAuthorNo.Text);
                    if (result != false)
                    {
                        pnAuthor.Enabled = false;
                        btCancel.Enabled = false;
                        btSave.Enabled = false;
                        GetAuthors();
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
            pnAuthor.Enabled = false;
            btInsert.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
            ListAuthor.ResetCurrentItem();
            txtAuthorSearch.Focus();
        }

        private void ClearInput()
        {
            txtAuthorName.Text = null;
            txtAuthorDescription.Text = null;
            txtAuthorName.Focus();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetAuthors();
            btRefresh.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                int authorID = Convert.ToInt32(txtAuthorNo.Text);
                string authorName = txtAuthorName.Text;
                string description = txtAuthorDescription.Text;
               
                if (objState == EntityState.Added)
                {
                    //if (AuthorsBUS.Instance.InsertAuthor(authorName, description))
                    //{
                    Authors author = new Authors(authorName, description);
                    DataRow row = dtAuthors.NewRow();
                        dtAuthors.Rows.Add(row);
                        AuthorsBUS.Instance.Add(dtAuthors, author);
                        GetAuthors();
                        ListAuthor.MoveLast();
                        pnAuthor.Enabled = false;
                        btSave.Enabled = false;
                        btCancel.Enabled = false;
                        btInsert.Enabled = true;
                        btUpdate.Enabled = true;
                        btDelete.Enabled = true;

                        MetroMessageBox.Show(this, "Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // }
                }
                else if(objState == EntityState.Changed)
                {
                    if (AuthorsBUS.Instance.UpdateAuthor(authorID, authorName, description))
                    {
                        GetAuthors();
                        pnAuthor.Enabled = false;
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

        private void txtAuthorSearch_ButtonClick(object sender, EventArgs e)
        {
            btRefresh.Enabled = true;
            DataTable dt = AuthorsBUS.Instance.SearchAuthorByName(txtAuthorSearch.Text);
            ListAuthor.DataSource = dt;
            txtAuthorSearch.Clear();
            txtAuthorSearch.Focus();
        }
        int selectedRow;
        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }
    }
}
