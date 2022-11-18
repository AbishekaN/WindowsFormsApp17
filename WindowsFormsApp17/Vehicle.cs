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
    public partial class Vehicle : Form
    {
     

        public Vehicle()
        {
            InitializeComponent();
        }

        private void lblvehitype_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
        }

        private void Vehicle_Load(object sender, EventArgs e) //Insert Details 
        {
            
            
             
            
            
            panelvehid.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = LENOVO\SQLEXPRESS; Initial Catalog = AyuboD; Integrated Security = True");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Vehicle VALUES ( @V_ID,@V_No,@Type,@Brand)", con);
                {
                    cmd.Parameters.AddWithValue("@V_ID", txtvid.Text);
                    cmd.Parameters.AddWithValue("@V_No", txtvehicleno.Text);
                    cmd.Parameters.AddWithValue("@Type", cbovehitype.Text);
                    cmd.Parameters.AddWithValue("@Brand", cbobrands.Text);

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Data Added Successfully");
                Vehicle_Load(sender, e);
                con.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
          
        

        private void cbovtype_SelectedIndexChanged(object sender, EventArgs e, int weeklyCost)
        {
            
        }

        private void cbovtype_SelectedIndexChanged(object sender, EventArgs e, int weeklyCost, int WeeklyCost)
        {
           


        }

        private void txtvdrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtvehicleid.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtvehicleno.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbovehitype.Text = dgv1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbobrands.Text = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void lblvtypevdetails_Click(object sender, EventArgs e)
        {

        }

        private void cbovehitype_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=AyuboD;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Vehicle set VehicleID=@V_ID,V_No=@VehicleNo,Type=@Type Where Brand=@brand", con);
                cmd.Parameters.AddWithValue("V_ID", txtvehicleid.Text);
                cmd.Parameters.AddWithValue("V_No", txtvehicleno.Text);
                cmd.Parameters.AddWithValue("Type", cbovehitype.Text);
                cmd.Parameters.AddWithValue("Brand", cbobrands.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
