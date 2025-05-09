namespace Schedully.Controls
{
    partial class UserControlDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDelete));
            dgvdel = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            delbtn = new circlebutton();
            tooltip = new ToolTip(components);
            clientname = new MaterialSkin.Controls.MaterialTextBox();
            refresh = new circlebutton();
            ((System.ComponentModel.ISupportInitialize)dgvdel).BeginInit();
            SuspendLayout();
            // 
            // dgvdel
            // 
            dgvdel.BackgroundColor = Color.Beige;
            dgvdel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdel.Location = new Point(136, 63);
            dgvdel.Name = "dgvdel";
            dgvdel.RowHeadersWidth = 62;
            dgvdel.Size = new Size(1161, 440);
            dgvdel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20F);
            label2.ForeColor = Color.FromArgb(38, 50, 56);
            label2.Location = new Point(516, 13);
            label2.Name = "label2";
            label2.Size = new Size(416, 47);
            label2.TabIndex = 6;
            label2.Text = "Deleting Appointments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(249, 249, 249);
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(38, 50, 56);
            label1.Location = new Point(344, 582);
            label1.Name = "label1";
            label1.Size = new Size(207, 41);
            label1.TabIndex = 7;
            label1.Text = "Enter Client ID";
            // 
            // delbtn
            // 
            delbtn.BackColor = Color.DeepSkyBlue;
            delbtn.FlatAppearance.BorderSize = 0;
            delbtn.FlatStyle = FlatStyle.Flat;
            delbtn.Image = (Image)resources.GetObject("delbtn.Image");
            delbtn.Location = new Point(642, 688);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(108, 99);
            delbtn.TabIndex = 8;
            tooltip.SetToolTip(delbtn, "Delete");
            delbtn.UseVisualStyleBackColor = false;
            delbtn.Click += delbtn_Click;
            // 
            // clientname
            // 
            clientname.AnimateReadOnly = false;
            clientname.BorderStyle = BorderStyle.None;
            clientname.Depth = 0;
            clientname.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            clientname.LeadingIcon = null;
            clientname.Location = new Point(557, 582);
            clientname.MaxLength = 50;
            clientname.MouseState = MaterialSkin.MouseState.OUT;
            clientname.Multiline = false;
            clientname.Name = "clientname";
            clientname.Size = new Size(375, 50);
            clientname.TabIndex = 35;
            clientname.Text = "";
            clientname.TrailingIcon = null;
            // 
            // refresh
            // 
            refresh.BackColor = Color.FromArgb(249, 249, 249);
            refresh.FlatAppearance.BorderSize = 0;
            refresh.FlatStyle = FlatStyle.Flat;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(136, 509);
            refresh.Name = "refresh";
            refresh.Size = new Size(66, 62);
            refresh.TabIndex = 36;
            refresh.UseVisualStyleBackColor = false;
            refresh.Click += refresh_Click;
            // 
            // UserControlDelete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            Controls.Add(refresh);
            Controls.Add(clientname);
            Controls.Add(delbtn);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dgvdel);
            Name = "UserControlDelete";
            Size = new Size(1435, 865);
            Load += UserControlDelete_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdel;
        private Label label2;
        private Label label1;
        private ToolTip tooltip;
        private circlebutton delbtn;
        private MaterialSkin.Controls.MaterialTextBox clientname;
        private circlebutton refresh;
    }
}
