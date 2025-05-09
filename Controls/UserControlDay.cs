using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Security.Cryptography;
using System.Reflection;

namespace Schedully.Controls
{
    public partial class UserControlDay : UserControl
    {
        private UserControlCalen parentCalen;
        private string _days;
        private string date;
        public List<string> names { get; private set; }
        public List<string> type { get; private set; }
        List<int> IDs = new List<int>();
        public UserControlDay(string days, int appointmentCount, UserControlCalen calen)
        {
            InitializeComponent();
            parentCalen = calen;
            names = new List<string>();
            type = new List<string>();
            _days = days;
            daynum.Text = days;
            daycheck.Hide();
            date = $"{UserControlCalen._month:D2}/{_days:D2}/{UserControlCalen._year}";

            if (appointmentCount > 0)
            {
                daypic.Show();
            }

            if(appointmentCount == 6)
            {
                fully.Show();
            }

                lblcount.Text = appointmentCount > 0 ? appointmentCount.ToString() : "";
        }

        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                string weekdays = day.ToString("ddd");
                if (weekdays == "Sun")
                {
                    daynum.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    daynum.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            catch (Exception)
            {
                // Handle parsing errors if necessary
            }
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {


        }

        private void daypanel_Click(object sender, EventArgs e)
        {
            getclientids(date);
            loadnametype();


            if (names.Count == 0)
            {
                MessageBox.Show("No clients", "Clients on this day");
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < names.Count; i++)
                {
                    sb.AppendLine($"{names[i],-25} {type[i]}"); // -25 pads names for alignment
                }

                MessageBox.Show(sb.ToString(), "Clients on this day");
            }
        }

        private void daypanel_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting logic if needed
        }


