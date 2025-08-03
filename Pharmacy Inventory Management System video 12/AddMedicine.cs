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

namespace Pharmacy_Inventory_Management_System_video_12
{
    public partial class Add_Medicine : Form
    {
        public Add_Medicine()
        {
            InitializeComponent();
        }

        private void Add_Medicine_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Conyfiguration message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dashboard loginform = new Dashboard();
                loginform.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String medicineid1 = medicineid.Text;
                String name = medicinename.Text;

                String number = medicinenumber.Text;
                String manudate = manufacturedate.Value.ToString("yyy/MM/dd");
                String expired = expireddate.Value.ToString("yyy/MM/dd");
                String quani = quanity.Text;
                String price = priceperunit.Text;
                String error = "";

               
                    var con = myfunction.Databaseconnection();
                    con.Open();

                    String qry = "INSERT INTO addmedicine(medicineid, medicinename , medicinenumber, manufacturingdate, expiredate,quanity,priceperunit) VALUES ('" + medicineid1 + "','" + name + "','" + number + "','" + manudate + "','" + expired + "','" + quani + "','"+price+"')";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("added successfully");
                    con.Close();

                

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }

        }
    }
}
