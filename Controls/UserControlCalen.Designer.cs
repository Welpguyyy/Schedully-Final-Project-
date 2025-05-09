namespace Schedully.Controls
{
    partial class UserControlCalen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCalen));
            lblmonth = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            calendarflow = new FlowLayoutPanel();
            next = new circlebutton();
            prev = new circlebutton();
            refresh = new circlebutton();
            datelbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblmonth
            // 
            lblmonth.AutoSize = true;
            lblmonth.Font = new Font("Segoe UI", 16F);
            lblmonth.Location = new Point(56, 29);
            lblmonth.Name = "lblmonth";
            lblmonth.Size = new Size(115, 45);
            lblmonth.TabIndex = 17;
            lblmonth.Text = "Month";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(1231, 108);
            label7.Name = "label7";
            label7.Size = new Size(116, 36);
            label7.TabIndex = 37;
            label7.Text = "Saturday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(1069, 108);
            label6.Name = "label6";
            label6.Size = new Size(84, 36);
            label6.TabIndex = 36;
            label6.Text = "Friday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(855, 108);
            label5.Name = "label5";
            label5.Size = new Size(120, 36);
            label5.TabIndex = 35;
            label5.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(655, 108);
            label4.Name = "label4";
            label4.Size = new Size(148, 36);
            label4.TabIndex = 34;
            label4.Text = "Wednesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(482, 108);
            label3.Name = "label3";
            label3.Size = new Size(110, 36);
            label3.TabIndex = 33;
            label3.Text = "Tuesday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(289, 108);
            label2.Name = "label2";
            label2.Size = new Size(109, 36);
            label2.TabIndex = 32;
            label2.Text = "Monday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(115, 108);
            label1.Name = "label1";
            label1.Size = new Size(100, 36);
            label1.TabIndex = 31;
            label1.Text = "Sunday";
            // 
            // calendarflow
            // 
            calendarflow.Location = new Point(60, 170);
            calendarflow.Name = "calendarflow";
            calendarflow.Size = new Size(1338, 985);
            calendarflow.TabIndex = 30;
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(224, 224, 224);
            next.FlatAppearance.BorderSize = 0;
            next.FlatStyle = FlatStyle.Flat;
            next.Image = (Image)resources.GetObject("next.Image");
            next.Location = new Point(432, 8);
            next.Name = "next";
            next.Size = new Size(69, 66);
            next.TabIndex = 38;
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // prev
            // 
            prev.BackColor = Color.FromArgb(224, 224, 224);
            prev.FlatAppearance.BorderSize = 0;
            prev.FlatStyle = FlatStyle.Flat;
            prev.Image = (Image)resources.GetObject("prev.Image");
            prev.Location = new Point(345, 8);
            prev.Name = "prev";
            prev.Size = new Size(69, 66);
            prev.TabIndex = 39;
            prev.UseVisualStyleBackColor = false;
            prev.Click += prev_Click;
            // 
            // refresh
            // 
            refresh.BackColor = Color.FromArgb(249, 249, 249);
            refresh.FlatAppearance.BorderSize = 0;
            refresh.FlatStyle = FlatStyle.Flat;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(1317, 3);
            refresh.Name = "refresh";
            refresh.Size = new Size(66, 62);
            refresh.TabIndex = 40;
            refresh.UseVisualStyleBackColor = false;
            refresh.Click += refresh_Click;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            datelbl.Location = new Point(824, 21);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(89, 44);
            datelbl.TabIndex = 41;
            datelbl.Text = "Date";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UserControlCalen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(249, 249, 249);
            Controls.Add(datelbl);
            Controls.Add(refresh);
            Controls.Add(prev);
            Controls.Add(next);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calendarflow);
            Controls.Add(lblmonth);
            Name = "UserControlCalen";
            Size = new Size(1409, 865);
            Load += UserControlCalen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblmonth;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel calendarflow;
        private circlebutton next;
        private circlebutton prev;
        private circlebutton refresh;
        private Label datelbl;
        private System.Windows.Forms.Timer timer1;
    }

    partial class CopyOfUserControlCalen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyOfUserControlCalen));
            lblmonth = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            calendarflow = new FlowLayoutPanel();
            next = new circlebutton();
            prev = new circlebutton();
            refresh = new circlebutton();
            SuspendLayout();
            // 
            // lblmonth
            // 
            lblmonth.AutoSize = true;
            lblmonth.Font = new Font("Segoe UI", 16F);
            lblmonth.Location = new Point(56, 29);
            lblmonth.Name = "lblmonth";
            lblmonth.Size = new Size(115, 45);
            lblmonth.TabIndex = 17;
            lblmonth.Text = "Month";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(1235, 107);
            label7.Name = "label7";
            label7.Size = new Size(116, 36);
            label7.TabIndex = 37;
            label7.Text = "Saturday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(1073, 107);
            label6.Name = "label6";
            label6.Size = new Size(84, 36);
            label6.TabIndex = 36;
            label6.Text = "Friday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(859, 107);
            label5.Name = "label5";
            label5.Size = new Size(120, 36);
            label5.TabIndex = 35;
            label5.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(659, 107);
            label4.Name = "label4";
            label4.Size = new Size(148, 36);
            label4.TabIndex = 34;
            label4.Text = "Wednesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(486, 107);
            label3.Name = "label3";
            label3.Size = new Size(110, 36);
            label3.TabIndex = 33;
            label3.Text = "Tuesday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(293, 107);
            label2.Name = "label2";
            label2.Size = new Size(109, 36);
            label2.TabIndex = 32;
            label2.Text = "Monday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(119, 107);
            label1.Name = "label1";
            label1.Size = new Size(100, 36);
            label1.TabIndex = 31;
            label1.Text = "Sunday";
            // 
            // calendarflow
            // 
            calendarflow.Location = new Point(64, 169);
            calendarflow.Name = "calendarflow";
            calendarflow.Size = new Size(1338, 985);
            calendarflow.TabIndex = 30;
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(224, 224, 224);
            next.FlatAppearance.BorderSize = 0;
            next.FlatStyle = FlatStyle.Flat;
            next.Image = (Image)resources.GetObject("next.Image");
            next.Location = new Point(432, 8);
            next.Name = "next";
            next.Size = new Size(69, 66);
            next.TabIndex = 38;
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // prev
            // 
            prev.BackColor = Color.FromArgb(224, 224, 224);
            prev.FlatAppearance.BorderSize = 0;
            prev.FlatStyle = FlatStyle.Flat;
            prev.Image = (Image)resources.GetObject("prev.Image");
            prev.Location = new Point(345, 8);
            prev.Name = "prev";
            prev.Size = new Size(69, 66);
            prev.TabIndex = 39;
            prev.UseVisualStyleBackColor = false;
            prev.Click += prev_Click;
            // 
            // refresh
            // 
            refresh.BackColor = Color.FromArgb(249, 249, 249);
            refresh.FlatAppearance.BorderSize = 0;
            refresh.FlatStyle = FlatStyle.Flat;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(1317, 3);
            refresh.Name = "refresh";
            refresh.Size = new Size(66, 62);
            refresh.TabIndex = 40;
            refresh.UseVisualStyleBackColor = false;
            refresh.Click += refresh_Click;
            // 
            // CopyOfUserControlCalen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(249, 249, 249);
            Controls.Add(refresh);
            Controls.Add(prev);
            Controls.Add(next);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calendarflow);
            Controls.Add(lblmonth);
            Name = "CopyOfUserControlCalen";
            Size = new Size(1389, 833);
            Load += UserControlCalen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblmonth;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel calendarflow;
        private circlebutton next;
        private circlebutton prev;
        private circlebutton refresh;
    }
}
