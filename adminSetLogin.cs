using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class adminSetLogin : Form
    {
        public static string SetValueForText2 = "";
        public static string emailid = "";

        public adminSetLogin()
        {
            InitializeComponent();
            if (change_pass.SetValueForText1 == "edit")
            {
                label1.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                txtu.Visible = false;
            }
            else
            {
                label1.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                txtu.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (change_pass.SetValueForText1 == "edit")
            {
                label1.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                txtu.Visible = false;
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5K79RIS\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
                string id =change_pass.SetValueForText3;
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from LoginTbl where emailid='" + id + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    con.Close();
                    con.Open();
                    if (txtpass.Text.Trim() == txrepass.Text.Trim())
                    {
                        cmd = new SqlCommand("update LoginTbl set pass='"+txtpass.Text+"' where emailid='"+id+"'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        DialogResult d = MessageBox.Show("Level Saved Successfully", "Password Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (d == DialogResult.OK)
                        {
                            this.Hide();
                            SetValueForText2 = "Edit";
                            newpass2 a = new newpass2(txtu.Text);
                            a.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Not Matched", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           else  if (txtu.Text != "" && txtpass.Text != "")
            {
                label1.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                txtu.Visible = true;
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5K79RIS\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
                string id = txtu.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from LoginTbl where userid='" + id + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("This UserID already Used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtu.Text = "";
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    if (txtpass.Text.Trim() == txrepass.Text.Trim())
                    {
                        cmd = new SqlCommand("INSERT INTO LoginTbl (userid, pass,emailid) VALUES ('" + txtu.Text + "', '" + txtpass.Text + "','"+textBox1.Text+"')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        DialogResult d = MessageBox.Show("Level Saved Successfully", "Password Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (d == DialogResult.OK)
                        {
                            this.Hide();
                            emailid = textBox1.Text;
                            newpass2 a = new newpass2(txtu.Text);
                            a.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Not Matched", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all Feilds", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
