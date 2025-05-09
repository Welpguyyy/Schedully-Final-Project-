using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Schedully
{
    public partial class DoctorLogin : Form
    {
        private Doctor doc;
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void DoctorLogin_Load(object sender, EventArgs e)
        {
            usertxt.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            if (usertxt.Text == "joram" && passtxt.Text == "admin")
            {
                Doctor dashboard = new Doctor(usertxt.Text);
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect Credentials");
                usertxt.Text = null;
                passtxt.Text = null;
            }
        }
    }
}
