using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (ProgressSpinner1.Value == 100)
            {
                timerSplash.Stop();
            }
        }
    }
}
