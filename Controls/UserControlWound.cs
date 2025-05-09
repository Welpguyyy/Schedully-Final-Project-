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
    public interface IWoundControl
    {
        void LoadWoundData();
        int GetPillID(string woundName);
        void UpdateWound(int pillID, string newWoundValue);

        int GetPillvalue(int pillID);
    }
    public partial class UserControlWound : UserControl, IWoundControl
    {
        int count = 0;
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        public UserControlWound()
        {
            InitializeComponent();
        }

        private void UserControlWound_Load(object sender, EventArgs e)
        {

            LoadWoundData();
        }

        private void Biogesic_Paint(object sender, PaintEventArgs e)
        {
            int borderWidth = 5; // Adjust thickness as needed
            Color borderColor = Color.Gray; // Change to desired color

            Control panel = sender as Control;
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, panel.Width - 1, panel.Height - 1));
            }
        }
        public void LoadWoundData()
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Wound FROM Medicine_Quantity"; // Fetch all rows from Cold column

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> quantities = new List<string>();

                            while (reader.Read()) // Read all rows
                            {
                                quantities.Add(reader["Wound"].ToString());
                            }

                            // Check if there are enough values before accessing them
                            if (quantities.Count >= 6)
                            {
                                betalbl.Text = "X" + quantities[0];
                                greenlbl.Text = "X" + quantities[1];
                                isolbl.Text = "X" + quantities[2];
                                nebalbl.Text = "X" + quantities[3];
                                fusidilbl.Text = "X" + quantities[4];
                                calalbl.Text = "X" + quantities[5];
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

        private void addbtn_Click(object sender, EventArgs e)
        {

            count++;


            quantlbl.Text = Convert.ToString(count);
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            count--;
            quantlbl.Text = Convert.ToString(count);
        }


        public int GetPillID(string woundname)
        {

            int pillID = -1;
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                string query = "SELECT PillID FROM Medicine_names WHERE Wound = @WoundName";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@WoundName", woundname);
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
        public void UpdateWound(int pillID, string newWoundValue)
        {


            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zhient\Desktop\projects\Schedully\bin\Debug\Schedully.accdb";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Medicine_Quantity SET Wound = @NewWound WHERE PillID = @PillID";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@NewWound", OleDbType.VarChar).Value = newWoundValue;
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
            LoadWoundData();
            count++;
            quantlbl.Text = "0";

        }

        private void circlebutton1_Click(object sender, EventArgs e)
        {

            string selectedWound = woundbox.SelectedItem.ToString();


            int pillID = GetPillID(selectedWound);
            int quant = GetPillvalue(pillID);
            quant -= count;




            string val = Convert.ToString(quant);
            if (pillID != -1)
            {
                UpdateWound(pillID, val);
              
                count = 0;
            }
            else
            {
                MessageBox.Show("Pill not found in Table 1.");
                count = 0;
            }
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
                    string query = "SELECT Wound FROM Medicine_Quantity"; // Fetch all rows from Cold column

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                if (int.TryParse(reader["Wound"].ToString(), out int woundValue))
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
