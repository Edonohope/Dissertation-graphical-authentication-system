using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class change_pass : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText3 = "";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5K79RIS\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
        
        public change_pass()
        {
            InitializeComponent();
        }

        public static class LoginInfo
        {
            public static string UserID;
        }
        private void txtu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtu.Text != "")
            {
                Random rnd = new Random();
                int otp = rnd.Next(1111, 9999);
                
                SetValueForText1 = "edit";
                SetValueForText3 = txtu.Text;
                string finalpassword = "Your Verification OTP is "+ otp.ToString();

                string toemail = txtu.Text;

                string url = ("http://smail.azurewebsites.net/Email.aspx?Title=Verification&emailid=" + toemail + "&Sub=OTP Verification&Msg=" + finalpassword + "");
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

                HttpWebResponse res = (HttpWebResponse)httpWebRequest.GetResponse();
                this.Close();
                
                OTPScreen o = new OTPScreen(otp.ToString());                
                this.Hide();
                 o.Show();

            }
            else
            {
                MessageBox.Show("Kindly Enter Valid Email id   !", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            //}
            //else
            //{
            //    MessageBox.Show("User Id or Password does not exist  !", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
