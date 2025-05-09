namespace Schedully.Controls
{
    partial class UserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDay));
            daypanel = new Panel();
            fully = new Label();
            daypic = new PictureBox();
            lblcount = new Label();
            daycheck = new CheckBox();
            daynum = new Label();
            clientinfo = new ToolTip(components);
            daypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daypic).BeginInit();
            SuspendLayout();
            // 
            // daypanel
            // 
            daypanel.BackColor = Color.White;
            daypanel.Controls.Add(fully);
            daypanel.Controls.Add(daypic);
            daypanel.Controls.Add(lblcount);
            daypanel.Controls.Add(daycheck);
            daypanel.Controls.Add(daynum);
            daypanel.Dock = DockStyle.Fill;
            daypanel.Location = new Point(2, 2);
            daypanel.Name = "daypanel";
            daypanel.Size = new Size(179, 151);
            daypanel.TabIndex = 1;
            daypanel.Click += daypanel_Click;
            daypanel.Paint += daypanel_Paint;
            daypanel.MouseEnter += daypanel_MouseEnter;
            daypanel.MouseLeave += daypanel_MouseLeave;
            daypanel.MouseHover += daypanel_MouseHover;
            // 
            // fully
            // 
            fully.AutoSize = true;
            fully.Font = new Font("Calibri", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            fully.Location = new Point(28, 76);
            fully.Name = "fully";
            fully.Size = new Size(128, 27);
            fully.TabIndex = 4;
            fully.Text = "Fully Booked";
            fully.Visible = false;
            // 
            // daypic
            // 
            daypic.Image = (Image)resources.GetObject("daypic.Image");
            daypic.Location = new Point(3, 3);
            daypic.Name = "daypic";
            daypic.Size = new Size(48, 70);
            daypic.SizeMode = PictureBoxSizeMode.CenterImage;
            daypic.TabIndex = 3;
            daypic.TabStop = false;
            daypic.Visible = false;
            // 
            // lblcount
            // 
            lblcount.AutoSize = true;
            lblcount.Location = new Point(154, 117);
            lblcount.Name = "lblcount";
            lblcount.Size = new Size(22, 25);
            lblcount.TabIndex = 2;
            lblcount.Text = "0";
            clientinfo.SetToolTip(lblcount, "wew");
            // 
            // daycheck
            // 
            daycheck.AutoSize = true;
            daycheck.BackColor = Color.IndianRed;
            daycheck.ForeColor = SystemColors.ActiveCaptionText;
            daycheck.Location = new Point(18, 18);
            daycheck.Name = "daycheck";
            daycheck.Size = new Size(22, 21);
            daycheck.TabIndex = 1;
            daycheck.UseVisualStyleBackColor = false;
            daycheck.Click += daypanel_Click;
            // 
            // daynum
            // 
            daynum.AutoSize = true;
            daynum.Font = new Font("Segoe UI", 12F);
            daynum.Location = new Point(129, 9);
            daynum.Name = "daynum";
            daynum.Size = new Size(40, 32);
            daynum.TabIndex = 0;
            daynum.Text = "00";
            // 
            // clientinfo
            // 
            clientinfo.BackColor = SystemColors.GradientActiveCaption;
            // 
            // UserControlDay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(daypanel);
            Name = "UserControlDay";
            Padding = new Padding(2);
            Size = new Size(183, 155);
            Load += UserControlDay_Load;
            daypanel.ResumeLayout(false);
            daypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)daypic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel daypanel;
        private CheckBox daycheck;
        private Label daynum;
        private Label lblcount;
        private PictureBox daypic;
        private ToolTip clientinfo;
        private Label fully;
    }

    partial class Copy1OfUserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Copy1OfUserControlDay));
            daypanel = new Panel();
            fully = new Label();
            daypic = new PictureBox();
            lblcount = new Label();
            daycheck = new CheckBox();
            daynum = new Label();
            clientinfo = new ToolTip(components);
            daypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daypic).BeginInit();
            SuspendLayout();
            // 
            // daypanel
            // 
            daypanel.BackColor = Color.White;
            daypanel.Controls.Add(fully);
            daypanel.Controls.Add(daypic);
            daypanel.Controls.Add(lblcount);
            daypanel.Controls.Add(daycheck);
            daypanel.Controls.Add(daynum);
            daypanel.Dock = DockStyle.Fill;
            daypanel.Location = new Point(2, 2);
            daypanel.Name = "daypanel";
            daypanel.Size = new Size(179, 151);
            daypanel.TabIndex = 1;
            daypanel.Click += daypanel_Click;
            daypanel.Paint += daypanel_Paint;
            daypanel.MouseEnter += daypanel_MouseEnter;
            daypanel.MouseLeave += daypanel_MouseLeave;
            daypanel.MouseHover += daypanel_MouseHover;
            // 
            // fully
            // 
            fully.AutoSize = true;
            fully.Font = new Font("Calibri", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            fully.Location = new Point(28, 76);
            fully.Name = "fully";
            fully.Size = new Size(128, 27);
            fully.TabIndex = 4;
            fully.Text = "Fully Booked";
            fully.Visible = false;
            // 
            // daypic
            // 
            daypic.Image = (Image)resources.GetObject("daypic.Image");
            daypic.Location = new Point(3, 3);
            daypic.Name = "daypic";
            daypic.Size = new Size(48, 70);
            daypic.SizeMode = PictureBoxSizeMode.CenterImage;
            daypic.TabIndex = 3;
            daypic.TabStop = false;
            daypic.Visible = false;
            // 
            // lblcount
            // 
            lblcount.AutoSize = true;
            lblcount.Location = new Point(154, 117);
            lblcount.Name = "lblcount";
            lblcount.Size = new Size(22, 25);
            lblcount.TabIndex = 2;
            lblcount.Text = "0";
            clientinfo.SetToolTip(lblcount, "wew");
            // 
            // daycheck
            // 
            daycheck.AutoSize = true;
            daycheck.BackColor = Color.IndianRed;
            daycheck.ForeColor = SystemColors.ActiveCaptionText;
            daycheck.Location = new Point(18, 18);
            daycheck.Name = "daycheck";
            daycheck.Size = new Size(22, 21);
            daycheck.TabIndex = 1;
            daycheck.UseVisualStyleBackColor = false;
            daycheck.Click += daypanel_Click;
            // 
            // daynum
            // 
            daynum.AutoSize = true;
            daynum.Font = new Font("Segoe UI", 12F);
            daynum.Location = new Point(129, 9);
            daynum.Name = "daynum";
            daynum.Size = new Size(40, 32);
            daynum.TabIndex = 0;
            daynum.Text = "00";
            // 
            // clientinfo
            // 
            clientinfo.BackColor = SystemColors.GradientActiveCaption;
            // 
            // Copy1OfUserControlDay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(daypanel);
            Name = "Copy1OfUserControlDay";
            Padding = new Padding(2);
            Size = new Size(183, 155);
            Load += UserControlDay_Load;
            daypanel.ResumeLayout(false);
            daypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)daypic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel daypanel;
        private CheckBox daycheck;
        private Label daynum;
        private Label lblcount;
        private PictureBox daypic;
        private ToolTip clientinfo;
        private Label fully;
    }

    partial class CopyOfUserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyOfUserControlDay));
            daypanel = new Panel();
            daypic = new PictureBox();
            lblcount = new Label();
            daycheck = new CheckBox();
            daynum = new Label();
            daypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daypic).BeginInit();
            SuspendLayout();
            // 
            // daypanel
            // 
            daypanel.BackColor = Color.White;
            daypanel.Controls.Add(daypic);
            daypanel.Controls.Add(lblcount);
            daypanel.Controls.Add(daycheck);
            daypanel.Controls.Add(daynum);
            daypanel.Dock = DockStyle.Fill;
            daypanel.Location = new Point(2, 2);
            daypanel.Name = "daypanel";
            daypanel.Size = new Size(179, 151);
            daypanel.TabIndex = 1;
            daypanel.Click += daypanel_Click;
            daypanel.Paint += daypanel_Paint;
            // 
            // daypic
            // 
            daypic.Image = (Image)resources.GetObject("daypic.Image");
            daypic.Location = new Point(3, 3);
            daypic.Name = "daypic";
            daypic.Size = new Size(48, 70);
            daypic.SizeMode = PictureBoxSizeMode.CenterImage;
            daypic.TabIndex = 3;
            daypic.TabStop = false;
            daypic.Visible = false;
            // 
            // lblcount
            // 
            lblcount.AutoSize = true;
            lblcount.Location = new Point(154, 117);
            lblcount.Name = "lblcount";
            lblcount.Size = new Size(22, 25);
            lblcount.TabIndex = 2;
            lblcount.Text = "0";
            // 
            // daycheck
            // 
            daycheck.AutoSize = true;
            daycheck.BackColor = Color.IndianRed;
            daycheck.ForeColor = SystemColors.ActiveCaptionText;
            daycheck.Location = new Point(18, 18);
            daycheck.Name = "daycheck";
            daycheck.Size = new Size(22, 21);
            daycheck.TabIndex = 1;
            daycheck.UseVisualStyleBackColor = false;
            daycheck.Click += daypanel_Click;
            // 
            // daynum
            // 
            daynum.AutoSize = true;
            daynum.Font = new Font("Segoe UI", 12F);
            daynum.Location = new Point(129, 9);
            daynum.Name = "daynum";
            daynum.Size = new Size(40, 32);
            daynum.TabIndex = 0;
            daynum.Text = "00";
            // 
            // CopyOfUserControlDay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(daypanel);
            Name = "CopyOfUserControlDay";
            Padding = new Padding(2);
            Size = new Size(183, 155);
            Load += UserControlDay_Load;
            daypanel.ResumeLayout(false);
            daypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)daypic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel daypanel;
        private CheckBox daycheck;
        private Label daynum;
        private Label lblcount;
        private PictureBox daypic;
    }
}
