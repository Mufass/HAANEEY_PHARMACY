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
using MySql.Data.MySqlClient;



namespace Pharmacy_Inventory_Management_System_video_12
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            login_btn.Click += Login_btn_Click;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            var con = myfunction.Databaseconnection();

            try
            {
           
                con.Open();
                String qry = "select username,password from register where" +
                    "(username='" + txtuser.Text + "' AND password='" + txtpass.Text + "')";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    con.Close();
                    Dashboard home = new Dashboard();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("username or password error");
                }
               

            }
            catch(Exception ex)
            {
                MessageBox.Show("some error + " + ex);
                con.Close();
            }




        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtpass.UseSystemPasswordChar=false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
