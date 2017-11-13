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
    public partial class frmPublisher : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;
        BindingSource ListPublisher = new BindingSource();
        public frmPublisher()
        {
            InitializeComponent();
        }
        private void frmPublisher_Load(object sender, EventArgs e)
        {
            dgvPublisher.DataSource = ListPublisher;
            GetPublishers();
            LoadPublisherBinding();
            pnPublisher.Enabled = false;
            btCancel.Enabled = false;
            btSave.Enabled = false;
            txtPublisherSearch.Focus();
        }
        private void GetPublishers()
        {
            try
            {
                DataTable dt = PublishersBUS.Instance.GetPublishers();
                ListPublisher.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private void LoadPublisherBinding()
        {
            txtPublisherNo.DataBindings.Add(new Binding("Text", dgvPublisher.DataSource, "publisher_ID", true, DataSourceUpdateMode.Never));
            txtPublisherName.DataBindings.Add(new Binding("Text", dgvPublisher.DataSource, "publisher_Name", true, DataSourceUpdateMode.Never));
            txtPublisherAddress.DataBindings.Add(new Binding("Text", dgvPublisher.DataSource, "publisher_Address", true, DataSourceUpdateMode.Never));
            txtPublisherDescription.DataBindings.Add(new Binding("Text", dgvPublisher.DataSource, "publisher_Description", true, DataSourceUpdateMode.Never));
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pnPublisher.Enabled = true;
            btCancel.Enabled = true;
            btSave.Enabled = true;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            ClearInput();
            txtPublisherName.Focus();
        }

        private void ClearInput()
        {
            txtPublisherName.Text = string.Empty;
            txtPublisherAddress.Text = string.Empty;
            txtPublisherDescription.Text = string.Empty;
            txtPublisherName.Focus();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnPublisher.Enabled = true;
            btSave.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            txtPublisherName.Focus();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool result = PublishersBUS.Instance.RemovePublisher(txtPublisherNo.Text);
                    if (result != false)
                    {
                        pnPublisher.Enabled = false;
                        btCancel.Enabled = false;
                        btSave.Enabled = false;
                        GetPublishers();
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
            pnPublisher.Enabled = false;
            btInsert.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
            ListPublisher.ResetCurrentItem();
            txtPublisherSearch.Focus();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetPublishers();
            btRefresh.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                string publisherNo = txtPublisherNo.Text;
                string publisherName = txtPublisherName.Text;
                string address = txtPublisherAddress.Text;
                string description = txtPublisherDescription.Text;
                if (objState == EntityState.Added)
                {
                    if (PublishersBUS.Instance.InsertPublisher(publisherName, address, description))
                    {
                        GetPublishers();
                        ListPublisher.MoveLast();
                        pnPublisher.Enabled = false;
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
                    if (PublishersBUS.Instance.UpdatePublisher(publisherNo, publisherName, address, description))
                    {
                        GetPublishers();
                        pnPublisher.Enabled = false;
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

        private void txtPublisherSearch_ButtonClick(object sender, EventArgs e)
        {
            btRefresh.Enabled = true;
            DataTable dt = PublishersBUS.Instance.SearchPublisherByName(txtPublisherSearch.Text);
            ListPublisher.DataSource = dt;
            txtPublisherSearch.Clear();
            txtPublisherSearch.Focus();
        }


    }
}
