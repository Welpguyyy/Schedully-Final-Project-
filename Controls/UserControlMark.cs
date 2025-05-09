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
    public partial class UserControlMark : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        private int selectedRowIndex = -1;
        public UserControlMark()
        {
            InitializeComponent();
        }



        private void UserControlMark_Load(object sender, EventArgs e)
        {
            loadtable();
        }
        private void loadtable()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb");
            da = new OleDbDataAdapter("SELECT *FROM clients", myConn);

            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "clients");
            dgvmark.DataSource = ds.Tables["clients"];
            myConn.Close();

        }



        private void dgvmark_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get the row index at the click position
                var hitTest = dgvmark.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    // Select the row
                    dgvmark.ClearSelection();
                    dgvmark.Rows[hitTest.RowIndex].Selected = true;
                    selectedRowIndex = hitTest.RowIndex;
                }
            }
        }

        private void markCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clientId = dgvmark.Rows[selectedRowIndex].Cells["ClientID"].Value.ToString();
            mark(clientId);

            MessageBox.Show("This Appoointment is Completed");
            loadtable();
        }

        private void mark(string ID)
        {
            using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    myConn.Open();

                    // Delete from Appointments first
                    string query2 = "DELETE FROM Appointments WHERE [Appointment ID] = ?";
                    using (var command = new OleDbCommand(query2, myConn))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", ID);
                        command.ExecuteNonQuery();
                    }

                    // Then delete from Clients
                    string query = "DELETE FROM Clients WHERE ClientID = ?";
                    using (var command2 = new OleDbCommand(query, myConn))
                    {
                        command2.Parameters.AddWithValue("@ClientID", ID);
                        command2.ExecuteNonQuery();
                    }

                    string query3 = "DELETE FROM Client_DIagnosis WHERE diagID = ?";
                    using (var command3 = new OleDbCommand(query3, myConn))
                    {
                        command3.Parameters.AddWithValue("@diagID", ID);
                        command3.ExecuteNonQuery();
                    }
                    string query4 = "DELETE FROM ParentInfo WHERE ID = ?";
                    using (var command4 = new OleDbCommand(query4, myConn))
                    {
                        command4.Parameters.AddWithValue("@ID", ID);
                        command4.ExecuteNonQuery();
                    }




                    loadtable(); // Refresh the display
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
