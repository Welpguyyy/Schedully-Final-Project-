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

namespace Schedully
{
    public partial class Doctor : MaterialForm
    {
        private Form1 form1;

        Controls.UserControlMark markuser = new Controls.UserControlMark();
        Controls.UserControlCalen Calenuser = new Controls.UserControlCalen();
        Controls.UserControlDiag diagnose = new Controls.UserControlDiag();

        private string docname;
        public Doctor(string username)
        {
            InitializeComponent();
            docname = username;

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            timer1.Start();


            pandiagnos.Width = 0;
            panelview.Width = 0;
            sidebar.Height = 0;
            docpanel.Left = sidebar.Left;
            docpanel.Width += 191;

        }

        private void docview_Mouse_Leave(object sender, EventArgs e)
        {
            viewtrans.Start();
            docview.BackColor = Color.FromArgb(187, 222, 251);
        }

        private void back_Click(object sender, EventArgs e)
        {


            Application.OpenForms["form1"]?.Show();
            this.Hide();
        }




        private void docview_Click(object sender, EventArgs e)
        {
            docpanel.Controls.Clear();
            docpanel.Controls.Add(Calenuser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = clientsearch.Text.Trim();

            Controls.UserControlSearch searchuser = new Controls.UserControlSearch(name);
            if (string.IsNullOrWhiteSpace(clientsearch.Text))
            {
                MessageBox.Show("Please Enter a name First");

            }
            else
            {
                docpanel.Controls.Clear();
                docpanel.Controls.Add(searchuser);

            }
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void docpanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, docpanel.ClientRectangle,
    Color.FromArgb(207, 216, 220), 2, ButtonBorderStyle.Solid, // Left
    Color.FromArgb(207, 216, 220), 2, ButtonBorderStyle.Solid, // Top
    Color.FromArgb(207, 216, 220), 2, ButtonBorderStyle.Solid, // Right
    Color.FromArgb(207, 216, 220), 2, ButtonBorderStyle.Solid); // Bottom
        }
        bool sidebarexpand = true;
        private void sidebartrans_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                // Collapse sidebar
                sidebar.Height -= 20;

                if (sidebar.Height <= 0) // Target collapsed height
                {
                    sidebar.Height = 0; // Prevent negative height
                    sidebarexpand = false; // Now it's collapsed
                    sidebartrans.Stop();
                }
            }
            else
            {
                // Expand sidebar
                sidebar.Height += 20;

                if (sidebar.Height >= 865) // Target expanded height
                {

                    sidebar.Height = 865; // Prevent overflow
                    sidebarexpand = true; // Now it's expanded
                    sidebartrans.Stop();
                }
            }

        }


        bool viewextend = false;
        private void viewtrans_Tick(object sender, EventArgs e)
        {
            if (viewextend == false)
            {
                panelview.Width -= 30;
                if (panelview.Width <= 0)
                {
                    viewtrans.Stop();
                    viewextend = true;
                }
            }
            else
            {
                panelview.Width += 30;
                if (panelview.Width >= 97)
                {
                    viewtrans.Stop();
                    viewextend = false;
                }
            }
        }
        bool panelexpand = true;
        int panelTransitionSpeed = 20;  // Speed of movement
        int sidebarWidth = 191;
        private void paneltrans_Tick(object sender, EventArgs e)
        {

            if (panelexpand)
            {
                // Sidebar is collapsing → Expand panel left
                docpanel.Left -= panelTransitionSpeed;
                docpanel.Width += panelTransitionSpeed;

                // Check if transition is complete
                if (docpanel.Left <= sidebar.Left)
                {
                    docpanel.Left = sidebar.Left;
                    docpanel.Width += (sidebarWidth - (docpanel.Left - sidebar.Left));  // Ensure full width gain
                    panelexpand = false;
                    paneltrans.Stop();
                }
            }
            else
            {
                // Sidebar is expanding → Shrink panel right
                docpanel.Left += panelTransitionSpeed;
                docpanel.Width -= panelTransitionSpeed;

                // Check if transition is complete
                if (docpanel.Left >= sidebar.Left + sidebarWidth)
                {
                    docpanel.Left = sidebar.Left + sidebarWidth;
                    docpanel.Width -= (docpanel.Left - (sidebar.Left + sidebarWidth));  // Ensure width reset
                    panelexpand = true;
                    paneltrans.Stop();
                }
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            sidebartrans.Start();
            paneltrans.Start();
        }

        private void docmark_MouseHover(object sender, EventArgs e)
        {
            marktrans.Start();
        }

        private void docview_MouseHover(object sender, EventArgs e)
        {
            viewtrans.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();

        }

        bool diagextend = false;
        private void marktrans_Tick(object sender, EventArgs e)
        {
            if (diagextend == false)
            {
                pandiagnos.Width -= 30;
                if (pandiagnos.Width <= 0)
                {
                    marktrans.Stop();
                    diagextend = true;
                }
            }
            else
            {
                pandiagnos.Width += 30;
                if (pandiagnos.Width >= 97)
                {
                    marktrans.Stop();
                    diagextend = false;
                }
            }

        }

        private void diagnose_MouseHover(object sender, EventArgs e)
        {
            marktrans.Start();
        }

        private void diagnose_MouseLeave(object sender, EventArgs e)
        {
            marktrans.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void diagnosebtn_Click(object sender, EventArgs e)
        {

            docpanel.Controls.Clear();
            docpanel.Controls.Add(diagnose);



        }

        private void diagnosebtn_MouseHover(object sender, EventArgs e)
        {
            marktrans.Start();
        }

        private void diagnosebtn_MouseLeave(object sender, EventArgs e)
        {
            marktrans.Start();
        }

        public Controls.CopyOfUserControlCalen CopyOfUserControlCalen
        {
            get => default;
            set
            {
            }
        }
    }
}