        private void getclientids(string date)
        {
            IDs.Clear(); // Clear the list before adding new IDs
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb";
            string query = "SELECT [Appointment ID] FROM Appointments WHERE [Appointment date] = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Use the date string directly as a parameter
                        command.Parameters.AddWithValue("?", date);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    IDs.Add(reader.GetInt32(0)); // Or GetValue(0) if you're unsure of the type
                                }
                            }
                        }
                    }
                }
                catch (OleDbException oleDbEx)
                {
                    MessageBox.Show("Database error: " + oleDbEx.Message, "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching appointment IDs: " + ex.Message, "Error");
                }
            }


        }

        private void loadnametype()
        {
            names.Clear();
            type.Clear();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                for (int i = 0; i < IDs.Count; i++)
                {
                    // Step 1: Get Client Name
                    string clientQuery = "SELECT Firstname, Lastname FROM Clients WHERE ClientID = ?";
                    using (OleDbCommand clientCmd = new OleDbCommand(clientQuery, connection))
                    {
                        clientCmd.Parameters.AddWithValue("?", IDs[i]);

                        using (OleDbDataReader reader = clientCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fname = reader["Firstname"].ToString();
                                string lname = reader["Lastname"].ToString();
                                string fullname = $"{fname} {lname}";
                                names.Add(fullname);
                            }
                        }
                    }

                    // Step 2: Get Appointment Type
                    string appointmentQuery = "SELECT Type FROM Appointments WHERE [Appointment ID] = ?";
                    using (OleDbCommand appointmentCmd = new OleDbCommand(appointmentQuery, connection))
                    {
                        appointmentCmd.Parameters.AddWithValue("?", IDs[i]);

                        using (OleDbDataReader reader = appointmentCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string typeValue = reader["Type"].ToString();
                                type.Add(typeValue);
                            }
                            else
                            {
                                type.Add("");
                            }
                        }
                    }
                }


            }
        }

        private void daypanel_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 150, 79);
        }

        private void daypanel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 150, 79);
        }

        private void daypanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }

    public partial class Copy1OfUserControlDay : UserControl
    {
        private UserControlCalen parentCalen;
        private string _days;
        private string date;
        public List<string> names { get; private set; }
        public List<string> type { get; private set; }
        List<int> IDs = new List<int>();
        public Copy1OfUserControlDay(string days, int appointmentCount, UserControlCalen calen)
        {
            InitializeComponent();
            parentCalen = calen;
            names = new List<string>();
            type = new List<string>();
            _days = days;
            daynum.Text = days;
            daycheck.Hide();
            date = $"{UserControlCalen._month:D2}/{_days:D2}/{UserControlCalen._year}";

            if (appointmentCount > 0)
            {
                daypic.Show();
            }

            if (appointmentCount == 6)
            {
                fully.Show();
            }

            lblcount.Text = appointmentCount > 0 ? appointmentCount.ToString() : "";
        }

        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                string weekdays = day.ToString("ddd");
                if (weekdays == "Sun")
                {
                    daynum.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    daynum.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            catch (Exception)
            {
                // Handle parsing errors if necessary
            }
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {


        }

        private void daypanel_Click(object sender, EventArgs e)
        {
            getclientids(date);
            loadnametype();


            if (names.Count == 0)
            {
                MessageBox.Show("No clients", "Clients on this day");
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < names.Count; i++)
                {
                    sb.AppendLine($"{names[i],-25} {type[i]}"); // -25 pads names for alignment
                }

                MessageBox.Show(sb.ToString(), "Clients on this day");
            }
        }

        private void daypanel_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting logic if needed
        }


        private void getclientids(string date)
        {
            IDs.Clear(); // Clear the list before adding new IDs
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb";
            string query = "SELECT [Appointment ID] FROM Appointments WHERE [Appointment date] = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Use the date string directly as a parameter
                        command.Parameters.AddWithValue("?", date);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    IDs.Add(reader.GetInt32(0)); // Or GetValue(0) if you're unsure of the type
                                }
                            }
                        }
                    }
                }
                catch (OleDbException oleDbEx)
                {
                    MessageBox.Show("Database error: " + oleDbEx.Message, "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching appointment IDs: " + ex.Message, "Error");
                }
            }


        }

        private void loadnametype()
        {
            names.Clear();
            type.Clear();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                for (int i = 0; i < IDs.Count; i++)
                {
                    // Step 1: Get Client Name
                    string clientQuery = "SELECT Firstname, Lastname FROM Clients WHERE ClientID = ?";
                    using (OleDbCommand clientCmd = new OleDbCommand(clientQuery, connection))
                    {
                        clientCmd.Parameters.AddWithValue("?", IDs[i]);

                        using (OleDbDataReader reader = clientCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fname = reader["Firstname"].ToString();
                                string lname = reader["Lastname"].ToString();
                                string fullname = $"{fname} {lname}";
                                names.Add(fullname);
                            }
                        }
                    }

                    // Step 2: Get Appointment Type
                    string appointmentQuery = "SELECT Type FROM Appointments WHERE [Appointment ID] = ?";
                    using (OleDbCommand appointmentCmd = new OleDbCommand(appointmentQuery, connection))
                    {
                        appointmentCmd.Parameters.AddWithValue("?", IDs[i]);

                        using (OleDbDataReader reader = appointmentCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string typeValue = reader["Type"].ToString();
                                type.Add(typeValue);
                            }
                            else
                            {
                                type.Add("");
                            }
                        }
                    }
                }


            }
        }

        private void daypanel_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 150, 79);
        }

        private void daypanel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 150, 79);
        }

        private void daypanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }


    public partial class CopyOfUserControlDay : UserControl
    {
        private string _days;
        private string date;

        public CopyOfUserControlDay(string days, int appointmentCount, UserControlCalen calen)
        {
            InitializeComponent();
            _days = days;
            daynum.Text = days;
            daycheck.Hide();
            date = UserControlCalen._month + "/" + _days + "/" + UserControlCalen._year;

            if (appointmentCount > 0)
            {
                daypic.Show();
            }


            lblcount.Text = appointmentCount > 0 ? appointmentCount.ToString() : "";
        }

        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                string weekdays = day.ToString("ddd");
                if (weekdays == "Sun")
                {
                    daynum.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    daynum.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            catch (Exception)
            {
                // Handle parsing errors if necessary
            }
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }

        private void daypanel_Click(object sender, EventArgs e)
        {
            if (daycheck.Checked == false)
            {
                daycheck.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
            }
            else
            {
                daycheck.Checked = false;
                this.BackColor = Color.Gray;
            }
        }

        private void daypanel_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting logic if needed
        }
        private void loadsearch()
        {







        }
    }
}