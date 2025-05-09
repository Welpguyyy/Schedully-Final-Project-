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
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Schedully.Controls
{
    public partial class UserControlSearch : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        string clientsearch;
        public UserControlSearch(string name)
        {
         clientsearch = name;
            InitializeComponent();
        }

        private void UserControlSearch_Load(object sender, EventArgs e)
        {
            loadsearch();
        }

        private void loadsearch()
        {
            
            string query = "Select Firstname From Clients";

            List<string> clientnames = new List<string>();
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
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
                                string fullName = reader["Firstname"].ToString();
                                string firstName = fullName.Split(' ')[0]; // Get first name
                                clientnames.Add(firstName);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            string[] names = clientnames.ToArray();
            string client;
            int i, indic=0;

            for (i = 0; i < names.Length; i++) {
                if (clientsearch == names[i]) {

                    client = names[i];
                    searched(client);
                    indic++;
                    break;
                }
            
            
            
            }
            if (indic == 0) {

                MessageBox.Show("Client not found");
            }
            else
            {
                MessageBox.Show("Client Found!");
            }





        }
        private void searched(string name)
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zhient\Desktop\projects\Schedully\bin\Debug\Schedully.accdb";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT Firstname, Lastname, Midinitial, Age, Gender, Contact, Address, Covid, Symptoms, Program, 
                       Type, [Appointment Date], [Appointment Time], Fname, Lname, ParContact, ParAddress 
                FROM clientfull 
                WHERE Firstname = @FirstName";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", name);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fname.Text = reader["Firstname"].ToString().Trim();
                                lname.Text = reader["Lastname"].ToString().Trim();
                                Midinit.Text = reader["Midinitial"].ToString().Trim();
                                age.Text = reader["Age"].ToString();
                                Gender.SelectedItem = reader["Gender"].ToString().Trim();
                                Contact.Text = reader["Contact"].ToString().Trim();
                                addres.Text = reader["Address"].ToString().Trim();
                                symptoms.Text = reader["Symptoms"].ToString().Trim();
                                coursecombo.SelectedItem = reader["Program"].ToString().Trim();
                                apptime.SelectedItem = reader["Appointment Time"].ToString().Trim();

                                parentfname.Text = reader["Fname"].ToString().Trim();
                                parentlname.Text = reader["Lname"].ToString().Trim();
                                parentcontact.Text = reader["ParContact"].ToString().Trim();
                                parentaddress.Text = reader["ParAddress"].ToString().Trim();

                                Onsite.Checked = reader["Type"].ToString() == "Onsite";
                                Virtual.Checked = reader["Type"].ToString() == "Online";

                                yescovid.Checked = reader["Covid"].ToString() == "Yes";
                                nocovid.Checked = reader["Covid"].ToString() == "No";

                                string dateString = reader["Appointment Date"].ToString();
                                if (!string.IsNullOrWhiteSpace(dateString))
                                {
                                    if (DateTime.TryParseExact(dateString, "MM/dd/yyyy",
                                                               System.Globalization.CultureInfo.InvariantCulture,
                                                               System.Globalization.DateTimeStyles.None,
                                                               out DateTime parsedDate))
                                    {
                                        date.Value = parsedDate;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid date format.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No appointment date found.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Client not found.");
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
    }
}
