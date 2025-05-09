namespace Schedully
{
    partial class Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ploty = new OxyPlot.WindowsForms.PlotView();
            back = new circlebutton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 50, 56);
            label1.Location = new Point(805, 74);
            label1.Name = "label1";
            label1.Size = new Size(244, 59);
            label1.TabIndex = 4;
            label1.Text = " ANALYTICS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1608, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 200);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // ploty
            // 
            ploty.BackColor = Color.FromArgb(227, 242, 253);
            ploty.Location = new Point(269, 303);
            ploty.Name = "ploty";
            ploty.PanCursor = Cursors.Hand;
            ploty.Size = new Size(1357, 639);
            ploty.TabIndex = 42;
            ploty.Text = "plotView1";
            ploty.ZoomHorizontalCursor = Cursors.SizeWE;
            ploty.ZoomRectangleCursor = Cursors.SizeNWSE;
            ploty.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // back
            // 
            back.BackColor = Color.Azure;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Image = (Image)resources.GetObject("back.Image");
            back.Location = new Point(1504, 3);
            back.Name = "back";
            back.Size = new Size(66, 62);
            back.TabIndex = 43;
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(back);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1815, 233);
            panel1.TabIndex = 44;
            // 
            // Analytics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 242, 253);
            ClientSize = new Size(1821, 1024);
            Controls.Add(panel1);
            Controls.Add(ploty);
            Name = "Analytics";
            Text = "Analytics";
            Load += Analytics_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private OxyPlot.WindowsForms.PlotView ploty;
        private circlebutton back;
        private Panel panel1;
    }
}