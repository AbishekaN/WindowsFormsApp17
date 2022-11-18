using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            paneldriverd.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=AyuboD;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Driver VALUES(@D_ID,@D_Name,@Email,@Cont_No,@Lise_No)",con);
                {
                    cmd.Parameters.AddWithValue("@D_ID", txtdriveriid.Text);
                    cmd.Parameters.AddWithValue("@D_Name", txtdrivername.Text);
                    cmd.Parameters.AddWithValue("@Email", txtdremail.Text);
                    cmd.Parameters.AddWithValue("@Cont_No", txtdrivercontno.Text);
                    cmd.Parameters.AddWithValue("@Lise_No", txtlisenceno.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data Added Successfully");
                Driver_Load(sender, e);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=AyuboD;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Driver WHERE @D_ID= @D_ID", con);
                cmd.Parameters.AddWithValue("@D_ID", txtdriveriid.Text);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Data Deleted");
                Driver_Load(sender, e);
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }   

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=AyuboD;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Drive set D_Name=@D_Name,Email=@Email,Cont_No=@Cont_No,Lise_No@Lise_No where D_ID= @D_ID", con);
                cmd.Parameters.AddWithValue("@D_ID", txtdriveriid.Text);
                cmd.Parameters.AddWithValue("@D_Name", txtdrivername.Text);
                cmd.Parameters.AddWithValue("@Email", txtdremail.Text);
                cmd.Parameters.AddWithValue("@Cont_No", txtdrivercontno.Text);
                cmd.Parameters.AddWithValue("@Lise_No", txtlisenceno.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update Successfully");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }
    }
}
