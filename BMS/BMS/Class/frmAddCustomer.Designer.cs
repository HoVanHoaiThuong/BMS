namespace BMS.Class
{
    partial class frmAddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.chkGender = new MetroFramework.Controls.MetroCheckBox();
            this.dtDOB = new MetroFramework.Controls.MetroDateTime();
            this.btOpenFile = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPoints = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerID = new MetroFramework.Controls.MetroTextBox();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pbCustomer = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Red;
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 50);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(682, 351);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Black;
            this.metroPanel2.Controls.Add(this.btSave);
            this.metroPanel2.Controls.Add(this.chkGender);
            this.metroPanel2.Controls.Add(this.dtDOB);
            this.metroPanel2.Controls.Add(this.btOpenFile);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.txtPoints);
            this.metroPanel2.Controls.Add(this.txtPhone);
            this.metroPanel2.Controls.Add(this.txtAddress);
            this.metroPanel2.Controls.Add(this.txtCustomerID);
            this.metroPanel2.Controls.Add(this.txtFullName);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.pbCustomer);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 21);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(676, 309);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Red;
            this.btSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSave.BackgroundImage")));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.Highlight = true;
            this.btSave.Location = new System.Drawing.Point(524, 258);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(117, 32);
            this.btSave.TabIndex = 52;
            this.btSave.UseCustomBackColor = true;
            this.btSave.UseSelectable = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // chkGender
            // 
            this.chkGender.AutoSize = true;
            this.chkGender.Checked = true;
            this.chkGender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGender.ForeColor = System.Drawing.Color.White;
            this.chkGender.Location = new System.Drawing.Point(348, 134);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(49, 15);
            this.chkGender.TabIndex = 51;
            this.chkGender.Text = "Male";
            this.chkGender.UseCustomBackColor = true;
            this.chkGender.UseCustomForeColor = true;
            this.chkGender.UseSelectable = true;
            this.chkGender.CheckStateChanged += new System.EventHandler(this.chkGender_CheckStateChanged);
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "dd/MM/yyyy";
            this.dtDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(347, 99);
            this.dtDOB.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(294, 29);
            this.dtDOB.TabIndex = 50;
            this.dtDOB.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // btOpenFile
            // 
            this.btOpenFile.BackColor = System.Drawing.Color.Red;
            this.btOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOpenFile.BackgroundImage")));
            this.btOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btOpenFile.Location = new System.Drawing.Point(35, 199);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(157, 35);
            this.btOpenFile.TabIndex = 49;
            this.btOpenFile.UseSelectable = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(221, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 15);
            this.metroLabel3.TabIndex = 48;
            this.metroLabel3.Text = "Gender";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txtPoints
            // 
            // 
            // 
            // 
            this.txtPoints.CustomButton.Image = null;
            this.txtPoints.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtPoints.CustomButton.Name = "";
            this.txtPoints.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPoints.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPoints.CustomButton.TabIndex = 1;
            this.txtPoints.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPoints.CustomButton.UseSelectable = true;
            this.txtPoints.Enabled = false;
            this.txtPoints.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPoints.Lines = new string[] {
        "0"};
            this.txtPoints.Location = new System.Drawing.Point(347, 217);
            this.txtPoints.MaxLength = 32767;
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.PasswordChar = '\0';
            this.txtPoints.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPoints.SelectedText = "";
            this.txtPoints.SelectionLength = 0;
            this.txtPoints.SelectionStart = 0;
            this.txtPoints.ShortcutsEnabled = true;
            this.txtPoints.ShowButton = true;
            this.txtPoints.Size = new System.Drawing.Size(116, 25);
            this.txtPoints.TabIndex = 47;
            this.txtPoints.Text = "0";
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPoints.UseSelectable = true;
            this.txtPoints.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPoints.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(347, 186);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.ShowButton = true;
            this.txtPhone.ShowClearButton = true;
            this.txtPhone.Size = new System.Drawing.Size(179, 25);
            this.txtPhone.TabIndex = 46;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(347, 155);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.ShowButton = true;
            this.txtAddress.ShowClearButton = true;
            this.txtAddress.Size = new System.Drawing.Size(294, 25);
            this.txtAddress.TabIndex = 45;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerID
            // 
            // 
            // 
            // 
            this.txtCustomerID.CustomButton.Image = null;
            this.txtCustomerID.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtCustomerID.CustomButton.Name = "";
            this.txtCustomerID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCustomerID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerID.CustomButton.TabIndex = 1;
            this.txtCustomerID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerID.CustomButton.UseSelectable = true;
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Lines = new string[0];
            this.txtCustomerID.Location = new System.Drawing.Point(347, 37);
            this.txtCustomerID.MaxLength = 32767;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PasswordChar = '\0';
            this.txtCustomerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.SelectionLength = 0;
            this.txtCustomerID.SelectionStart = 0;
            this.txtCustomerID.ShortcutsEnabled = true;
            this.txtCustomerID.ShowButton = true;
            this.txtCustomerID.ShowClearButton = true;
            this.txtCustomerID.Size = new System.Drawing.Size(116, 25);
            this.txtCustomerID.TabIndex = 43;
            this.txtCustomerID.UseSelectable = true;
            this.txtCustomerID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.CustomButton.Image = null;
            this.txtFullName.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.txtFullName.CustomButton.Name = "";
            this.txtFullName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullName.CustomButton.TabIndex = 1;
            this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullName.CustomButton.UseSelectable = true;
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(347, 68);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.ShowButton = true;
            this.txtFullName.ShowClearButton = true;
            this.txtFullName.Size = new System.Drawing.Size(294, 25);
            this.txtFullName.TabIndex = 42;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(221, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 15);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Customer No.";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(221, 221);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 15);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Accumulation Points";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(221, 71);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(97, 15);
            this.metroLabel5.TabIndex = 40;
            this.metroLabel5.Text = "Customer Name";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(221, 191);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(42, 15);
            this.metroLabel8.TabIndex = 37;
            this.metroLabel8.Text = "Phone";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(221, 101);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 15);
            this.metroLabel4.TabIndex = 39;
            this.metroLabel4.Text = "DOB";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(221, 161);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 15);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "Address";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // pbCustomer
            // 
            this.pbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCustomer.BackColor = System.Drawing.Color.Red;
            this.pbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCustomer.Location = new System.Drawing.Point(35, 41);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(158, 155);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustomer.TabIndex = 35;
            this.pbCustomer.TabStop = false;
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 401);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmAddCustomer";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Add Customer";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroCheckBox chkGender;
        private MetroFramework.Controls.MetroDateTime dtDOB;
        private MetroFramework.Controls.MetroButton btOpenFile;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPoints;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtCustomerID;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pbCustomer;
    }
}