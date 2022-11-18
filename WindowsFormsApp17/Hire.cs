using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Hire : Form
    {
        private int DriveCost;
        private int DailyRent;
        private int AirportDrop;
        private int AirportPickup;
        private int HundreadKMPPK;
        private int TwoHundreadKMPK;
        private int StartingKM;
        private int EndingKM;
        private int Distance;
        private int HireCost;
        private int OverNight;
        private int panelty;
        public Hire()
        {
            InitializeComponent();
        }

        private void Hire_Load(object sender, EventArgs e)
        {
            panelhired.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btndaytour_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnlongtour_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btndaytour_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnlongtour_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panelhired_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncalculatehire_Click(object sender, EventArgs e)
        {
            StartingKM = int.Parse(txtstkm.Text);
            EndingKM = int.Parse(txtendkm.Text);
            Distance = EndingKM - StartingKM;

            if (Distance > 100)
            {
                panelty = 1500;
            }
            else
            {
                panelty = 0;
            }
            DateTime StartTime = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime EndTime = Convert.ToDateTime(dateTimePicker2.Value);

            int timepicker = EndTime.Subtract(StartTime).Days;

            if (timepicker >= 1) 
            {
                OverNight = int.Parse(txtovernightchages.Text);
            
            }
            else 
            {
                OverNight = 0;
            }

            if (comboBox1.SelectedItem == "Airport Pickup")
            {
                HireCost = AirportPickup * Distance;
                txttotalpricehire.Text.ToString();

            }
            else if (comboBox1.SelectedItem == "100KM Package")
            {
                HireCost = timepicker * OverNight + (timepicker * HundreadKMPPK) + HundreadKMPPK + (panelty * timepicker);
                txttotalpricehire.Text.ToString();
            }
            
        }   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Small Car") 
            {
                AirportDrop = 140;
                AirportPickup = 150;
                HundreadKMPPK = 12000;
                TwoHundreadKMPK = 13000;
            
            }
            else if (comboBox1.SelectedItem == "KDH Van") 
            {
                AirportDrop = 150;
                AirportPickup = 160;
                HundreadKMPPK = 13000;
                TwoHundreadKMPK = 14000;
            }
            else if (comboBox1.SelectedItem == "Mini Van") 
            { 
                AirportDrop = 160;
                AirportPickup = 140;
                HundreadKMPPK = 15000;
                TwoHundreadKMPK = 16000;
            }
            else if (comboBox1.SelectedItem == "Sedan Car") 
            {
                AirportDrop = 170;
                AirportPickup = 180;
                HundreadKMPPK = 16000;
                TwoHundreadKMPK = 17000;
            
            }
            else 
            {
                DailyRent = 0;
            }
        }

        private void cbovtype2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
