namespace Schedully.Controls
{
    partial class UserControlFirstaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlFirstaid));
            gauzelbl = new Label();
            bplbl = new Label();
            gloveslbl = new Label();
            bandlbl = new Label();
            thermolbl = new Label();
            panel4 = new Panel();
            firstlbl = new Label();
            label5 = new Label();
            removebtn = new circlebutton();
            addbtn = new circlebutton();
            label4 = new Label();
            firstbox = new MaterialSkin.Controls.MaterialComboBox();
            circlebutton1 = new circlebutton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gauzelbl
            // 
            gauzelbl.AutoSize = true;
            gauzelbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gauzelbl.Location = new Point(193, 148);
            gauzelbl.Name = "gauzelbl";
            gauzelbl.Size = new Size(50, 39);
            gauzelbl.TabIndex = 11;
            gauzelbl.Text = "X0";
            // 
            // bplbl
            // 
            bplbl.AutoSize = true;
            bplbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bplbl.Location = new Point(485, 148);
            bplbl.Name = "bplbl";
            bplbl.Size = new Size(50, 39);
            bplbl.TabIndex = 9;
            bplbl.Text = "X0";
            // 
            // gloveslbl
            // 
            gloveslbl.AutoSize = true;
            gloveslbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gloveslbl.Location = new Point(827, 0);
            gloveslbl.Name = "gloveslbl";
            gloveslbl.Size = new Size(50, 39);
            gloveslbl.TabIndex = 8;
            gloveslbl.Text = "X0";
            // 
            // bandlbl
            // 
            bandlbl.AutoSize = true;
            bandlbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bandlbl.Location = new Point(485, 0);
            bandlbl.Name = "bandlbl";
            bandlbl.Size = new Size(50, 39);
            bandlbl.TabIndex = 10;
            bandlbl.Text = "X0";
            // 
            // thermolbl
            // 
            thermolbl.AutoSize = true;
            thermolbl.Font = new Font("Calibri", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            thermolbl.Location = new Point(193, 0);
            thermolbl.Name = "thermolbl";
            thermolbl.Size = new Size(50, 39);
            thermolbl.TabIndex = 7;
            thermolbl.Text = "X0";
            // 
            // panel4
            // 
            panel4.Controls.Add(firstlbl);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(removebtn);
            panel4.Controls.Add(addbtn);
            panel4.Location = new Point(1350, 348);
            panel4.Name = "panel4";
            panel4.Size = new Size(187, 140);
            panel4.TabIndex = 31;
            // 
            // firstlbl
            // 
            firstlbl.AutoSize = true;
            firstlbl.Location = new Point(116, 23);
            firstlbl.Name = "firstlbl";
            firstlbl.Size = new Size(22, 25);
            firstlbl.TabIndex = 42;
            firstlbl.Text = "0";
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
            label4.Location = new Point(1305, 179);
            label4.Name = "label4";
            label4.Size = new Size(242, 39);
            label4.TabIndex = 30;
            label4.Text = "Equipment name";
            // 
            // firstbox
            // 
            firstbox.AutoResize = false;
            firstbox.BackColor = Color.FromArgb(255, 255, 255);
            firstbox.Depth = 0;
            firstbox.DrawMode = DrawMode.OwnerDrawVariable;
            firstbox.DropDownHeight = 174;
            firstbox.DropDownStyle = ComboBoxStyle.DropDownList;
            firstbox.DropDownWidth = 121;
            firstbox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            firstbox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            firstbox.FormattingEnabled = true;
            firstbox.IntegralHeight = false;
            firstbox.ItemHeight = 43;
            firstbox.Items.AddRange(new object[] { "Thermometer", "Gauze ", "Band- aid", "BP", "Gloves" });
            firstbox.Location = new Point(1321, 247);
            firstbox.MaxDropDownItems = 4;
            firstbox.MouseState = MaterialSkin.MouseState.OUT;
            firstbox.Name = "firstbox";
            firstbox.Size = new Size(279, 49);
            firstbox.StartIndex = 0;
            firstbox.TabIndex = 32;
            // 
            // circlebutton1
            // 
            circlebutton1.BackColor = Color.Gainsboro;
            circlebutton1.FlatStyle = FlatStyle.Flat;
            circlebutton1.Location = new Point(1383, 523);
            circlebutton1.Name = "circlebutton1";
            circlebutton1.Size = new Size(137, 69);
            circlebutton1.TabIndex = 43;
            circlebutton1.Text = "Take items";
            circlebutton1.UseVisualStyleBackColor = false;
            circlebutton1.Click += circlebutton1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.1647949F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8352051F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 203F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Controls.Add(thermolbl, 1, 0);
            tableLayoutPanel1.Controls.Add(gloveslbl, 5, 0);
            tableLayoutPanel1.Controls.Add(gauzelbl, 1, 1);
            tableLayoutPanel1.Controls.Add(bplbl, 3, 1);
            tableLayoutPanel1.Controls.Add(bandlbl, 3, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(label7, 4, 0);
            tableLayoutPanel1.Location = new Point(88, 114);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(898, 297);
            tableLayoutPanel1.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 35);
            label6.TabIndex = 32;
            label6.Text = "Thermometer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 148);
            label1.Name = "label1";
            label1.Size = new Size(85, 35);
            label1.TabIndex = 33;
            label1.Text = "Gauze";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 35);
            label2.TabIndex = 34;
            label2.Text = "Band-Aid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 148);
            label3.Name = "label3";
            label3.Size = new Size(44, 35);
            label3.TabIndex = 35;
            label3.Text = "BP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(607, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 35);
            label7.TabIndex = 36;
            label7.Text = "Gloves";
            // 
            // UserControlFirstaid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(circlebutton1);
            Controls.Add(firstbox);
            Controls.Add(panel4);
            Controls.Add(label4);
            Name = "UserControlFirstaid";
            Size = new Size(1748, 655);
            Load += UserControlFirstaid_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel4;
        private Label label5;
        private circlebutton removebtn;
        private circlebutton addbtn;
        private Label label4;
        private MaterialSkin.Controls.MaterialComboBox firstbox;
        private Label gauzelbl;
        private Label bplbl;
        private Label gloveslbl;
        private Label bandlbl;
        private Label thermolbl;
        private Label firstlbl;
        private circlebutton circlebutton1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
    }
}
