using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Numerics;
using System.Media;
using MaterialSkin;
using MaterialSkin.Controls;




namespace Schedully
{
    public partial class Form1 : Form
    {
        private Analytics analytics;
        private DoctorLogin doctor;
        private Doctor doc;
        private Nurse nurse;
        private Inventory inven;
        private System.Windows.Forms.Timer timer;
        private Random rand = new Random();
        private SoundPlayer sound;
        public Form1()
        {
            InitializeComponent();
            sound = new SoundPlayer("buttonb.wav");
            sound.Load();

        }

        public Inventory Inventory
        {
            get => default;
            set
            {
            }
        }

        public Nurse Nurse
        {
            get => default;
            set
            {
            }
        }

        public Doctor Doctor
        {
            get => default;
            set
            {
            }
        }

        private void createroundbtndoc()
        {
            doc = new Doctor("");
            RoundedButton shadowBtn = new RoundedButton();
            shadowBtn.Text = "";
            shadowBtn.Size = new Size(200, 80);
            shadowBtn.Location = new Point(230, 320); // Slightly offset
            shadowBtn.rdus = 30;
            shadowBtn.BackColor = Color.Gray;
            shadowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            shadowBtn.FlatAppearance.BorderSize = 1;
            shadowBtn.Enabled = false;

            RoundedButton rb = new RoundedButton();
            rb.Text = "Doctor";
            rb.Height = 80;
            rb.Width = 200;
            rb.Location = new Point(220, 310);
            rb.rdus = 30;
            rb.BackColor = Color.LightCyan;
            rb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rb.FlatAppearance.BorderColor = Color.Black;
            rb.FlatAppearance.BorderSize = 1;





            rb.Click += (sender, e) => switchform(doc);

            rb.MouseEnter += (sender, e) =>
            {
                sound.Play();
                rb.BackColor = Color.Cyan; // Change to a brighter color
                rb.Size = new Size(215, 95); // Slightly enlarge
                rb.Location = new Point(225, 315); // Adjust position to keep it centered


            };
            rb.MouseLeave += (sender, e) =>
            {

                rb.BackColor = Color.LightCyan; // Revert to original color
                rb.Size = new Size(200, 80); // Reset size
                rb.Location = new Point(220, 310); // Reset position

            };



            this.Controls.Add(rb);
            this.Controls.Add(shadowBtn);
        }
        private void createroundbtnnurse()
        {
            nurse = new Nurse();
            RoundedButton shadowBtn = new RoundedButton();
            shadowBtn.Text = "";
            shadowBtn.Size = new Size(200, 80);
            shadowBtn.Location = new Point(623, 323); // Slightly offset
            shadowBtn.rdus = 30;
            shadowBtn.BackColor = Color.Gray;
            shadowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            shadowBtn.FlatAppearance.BorderSize = 1;
            shadowBtn.Enabled = false;

            RoundedButton rb2 = new RoundedButton();
            rb2.Text = "Nurse";
            rb2.Height = 80;
            rb2.Width = 200;
            rb2.Location = new Point(610, 310);
            rb2.rdus = 30;
            rb2.BackColor = Color.LightCyan;
            rb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rb2.FlatAppearance.BorderColor = Color.Black;
            rb2.FlatAppearance.BorderSize = 1;

            rb2.Click += (sender, e) => switchform(nurse);



            rb2.MouseEnter += (sender, e) =>
            {
                sound.Play();
                rb2.BackColor = Color.Cyan;
                rb2.Size = new Size(215, 95);
                rb2.Location = new Point(615, 315);


            };
            rb2.MouseLeave += (sender, e) =>
            {
                rb2.BackColor = Color.LightCyan;
                rb2.Size = new Size(200, 80);
                rb2.Location = new Point(610, 315);

            };



            this.Controls.Add(rb2);
            this.Controls.Add(shadowBtn);

        }
        private void createinventorybtn()

        {


            inven = new Inventory();
            RoundedButton shadowBtn = new RoundedButton();
            shadowBtn.Text = "";
            shadowBtn.Size = new Size(150, 50);
            shadowBtn.Location = new Point(26, 28); // Slightly offset
            shadowBtn.rdus = 30;
            shadowBtn.BackColor = Color.Gray;
            shadowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            shadowBtn.FlatAppearance.BorderSize = 1;
            shadowBtn.Enabled = false;

            RoundedButton rb2 = new RoundedButton();
            rb2.Text = "Pills";
            rb2.Height = 50;
            rb2.Width = 150;
            rb2.Location = new Point(13, 15);
            rb2.rdus = 30;
            rb2.BackColor = Color.LightCyan;
            rb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rb2.FlatAppearance.BorderColor = Color.Black;
            rb2.FlatAppearance.BorderSize = 1;

            rb2.Click += (sender, e) => switchform(inven);



            rb2.MouseEnter += (sender, e) =>
            {
                sound.Play();
                rb2.BackColor = Color.Cyan;
                rb2.Size = new Size(160, 60);
                rb2.Location = new Point(17, 19);


            };
            rb2.MouseLeave += (sender, e) =>
            {
                rb2.BackColor = Color.LightCyan;
                rb2.Size = new Size(150, 50);
                rb2.Location = new Point(13, 15);

            };



            this.Controls.Add(rb2);
            this.Controls.Add(shadowBtn);
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            createinventorybtn();
            timer1.Start();
            StartMoving();
            createroundbtndoc();
            createroundbtnnurse();

        }
        private void StartMoving()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 300; // Adjust speed (lower is faster)
            timer.Tick += timer1_Tick;
            timer.Start();


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int red = rand.Next(100, 256);
            int green = rand.Next(100, 256);
            int blue = rand.Next(100, 256);

            lblsched.ForeColor = Color.FromArgb(255, red, green, blue);
        }
        private void switchform(Form form)
        {
            this.Hide();

            if (form.Visible)
            {
                form.BringToFront();

            }
            else
            {
                form.Show();
            }

        }
        class RoundedButton : Button
        {
            public int rdus = 10;
            System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
            {
                float r2 = radius / 2f;
                System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
                GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
                GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
                GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
                GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
                GraphPath.AddArc(Rect.X + Rect.Width - radius,
                        Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
                GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
                GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
                GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
                GraphPath.CloseFigure();
                return GraphPath;
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
                using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
                {
                    this.Region = new Region(GraphPath);
                    using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                    {
                        pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                        e.Graphics.DrawPath(pen, GraphPath);
                    }
                }
            }
        }

       
        private void analy_Click(object sender, EventArgs e)
        {
            analytics = new Analytics();

            switchform(analytics);
        }
    }
}
