using BUS;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.Class
{
    public partial class frmAddCustomer : MetroFramework.Forms.MetroForm
    {
        public frmAddCustomer()
        {
            InitializeComponent();
            btSave.Enabled = false;
            txtFullName.Focus();
        }
        String strFilePath = "";
        Byte[] ImageByteArray = null;
        private void chkGender_CheckStateChanged(object sender, EventArgs e)
        {

            if (chkGender.CheckState == CheckState.Checked)
            {
                chkGender.Text = "Male";
            }
            else if (chkGender.CheckState == CheckState.Unchecked)
            {
                chkGender.Text = "Female";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtFullName.Text;
                DateTime? dob = dtDOB.Value;
                bool? gender = (chkGender.Checked) ? true : false;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                byte[] img = ImageByteArray;
                int points = Convert.ToInt32(txtPoints.Text);
                if (img != null)
                {
                    if (CustomersBUS.Instance.InsertCustomer(fullName, dob, gender, address, phone, img, points))
                    {
                        btSave.Enabled = false;
                        txtFullName.Text = "";
                        txtAddress.Text = "";
                        txtPhone.Text = "";
                        pbCustomer.Image = null;
                        MetroMessageBox.Show(this, "Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    btSave.Enabled = false;
                    MetroMessageBox.Show(this, "Cannot insert because Image is NULL.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Images|  *.JPG; *.PNG; *.GJF", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        strFilePath = ofd.FileName;
                        pbCustomer.Image = new Bitmap(strFilePath);
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
            catch (Exception ex)
            {
                throw ex;
            }
        }







    }  
}
