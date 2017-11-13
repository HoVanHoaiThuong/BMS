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
using System.IO;
using BUS;
using DTO;
using MetroFramework.Controls;
using MetroFramework;

namespace BMS.Class
{
    public partial class frmBook : pnSlider
    {
        public event EventHandler SettingClosed;
        public frmBook(Form owner):base(owner)
        {
            InitializeComponent();
            dgvBooks.DataSource = ListBook;
            Book_Load();
            DefaultImage = pbBook.Image;
        }

        private void linkBack_Click(object sender, EventArgs e)
        {
            Swipe(false);

            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }
        EntityState objState = EntityState.Unchanged;
        BindingSource ListBook = new BindingSource();
        String strFilePath = "";
        Image DefaultImage;
        Byte[] ImageByteArray = null;
       
        private void Book_Load()
        {
            GetBooks();
            pnBookDetails.Enabled = false;
            btCancel.Enabled = false;
            btSave.Enabled = false;
            txtSearch.Focus();
            
            LoadAuthorIntoCombobox(cbAuthor);
            LoadPublisherIntoCombobox(cbPublisher);
            LoadCategoryIntoCombobox(cbCategory);
            LoadBookBinding();
           
        }

        private void GetBooks()
        {
            try
            {
                DataTable dt = BooksBUS.Instance.GetBooks();
                ListBook.DataSource = dt;
                int sumRecord = BooksBUS.Instance.GetQBook();
                int page = sumRecord / 10;
                if (sumRecord % 10 != 0)
                {
                    page++;
                }
                lbTotalRecord.Text = "/" + page.ToString() + " page(s)";
            }
            catch (SqlException ex)
            {
                MetroMessageBox.Show(this, "Error! Cannot retrieve data. Please try again!" + Environment.NewLine + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void LoadAuthorIntoCombobox(MetroComboBox cb)
        {
            DataTable dt = AuthorsBUS.Instance.GetAuthors();
            List<Authors> list = new List<Authors>();
            foreach (DataRow item in dt.Rows)
            {
                Authors author = new Authors(item);
                list.Add(author);
            }
            cb.DataSource = list;
            cb.DisplayMember = "AuthorName";
        }
        private void LoadPublisherIntoCombobox(MetroComboBox cb)
        {
            DataTable dt = PublishersBUS.Instance.GetPublishers();
            List<Publishers> list = new List<Publishers>();
            foreach (DataRow item in dt.Rows)
            {
                Publishers publisher = new Publishers(item);
                list.Add(publisher);
            }
            cb.DataSource = list;
            cb.DisplayMember = "PublisherName";
            
        }
        private void LoadCategoryIntoCombobox(MetroComboBox cb)
        {
            DataTable dt = CategoriesBUS.Instance.GetCategories();
            List<Categories> list = new List<Categories>();
            foreach (DataRow item in dt.Rows)
            {
                Categories category = new Categories(item);
                list.Add(category);
            }
            cb.DataSource = list;
            cb.DisplayMember = "CategoryName";
        }

        private void LoadBookBinding()
        {
            txtBookID.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "book_ID", true, DataSourceUpdateMode.Never));
            txtBookTitle.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "book_Title", true, DataSourceUpdateMode.Never));
            cbAuthor.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "author_Full_Name", true, DataSourceUpdateMode.Never));
            cbPublisher.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "publisher_Name", true, DataSourceUpdateMode.Never));
            cbCategory.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "category_Name", true, DataSourceUpdateMode.Never));
            txtYearofPublished.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "year_Published", true, DataSourceUpdateMode.Never));
            txtPages.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "pages", true, DataSourceUpdateMode.Never));
            txtQuantity.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "quantity", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "unit_Price", true, DataSourceUpdateMode.Never));
            pbBook.DataBindings.Add(new Binding("Image", dgvBooks.DataSource, "book_Image", true, DataSourceUpdateMode.Never));
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Images|  *.JPG; *.PNG; *.GJF", ValidateNames = true })
                {
                    btSave.Enabled = true;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        strFilePath = ofd.FileName;
                        pbBook.Image = new Bitmap(strFilePath);
                            if (strFilePath == "")
                            {
                               
                                if (ImageByteArray.Length != 0)
                                    ImageByteArray = new byte[] { };
                            }
                            else
                            {
                                Image temp = new Bitmap(strFilePath);
                                MemoryStream strm = new MemoryStream();
                                temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                                ImageByteArray = strm.ToArray();
                            }
                     }
                 }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void mtAuthor_Click(object sender, EventArgs e)
        {
            frmAuthor f = new frmAuthor();
            f.ShowDialog();
        }

        private void mtPublisher_Click(object sender, EventArgs e)
        {
            frmPublisher f = new frmPublisher();
            f.ShowDialog();
        }

        private void mtCategory_Click(object sender, EventArgs e)
        {
            frmCategory f = new frmCategory();
            f.ShowDialog();
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pnBookDetails.Enabled = true;
            btCancel.Enabled = true;
            btSave.Enabled = false;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            pbBook.Image = null;
            ClearInput();
            txtBookTitle.Focus();
        }
        private void ClearInput()
        {
            txtBookID.Text = string.Empty;
            txtBookTitle.Text = string.Empty;
            txtYearofPublished.Text = string.Empty;
            txtPages.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtBookTitle.Focus();

        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnBookDetails.Enabled = true;
            btSave.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            txtBookTitle.Focus();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool result = BooksBUS.Instance.RemoveBook(Convert.ToInt32(txtBookID.Text));
                    if (result != false)
                    {
                        pnBookDetails.Enabled = false;
                        btCancel.Enabled = false;
                        btSave.Enabled = false;
                        txtSearch.Focus();
                        GetBooks();
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
            pnBookDetails.Enabled = false;
            btInsert.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
            btCancel.Enabled = false;
            ListBook.ResetCurrentItem();
            txtSearch.Focus();
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetBooks();
            pnControl.Enabled = true;
            btRefresh.Enabled = true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                string bookTitle = txtBookTitle.Text;
                string yearOfPublished = txtYearofPublished.Text;
                string pages = txtPages.Text;
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double price = Convert.ToDouble(txtPrice.Text);
                byte[] img = ImageByteArray;
                int authorID = ((cbAuthor.SelectedItem as Authors).AuthorID);
                int publisherID = (cbPublisher.SelectedItem as Publishers).PublisherID;
                int categoryID = (cbCategory.SelectedItem as Categories).CategoryID;

                if (objState == EntityState.Added)
                {
                    if (img != null)
                    {
                        if (BooksBUS.Instance.InsertBook(bookTitle, yearOfPublished, pages, quantity, price, img, authorID, publisherID, categoryID))
                        {
                            GetBooks();
                            ListBook.MoveLast();
                            pnBookDetails.Enabled = false;
                            btSave.Enabled = false;
                            btCancel.Enabled = false;
                            btInsert.Enabled = true;
                            btUpdate.Enabled = true;
                            btDelete.Enabled = true;
                            txtSearch.Focus();
                            MetroMessageBox.Show(this, "Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        pnBookDetails.Enabled = false;
                        btSave.Enabled = false;
                        btCancel.Enabled = false;
                        btInsert.Enabled = true;
                        btUpdate.Enabled = true;
                        btDelete.Enabled = true;
                        txtSearch.Focus();
                        MetroMessageBox.Show(this, "Cannot insert this record because Image is NULL.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (objState == EntityState.Changed)
                {
                    int bookID = Convert.ToInt32(txtBookID.Text);
                    if(img == null)
                    {
                        img = (byte[])dgvBooks.CurrentRow.Cells[9].Value;
                    }
                    if (BooksBUS.Instance.UpdateBook(bookID, bookTitle, yearOfPublished, pages, quantity, price, img, authorID, publisherID, categoryID))
                    {
                        GetBooks();
                        pnBookDetails.Enabled = false;
                        btSave.Enabled = false;
                        btCancel.Enabled = false;
                        btInsert.Enabled = true;
                        btDelete.Enabled = true;
                        MetroMessageBox.Show(this, "Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Update fail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                objState = EntityState.Unchanged;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            pnControl.Enabled = false;
            if(rdBookTitle.Checked)
            {
                string bookTitle = txtSearch.Text;
                ListBook.DataSource = BooksBUS.Instance.SearchBookByBookTitle(bookTitle);
            }
            else if(rdBookNo.Checked)
            {
                int bookID = Convert.ToInt32(txtSearch.Text);
                ListBook.DataSource = BooksBUS.Instance.SearchBookByBookID(bookID);
            }
            else if(rdAuthorName.Checked)
            {
                string authorName = txtSearch.Text;
                ListBook.DataSource = BooksBUS.Instance.SearchBookByAuthorName(authorName);
            }
            else if (rdAuthorNo.Checked)
            {
                int authorID = Convert.ToInt32(txtSearch.Text);
                ListBook.DataSource = BooksBUS.Instance.SearchBookByAuthorID(authorID);
            }
            else if (rdPublisherName.Checked)
            {
                string publisherName = txtSearch.Text;
                ListBook.DataSource = BooksBUS.Instance.SearchBookByPublisherName(publisherName);
            }
            else if (rdPublisherNo.Checked)
            {
                int publisherID = Convert.ToInt32(txtSearch.Text);
                ListBook.DataSource = BooksBUS.Instance.SearchBookByPublisherID(publisherID);
            }
            else if (rdCategoryName.Checked)
            {
                string categoryName = txtSearch.Text;
                ListBook.DataSource = BooksBUS.Instance.SearchBookByCategoryName(categoryName);
            }
            else if (rdCategoryNo.Checked)
            {
                int categoryID = Convert.ToInt32(txtSearch.Text);
                ListBook.DataSource = BooksBUS.Instance.SearchBookByCategoryID(categoryID);
            }
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            txtPage.Text = "1";
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            int sumRecord = BooksBUS.Instance.GetQBook();
            int lastPage = sumRecord / 10;
            if(sumRecord % 10 != 0)
            {
                lastPage++;
            }
            txtPage.Text = lastPage.ToString();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            int sumRecord = BooksBUS.Instance.GetQBook();
            int totalPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
            {
                totalPage++;
            }
            if (page < totalPage)
            {
                page++;
            }
            txtPage.Text = page.ToString();
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            if(page > 1)
            {
                page--;
            }
            txtPage.Text = page.ToString();
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            ListBook.DataSource = BooksBUS.Instance.GetBookByPage(Convert.ToInt32(txtPage.Text));
        }
    }
}
