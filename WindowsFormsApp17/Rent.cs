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
    public partial class Rent : Form
    {
      

        public Rent()
        {
            InitializeComponent();
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            panelrentd.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        public int DailyRent;
        public int WeeklyRent;
        //private int StartDate;
        //private int EndDate; 
        //private int RemMonthWeeks;

        public int Days;
        public int Weeks;
        public int Months;
        public int DriverCost;
        public int TotalRent;
        public int RemMonthWeekDays;
        public int RemWeekDays;
        public int RemMonthWeeks;
        public int MonthlyRent;
        private void rdonorent_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void cbovtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        private void btncalculaterent_Click(object sender, EventArgs e)
        {
            DateTime StartDate = Convert.ToDateTime(dtprenteddate.Text);
            DateTime EndDate = Convert.ToDateTime(dtpreturndate.Text);

            int Days = EndDate.Subtract(StartDate).Days;

            int Weeks = Days / 7;
            int Months = Days / 30;
            int RemWeekDays = Days % 7;
            int RemMonthWeeks = (Days % 30) /7 ;
            int RemMonthWeekDays = RemMonthWeeks % 7;

            if(Days <= 7) 
            {
                TotalRent = DailyRent * Days + DriverCost * Days;
                txtTamount.Text = TotalRent.ToString();
            
            }
            else if (Days <= 30 && Days > 7) 
            {
                TotalRent = WeeklyRent * Weeks + DailyRent + RemWeekDays + DriverCost * Days;
                txtTamount.Text = TotalRent.ToString();
            
            }
            else if (Days > 30) 
            { 
                TotalRent = MonthlyRent * Months + RemMonthWeeks * WeeklyRent + Weeks + DriverCost * Days;
            
            }
                
               

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
        }

        private void rdodryes_CheckedChanged(object sender, EventArgs e)
        {
            


        }

        private void cbovtype2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbovehicletype.SelectedItem == "Small Car")
            {
                DailyRent = 4000;
                txtdailyrent.Text = DailyRent.ToString();
                WeeklyRent = 28000;
                txtweeklyrent.Text = WeeklyRent.ToString();
                MonthlyRent = 112000;
                txtmonthlyrent.Text = MonthlyRent.ToString();

            }
            else if (Cbovehicletype.SelectedItem == "KDH Van")
            {
                DailyRent = 5000;
                txtdailyrent.Text = DailyRent.ToString();
                WeeklyRent = 35000;
                txtweeklyrent.Text = WeeklyRent.ToString();
                MonthlyRent = 140000;
                txtmonthlyrent.Text = MonthlyRent.ToString();

            }
            else if (Cbovehicletype.SelectedItem == "Mini Van") 
            {

                DailyRent = 6000;
                txtdailyrent.Text = DailyRent.ToString();
                WeeklyRent = 42000;
                txtweeklyrent.Text = WeeklyRent.ToString();
                MonthlyRent = 168000;
                txtmonthlyrent.Text = MonthlyRent.ToString();

            }
            else if (Cbovehicletype.SelectedItem == "Sedan Car")
                
            {
                DailyRent = 8000;
                txtdailyrent.Text = DailyRent.ToString();
                WeeklyRent = 56000;
                txtweeklyrent.Text = WeeklyRent.ToString();
                MonthlyRent = 224000;

            }
            else 
            {
                DailyRent = 0;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Yes")
            {
                DriverCost = 3000;
                txtdrivercost.Text = DriverCost.ToString();

            }
            else 
            {

                DriverCost = 0;
                txtdrivercost.Text = DriverCost.ToString();


            }
            

            
            
        }
    }
}
