using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.OleDb;
using System.Globalization;

namespace Schedully.Controls
{
    public partial class UserControlAdd : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        List<string> appointmentDates = new List<string>();
        List<string> appointmentTimes = new List<string>();

        public UserControlAdd()
        {
            InitializeComponent();
        }

        private void RoundButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Change this value for more/less rounding
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void ResetRadioButtons()
        {
            foreach (Control ctrl in Apptype.Controls)
            {
                if (ctrl is System.Windows.Forms.RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
        }

        private void UserControlAdd_Load(object sender, EventArgs e)
        {
            LoadData();
            loaddateandtime();
        }

        private void LoadData()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb");
            da = new OleDbDataAdapter("SELECT * FROM clients", myConn);

            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "clients");
            dgvappoint.DataSource = ds.Tables["clients"];
            myConn.Close();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = date.Value.Date;   //ang gi pick sa user na date
            DateTime currentDate = DateTime.Today;    // karung adlawa
            string timeselect = apptime.SelectedItem?.ToString();

            // 1. Past‑date check
            if (selectedDate < currentDate)
            {
                MessageBox.Show("Unavailable date");
                return;
            }
            int appointmentExists = 0;
            
            string dateselect = date.Value.ToString("MM/dd/yyyy");

            for (int i = 0; i < appointmentDates.Count; i++) {

                if (dateselect == appointmentDates[i] && timeselect == appointmentTimes[i])
                {
                    appointmentExists = 1;
                    break;
                }
            
            
            }


            if (appointmentExists==1)
            {
                MessageBox.Show("That schedule is taken");
            }
            else
            {
                CreateAppointment();
            }

        }

        private void CreateAppointment()
        {
            string type = Onsite.Checked ? "Onsite" : Virtual.Checked ? "Virtual" : "";
            string covid = yescovid.Checked ? "Yes" : nocovid.Checked ? "No" : "";

            string insertFullClientQuery = "INSERT INTO clientfull (Firstname, Lastname, Midinitial, Age, Gender, Contact, Address, Covid, Symptoms, Program, [Type], [Appointment Date], [Appointment Time], Fname, Lname, ParContact, ParAddress) " +
                                           "VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";

           

            using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    myConn.Open();

                    // Insert into fullclient
                    using (OleDbCommand clientCmd = new OleDbCommand(insertFullClientQuery, myConn))
                    {
                        clientCmd.Parameters.AddWithValue("?", fname.Text);
                        clientCmd.Parameters.AddWithValue("?", lname.Text);
                        clientCmd.Parameters.AddWithValue("?", Midinit.Text);
                        clientCmd.Parameters.AddWithValue("?", age.Text);
                        clientCmd.Parameters.AddWithValue("?", Gender.SelectedItem?.ToString() ?? "");
                        clientCmd.Parameters.AddWithValue("?", Contact.Text);
                        clientCmd.Parameters.AddWithValue("?", addres.Text);
                        clientCmd.Parameters.AddWithValue("?", covid);
                        clientCmd.Parameters.AddWithValue("?", symptoms.Text);
                        clientCmd.Parameters.AddWithValue("?", coursecombo.SelectedItem?.ToString() ?? "");
                        
                        clientCmd.Parameters.AddWithValue("?", type);
                        clientCmd.Parameters.AddWithValue("?", date.Value.ToString("MM/dd/yyyy"));
                        clientCmd.Parameters.AddWithValue("?", apptime.SelectedItem?.ToString() ?? "");                                                   
                        clientCmd.Parameters.AddWithValue("?", parentfname.Text);
                        clientCmd.Parameters.AddWithValue("?", parentlname.Text);
                        clientCmd.Parameters.AddWithValue("?", parentcontact.Text);
                        clientCmd.Parameters.AddWithValue("?", parentaddress.Text);
                       
                        clientCmd.ExecuteNonQuery();
                    }

                   
                   

                    MessageBox.Show("Appointment Created Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            ResetFields();
            LoadData();
        }

        private void ResetFields()
        {
            fname.Text = "";
            lname.Text = "";
            Midinit.Text = "";
            age.Text = "";
            Gender.SelectedIndex = -1;
            ResetRadioButtons();
            apptime.SelectedIndex = -1;

            // Reset parent info
            parentfname.Text = "";
            parentlname.Text = "";
            parentcontact.Text = "";
            parentaddress.Text = "";
            Contact.Text = "";
            addres.Text = "";
            symptoms.Text = "";
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            loaddateandtime();
        }

        private void loaddateandtime()
        {
            string query = "SELECT [Appointment Date], [Appointment Time] FROM Appointments";

          
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
                                string date = reader["Appointment Date"].ToString();
                                string time = reader["Appointment Time"].ToString();

                                appointmentDates.Add(date);
                                appointmentTimes.Add(time);
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



        public abstract class Methods
        {
            public abstract void LoadData();
            public abstract void CreateAppointment();
            public abstract void ResetFields();

          
            

            
            
        }


        public class UserControlAddMethods : Methods
        {
            private UserControlAdd userControl;

            public UserControlAddMethods(UserControlAdd userControl)
            {
                this.userControl = userControl;
            }

            public override void LoadData()
            {
                userControl.LoadData();
            }

            public override void CreateAppointment()
            {
                userControl.CreateAppointment();
            }

            public override void ResetFields()
            {
                userControl.ResetFields();
            }
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}