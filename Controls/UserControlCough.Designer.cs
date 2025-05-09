namespace Schedully.Controls
{
    partial class UserControlCough
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCough));
            lagulbl = new Label();
            label2 = new Label();
            label1 = new Label();
            carbo = new Label();
            panel1 = new Panel();
            cough = new Label();
            label5 = new Label();
            removebtn = new circlebutton();
            addbtn = new circlebutton();
            label4 = new Label();
            coughbox = new MaterialSkin.Controls.MaterialComboBox();
            circlebutton1 = new circlebutton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lagulbl
            // 
            lagulbl.AutoSize = true;
            lagulbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lagulbl.Location = new Point(459, 142);
            lagulbl.Name = "lagulbl";
            lagulbl.Size = new Size(50, 39);
            lagulbl.TabIndex = 8;
            lagulbl.Text = "X0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(335, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 135);
            label2.TabIndex = 22;
            label2.Text = "Lagundi Syrup";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 90);
            label1.TabIndex = 21;
            label1.Text = "Ambroxol HCl";
            // 
            // carbo
            // 
            carbo.AutoSize = true;
            carbo.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            carbo.Location = new Point(220, 142);
            carbo.Name = "carbo";
            carbo.Size = new Size(50, 39);
            carbo.TabIndex = 7;
            carbo.Text = "X0";
            // 
            // panel1
            // 
            panel1.Controls.Add(cough);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(removebtn);
            panel1.Controls.Add(addbtn);
            panel1.Location = new Point(1023, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 140);
            panel1.TabIndex = 29;
            // 
            // cough
            // 
            cough.AutoSize = true;
            cough.Location = new Point(116, 23);
            cough.Name = "cough";
            cough.Size = new Size(22, 25);
            cough.TabIndex = 23;
            cough.Text = "0";
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
            label4.Location = new Point(978, 158);
            label4.Name = "label4";
            label4.Size = new Size(219, 39);
            label4.TabIndex = 28;
            label4.Text = "Medicine name";
            // 
            // coughbox
            // 
            coughbox.AutoResize = false;
            coughbox.BackColor = Color.FromArgb(255, 255, 255);
            coughbox.Depth = 0;
            coughbox.DrawMode = DrawMode.OwnerDrawVariable;
            coughbox.DropDownHeight = 174;
            coughbox.DropDownStyle = ComboBoxStyle.DropDownList;
            coughbox.DropDownWidth = 121;
            coughbox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            coughbox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            coughbox.FormattingEnabled = true;
            coughbox.IntegralHeight = false;
            coughbox.ItemHeight = 43;
            coughbox.Items.AddRange(new object[] { "Solmux", "Ascof" });
            coughbox.Location = new Point(978, 236);
            coughbox.MaxDropDownItems = 4;
            coughbox.MouseState = MaterialSkin.MouseState.OUT;
            coughbox.Name = "coughbox";
            coughbox.Size = new Size(319, 49);
            coughbox.StartIndex = 0;
            coughbox.TabIndex = 30;
            // 
            // circlebutton1
            // 
            circlebutton1.BackColor = Color.Gainsboro;
            circlebutton1.FlatStyle = FlatStyle.Flat;
            circlebutton1.Location = new Point(1044, 520);
            circlebutton1.Name = "circlebutton1";
            circlebutton1.Size = new Size(137, 69);
            circlebutton1.TabIndex = 31;
            circlebutton1.Text = "Take items";
            circlebutton1.UseVisualStyleBackColor = false;
            circlebutton1.Click += circlebutton1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.4054F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.594593F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lagulbl, 3, 1);
            tableLayoutPanel1.Controls.Add(carbo, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Location = new Point(265, 207);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.044693F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.955307F));
            tableLayoutPanel1.Size = new Size(536, 297);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 142);
            label6.Name = "label6";
            label6.Size = new Size(98, 35);
            label6.TabIndex = 31;
            label6.Text = "Solmux";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(335, 142);
            label3.Name = "label3";
            label3.Size = new Size(78, 35);
            label3.TabIndex = 32;
            label3.Text = "Ascof";
            // 
            // UserControlCough
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(circlebutton1);
            Controls.Add(coughbox);
            Controls.Add(panel1);
            Controls.Add(label4);
            Name = "UserControlCough";
            Size = new Size(1748, 655);
            Load += UserControlCough_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private circlebutton removebtn;
        private circlebutton addbtn;
        private Label label4;
        private MaterialSkin.Controls.MaterialComboBox coughbox;
        private Label lagulbl;
        private Label carbo;
        private circlebutton circlebutton1;
        private Label cough;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label3;
    }
}
