using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Properties;

namespace Schedully
{
    public partial class Inventory : MaterialForm
    {

        private Form1 form1;
        Controls.UserControlCold cold = new Controls.UserControlCold();
        Controls.UserControlCough cough = new Controls.UserControlCough();
        Controls.UserControlFirstaid firstaid = new Controls.UserControlFirstaid();
        Controls.UserControlPain pain = new Controls.UserControlPain();
        Controls.UserControlStomach stomach = new Controls.UserControlStomach();
        Controls.UserControlWound wound = new Controls.UserControlWound();
        public Inventory()
        {
            InitializeComponent();
        }

        public Controls.UserControlCough UserControlCough
        {
            get => default;
            set
            {
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = panel1.ClientRectangle;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel1.Region = new Region(path);

            // Draw Border
            Pen pen = new Pen(Color.FromArgb(207, 216, 220), 6); // Border color + thickness
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = panel2.ClientRectangle;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel2.Region = new Region(path);

            // Draw Border
            Pen pen = new Pen(Color.FromArgb(207, 216, 220), 6); // Border color + thickness
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, path);
        }

        private void painbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(pain);
        }

        private void coldbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(cold);
        }

        private void stomachbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(stomach);
        }

        private void woundbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(wound);
        }

        private void coughbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(cough);
        }

        private void firstbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(firstaid);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.OpenForms["form1"]?.Show();
            this.Hide();
        }
    }
}
