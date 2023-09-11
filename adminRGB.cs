using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;



namespace WindowsFormsApplication1
{
    public partial class newpass2 : Form
    {
        public static string status = "";

        string s;
        public newpass2( string s1)
        {
            s = s1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txrepass.AppendText("Red ,");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txrepass.AppendText("Green ,");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txrepass.AppendText("Blue ,");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (adminSetLogin.SetValueForText2 == "Edit")
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5K79RIS\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    if (txrepass.Text.Trim() != "")
                    {
                        string emailid = change_pass.SetValueForText3;
                        SqlCommand cmd = new SqlCommand("update Rgb set pattern='"+txrepass.Text+"' where emailid='"+change_pass.SetValueForText3+"'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        DialogResult d = MessageBox.Show("Level Saved Successfully", "Password Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (d == DialogResult.OK)
                        {
                            this.Hide();
                            status = "Edit";
                            Form1 p = new Form1(s);
                            p.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Pattern", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5K79RIS\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    if (txrepass.Text.Trim() != "")
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Rgb values('" + s + "', @pattern,'"+adminSetLogin.emailid+"')", con);
                        cmd.Parameters.AddWithValue("@pattern", txrepass.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        DialogResult d = MessageBox.Show("Level Saved Successfully", "Password Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (d == DialogResult.OK)
                        {
                            this.Hide();
                            Form1 p = new Form1(s);
                            p.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Pattern", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                }
            }
         
        }
    }
}
