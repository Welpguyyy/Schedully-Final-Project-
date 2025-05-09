using Schedully.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedully
{
    public partial class Calendar : Form
    {
        public static int _year, _month;
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            showdays(DateTime.Now.Month, DateTime.Now.Year);

        }
        private void showdays(int month, int year)
        {
            calendarflow.Controls.Clear();
            _year = year;
            _month = month;

            string monthname = new DateTimeFormatInfo().GetMonthName(month);
            lblmonth.Text = monthname.ToUpper() + " " + year;
            DateTime Startofthemonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(Startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < week; i++)
            {
                
            }
            for (int i = 1; i <= day; i++)
            {
               
            }


        }

        private void next_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showdays(_month, _year);

        }

        private void prev_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showdays(_month, _year);


        }

        private void switchform(Form form)
        {
            if (form == null)
            {

                MessageBox.Show("Form not initialized.");
                return;
            }

            this.Hide();

            if (!form.IsHandleCreated || form.IsDisposed)
            {

                form = new Nurse();
            }

            form.Show();
            form.BringToFront();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

           Nurse nurse = new Nurse();
            switchform(nurse);
        }
        private void backbtn_Mouse_Enter(object sender, EventArgs e)
        {
            backbtn.Size = new Size(105, 90);
           

        }
        private void backbtn_Mouse_Leave(object sender, EventArgs e)
        {
            backbtn.Size = new Size(96, 81);
         
        }
    }
}
