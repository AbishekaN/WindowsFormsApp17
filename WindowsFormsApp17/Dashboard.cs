using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnvehicle_Click(object sender, EventArgs e)
        {
           
        }

        private void btncustom_Click(object sender, EventArgs e)
        {
            
        }

        private void btndriver_Click(object sender, EventArgs e)
        {
            
        }

        private void btnpackages_Click(object sender, EventArgs e)
        {
           

        }

        private void btnhire_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnrent_Click(object sender, EventArgs e)
        {
            

        }

        private void panelvehid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            paneldashbrd.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnvehicle_Click_1(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Show();
        }

        private void btncustom_Click_1(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void btndriver_Click_1(object sender, EventArgs e)
        {
            Driver driver = new Driver();
            driver.Show();
        }

        private void btnhire_Click_1(object sender, EventArgs e)
        {
            Hire hire = new Hire();
            hire.Show();
        }

        private void btnrent_Click_1(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            rent.Show();
        }
    }
}
