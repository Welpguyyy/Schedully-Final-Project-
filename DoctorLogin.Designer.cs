namespace Schedully
{
    partial class DoctorLogin
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
            label1 = new Label();
            label2 = new Label();
            passtxt = new MaskedTextBox();
            usertxt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 121);
            label1.Name = "label1";
            label1.Size = new Size(165, 33);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 166);
            label2.Name = "label2";
            label2.Size = new Size(180, 33);
            label2.TabIndex = 1;
            label2.Text = "Password : ";
            // 
            // passtxt
            // 
            passtxt.Location = new Point(187, 169);
            passtxt.Name = "passtxt";
            passtxt.PasswordChar = '*';
            passtxt.Size = new Size(236, 31);
            passtxt.TabIndex = 1;
            // 
            // usertxt
            // 
            usertxt.Location = new Point(187, 121);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(236, 31);
            usertxt.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(311, 257);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(29, 257);
            button2.Name = "button2";
            button2.Size = new Size(165, 34);
            button2.TabIndex = 5;
            button2.Text = "Forgot Password";
            button2.UseVisualStyleBackColor = true;
            // 
            // DoctorLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 194, 227);
            ClientSize = new Size(446, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(usertxt);
            Controls.Add(passtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DoctorLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorLogin";
            Load += DoctorLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox passtxt;
        private TextBox usertxt;
        private Button button1;
        private Button button2;
    }
}