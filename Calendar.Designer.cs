namespace Schedully
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            prev = new circlebutton();
            next = new circlebutton();
            lblmonth = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            calendarflow = new FlowLayoutPanel();
            toolTip1 = new ToolTip(components);
            backbtn = new circlebutton();
            SuspendLayout();
            // 
            // prev
            // 
            prev.BackColor = Color.FromArgb(224, 224, 224);
            prev.FlatAppearance.BorderSize = 0;
            prev.FlatStyle = FlatStyle.Flat;
            prev.Image = (Image)resources.GetObject("prev.Image");
            prev.Location = new Point(325, 12);
            prev.Name = "prev";
            prev.Size = new Size(69, 66);
            prev.TabIndex = 16;
            toolTip1.SetToolTip(prev, "Previous Month");
            prev.UseVisualStyleBackColor = false;
            prev.Click += prev_Click;
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(224, 224, 224);
            next.FlatAppearance.BorderSize = 0;
            next.FlatStyle = FlatStyle.Flat;
            next.Image = (Image)resources.GetObject("next.Image");
            next.Location = new Point(430, 12);
            next.Name = "next";
            next.Size = new Size(69, 66);
            next.TabIndex = 15;
            toolTip1.SetToolTip(next, "Next Month");
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // lblmonth
            // 
            lblmonth.AutoSize = true;
            lblmonth.Font = new Font("Segoe UI", 16F);
            lblmonth.Location = new Point(63, 24);
            lblmonth.Name = "lblmonth";
            lblmonth.Size = new Size(115, 45);
            lblmonth.TabIndex = 14;
            lblmonth.Text = "Month";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(1320, 92);
            label7.Name = "label7";
            label7.Size = new Size(116, 36);
            label7.TabIndex = 29;
            label7.Text = "Saturday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(1158, 92);
            label6.Name = "label6";
            label6.Size = new Size(84, 36);
            label6.TabIndex = 28;
            label6.Text = "Friday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(944, 92);
            label5.Name = "label5";
            label5.Size = new Size(120, 36);
            label5.TabIndex = 27;
            label5.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(744, 92);
            label4.Name = "label4";
            label4.Size = new Size(148, 36);
            label4.TabIndex = 26;
            label4.Text = "Wednesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(571, 92);
            label3.Name = "label3";
            label3.Size = new Size(110, 36);
            label3.TabIndex = 25;
            label3.Text = "Tuesday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(378, 92);
            label2.Name = "label2";
            label2.Size = new Size(109, 36);
            label2.TabIndex = 24;
            label2.Text = "Monday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(204, 92);
            label1.Name = "label1";
            label1.Size = new Size(100, 36);
            label1.TabIndex = 23;
            label1.Text = "Sunday";
            // 
            // calendarflow
            // 
            calendarflow.Location = new Point(149, 154);
            calendarflow.Name = "calendarflow";
            calendarflow.Size = new Size(1338, 985);
            calendarflow.TabIndex = 22;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.White;
            backbtn.FlatAppearance.BorderSize = 0;
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Image = (Image)resources.GetObject("backbtn.Image");
            backbtn.Location = new Point(1379, 5);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(96, 81);
            backbtn.TabIndex = 30;
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            backbtn.MouseEnter += backbtn_Mouse_Enter;
            backbtn.MouseLeave += backbtn_Mouse_Leave;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1513, 861);
            Controls.Add(backbtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calendarflow);
            Controls.Add(prev);
            Controls.Add(next);
            Controls.Add(lblmonth);
            Name = "Calendar";
            Text = "Calendar";
            Load += Calendar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private circlebutton prev;
        private circlebutton next;
        private Label lblmonth;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel calendarflow;
        private ToolTip toolTip1;
        private circlebutton backbtn;
    }
}