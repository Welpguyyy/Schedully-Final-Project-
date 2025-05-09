namespace Schedully.Controls
{
    partial class UserControlMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMark));
            dgvmark = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            markCompleteToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            refresh = new circlebutton();
            ((System.ComponentModel.ISupportInitialize)dgvmark).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvmark
            // 
            dgvmark.BackgroundColor = Color.Beige;
            dgvmark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmark.ContextMenuStrip = contextMenuStrip1;
            dgvmark.Location = new Point(220, 132);
            dgvmark.Name = "dgvmark";
            dgvmark.RowHeadersWidth = 62;
            dgvmark.Size = new Size(1055, 561);
            dgvmark.TabIndex = 4;
            dgvmark.MouseDown += dgvmark_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { markCompleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(207, 36);
            // 
            // markCompleteToolStripMenuItem
            // 
            markCompleteToolStripMenuItem.Name = "markCompleteToolStripMenuItem";
            markCompleteToolStripMenuItem.Size = new Size(206, 32);
            markCompleteToolStripMenuItem.Text = "Mark Complete";
            markCompleteToolStripMenuItem.Click += markCompleteToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(38, 50, 56);
            label2.Location = new Point(610, 51);
            label2.Name = "label2";
            label2.Size = new Size(310, 42);
            label2.TabIndex = 7;
            label2.Text = "Mark Appointment";
            // 
            // refresh
            // 
            refresh.BackColor = Color.FromArgb(249, 249, 249);
            refresh.FlatAppearance.BorderSize = 0;
            refresh.FlatStyle = FlatStyle.Flat;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(220, 699);
            refresh.Name = "refresh";
            refresh.Size = new Size(66, 62);
            refresh.TabIndex = 31;
            refresh.UseVisualStyleBackColor = false;
            refresh.Click += refresh_Click;
            // 
            // UserControlMark
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            Controls.Add(refresh);
            Controls.Add(label2);
            Controls.Add(dgvmark);
            Font = new Font("Microsoft Sans Serif", 9F);
            Name = "UserControlMark";
            Size = new Size(1442, 907);
            Load += UserControlMark_Load;
            ((System.ComponentModel.ISupportInitialize)dgvmark).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvmark;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem markCompleteToolStripMenuItem;
        private circlebutton refresh;
    }
}
