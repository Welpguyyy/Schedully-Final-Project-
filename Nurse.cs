using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Schedully
{
    public partial class Nurse : MaterialForm
    {
        private Form1 form1;
        private SoundPlayer sound;
        Controls.UserControlAdd adduser = new Controls.UserControlAdd();
        Controls.UserControlDelete deluser = new Controls.UserControlDelete();
        Controls.UserControlUpdate updateuser = new Controls.UserControlUpdate();
        Controls.UserControlCalen Calendaruser = new Controls.UserControlCalen();
        Controls.UserControlMark markuser = new Controls.UserControlMark();
        private Calendar calendar;
        List<string> fullnames = new List<string>();
        


        public Nurse()
        {
            InitializeComponent();
            sound = new SoundPlayer("buttonb.wav");
            sound.Load();




        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();
            Mainpanel.Controls.Add(adduser);

        }
        private void addbtn_Mouse_Enter(object sender, EventArgs e)
        {
            addtrans.Start();

            addbtn.BackColor = Color.Azure;

        }
        private void addbtn_Mouse_Leave(object sender, EventArgs e)
        {
            addtrans.Start();
            addbtn.BackColor = Color.FromArgb(187, 222, 251);
        }
        private void cancelbtn_Mouse_Enter(object sender, EventArgs e)
        {
            canceltrans.Start();
            cancelbtn.BackColor = Color.Azure;

        }
        private void cancelbtn_Mouse_Leave(object sender, EventArgs e)
        {
            canceltrans.Start();

            cancelbtn.BackColor = Color.FromArgb(187, 222, 251);
        }
        private void viewbtn_Mouse_Enter(object sender, EventArgs e)
        {
            viewtrans.Start();

            viewbtn.BackColor = Color.Azure;

        }
        private void viewbtn_Mouse_Leave(object sender, EventArgs e)
        {
            viewtrans.Start();

            viewbtn.BackColor = Color.FromArgb(187, 222, 251);
        }
        private void updatebtn_Mouse_Enter(object sender, EventArgs e)
        {
            updatetrans.Start();

            updatebtn.BackColor = Color.Azure;

        }
        private void updatebtn_Mouse_Leave(object sender, EventArgs e)
        {
            updatetrans.Start();

            updatebtn.BackColor = Color.FromArgb(187, 222, 251);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void Nurse_Load(object sender, EventArgs e)
        {
            loadnames();
            timer1.Start();
            panmark.Width = 0;
            panadd.Width = 0;
            pancanel.Width = 0;
            panview.Width = 0;
            panupdate.Width = 0;


            sidebar.Height = 0;

            // Collapse sidebar's width (to make it disappear horizontally)


            // Move Mainpanel to the left (take sidebar’s space)
            Mainpanel.Left = sidebar.Left;  // Move to x=0
            Mainpanel.Width += 219;

        }
        private void loadnames()
        {
            string query = "SELECT Firstname, Lastname FROM Clients";

            
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
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
                                string firstName = reader["Firstname"].ToString();
                                string lastName = reader["Lastname"].ToString();
                                string fullName = $"{firstName} {lastName}";
                                fullnames.Add(fullName);
                            }
                        }
                    }

                    suggested.Items.AddRange(fullnames.ToArray());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {


            Application.OpenForms["form1"]?.Show();
            this.Hide();



        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();
            Mainpanel.Controls.Add(deluser);

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();
            Mainpanel.Controls.Add(updateuser);
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();
            Mainpanel.Controls.Add(Calendaruser);

        }
        private void switchform(Form form)
        {
            if (form == null)
            {

                MessageBox.Show("Form not initialized.");
                return;
            }

            this.Hide();

            if (!form.IsHandleCreated || form.IsDisposed)
            {

                form = new Calendar();
            }

            form.Show();
            form.BringToFront();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string name = Searchtext.Text.Trim();


            Controls.UserControlSearch searchuser = new Controls.UserControlSearch(name);
            if (string.IsNullOrWhiteSpace(Searchtext.Text))
            {
                MessageBox.Show("Please Enter a name First");

            }
            else
            {
                Mainpanel.Controls.Clear();
                Mainpanel.Controls.Add(searchuser);

            }
        }


        private void materialDrawer1_Click(object sender, EventArgs e)
        {

        }

        private void nursesearch_TextChanged(object sender, EventArgs e)
        {

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

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, addpanel.ClientRectangle,
      Color.FromArgb(207, 216, 220), 6, ButtonBorderStyle.Solid, // Left
      Color.FromArgb(207, 216, 220), 6, ButtonBorderStyle.Solid, // Top
      Color.FromArgb(207, 216, 220), 6, ButtonBorderStyle.Solid, // Right
      Color.FromArgb(207, 216, 220), 6, ButtonBorderStyle.Solid); // Bottom
        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, Mainpanel.ClientRectangle,
      Color.FromArgb(207, 216, 220), 2, ButtonBorderStyle.Solid, // Left
      Color.FromArgb(207, 216, 220), 2, ButtonBorderStyle.Solid, // Top
      Color.FromArgb(207, 216, 220), 2, ButtonBorderStyle.Solid, // Right
      Color.FromArgb(207, 216, 220), 2, ButtonBorderStyle.Solid); // Bottom
        }


        bool sidebarexpand = true;
        private void sidebartransition_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                // Collapse sidebar
                sidebar.Height -= 20;

                if (sidebar.Height <= 0) // Target collapsed height
                {
                    sidebar.Height = 0; // Prevent negative height
                    sidebarexpand = false; // Now it's collapsed
                    sidebartransition.Stop();
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
                    sidebartransition.Stop();
                }
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
            paneltransition.Start();
        }

        bool panelexpand = true;
        int panelTransitionSpeed = 20;  // Speed of movement
        int sidebarWidth = 218;
        private void paneltransition_Tick(object sender, EventArgs e)
        {
            if (panelexpand)
            {
                // Sidebar is collapsing → Expand panel left
                Mainpanel.Left -= panelTransitionSpeed;
                Mainpanel.Width += panelTransitionSpeed;

                // Check if transition is complete
                if (Mainpanel.Left <= sidebar.Left)
                {
                    Mainpanel.Left = sidebar.Left;
                    Mainpanel.Width += (sidebarWidth - (Mainpanel.Left - sidebar.Left));  // Ensure full width gain
                    panelexpand = false;
                    paneltransition.Stop();
                }
            }
            else
            {
                // Sidebar is expanding → Shrink panel right
                Mainpanel.Left += panelTransitionSpeed;
                Mainpanel.Width -= panelTransitionSpeed;

                // Check if transition is complete
                if (Mainpanel.Left >= sidebar.Left + sidebarWidth)
                {
                    Mainpanel.Left = sidebar.Left + sidebarWidth;
                    Mainpanel.Width -= (Mainpanel.Left - (sidebar.Left + sidebarWidth));  // Ensure width reset
                    panelexpand = true;
                    paneltransition.Stop();
                }
            }

        }


        bool addextend = false;
        private void addtrans_Tick(object sender, EventArgs e)
        {
            if (addextend == false)
            {
                panadd.Width -= 30;
                if (panadd.Width <= 0)
                {
                    addtrans.Stop();
                    addextend = true;
                }
            }
            else
            {
                panadd.Width += 30;
                if (panadd.Width >= 97)
                {
                    addtrans.Stop();
                    addextend = false;
                }
            }
        }

        bool cancelextend = false;
        private void canceltrans_Tick(object sender, EventArgs e)
        {
            if (cancelextend == false)
            {
                pancanel.Width -= 30;
                if (pancanel.Width <= 0)
                {
                    canceltrans.Stop();
                    cancelextend = true;
                }
            }
            else
            {
                pancanel.Width += 30;
                if (pancanel.Width >= 97)
                {
                    canceltrans.Stop();
                    cancelextend = false;
                }
            }
        }
        bool updateextend = false;
        private void updatetrans_Tick(object sender, EventArgs e)
        {
            if (updateextend == false)
            {
                panupdate.Width -= 30;
                if (panupdate.Width <= 0)
                {
                    updatetrans.Stop();
                    updateextend = true;
                }
            }
            else
            {
                panupdate.Width += 30;
                if (panupdate.Width >= 97)
                {
                    updatetrans.Stop();
                    updateextend = false;
                }
            }
        }
        bool viewextend = false;
        private void viewtrans_Tick(object sender, EventArgs e)
        {
            if (viewextend == false)
            {
                panview.Width -= 30;
                if (panview.Width <= 0)
                {
                    viewtrans.Stop();
                    viewextend = true;
                }
            }
            else
            {
                panview.Width += 30;
                if (panview.Width >= 97)
                {
                    viewtrans.Stop();
                    viewextend = false;
                }
            }
        }

        private void addbtn_MouseHover(object sender, EventArgs e)
        {
            addtrans.Start();
        }

        private void cancelbtn_MouseHover(object sender, EventArgs e)
        {
            canceltrans.Start();
        }

        private void updatebtn_MouseHover(object sender, EventArgs e)
        {
            updatetrans.Start();
        }

        private void viewbtn_MouseHover(object sender, EventArgs e)
        {
            viewtrans.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        bool markextend = false;
        private void marktrans_Tick(object sender, EventArgs e)
        {

            if (markextend == false)
            {
                panmark.Width -= 30;
                if (panmark.Width <= 0)
                {
                    marktrans.Stop();
                    markextend = true;
                }
            }
            else
            {
                panmark.Width += 30;
                if (panmark.Width >= 97)
                {
                    marktrans.Stop();
                    markextend = false;
                }
            }
        }

        private void docmark_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();
            Mainpanel.Controls.Add(markuser);
        }

        private void panview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void docmark_MouseHover(object sender, EventArgs e)
        {
            marktrans.Start();
        }

        private void timelbl_Click(object sender, EventArgs e)
        {

        }

        public Controls.UserControlAdd UserControlAdd
        {
            get => default;
            set
            {
            }
        }

        public Controls.UserControlUpdate UserControlUpdate
        {
            get => default;
            set
            {
            }
        }

        public Controls.UserControlDelete UserControlDelete
        {
            get => default;
            set
            {
            }
        }

        public Controls.UserControlCalen UserControlCalen
        {
            get => default;
            set
            {
            }
        }
    }
}
