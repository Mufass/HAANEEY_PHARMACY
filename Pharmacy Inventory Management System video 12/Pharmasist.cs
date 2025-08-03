using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Inventory_Management_System_video_12
{
    public partial class Pharmasist : Form
    {
        public Pharmasist()
        {
            InitializeComponent();
            btnlogin.Click += Btnlogin_Click;
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                    String username = txtusername.Text;
                    String password = txtpassword.Text;
                  
                    String name = txtname.Text;
                    String dob = datadob.Value.ToString("yyy/MM/dd");
                    String phone = txtphone.Text;
                    String email = txtemail.Text;
                    String error = "";

            if (myfunction.ValidateUsernameAndPassword(username, password, out error))
                {
                   
                    var con = myfunction.Databaseconnection();
                    con.Open();

                    String qry = "INSERT INTO register(name, dob , phonenumber , email, username,password ) VALUES ('" + name + "','" + dob + "','" + phone + "','" + email + "','" + username + "','" + password + "')";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    login log = new login();
                    log.Show();
                    MessageBox.Show("login successfully");
                    con.Close();

                }
                else
                {
                    erromessage.ForeColor = Color.Red;
                    erromessage.Text = error;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
               
            }
          
           
          

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Conyfiguration message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dashboard loginform = new Dashboard();
                loginform.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Pharmasist_Load(object sender, EventArgs e)
        {

        }
    }
}
