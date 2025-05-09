namespace Schedully
{
    partial class Doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            panel1 = new Panel();
            datelbl = new Label();
            menubtn = new circlebutton();
            timelbl = new Label();
            button1 = new Button();
            panel3 = new Panel();
            clientsearch = new MaterialSkin.Controls.MaterialTextBox();
            label1 = new Label();
            back = new circlebutton();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            docview = new circlebutton();
            diagnosebtn = new circlebutton();
            sidebar = new FlowLayoutPanel();
            viewpanel = new Panel();
            panel2 = new Panel();
            docpanel = new Panel();
            pandiagnos = new Panel();
            label2 = new Label();
            panelview = new Panel();
            panview = new Label();
            sidebartrans = new System.Windows.Forms.Timer(components);
            marktrans = new System.Windows.Forms.Timer(components);
            viewtrans = new System.Windows.Forms.Timer(components);
            paneltrans = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            viewpanel.SuspendLayout();
            panel2.SuspendLayout();
            docpanel.SuspendLayout();
            pandiagnos.SuspendLayout();
            panelview.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(datelbl);
            panel1.Controls.Add(menubtn);
            panel1.Controls.Add(timelbl);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(back);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1630, 221);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Font = new Font("Calibri", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            datelbl.Location = new Point(1165, 55);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(68, 35);
            datelbl.TabIndex = 13;
            datelbl.Text = "Date";
            // 
            // menubtn
            // 
            menubtn.BackColor = Color.FromArgb(227, 242, 253);
            menubtn.FlatAppearance.BorderSize = 0;
            menubtn.FlatStyle = FlatStyle.Flat;
            menubtn.Image = (Image)resources.GetObject("menubtn.Image");
            menubtn.Location = new Point(50, 140);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(73, 65);
            menubtn.TabIndex = 10;
            menubtn.UseVisualStyleBackColor = false;
            menubtn.Click += menubtn_Click;
            // 
            // timelbl
            // 
            timelbl.AutoSize = true;
            timelbl.Font = new Font("Calibri", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            timelbl.Location = new Point(1163, 20);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(70, 35);
            timelbl.TabIndex = 12;
            timelbl.Text = "Time";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1460, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 69);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(clientsearch);
            panel3.Location = new Point(1034, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 69);
            panel3.TabIndex = 10;
            // 
            // clientsearch
            // 
            clientsearch.AnimateReadOnly = false;
            clientsearch.BorderStyle = BorderStyle.None;
            clientsearch.Depth = 0;
            clientsearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            clientsearch.LeadingIcon = null;
            clientsearch.Location = new Point(24, 10);
            clientsearch.MaxLength = 50;
            clientsearch.MouseState = MaterialSkin.MouseState.OUT;
            clientsearch.Multiline = false;
            clientsearch.Name = "clientsearch";
            clientsearch.Size = new Size(396, 50);
            clientsearch.TabIndex = 0;
            clientsearch.Text = "";
            clientsearch.TrailingIcon = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(676, 20);
            label1.Name = "label1";
            label1.Size = new Size(382, 59);
            label1.TabIndex = 4;
            label1.Text = "Doctor Dashboard";
            // 
            // back
            // 
            back.BackColor = Color.Azure;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Image = (Image)resources.GetObject("back.Image");
            back.Location = new Point(1573, 0);
            back.Name = "back";
            back.Size = new Size(66, 62);
            back.TabIndex = 7;
            toolTip1.SetToolTip(back, "Back on Homepage");
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(197, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 202);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // docview
            // 
            docview.BackColor = Color.FromArgb(187, 222, 251);
            docview.FlatAppearance.BorderSize = 0;
            docview.FlatStyle = FlatStyle.Flat;
            docview.Image = (Image)resources.GetObject("docview.Image");
            docview.Location = new Point(44, 18);
            docview.Name = "docview";
            docview.Size = new Size(92, 87);
            docview.TabIndex = 4;
            toolTip1.SetToolTip(docview, "View Appointment");
            docview.UseVisualStyleBackColor = false;
            docview.Click += docview_Click;
            docview.MouseEnter += docview_MouseHover;
            docview.MouseLeave += docview_Mouse_Leave;
            docview.MouseHover += docview_MouseHover;
            // 
            // diagnosebtn
            // 
            diagnosebtn.BackColor = Color.FromArgb(187, 222, 251);
            diagnosebtn.FlatAppearance.BorderSize = 0;
            diagnosebtn.FlatStyle = FlatStyle.Flat;
            diagnosebtn.Image = (Image)resources.GetObject("diagnosebtn.Image");
            diagnosebtn.Location = new Point(44, 7);
            diagnosebtn.Name = "diagnosebtn";
            diagnosebtn.Size = new Size(92, 87);
            diagnosebtn.TabIndex = 5;
            toolTip1.SetToolTip(diagnosebtn, "diagnose");
            diagnosebtn.UseVisualStyleBackColor = false;
            diagnosebtn.Click += diagnosebtn_Click;
            diagnosebtn.MouseLeave += diagnosebtn_MouseLeave;
            diagnosebtn.MouseHover += diagnosebtn_MouseHover;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(187, 222, 251);
            sidebar.Controls.Add(viewpanel);
            sidebar.Controls.Add(panel2);
            sidebar.Location = new Point(6, 288);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(191, 913);
            sidebar.TabIndex = 5;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // viewpanel
            // 
            viewpanel.Controls.Add(docview);
            viewpanel.Location = new Point(3, 3);
            viewpanel.Name = "viewpanel";
            viewpanel.Size = new Size(341, 119);
            viewpanel.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(diagnosebtn);
            panel2.Location = new Point(3, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 8;
            // 
            // docpanel
            // 
            docpanel.BackColor = Color.FromArgb(249, 249, 249);
            docpanel.Controls.Add(pandiagnos);
            docpanel.Controls.Add(panelview);
            docpanel.Location = new Point(200, 288);
            docpanel.Name = "docpanel";
            docpanel.Size = new Size(1442, 907);
            docpanel.TabIndex = 3;
            docpanel.Paint += docpanel_Paint;
            // 
            // pandiagnos
            // 
            pandiagnos.BackColor = Color.FromArgb(187, 222, 251);
            pandiagnos.Controls.Add(label2);
            pandiagnos.Location = new Point(0, 131);
            pandiagnos.Name = "pandiagnos";
            pandiagnos.Size = new Size(124, 97);
            pandiagnos.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F);
            label2.Location = new Point(0, 32);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 10;
            label2.Text = "Diagnose";
            label2.Click += label2_Click;
            // 
            // panelview
            // 
            panelview.BackColor = Color.FromArgb(187, 222, 251);
            panelview.Controls.Add(panview);
            panelview.Location = new Point(0, 6);
            panelview.Name = "panelview";
            panelview.Size = new Size(97, 122);
            panelview.TabIndex = 11;
            // 
            // panview
            // 
            panview.AutoSize = true;
            panview.Font = new Font("Century", 12F);
            panview.Location = new Point(5, 46);
            panview.Name = "panview";
            panview.Size = new Size(68, 28);
            panview.TabIndex = 10;
            panview.Text = "View";
            // 
            // sidebartrans
            // 
            sidebartrans.Interval = 10;
            sidebartrans.Tick += sidebartrans_Tick;
            // 
            // marktrans
            // 
            marktrans.Interval = 70;
            marktrans.Tick += marktrans_Tick;
            // 
            // viewtrans
            // 
            viewtrans.Interval = 70;
            viewtrans.Tick += viewtrans_Tick;
            // 
            // paneltrans
            // 
            paneltrans.Interval = 50;
            paneltrans.Tick += paneltrans_Tick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 194, 227);
            ClientSize = new Size(1636, 1201);
            Controls.Add(sidebar);
            Controls.Add(docpanel);
            Controls.Add(panel1);
            Name = "Doctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor";
            Load += Doctor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            viewpanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            docpanel.ResumeLayout(false);
            pandiagnos.ResumeLayout(false);
            pandiagnos.PerformLayout();
            panelview.ResumeLayout(false);
            panelview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private circlebutton updatebtn;
        private circlebutton docadd;
        private ToolTip toolTip1;
        private circlebutton back;
        private Label label1;
        private Panel panel3;
        private Button button1;
        private MaterialSkin.Controls.MaterialTextBox clientsearch;
        private FlowLayoutPanel sidebar;
        private circlebutton menubtn;
        private circlebutton docview;
        private Panel docpanel;
        private Panel viewpanel;
        private Panel panelview;
        private Label panview;
        private System.Windows.Forms.Timer sidebartrans;
        private System.Windows.Forms.Timer marktrans;
        private System.Windows.Forms.Timer viewtrans;
        private System.Windows.Forms.Timer paneltrans;
        private Label datelbl;
        private Label timelbl;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;

        private Panel pandiagnos;
        private Label label2;
        private circlebutton diagnosebtn;
    }
}