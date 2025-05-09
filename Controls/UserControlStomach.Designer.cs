namespace Schedully.Controls
{
    partial class UserControlStomach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStomach));
            hydralbl = new Label();
            kremlbl = new Label();
            pedlbl = new Label();
            imolbl = new Label();
            dialbl = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gavlbl = new Label();
            panel1 = new Panel();
            stomlbl = new Label();
            label5 = new Label();
            removebtn = new circlebutton();
            addbtn = new circlebutton();
            label4 = new Label();
            stomachbox = new MaterialSkin.Controls.MaterialComboBox();
            circlebutton1 = new circlebutton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // hydralbl
            // 
            hydralbl.AutoSize = true;
            hydralbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            hydralbl.Location = new Point(897, 120);
            hydralbl.Name = "hydralbl";
            hydralbl.Size = new Size(50, 39);
            hydralbl.TabIndex = 12;
            hydralbl.Text = "X0";
            // 
            // kremlbl
            // 
            kremlbl.AutoSize = true;
            kremlbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            kremlbl.Location = new Point(227, 240);
            kremlbl.Name = "kremlbl";
            kremlbl.Size = new Size(50, 39);
            kremlbl.TabIndex = 8;
            kremlbl.Text = "X0";
            // 
            // pedlbl
            // 
            pedlbl.AutoSize = true;
            pedlbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            pedlbl.Location = new Point(897, 240);
            pedlbl.Name = "pedlbl";
            pedlbl.Size = new Size(50, 39);
            pedlbl.TabIndex = 11;
            pedlbl.Text = "X0";
            // 
            // imolbl
            // 
            imolbl.AutoSize = true;
            imolbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            imolbl.Location = new Point(567, 120);
            imolbl.Name = "imolbl";
            imolbl.Size = new Size(50, 39);
            imolbl.TabIndex = 9;
            imolbl.Text = "X0";
            // 
            // dialbl
            // 
            dialbl.AutoSize = true;
            dialbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dialbl.Location = new Point(567, 240);
            dialbl.Name = "dialbl";
            dialbl.Size = new Size(50, 39);
            dialbl.TabIndex = 10;
            dialbl.Text = "X0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(664, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 90);
            label3.TabIndex = 27;
            label3.Text = "ORS (Oral Rehydration)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(336, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 45);
            label2.TabIndex = 26;
            label2.Text = "Loperamide";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 45);
            label1.TabIndex = 25;
            label1.Text = "Antacids";
            // 
            // gavlbl
            // 
            gavlbl.AutoSize = true;
            gavlbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gavlbl.Location = new Point(227, 120);
            gavlbl.Name = "gavlbl";
            gavlbl.Size = new Size(50, 39);
            gavlbl.TabIndex = 7;
            gavlbl.Text = "X0";
            // 
            // panel1
            // 
            panel1.Controls.Add(stomlbl);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(removebtn);
            panel1.Controls.Add(addbtn);
            panel1.Location = new Point(1339, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 140);
            panel1.TabIndex = 38;
            // 
            // stomlbl
            // 
            stomlbl.AutoSize = true;
            stomlbl.Location = new Point(116, 23);
            stomlbl.Name = "stomlbl";
            stomlbl.Size = new Size(22, 25);
            stomlbl.TabIndex = 41;
            stomlbl.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 23);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 22;
            label5.Text = "Quantity: ";
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.Silver;
            removebtn.FlatAppearance.BorderSize = 0;
            removebtn.FlatStyle = FlatStyle.Flat;
            removebtn.Image = (Image)resources.GetObject("removebtn.Image");
            removebtn.Location = new Point(12, 68);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(50, 50);
            removebtn.TabIndex = 21;
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Silver;
            addbtn.FlatAppearance.BorderSize = 0;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Image = (Image)resources.GetObject("addbtn.Image");
            addbtn.Location = new Point(121, 68);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(49, 53);
            addbtn.TabIndex = 15;
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1294, 188);
            label4.Name = "label4";
            label4.Size = new Size(219, 39);
            label4.TabIndex = 37;
            label4.Text = "Medicine name";
            // 
            // stomachbox
            // 
            stomachbox.AutoResize = false;
            stomachbox.BackColor = Color.FromArgb(255, 255, 255);
            stomachbox.Depth = 0;
            stomachbox.DrawMode = DrawMode.OwnerDrawVariable;
            stomachbox.DropDownHeight = 174;
            stomachbox.DropDownStyle = ComboBoxStyle.DropDownList;
            stomachbox.DropDownWidth = 121;
            stomachbox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            stomachbox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            stomachbox.FormattingEnabled = true;
            stomachbox.IntegralHeight = false;
            stomachbox.ItemHeight = 43;
            stomachbox.Items.AddRange(new object[] { "Gaviscon", "Kremil-s", "Imodium", "Diatabs", "Pedialyte", "Hydrite" });
            stomachbox.Location = new Point(1311, 270);
            stomachbox.MaxDropDownItems = 4;
            stomachbox.MouseState = MaterialSkin.MouseState.OUT;
            stomachbox.Name = "stomachbox";
            stomachbox.Size = new Size(300, 49);
            stomachbox.StartIndex = 0;
            stomachbox.TabIndex = 39;
            // 
            // circlebutton1
            // 
            circlebutton1.BackColor = Color.Gainsboro;
            circlebutton1.FlatStyle = FlatStyle.Flat;
            circlebutton1.Location = new Point(1372, 540);
            circlebutton1.Name = "circlebutton1";
            circlebutton1.Size = new Size(137, 69);
            circlebutton1.TabIndex = 40;
            circlebutton1.Text = "Take items";
            circlebutton1.UseVisualStyleBackColor = false;
            circlebutton1.Click += circlebutton1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.2672653F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.73273F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(pedlbl, 5, 2);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(hydralbl, 5, 1);
            tableLayoutPanel1.Controls.Add(label3, 4, 0);
            tableLayoutPanel1.Controls.Add(dialbl, 3, 2);
            tableLayoutPanel1.Controls.Add(gavlbl, 1, 1);
            tableLayoutPanel1.Controls.Add(imolbl, 3, 1);
            tableLayoutPanel1.Controls.Add(kremlbl, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(label9, 2, 2);
            tableLayoutPanel1.Controls.Add(label10, 4, 1);
            tableLayoutPanel1.Controls.Add(label11, 4, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Location = new Point(132, 137);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.Size = new Size(998, 369);
            tableLayoutPanel1.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 120);
            label6.Name = "label6";
            label6.Size = new Size(118, 35);
            label6.TabIndex = 34;
            label6.Text = "Gaviscon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 240);
            label7.Name = "label7";
            label7.Size = new Size(108, 35);
            label7.TabIndex = 35;
            label7.Text = "Kremil-s";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(336, 120);
            label8.Name = "label8";
            label8.Size = new Size(117, 35);
            label8.TabIndex = 36;
            label8.Text = "Imodium";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(336, 240);
            label9.Name = "label9";
            label9.Size = new Size(99, 35);
            label9.TabIndex = 37;
            label9.Text = "Diatabs";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(664, 120);
            label10.Name = "label10";
            label10.Size = new Size(99, 35);
            label10.TabIndex = 38;
            label10.Text = "Hydrite";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(664, 240);
            label11.Name = "label11";
            label11.Size = new Size(118, 35);
            label11.TabIndex = 39;
            label11.Text = "Pedialyte";
            // 
            // UserControlStomach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(circlebutton1);
            Controls.Add(stomachbox);
            Controls.Add(panel1);
            Controls.Add(label4);
            Name = "UserControlStomach";
            Size = new Size(1748, 655);
            Load += UserControlStomach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private circlebutton removebtn;
        private circlebutton addbtn;
        private Label label4;
        private MaterialSkin.Controls.MaterialComboBox stomachbox;
        private Label hydralbl;
        private Label kremlbl;
        private Label pedlbl;
        private Label imolbl;
        private Label dialbl;
        private Label gavlbl;
        private circlebutton circlebutton1;
        private Label stomlbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
