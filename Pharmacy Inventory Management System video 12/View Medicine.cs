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
    public partial class ViewMedicine : Form
    {
        public ViewMedicine()
        {
            InitializeComponent();
            displaydata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Conyfiguration message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        myfunction fn = new myfunction();

        public void displaydata()
        {
            string query = "SELECT * FROM addmedicine";
            DataSet ds = fn.getData(query);

            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];  // Bind to DataGridView
            }
        }

        private void ViewMedicine_Load(object sender, EventArgs e)
        {

            displaydata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected medicine ID from the DataGridView
                    string medicineId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM addmedicine WHERE id = @id";
                        using (SqlConnection con = myfunction.Databaseconnection())
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@id", medicineId);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Medicine deleted successfully.");
                                    displaydata(); // Refresh DataGridView
                                }
                                else
                                {
                                    MessageBox.Show("Medicine not found or could not be deleted.");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            string searchText = textBox1.Text.Trim();
            string query = "SELECT medicineid, medicinename, expiredate, quanity FROM addmedicine WHERE (medicinename LIKE @search + '%' OR CAST(medicineid AS NVARCHAR) LIKE @search + '%') AND expiredate >= GETDATE() AND quanity > 0";

            using (SqlConnection con = myfunction.Databaseconnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@search", searchText);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;  // Bind data to DataGridView
                }
            }


        }
    }
    //this
}
//test for code