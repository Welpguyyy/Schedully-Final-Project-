using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedully.Controls
{
    public interface IpainControl
    {
        void load();
        int GetPillID(string Name);
        void Update(int pillid, string newValue);

        int GetPillvalue(int pillID);
    }
    public partial class UserControlPain : UserControl, IpainControl
    {
        int count = 0;
        public UserControlPain()
        {
            InitializeComponent();
        }

        private void UserControlPain_Load(object sender, EventArgs e)
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
                    string query = "SELECT Pain FROM Medicine_Quantity"; // Fetch all rows from Cold column

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> quantities = new List<string>();

                            while (reader.Read()) // Read all rows
                            {
                                quantities.Add(reader["Pain"].ToString());
                            }

                            // Check if there are enough values before accessing them
                            if (quantities.Count >= 6)
                            {
                                biolbl.Text = "X" + quantities[0];
                                calpollbl.Text = "X" + quantities[1];
                                medilbl.Text = "X" + quantities[2];
                                advillbl.Text = "X" + quantities[3];
                                dolfenallbl.Text = "X" + quantities[4];
                                mefenamiclbl.Text = "X" + quantities[5];
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
                string query = "SELECT PillID FROM Medicine_names WHERE Pain = @Name";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
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

                    string query = "UPDATE Medicine_Quantity SET Pain = @New WHERE PillID = @PillID";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@New", OleDbType.VarChar).Value = newValue;
                        cmd.Parameters.Add("@PillID", OleDbType.Integer).Value = pillID;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(" updated successfully.");
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
            count = 0;
            painlbl.Text = "0";


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
                    string query = "SELECT Pain FROM Medicine_Quantity";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                if (int.TryParse(reader["Pain"].ToString(), out int woundValue))
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

                                if (i == pillid - 1)
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


            painlbl.Text = Convert.ToString(count);
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            count--;


            painlbl.Text = Convert.ToString(count);
        }

        private void circlebutton1_Click(object sender, EventArgs e)
        {

            string selected = painbox.SelectedItem.ToString();


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
