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
using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Xml.Linq;
using System.Globalization;


namespace Schedully.Controls
{
    public partial class UserControlUpdate : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
       
       public UserControlUpdate()
        {
            InitializeComponent();
        }

        private void UserControlUpdate_Load(object sender, EventArgs e)
        {
            loadtable();
        }
        private void loadtable()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb");
            da = new OleDbDataAdapter("SELECT * FROM Clients", myConn);

            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Clients");
            dgvupdate.DataSource = ds.Tables["Clients"];
            myConn.Close();


        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            string enteredName = clientsearch.Text.Trim();

            if (string.IsNullOrEmpty(enteredName))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();

                   // Find ClientID using Firstname
                    string getIdQuery = "SELECT ClientID FROM clients WHERE Firstname = ?";
                    int clientId = -1;

                    using (OleDbCommand getIdCmd = new OleDbCommand(getIdQuery, conn))
                    {
                        getIdCmd.Parameters.AddWithValue("?", enteredName);
                        object result = getIdCmd.ExecuteScalar();

                        if (result != null)
                        {
                            clientId = Convert.ToInt32(result);
                            clientid.Text = clientId.ToString(); // Store ClientID in the hidden or visible textbox
                        }
                        else
                        {
                            MessageBox.Show("Client not found.");
                            return;
                        }
                    }

                  //Load ClientDetails
                    string clientQuery = "SELECT * FROM Clients WHERE ClientID = ?";
                    using (OleDbCommand clientCmd = new OleDbCommand(clientQuery, conn))
                    {
                        clientCmd.Parameters.AddWithValue("?", clientId);
                        using (OleDbDataReader reader = clientCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Client Found!");
                                Fname.Text = reader["Firstname"].ToString();
                                Lname.Text = reader["Lastname"].ToString();
                                Mid.Text = reader["Midinitial"].ToString();
                                age.Text = reader["Age"].ToString();
                                Gender.SelectedItem = reader["Gender"].ToString();
                                contact.Text = reader["Contact"].ToString();
                                address.Text = reader["Address"].ToString();
                                symptoms.Text = reader["Symptoms"].ToString();
                                coursecombo.SelectedItem = reader["Program"].ToString();

                                string covid = reader["Covid"].ToString();
                                yescovid.Checked = covid == "Yes";
                                nocovid.Checked = covid == "No";
                            }
                        }
                    }

                    //  Load AppointmentDetails
                    string appQuery = "SELECT * FROM Appointments WHERE [Appointment ID] = ?";
                    using (OleDbCommand appCmd = new OleDbCommand(appQuery, conn))
                    {
                        appCmd.Parameters.AddWithValue("?", clientId);
                        using (OleDbDataReader reader = appCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string type = reader["Type"].ToString();
                                Onsite.Checked = type == "Onsite";
                                Virtual.Checked = type == "Virtual";

                                string dateString = reader["Appointment Date"].ToString();
                                if (!string.IsNullOrWhiteSpace(dateString) &&
                                    DateTime.TryParseExact(dateString, "MM/dd/yyyy", CultureInfo.InvariantCulture,
                                                           DateTimeStyles.None, out DateTime parsedDate))
                                {
                                    date.Value = parsedDate;
                                }

                                apptime.SelectedItem = reader["Appointment Time"].ToString();
                            }
                        }
                    }

                    //Load ParentInfo
                    string parentQuery = "SELECT * FROM ParentInfo WHERE ID = ?";
                    using (OleDbCommand parentCmd = new OleDbCommand(parentQuery, conn))
                    {
                        parentCmd.Parameters.AddWithValue("?", clientId);
                        using (OleDbDataReader reader = parentCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                parentfname.Text = reader["Fname"].ToString();
                                parentlname.Text = reader["Lname"].ToString();
                                parentcontact.Text = reader["ParContact"].ToString();
                                parentaddress.Text = reader["ParAddress"].ToString();
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
    
        private void updatebtn_Click(object sender, EventArgs e)
        {
            string type = Onsite.Checked ? "Onsite" : Virtual.Checked ? "Virtual" : "";
            string covid = yescovid.Checked ? "Yes" : nocovid.Checked ? "No" : "";

            string updateClientQuery = "UPDATE fullclient SET " +
                                       "Lastname = ?, Midinitial = ?, Age = ?, Gender = ?, [Type] = ?, " +
                                       "[Appointment Date] = ?, [Appointment Time] = ?, Contact = ?, Address = ?, " +
                                       "Covid = ?, Symptoms = ?, Fname = ?, Lname = ?, ParContact = ?, ParAddress = ? " +
                                       "Program = ? "+ "WHERE Firstname = ?";

            using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    myConn.Open();

                    using (OleDbCommand clientCmd = new OleDbCommand(updateClientQuery, myConn))
                    {
                        clientCmd.Parameters.AddWithValue("?", Lname.Text);
                        clientCmd.Parameters.AddWithValue("?", Mid.Text);
                        clientCmd.Parameters.AddWithValue("?", age.Text);
                        clientCmd.Parameters.AddWithValue("?", Gender.SelectedItem?.ToString() ?? "");
                        clientCmd.Parameters.AddWithValue("?", type);
                        clientCmd.Parameters.AddWithValue("?", date.Value.ToString("MM/dd/yyyy"));
                        clientCmd.Parameters.AddWithValue("?", apptime.SelectedItem?.ToString() ?? "");
                        clientCmd.Parameters.AddWithValue("?", contact.Text);
                        clientCmd.Parameters.AddWithValue("?", address.Text);
                        clientCmd.Parameters.AddWithValue("?", covid);
                        clientCmd.Parameters.AddWithValue("?", symptoms.Text);
                        clientCmd.Parameters.AddWithValue("?", parentfname.Text);
                        clientCmd.Parameters.AddWithValue("?", parentlname.Text);
                        clientCmd.Parameters.AddWithValue("?", parentcontact.Text);
                        clientCmd.Parameters.AddWithValue("?", parentaddress.Text);
                        clientCmd.Parameters.AddWithValue("?", coursecombo.SelectedItem?.ToString() ?? "");

                        // WHERE condition parameter
                        clientCmd.Parameters.AddWithValue("?", Fname.Text); // Firstname to identify the record

                        clientCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Appointment Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadtable();
        }
    }
}
