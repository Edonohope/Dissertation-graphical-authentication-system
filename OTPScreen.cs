using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class OTPScreen : Form
    {
        string check;
        public OTPScreen(string otp)
        {
            check = otp;
            InitializeComponent();
        }

        private void btnsubotp_Click(object sender, EventArgs e)
        {
            if (txtotp.Text != "")
            {
                if (check.Equals(txtotp.Text))
                {
                    adminSetLogin r = new adminSetLogin();
                    this.Hide();
                    r.Show();
                }
            }
        }
    }
}
