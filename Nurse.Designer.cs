namespace Schedully
{
    partial class Nurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse));
            panel1 = new Panel();
            datelbl = new Label();
            menubtn = new circlebutton();
            timelbl = new Label();
            panel3 = new Panel();
            Searchtext = new MaterialSkin.Controls.MaterialTextBox2();
            searchbutton = new Button();
            label1 = new Label();
            back = new circlebutton();
            pictureBox1 = new PictureBox();
            updatebtn = new circlebutton();
            viewbtn = new circlebutton();
            cancelbtn = new circlebutton();
            addbtn = new circlebutton();
            Mainpanel = new Panel();
            suggested = new ListBox();
            panmark = new Panel();
            label5 = new Label();
            panadd = new Panel();
            label2 = new Label();
            panview = new Panel();
            label4 = new Label();
            panupdate = new Panel();
            label3 = new Label();
            sidebar = new FlowLayoutPanel();
            addpanel = new Panel();
            cancelpanel = new Panel();
            updatepanel = new Panel();
            viewpanel = new Panel();
            markpanel = new Panel();
            docmark = new circlebutton();
            sidebartransition = new System.Windows.Forms.Timer(components);
            paneltransition = new System.Windows.Forms.Timer(components);
            addtrans = new System.Windows.Forms.Timer(components);
            pancanel = new Panel();
            label6 = new Label();
            canceltrans = new System.Windows.Forms.Timer(components);
            updatetrans = new System.Windows.Forms.Timer(components);
            viewtrans = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            marktrans = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Mainpanel.SuspendLayout();
            panmark.SuspendLayout();
            panadd.SuspendLayout();
            panview.SuspendLayout();
            panupdate.SuspendLayout();
            sidebar.SuspendLayout();
            addpanel.SuspendLayout();
            cancelpanel.SuspendLayout();
            updatepanel.SuspendLayout();
            viewpanel.SuspendLayout();
            markpanel.SuspendLayout();
            pancanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(datelbl);
            panel1.Controls.Add(menubtn);
            panel1.Controls.Add(timelbl);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(searchbutton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(back);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1652, 235);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Font = new Font("Calibri", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            datelbl.Location = new Point(1194, 53);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(68, 35);
            datelbl.TabIndex = 11;
            datelbl.Text = "Date";
            // 
            // menubtn
            // 
            menubtn.BackColor = Color.FromArgb(227, 242, 253);
            menubtn.FlatAppearance.BorderSize = 0;
            menubtn.FlatStyle = FlatStyle.Flat;
            menubtn.Image = (Image)resources.GetObject("menubtn.Image");
            menubtn.Location = new Point(50, 151);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(73, 65);
            menubtn.TabIndex = 9;
            menubtn.UseVisualStyleBackColor = false;
            menubtn.Click += menubtn_Click;
            // 
            // timelbl
            // 
            timelbl.AutoSize = true;
            timelbl.Font = new Font("Calibri", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            timelbl.Location = new Point(1207, 15);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(70, 35);
            timelbl.TabIndex = 10;
            timelbl.Text = "Time";
            timelbl.Click += timelbl_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(236, 239, 241);
            panel3.Controls.Add(Searchtext);
            panel3.Location = new Point(906, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(572, 80);
            panel3.TabIndex = 12;
            // 
            // Searchtext
            // 
            Searchtext.AnimateReadOnly = false;
            Searchtext.BackgroundImageLayout = ImageLayout.None;
            Searchtext.CharacterCasing = CharacterCasing.Normal;
            Searchtext.Depth = 0;
            Searchtext.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Searchtext.HideSelection = true;
            Searchtext.LeadingIcon = null;
            Searchtext.LeaveOnEnterKey = true;
            Searchtext.Location = new Point(28, 19);
            Searchtext.MaxLength = 32767;
            Searchtext.MouseState = MaterialSkin.MouseState.OUT;
            Searchtext.Name = "Searchtext";
            Searchtext.PasswordChar = '\0';
            Searchtext.PrefixSuffixText = null;
            Searchtext.ReadOnly = false;
            Searchtext.RightToLeft = RightToLeft.No;
            Searchtext.SelectedText = "";
            Searchtext.SelectionLength = 0;
            Searchtext.SelectionStart = 0;
            Searchtext.ShortcutsEnabled = true;
            Searchtext.Size = new Size(522, 48);
            Searchtext.TabIndex = 0;
            Searchtext.TabStop = false;
            Searchtext.TextAlign = HorizontalAlignment.Left;
            Searchtext.TrailingIcon = null;
            Searchtext.UseSystemPasswordChar = false;
            // 
            // searchbutton
            // 
            searchbutton.BackColor = Color.FromArgb(100, 181, 246);
            searchbutton.Image = (Image)resources.GetObject("searchbutton.Image");
            searchbutton.Location = new Point(1475, 99);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(75, 80);
            searchbutton.TabIndex = 11;
            searchbutton.UseVisualStyleBackColor = false;
            searchbutton.Click += searchbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 50, 56);
            label1.Location = new Point(683, 24);
            label1.Name = "label1";
            label1.Size = new Size(365, 59);
            label1.TabIndex = 3;
            label1.Text = "Nurse Dashboard";
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
            back.TabIndex = 6;
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 202);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.FromArgb(187, 222, 251);
            updatebtn.FlatAppearance.BorderSize = 0;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Image = (Image)resources.GetObject("updatebtn.Image");
            updatebtn.Location = new Point(58, 3);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(105, 100);
            updatebtn.TabIndex = 5;
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            updatebtn.MouseEnter += updatebtn_Mouse_Enter;
            updatebtn.MouseLeave += updatebtn_Mouse_Leave;
            updatebtn.MouseHover += updatebtn_MouseHover;
            // 
            // viewbtn
            // 
            viewbtn.BackColor = Color.FromArgb(187, 222, 251);
            viewbtn.FlatAppearance.BorderSize = 0;
            viewbtn.FlatStyle = FlatStyle.Flat;
            viewbtn.Image = (Image)resources.GetObject("viewbtn.Image");
            viewbtn.Location = new Point(59, 3);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(104, 96);
            viewbtn.TabIndex = 4;
            viewbtn.UseVisualStyleBackColor = false;
            viewbtn.Click += viewbtn_Click;
            viewbtn.MouseEnter += viewbtn_Mouse_Enter;
            viewbtn.MouseLeave += viewbtn_Mouse_Leave;
            viewbtn.MouseHover += viewbtn_MouseHover;
            // 
            // cancelbtn
            // 
            cancelbtn.BackColor = Color.FromArgb(187, 222, 251);
            cancelbtn.FlatAppearance.BorderSize = 0;
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.Image = (Image)resources.GetObject("cancelbtn.Image");
            cancelbtn.Location = new Point(54, 3);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(109, 103);
            cancelbtn.TabIndex = 3;
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.Click += cancelbtn_Click;
            cancelbtn.MouseEnter += cancelbtn_Mouse_Enter;
            cancelbtn.MouseLeave += cancelbtn_Mouse_Leave;
            cancelbtn.MouseHover += cancelbtn_MouseHover;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.FromArgb(187, 222, 251);
            addbtn.FlatAppearance.BorderSize = 0;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Image = (Image)resources.GetObject("addbtn.Image");
            addbtn.Location = new Point(47, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(116, 115);
            addbtn.TabIndex = 2;
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            addbtn.MouseEnter += addbtn_Mouse_Enter;
            addbtn.MouseLeave += addbtn_Mouse_Leave;
            addbtn.MouseHover += addbtn_MouseHover;
            // 
            // Mainpanel
            // 
            Mainpanel.BackColor = Color.FromArgb(249, 249, 249);
            Mainpanel.Controls.Add(suggested);
            Mainpanel.Controls.Add(panmark);
            Mainpanel.Controls.Add(panadd);
            Mainpanel.Controls.Add(panview);
            Mainpanel.Controls.Add(panupdate);
            Mainpanel.Location = new Point(222, 299);
            Mainpanel.Name = "Mainpanel";
            Mainpanel.Size = new Size(1435, 865);
            Mainpanel.TabIndex = 2;
            Mainpanel.Paint += Mainpanel_Paint;
            // 
            // suggested
            // 
            suggested.FormattingEnabled = true;
            suggested.ItemHeight = 25;
            suggested.Location = new Point(712, -57);
            suggested.Name = "suggested";
            suggested.Size = new Size(544, 129);
            suggested.TabIndex = 13;
            suggested.Visible = false;
            // 
            // panmark
            // 
            panmark.BackColor = Color.FromArgb(187, 222, 251);
            panmark.Controls.Add(label5);
            panmark.Location = new Point(0, 503);
            panmark.Name = "panmark";
            panmark.Size = new Size(97, 122);
            panmark.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F);
            label5.Location = new Point(5, 46);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 10;
            label5.Text = "Mark";
            // 
            // panadd
            // 
            panadd.BackColor = Color.FromArgb(187, 222, 251);
            panadd.Controls.Add(label2);
            panadd.Location = new Point(0, 0);
            panadd.Name = "panadd";
            panadd.Size = new Size(97, 122);
            panadd.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F);
            label2.Location = new Point(5, 46);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 10;
            label2.Text = "Add ";
            // 
            // panview
            // 
            panview.BackColor = Color.FromArgb(187, 222, 251);
            panview.Controls.Add(label4);
            panview.Location = new Point(0, 381);
            panview.Name = "panview";
            panview.Size = new Size(97, 119);
            panview.TabIndex = 9;
            panview.Paint += panview_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F);
            label4.Location = new Point(0, 42);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 12;
            label4.Text = "View";
            // 
            // panupdate
            // 
            panupdate.BackColor = Color.FromArgb(187, 222, 251);
            panupdate.Controls.Add(label3);
            panupdate.Location = new Point(0, 253);
            panupdate.Name = "panupdate";
            panupdate.Size = new Size(98, 119);
            panupdate.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F);
            label3.Location = new Point(3, 38);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 11;
            label3.Text = "Update";
            // 
            // sidebar
            // 
            sidebar.AllowDrop = true;
            sidebar.BackColor = Color.FromArgb(187, 222, 251);
            sidebar.Controls.Add(addpanel);
            sidebar.Controls.Add(cancelpanel);
            sidebar.Controls.Add(updatepanel);
            sidebar.Controls.Add(viewpanel);
            sidebar.Controls.Add(markpanel);
            sidebar.Location = new Point(3, 299);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(218, 865);
            sidebar.TabIndex = 6;
            sidebar.Paint += sidebar_Paint;
            // 
            // addpanel
            // 
            addpanel.Controls.Add(addbtn);
            addpanel.Location = new Point(3, 3);
            addpanel.Name = "addpanel";
            addpanel.Size = new Size(341, 119);
            addpanel.TabIndex = 6;
            // 
            // cancelpanel
            // 
            cancelpanel.Controls.Add(cancelbtn);
            cancelpanel.Location = new Point(3, 128);
            cancelpanel.Name = "cancelpanel";
            cancelpanel.Size = new Size(341, 119);
            cancelpanel.TabIndex = 7;
            // 
            // updatepanel
            // 
            updatepanel.Controls.Add(updatebtn);
            updatepanel.Location = new Point(3, 253);
            updatepanel.Name = "updatepanel";
            updatepanel.Size = new Size(341, 119);
            updatepanel.TabIndex = 7;
            // 
            // viewpanel
            // 
            viewpanel.AllowDrop = true;
            viewpanel.Controls.Add(viewbtn);
            viewpanel.Location = new Point(3, 378);
            viewpanel.Name = "viewpanel";
            viewpanel.Size = new Size(341, 119);
            viewpanel.TabIndex = 7;
            // 
            // markpanel
            // 
            markpanel.Controls.Add(docmark);
            markpanel.Location = new Point(3, 503);
            markpanel.Name = "markpanel";
            markpanel.Size = new Size(341, 119);
            markpanel.TabIndex = 10;
            // 
            // docmark
            // 
            docmark.BackColor = Color.FromArgb(187, 222, 251);
            docmark.FlatAppearance.BorderSize = 0;
            docmark.FlatStyle = FlatStyle.Flat;
            docmark.Image = (Image)resources.GetObject("docmark.Image");
            docmark.Location = new Point(54, 10);
            docmark.Name = "docmark";
            docmark.Size = new Size(109, 102);
            docmark.TabIndex = 3;
            docmark.UseVisualStyleBackColor = false;
            docmark.Click += docmark_Click;
            docmark.MouseHover += docmark_MouseHover;
            // 
            // sidebartransition
            // 
            sidebartransition.Interval = 5;
            sidebartransition.Tick += sidebartransition_Tick;
            // 
            // paneltransition
            // 
            paneltransition.Interval = 50;
            paneltransition.Tick += paneltransition_Tick;
            // 
            // addtrans
            // 
            addtrans.Interval = 70;
            addtrans.Tick += addtrans_Tick;
            // 
            // pancanel
            // 
            pancanel.BackColor = Color.FromArgb(187, 222, 251);
            pancanel.Controls.Add(label6);
            pancanel.Location = new Point(222, 427);
            pancanel.Name = "pancanel";
            pancanel.Size = new Size(97, 119);
            pancanel.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F);
            label6.Location = new Point(-1, 50);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 12;
            label6.Text = "Cancel ";
            // 
            // canceltrans
            // 
            canceltrans.Interval = 70;
            canceltrans.Tick += canceltrans_Tick;
            // 
            // updatetrans
            // 
            updatetrans.Interval = 70;
            updatetrans.Tick += updatetrans_Tick;
            // 
            // viewtrans
            // 
            viewtrans.Interval = 70;
            viewtrans.Tick += viewtrans_Tick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // marktrans
            // 
            marktrans.Interval = 70;
            marktrans.Tick += marktrans_Tick;
            // 
            // Nurse
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(130, 194, 227);
            ClientSize = new Size(1658, 1160);
            Controls.Add(pancanel);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Controls.Add(Mainpanel);
            DrawerShowIconsWhenHidden = true;
            Name = "Nurse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nurse";
            Load += Nurse_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Mainpanel.ResumeLayout(false);
            panmark.ResumeLayout(false);
            panmark.PerformLayout();
            panadd.ResumeLayout(false);
            panadd.PerformLayout();
            panview.ResumeLayout(false);
            panview.PerformLayout();
            panupdate.ResumeLayout(false);
            panupdate.PerformLayout();
            sidebar.ResumeLayout(false);
            addpanel.ResumeLayout(false);
            cancelpanel.ResumeLayout(false);
            updatepanel.ResumeLayout(false);
            viewpanel.ResumeLayout(false);
            markpanel.ResumeLayout(false);
            pancanel.ResumeLayout(false);
            pancanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private circlebutton addbtn;
        private circlebutton viewbtn;
        private circlebutton cancelbtn;
        private circlebutton updatebtn;
        private circlebutton back;
        private Panel Mainpanel;
        private Label label1;
        private Button searchbutton;
        private Panel panel3;
        private TextBox nursesearch;
     //   private MaterialSkin.Controls.MaterialTextBox nursesearch;
        private MaterialSkin.Controls.MaterialTextBox2 Searchtext;
        private circlebutton menubtn;
        private FlowLayoutPanel sidebar;
        private Panel addpanel;
        private Panel cancelpanel;
        private Panel updatepanel;
        private Panel viewpanel;
        private System.Windows.Forms.Timer sidebartransition;
        private System.Windows.Forms.Timer paneltransition;
        private System.Windows.Forms.Timer addtrans;
        private Panel panadd;
        private Panel panview;
        private Panel panupdate;
        private Label label3;
        private Label label2;
        private Panel pancanel;
        private Label label6;
        private Label label4;
        private System.Windows.Forms.Timer canceltrans;
        private System.Windows.Forms.Timer updatetrans;
        private System.Windows.Forms.Timer viewtrans;
        private System.Windows.Forms.Timer timer1;
        private Label datelbl;
        private Label timelbl;
        private PictureBox pictureBox2;
        private Panel markpanel;
        private circlebutton docmark;
        private Panel panmark;
        private Label label5;
        private System.Windows.Forms.Timer marktrans;
        private ListBox suggested;
    }
}