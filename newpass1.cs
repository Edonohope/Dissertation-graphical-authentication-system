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

namespace WindowsFormsApplication1
{

    public partial class newpass1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5K79RIS\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");

        string s;
        public newpass1(string s1)
        {
            s = s1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtu.Text== textBox1.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update loginTbl set  pass=@password where userid='"+s+"'", con);
                cmd.Parameters.AddWithValue("@password", txtu.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DialogResult d = MessageBox.Show("Level Saved Successfully", "Password Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    this.Hide();
                    rgbchangepass a = new rgbchangepass(txtu.Text);
                    a.Show();
                }
            }
            else
            {
                MessageBox.Show("Password Not Matched  !", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
