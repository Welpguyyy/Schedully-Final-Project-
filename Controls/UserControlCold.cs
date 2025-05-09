using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Schedully.Controls
{
    public interface IColdControl
    {
        void load();
        int GetPillID(string coldName);
        void Update(int pillID, string newValue);

        int GetPillvalue(int pillID);
    }
    public partial class UserControlCold : UserControl, IColdControl
    {
        int count = 0;
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public UserControlCold()
        {
            InitializeComponent();
        }

        private void UserControlCold_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Cold FROM Medicine_Quantity"; // Fetch all rows from Cold column

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> quantities = new List<string>();

                            while (reader.Read()) // Read all rows
                            {
                                quantities.Add(reader["Cold"].ToString());
                            }

                            // Check if there are enough values before accessing them
                            if (quantities.Count >= 6)
                            {
                                allertalbl.Text = "X" + quantities[0];
                                claritinlbl.Text = "X" + quantities[1];
                                zyrteclbl.Text = "X" + quantities[2];
                                cetrilbl.Text = "X" + quantities[3];
                                bioflulbl.Text = "X" + quantities[4];
                                neozeplbl.Text = "X" + quantities[5];
                            }
                            else
                            {
                                MessageBox.Show("Not enough data in the database.");
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


        public int GetPillID(string Name)
        {
            int pillID = -1;
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                string query = "SELECT PillID FROM Medicine_names WHERE Cold = @ColdName";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ColdName", Name);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        pillID = Convert.ToInt32(result);
                    }
                }
            }
            return pillID;
        }
        public void Update(int pillID, string newValue)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zhient\Desktop\projects\Schedully\bin\Debug\Schedully.accdb";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Medicine_Quantity SET Cold = @New WHERE PillID = @PillID";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@New", OleDbType.VarChar).Value = newValue;
                        cmd.Parameters.Add("@PillID", OleDbType.Integer).Value = pillID;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given PillID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating wound: " + ex.Message);
                }

            }
            load();
            coldlbl.Text = "0";
        }
        public int GetPillvalue(int pillid)
        {
            int value = 0;
            List<int> quant = new List<int>();


            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Cold FROM Medicine_Quantity";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                if (int.TryParse(reader["Cold"].ToString(), out int woundValue))
                                {
                                    quant.Add(woundValue);
                                }
                                else
                                {
                                    quant.Add(0);
                                }
                            }


                            for (int i = 0; i < pillid; i++)
                            {

                                if (i == pillid -1 )
                                {
                                    value = quant[i];
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return value;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            count++;


            coldlbl.Text = Convert.ToString(count);
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            count--;


            coldlbl.Text = Convert.ToString(count);
        }

        private void circlebutton1_Click(object sender, EventArgs e)
        {

            string selected = coldbox.SelectedItem.ToString();


            int pillID = GetPillID(selected);
            int quant = GetPillvalue(pillID);
            quant -= count;




            string val = Convert.ToString(quant);
            if (pillID != -1)
            {
                Update(pillID, val);
               
                count = 0;
            }
            else
            {
                MessageBox.Show("Pill not found in Table 1.");
                count = 0;
            }
        }
    }
}
