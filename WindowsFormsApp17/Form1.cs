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


namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);  
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            if (txtusername.Text == "User" && txtpassword.Text == "1234")
            {
                MessageBox.Show("Login Successfull!");
                Dashboard DB = new Dashboard();
                DB.Show();
                

            }
            else 
            {
                MessageBox.Show("Login Failed");
            }
            



        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
