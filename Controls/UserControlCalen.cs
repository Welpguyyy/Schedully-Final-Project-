using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.OleDb;

namespace Schedully.Controls
{
    public partial class UserControlCalen : UserControl
    {
        public static int _year, _month;
        private Dictionary<DateTime, int> appointmentCounts = new Dictionary<DateTime, int>();
        private List<DateTime> appointmentDates = new List<DateTime>();

        public UserControlCalen()
        {
            InitializeComponent();
        }
        private void clientnamesload()
        {
            string query = "SELECT Firstname, Lastname FROM Clients";

            List<string> clientNames = new List<string>();
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string firstName = reader["Firstname"].ToString();
                                string lastName = reader["Lastname"].ToString();
                                string fullName = $"{firstName} {lastName}";
                                clientNames.Add(fullName);
                            }
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        public UserControlDay UserControlDay
        {
            get => default;
            set
            {
            }
        }

        private void UserControlCalen_Load(object sender, EventArgs e)
        {
            loaddate();
            timer1.Start();
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
                UserControlDay uc = new UserControlDay("", 0, this);
                calendarflow.Controls.Add(uc);
            }

            // Add controls for each day of the month
            for (int i = 1; i <= day; i++)
            {

                DateTime currentDate = new DateTime(year, month, i);

                int appointmentCount = appointmentCounts.ContainsKey(currentDate) ? appointmentCounts[currentDate] : 0;
                UserControlDay uc = new UserControlDay(i.ToString(), appointmentCount, this);
                calendarflow.Controls.Add(uc);
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
            loaddate(); // Load appointment data before showing days
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
            loaddate();
            showdays(_month, _year);
        }

        private void loaddate()
        {
            appointmentDates.Clear(); // Clear previous data
            appointmentCounts.Clear(); // Clear previous data

            string query = "SELECT [Appointment Date] FROM Appointments";

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["Appointment Date"] != DBNull.Value)
                                {
                                    // Convert the value to a string
                                    string appointmentDateString = reader["Appointment Date"].ToString();

                                    // Try to parse the date using the exact format
                                    DateTime appointmentDate;
                                    if (DateTime.TryParseExact(appointmentDateString, "M/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out appointmentDate))
                                    {
                                        // Get only the date part (ignores time)
                                        appointmentDate = appointmentDate.Date;

                                        // Store in list
                                        appointmentDates.Add(appointmentDate);

                                        // Store and count occurrences
                                        if (appointmentCounts.ContainsKey(appointmentDate))
                                            appointmentCounts[appointmentDate]++;
                                        else
                                            appointmentCounts[appointmentDate] = 1;
                                    }
                                    else
                                    {
                                        // Handle the case where parsing fails (optional)
                                        Console.WriteLine("Invalid date format: " + appointmentDateString);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


        private void refresh_Click(object sender, EventArgs e)
        {
            loaddate();
            showdays(_month, _year);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongDateString();
        }
    }

    public partial class CopyOfUserControlCalen : UserControl
    {
        public static int _year, _month;
        private Dictionary<DateTime, int> appointmentCounts = new Dictionary<DateTime, int>();
        private List<DateTime> appointmentDates = new List<DateTime>();

        public CopyOfUserControlCalen()
        {
            InitializeComponent();
        }

        public CopyOfUserControlDay CopyOfUserControlDay
        {
            get => default;
            set
            {
            }
        }

        private void UserControlCalen_Load(object sender, EventArgs e)
        {
            loaddate();

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
            loaddate(); // Load appointment data before showing days
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
            loaddate();
            showdays(_month, _year);
        }

        private void loaddate()
        {
            appointmentDates.Clear(); // Clear previous data
            appointmentCounts.Clear(); // Clear previous data

            string query = "SELECT [Appointment Date] FROM fullclient";

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["Appointment Date"] != DBNull.Value)
                                {
                                    // Convert the value to a string
                                    string appointmentDateString = reader["Appointment Date"].ToString();

                                    // Try to parse the date using the exact format
                                    DateTime appointmentDate;
                                    if (DateTime.TryParseExact(appointmentDateString, "M/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out appointmentDate))
                                    {
                                        // Get only the date part (ignores time)
                                        appointmentDate = appointmentDate.Date;

                                        // Store in list
                                        appointmentDates.Add(appointmentDate);

                                        // Store and count occurrences
                                        if (appointmentCounts.ContainsKey(appointmentDate))
                                            appointmentCounts[appointmentDate]++;
                                        else
                                            appointmentCounts[appointmentDate] = 1;
                                    }
                                    else
                                    {
                                        // Handle the case where parsing fails (optional)
                                        Console.WriteLine("Invalid date format: " + appointmentDateString);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loaddate();
            showdays(_month, _year);
        }
    }
}