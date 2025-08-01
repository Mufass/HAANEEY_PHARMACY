using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Inventory_Management_System_video_12
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
             new Dashboard();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Dashboard dash= new Dashboard();
            //panel1.Controls.Clear();
            Pharmasist add= new Pharmasist();
            //frm3.TopLevel = false;
            //panel1.Controls.Add(frm3);
            add.Show();
            this.Hide();
        }

       

        private void button9_Click_1(object sender, EventArgs e)
        {
            Add_Medicine frm2 = new Add_Medicine();
            frm2.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ViewMedicine vie = new ViewMedicine();
            vie.Show();
            this.Hide();
        }

        
        private void button13_Click(object sender, EventArgs e)
        {
            SellMedicine sell = new SellMedicine();
            sell.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close?","Conyfiguration message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                login loginform = new login();
                loginform.Show();
                this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Dashboard Dashboard = new Dashboard();
            Dashboard.TopLevel = false;
            panel1.Controls.Add(Dashboard);
            Dashboard.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel1.Controls.Clear();
            Dashboard Dashboard = new Dashboard();
            Dashboard.TopLevel = false;
            panel1.Controls.Add(Dashboard);
            Dashboard.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Pharmasist pha = new Pharmasist();
            pha.TopLevel = false;
            panel2.Controls.Add(pha);
            pha.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Add_Medicine medicine = new Add_Medicine();
            medicine.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ViewMedicine vimed = new ViewMedicine();
            vimed.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SellMedicine sel = new SellMedicine();
            sel.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    

