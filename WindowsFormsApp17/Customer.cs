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

namespace WindowsFormsApp17
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Deleted");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            panelcustde.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = LENOVO\SQLEXPRESS; Initial Catalog = AyuboD; Integrated Security = True");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES (@C_ID,@Name,@Address,@C_No)", con);
                {
                    cmd.Parameters.AddWithValue("@C_ID", txtcustid.Text);
                    cmd.Parameters.AddWithValue("@Name", txtcustname.Text);
                    cmd.Parameters.AddWithValue("Address", txtcustaddress.Text);
                    cmd.Parameters.AddWithValue("@C_No", txtcustcontno.Text);

                    cmd.ExecuteNonQuery();
                   
                }
                MessageBox.Show("Data Added Successfully");
                Customer_Load(sender, e);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtcustname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcustaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcustcontno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}
