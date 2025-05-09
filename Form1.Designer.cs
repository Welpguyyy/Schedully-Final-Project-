namespace Schedully
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblsched = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            analy = new circlebutton();
            SuspendLayout();
            // 
            // lblsched
            // 
            lblsched.AutoSize = true;
            lblsched.BackColor = Color.FromArgb(130, 194, 227);
            lblsched.Font = new Font("Brush Script MT", 48F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblsched.Location = new Point(310, 70);
            lblsched.Name = "lblsched";
            lblsched.Size = new Size(360, 117);
            lblsched.TabIndex = 0;
            lblsched.Text = "Schedully";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // analy
            // 
            analy.BackColor = Color.SkyBlue;
            analy.FlatAppearance.BorderSize = 0;
            analy.FlatStyle = FlatStyle.Flat;
            analy.Image = (Image)resources.GetObject("analy.Image");
            analy.Location = new Point(853, 12);
            analy.Name = "analy";
            analy.Size = new Size(93, 85);
            analy.TabIndex = 8;
            analy.UseVisualStyleBackColor = false;
            analy.Click += analy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 744);
            Controls.Add(analy);
            Controls.Add(lblsched);
            DoubleBuffered = true;
            Name = "Form1";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsched;
        private System.Windows.Forms.Timer timer1;
        private circlebutton analy;
    }
}
