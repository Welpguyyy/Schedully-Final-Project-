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

namespace Schedully.Controls
{
    public partial class UserControlDelete : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb";

        public UserControlDelete()
        {
            InitializeComponent();
        }

        private void UserControlDelete_Load(object sender, EventArgs e)
        {
            loadtable();
        }
       public abstract class Methods
        {
            protected string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb";


            public abstract void DeleteRecord(string tableName, string columnName, string value);


            public abstract DataTable LoadData(string tableName);


            protected OleDbConnection GetConnection()
            {
                return new OleDbConnection(connectionString);
            }
        }


        public class DatabaseMethods : Methods
        {
            public override void DeleteRecord(string tableName, string columnName, string value)
            {
                using (OleDbConnection myConn = GetConnection())
                {
                    try
                    {
                        myConn.Open();
                        string query = $"DELETE FROM {tableName} WHERE [{columnName}] = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                        {
                            cmd.Parameters.AddWithValue("?", value);
                            cmd.ExecuteNonQuery();
                        }
                        myConn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                }
            }

            public override DataTable LoadData(string tableName)
            {
                using (OleDbConnection myConn = GetConnection())
                {
                    try
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter($"SELECT * FROM {tableName}", myConn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading data: " + ex.Message);
                        return null;
                    }
                }
            }
        }

        private void loadtable()
        {
            try
            {
                myConn = new OleDbConnection(connection);
                da = new OleDbDataAdapter("SELECT * FROM Clients", myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "clients");
                dgvdel.DataSource = ds.Tables["clients"];
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            Methods dbmethods = new DatabaseMethods();
            try
            {
                dbmethods.DeleteRecord("Appointments", "Appointment ID", clientname.Text);
                dbmethods.DeleteRecord("Clients", "ClientID", clientname.Text);
                dbmethods.DeleteRecord("ParentInfo", "ID", clientname.Text);
                dbmethods.DeleteRecord("Client_DIagnosis", "diagID", clientname.Text);

                MessageBox.Show("Appointment Canceled");
                loadtable(); // Refresh the display
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadtable();
        }

     
       
    }
}
