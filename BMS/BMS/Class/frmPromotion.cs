using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using BUS;
using MetroFramework.Controls;
using DTO;

namespace BMS.Class
{
    public partial class frmPromotion : pnSlider
    {
        public event EventHandler SettingClosed;
        BindingSource PromotionBindingSource = new BindingSource();
        DataTable dtPromotion;
        EntityState objState = EntityState.Unchanged;
        public frmPromotion(Form owner) : base(owner)
        {
            InitializeComponent();
            
            dgvPromotion.DataSource = PromotionBindingSource;
            Promotion_Load();

        }
        private void linkBack_Click(object sender, EventArgs e)
        {
            Swipe(false);

            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }
        private void Promotion_Load()
        {
            GetPromotion();
            PromotionBinding();
            LoadBookIntoComboBox(cbBookTitle);
            pnPromotionInfo.Enabled = false;
            btCancel.Enabled = false;
            btSave.Enabled = false;
            txtSearch.Focus();
        }
        
        private void GetPromotion()
        {
            try
            {
                dtPromotion = PromotionsBUS.Instance.GetPromotion();
                Promotions promo = null;
                foreach (DataRow item in dtPromotion.Rows)
                {
                    promo = new Promotions(item);
                    PromotionsBUS.Instance.UpdatePromoStatus(promo.PromotionID);
                }
                dtPromotion = PromotionsBUS.Instance.GetPromotion();
                PromotionBindingSource.DataSource = dtPromotion;
                
            }
            catch (SqlException ex)
            {
                MetroMessageBox.Show(this, "Oops! Cannot retrieve data. Please try again!" + Environment.NewLine + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PromotionBinding()
        {
            txtPromoID.DataBindings.Add(new Binding("Text", dgvPromotion.DataSource, "promotion_ID", true, DataSourceUpdateMode.Never));
            cbBookTitle.DataBindings.Add(new Binding("Text", dgvPromotion.DataSource, "book_Title", true, DataSourceUpdateMode.Never));
            numericDiscount.DataBindings.Add(new Binding("Value", dgvPromotion.DataSource, "discount_Percent", true, DataSourceUpdateMode.Never));
            dtStartPromo.DataBindings.Add(new Binding("Value", dgvPromotion.DataSource, "start_Date", true, DataSourceUpdateMode.Never));
            dtEndPromo.DataBindings.Add(new Binding("Value", dgvPromotion.DataSource, "end_Date", true, DataSourceUpdateMode.Never));
            txtStatus.DataBindings.Add(new Binding("Text", dgvPromotion.DataSource, "promotion_Status", true, DataSourceUpdateMode.Never));
        }
        private void LoadBookIntoComboBox(MetroComboBox cb)
        {
            DataTable dt = BooksBUS.Instance.GetBooks();
            List<Books> list = new List<Books>();
            foreach (DataRow item in dt.Rows)
            {
                Books book = new Books(item);
                list.Add(book);
            }
            cb.DataSource = list;
            cb.DisplayMember = "BookTitle";
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pnPromotionInfo.Enabled = true;
            btCancel.Enabled = true;
            btSave.Enabled = true;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
           
            ClearInput();
            numericDiscount.Focus();
        }

        private void ClearInput()
        {
            numericDiscount.Value = 0;
            txtStatus.Text = "Khong ap dung";
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            cbBookTitle.Enabled = false;
            pnPromotionInfo.Enabled = true;
            btSave.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            numericDiscount.Focus();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            int promotionID = Convert.ToInt32(txtPromoID.Text);
            if (MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int result = PromotionsBUS.Instance.DeletePromo(promotionID);
                    if (result != 0)
                    {
                        pnPromotionInfo.Enabled = false;
                        btCancel.Enabled = false;
                        btSave.Enabled = false;
                        txtSearch.Focus();
                        GetPromotion();
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
            pnPromotionInfo.Enabled = false;
            btInsert.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
            btCancel.Enabled = false;
            PromotionBindingSource.ResetCurrentItem();
            txtSearch.Focus();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetPromotion();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                int bookID = (cbBookTitle.SelectedItem as Books).BookID;
                DateTime startDate = Convert.ToDateTime(dtStartPromo.Text);
                DateTime endDate = Convert.ToDateTime(dtEndPromo.Text);
                int discount = (int)numericDiscount.Value;
                string status = txtStatus.Text;

                Promotions promotion = new Promotions(bookID, discount, startDate, endDate, status);
                if (!(startDate > endDate))
                {
                    if (objState == EntityState.Added)
                    {
                        if (PromotionsBUS.Instance.CheckBookExist(bookID))
                        {
                            MetroMessageBox.Show(this, "This product already exists in the list of promotions. Please check again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        else
                        {
                            if (PromotionsBUS.Instance.AddPromo(promotion) != 0)
                            {
                                GetPromotion();
                                PromotionBindingSource.MoveLast();
                                pnPromotionInfo.Enabled = false;
                                btSave.Enabled = false;
                                btCancel.Enabled = false;
                                btInsert.Enabled = true;
                                btUpdate.Enabled = true;
                                btDelete.Enabled = true;
                                txtSearch.Focus();
                                MetroMessageBox.Show(this, "Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else if (objState == EntityState.Changed)
                    {
                        int promotionID = Convert.ToInt32(txtPromoID.Text);
                        if (PromotionsBUS.Instance.UpdatePromo(promotion, promotionID) != 0)
                        {
                            GetPromotion();
                            pnPromotionInfo.Enabled = false;
                            btSave.Enabled = false;
                            btCancel.Enabled = false;
                            btInsert.Enabled = true;
                            btDelete.Enabled = true;
                            MetroMessageBox.Show(this, "Updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Update failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    objState = EntityState.Unchanged;
                    cbBookTitle.Enabled = true;
                }
                else
                {
                    MetroMessageBox.Show(this, "The start date cannot be greater than the end of promotion date. Please check again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }//end of date
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            string bookTitle = txtSearch.Text;
            if (bookTitle != String.Empty || !String.IsNullOrWhiteSpace(bookTitle))
            {
                DataTable dt = PromotionsBUS.Instance.SearchBookPromo(bookTitle);
                PromotionBindingSource.DataSource = dt;
            }
            else
            {
                MetroMessageBox.Show(this, "Please enter (a) keyword(s) into the search box.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            btRefresh.Enabled = true;
        }
    }
}
