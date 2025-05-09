namespace Schedully
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            panel1 = new Panel();
            back = new circlebutton();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            datelbl = new Label();
            timelbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            painbtn = new Button();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            coldbtn = new Button();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            stomachbtn = new Button();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            woundbtn = new Button();
            pictureBox6 = new PictureBox();
            panel9 = new Panel();
            pictureBox8 = new PictureBox();
            coughbtn = new Button();
            panel10 = new Panel();
            pictureBox7 = new PictureBox();
            firstbtn = new Button();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(back);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1754, 139);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // back
            // 
            back.BackColor = Color.Azure;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Image = (Image)resources.GetObject("back.Image");
            back.Location = new Point(1099, 3);
            back.Name = "back";
            back.Size = new Size(66, 62);
            back.TabIndex = 7;
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // panel8
            // 
            panel8.Location = new Point(989, 142);
            panel8.Name = "panel8";
            panel8.Size = new Size(193, 98);
            panel8.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(808, 102);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(187, 222, 251);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(datelbl);
            panel2.Controls.Add(timelbl);
            panel2.Location = new Point(1171, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 139);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(402, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 139);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Font = new Font("Calibri", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            datelbl.Location = new Point(47, 58);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(68, 35);
            datelbl.TabIndex = 12;
            datelbl.Text = "Date";
            // 
            // timelbl
            // 
            timelbl.AutoSize = true;
            timelbl.Font = new Font("Calibri", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            timelbl.Location = new Point(36, 13);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(70, 35);
            timelbl.TabIndex = 11;
            timelbl.Text = "Time";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(249, 250, 251);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Location = new Point(109, 212);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1594, 104);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(187, 222, 251);
            panel3.Controls.Add(painbtn);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 98);
            panel3.TabIndex = 3;
            // 
            // painbtn
            // 
            painbtn.Font = new Font("Modern No. 20", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            painbtn.Location = new Point(137, 24);
            painbtn.Name = "painbtn";
            painbtn.Size = new Size(111, 50);
            painbtn.TabIndex = 0;
            painbtn.Text = "Pain";
            painbtn.UseVisualStyleBackColor = true;
            painbtn.Click += painbtn_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(254, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(259, 98);
            panel4.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 98);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(187, 222, 251);
            panel5.Controls.Add(coldbtn);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(268, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(259, 98);
            panel5.TabIndex = 4;
            // 
            // coldbtn
            // 
            coldbtn.Font = new Font("Modern No. 20", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coldbtn.Location = new Point(145, 24);
            coldbtn.Name = "coldbtn";
            coldbtn.Size = new Size(111, 50);
            coldbtn.TabIndex = 5;
            coldbtn.Text = "Cold";
            coldbtn.UseVisualStyleBackColor = true;
            coldbtn.Click += coldbtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(14, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(95, 98);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(187, 222, 251);
            panel6.Controls.Add(stomachbtn);
            panel6.Controls.Add(pictureBox5);
            panel6.Location = new Point(533, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(259, 98);
            panel6.TabIndex = 4;
            // 
            // stomachbtn
            // 
            stomachbtn.Font = new Font("Modern No. 20", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stomachbtn.Location = new Point(145, 24);
            stomachbtn.Name = "stomachbtn";
            stomachbtn.Size = new Size(111, 50);
            stomachbtn.TabIndex = 6;
            stomachbtn.Text = "Stomach";
            stomachbtn.UseVisualStyleBackColor = true;
            stomachbtn.Click += stomachbtn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(17, -3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(95, 98);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(187, 222, 251);
            panel7.Controls.Add(woundbtn);
            panel7.Controls.Add(pictureBox6);
            panel7.Location = new Point(798, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(259, 98);
            panel7.TabIndex = 4;
            // 
            // woundbtn
            // 
            woundbtn.Font = new Font("Modern No. 20", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            woundbtn.Location = new Point(148, 24);
            woundbtn.Name = "woundbtn";
            woundbtn.Size = new Size(111, 50);
            woundbtn.TabIndex = 7;
            woundbtn.Text = "Wound";
            woundbtn.UseVisualStyleBackColor = true;
            woundbtn.Click += woundbtn_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(17, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(95, 98);
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(187, 222, 251);
            panel9.Controls.Add(pictureBox8);
            panel9.Controls.Add(coughbtn);
            panel9.Location = new Point(1063, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(259, 98);
            panel9.TabIndex = 4;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(10, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(104, 98);
            pictureBox8.TabIndex = 5;
            pictureBox8.TabStop = false;
            // 
            // coughbtn
            // 
            coughbtn.Font = new Font("Modern No. 20", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coughbtn.Location = new Point(145, 24);
            coughbtn.Name = "coughbtn";
            coughbtn.Size = new Size(111, 50);
            coughbtn.TabIndex = 8;
            coughbtn.Text = "Cough";
            coughbtn.UseVisualStyleBackColor = true;
            coughbtn.Click += coughbtn_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(187, 222, 251);
            panel10.Controls.Add(pictureBox7);
            panel10.Controls.Add(firstbtn);
            panel10.Location = new Point(1328, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(259, 98);
            panel10.TabIndex = 4;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(13, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(104, 98);
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // firstbtn
            // 
            firstbtn.Font = new Font("Modern No. 20", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstbtn.Location = new Point(148, 24);
            firstbtn.Name = "firstbtn";
            firstbtn.Size = new Size(111, 50);
            firstbtn.TabIndex = 9;
            firstbtn.Text = "First aid";
            firstbtn.UseVisualStyleBackColor = true;
            firstbtn.Click += firstbtn_Click;
            // 
            // mainpanel
            // 
            mainpanel.AutoScroll = true;
            mainpanel.Location = new Point(6, 322);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1748, 655);
            mainpanel.TabIndex = 3;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1760, 1148);
            Controls.Add(mainpanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += Inventory_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label timelbl;
        private Label datelbl;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel9;
        private Panel panel10;
        private Panel mainpanel;
        private Button painbtn;
        private Button coldbtn;
        private Button stomachbtn;
        private Button woundbtn;
        private Button coughbtn;
        private Button firstbtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private circlebutton back;
    }
}