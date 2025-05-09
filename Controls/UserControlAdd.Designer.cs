namespace Schedully.Controls
{
    public partial class UserControlAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAdd));
            dgvappoint = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Gender = new ComboBox();
            label7 = new Label();
            Apptype = new GroupBox();
            Virtual = new RadioButton();
            Onsite = new RadioButton();
            label8 = new Label();
            label9 = new Label();
            date = new DateTimePicker();
            label10 = new Label();
            apptime = new ComboBox();
            toolTip1 = new ToolTip(components);
            fname = new MaterialSkin.Controls.MaterialTextBox2();
            lname = new MaterialSkin.Controls.MaterialTextBox2();
            Midinit = new MaterialSkin.Controls.MaterialTextBox2();
            age = new MaterialSkin.Controls.MaterialTextBox2();
            Addbtn = new Button();
            refresh = new circlebutton();
            coursecombo = new ComboBox();
            label11 = new Label();
            Contact = new MaterialSkin.Controls.MaterialTextBox2();
            label12 = new Label();
            label13 = new Label();
            addres = new MaterialSkin.Controls.MaterialTextBox2();
            label14 = new Label();
            parentlname = new MaterialSkin.Controls.MaterialTextBox2();
            parentfname = new MaterialSkin.Controls.MaterialTextBox2();
            label15 = new Label();
            label16 = new Label();
            parentcontact = new MaterialSkin.Controls.MaterialTextBox2();
            label17 = new Label();
            parentaddress = new MaterialSkin.Controls.MaterialTextBox2();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            covidgroup = new GroupBox();
            nocovid = new RadioButton();
            yescovid = new RadioButton();
            label21 = new Label();
            symptoms = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvappoint).BeginInit();
            Apptype.SuspendLayout();
            covidgroup.SuspendLayout();
            SuspendLayout();
            // 
            // dgvappoint
            // 
            dgvappoint.BackgroundColor = Color.Beige;
            dgvappoint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvappoint.Location = new Point(763, 24);
            dgvappoint.Name = "dgvappoint";
            dgvappoint.RowHeadersWidth = 62;
            dgvappoint.Size = new Size(666, 440);
            dgvappoint.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 50, 56);
            label1.Location = new Point(185, 12);
            label1.Name = "label1";
            label1.Size = new Size(302, 42);
            label1.TabIndex = 3;
            label1.Text = "Client Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(38, 50, 56);
            label2.Location = new Point(39, 155);
            label2.Name = "label2";
            label2.Size = new Size(146, 38);
            label2.TabIndex = 4;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(38, 50, 56);
            label3.Location = new Point(39, 209);
            label3.Name = "label3";
            label3.Size = new Size(142, 38);
            label3.TabIndex = 5;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(38, 50, 56);
            label4.Location = new Point(22, 267);
            label4.Name = "label4";
            label4.Size = new Size(178, 38);
            label4.TabIndex = 8;
            label4.Text = "Middle Initial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.FromArgb(38, 50, 56);
            label5.Location = new Point(35, 321);
            label5.Name = "label5";
            label5.Size = new Size(66, 38);
            label5.TabIndex = 10;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.FromArgb(38, 50, 56);
            label6.Location = new Point(22, 381);
            label6.Name = "label6";
            label6.Size = new Size(108, 38);
            label6.TabIndex = 12;
            label6.Text = "Gender";
            // 
            // Gender
            // 
            Gender.AutoCompleteMode = AutoCompleteMode.Suggest;
            Gender.Font = new Font("Segoe UI", 13F);
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            Gender.Location = new Point(204, 375);
            Gender.Name = "Gender";
            Gender.Size = new Size(157, 44);
            Gender.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(38, 50, 56);
            label7.Location = new Point(184, 1232);
            label7.Name = "label7";
            label7.Size = new Size(336, 42);
            label7.TabIndex = 14;
            label7.Text = "Appointment Details";
            // 
            // Apptype
            // 
            Apptype.Controls.Add(Virtual);
            Apptype.Controls.Add(Onsite);
            Apptype.Location = new Point(133, 1361);
            Apptype.Name = "Apptype";
            Apptype.Size = new Size(271, 95);
            Apptype.TabIndex = 15;
            Apptype.TabStop = false;
            // 
            // Virtual
            // 
            Virtual.AutoSize = true;
            Virtual.Font = new Font("Calibri", 13F);
            Virtual.Location = new Point(122, 33);
            Virtual.Name = "Virtual";
            Virtual.Size = new Size(110, 36);
            Virtual.TabIndex = 18;
            Virtual.TabStop = true;
            Virtual.Text = "Virtual";
            Virtual.UseVisualStyleBackColor = true;
            // 
            // Onsite
            // 
            Onsite.AutoSize = true;
            Onsite.Font = new Font("Calibri", 13F);
            Onsite.Location = new Point(6, 30);
            Onsite.Name = "Onsite";
            Onsite.Size = new Size(116, 36);
            Onsite.TabIndex = 17;
            Onsite.TabStop = true;
            Onsite.Text = "On Site";
            Onsite.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.ForeColor = Color.FromArgb(38, 50, 56);
            label8.Location = new Point(75, 1311);
            label8.Name = "label8";
            label8.Size = new Size(245, 38);
            label8.TabIndex = 16;
            label8.Text = "Appointment Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.ForeColor = Color.FromArgb(38, 50, 56);
            label9.Location = new Point(75, 1459);
            label9.Name = "label9";
            label9.Size = new Size(75, 38);
            label9.TabIndex = 17;
            label9.Text = "Date";
            // 
            // date
            // 
            date.CalendarForeColor = Color.FromArgb(38, 50, 56);
            date.Font = new Font("Segoe UI", 13F);
            date.Location = new Point(205, 1466);
            date.Name = "date";
            date.Size = new Size(444, 42);
            date.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.ForeColor = Color.FromArgb(38, 50, 56);
            label10.Location = new Point(75, 1530);
            label10.Name = "label10";
            label10.Size = new Size(78, 38);
            label10.TabIndex = 19;
            label10.Text = "Time";
            // 
            // apptime
            // 
            apptime.AutoCompleteMode = AutoCompleteMode.Suggest;
            apptime.Font = new Font("Segoe UI", 13F);
            apptime.FormattingEnabled = true;
            apptime.Items.AddRange(new object[] { "9:00 AM", "10:00 AM", "11:00 AM", "2:00 PM", "3:00 PM", "4:00 PM" });
            apptime.Location = new Point(217, 1530);
            apptime.Name = "apptime";
            apptime.Size = new Size(141, 44);
            apptime.TabIndex = 20;
            toolTip1.SetToolTip(apptime, "Enter Time");
            // 
            // fname
            // 
            fname.AnimateReadOnly = false;
            fname.BackgroundImageLayout = ImageLayout.None;
            fname.CharacterCasing = CharacterCasing.Normal;
            fname.Depth = 0;
            fname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fname.HideSelection = true;
            fname.LeadingIcon = null;
            fname.Location = new Point(204, 155);
            fname.MaxLength = 32767;
            fname.MouseState = MaterialSkin.MouseState.OUT;
            fname.Name = "fname";
            fname.PasswordChar = '\0';
            fname.PrefixSuffixText = null;
            fname.ReadOnly = false;
            fname.RightToLeft = RightToLeft.No;
            fname.SelectedText = "";
            fname.SelectionLength = 0;
            fname.SelectionStart = 0;
            fname.ShortcutsEnabled = true;
            fname.Size = new Size(320, 48);
            fname.TabIndex = 22;
            fname.TabStop = false;
            fname.TextAlign = HorizontalAlignment.Left;
            fname.TrailingIcon = null;
            fname.UseSystemPasswordChar = false;
            // 
            // lname
            // 
            lname.AnimateReadOnly = false;
            lname.BackgroundImageLayout = ImageLayout.None;
            lname.CharacterCasing = CharacterCasing.Normal;
            lname.Depth = 0;
            lname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lname.HideSelection = true;
            lname.LeadingIcon = null;
            lname.Location = new Point(204, 209);
            lname.MaxLength = 32767;
            lname.MouseState = MaterialSkin.MouseState.OUT;
            lname.Name = "lname";
            lname.PasswordChar = '\0';
            lname.PrefixSuffixText = null;
            lname.ReadOnly = false;
            lname.RightToLeft = RightToLeft.No;
            lname.SelectedText = "";
            lname.SelectionLength = 0;
            lname.SelectionStart = 0;
            lname.ShortcutsEnabled = true;
            lname.Size = new Size(320, 48);
            lname.TabIndex = 23;
            lname.TabStop = false;
            lname.TextAlign = HorizontalAlignment.Left;
            lname.TrailingIcon = null;
            lname.UseSystemPasswordChar = false;
            // 
            // Midinit
            // 
            Midinit.AnimateReadOnly = false;
            Midinit.BackgroundImageLayout = ImageLayout.None;
            Midinit.CharacterCasing = CharacterCasing.Upper;
            Midinit.Depth = 0;
            Midinit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Midinit.HideSelection = true;
            Midinit.LeadingIcon = null;
            Midinit.Location = new Point(206, 267);
            Midinit.MaxLength = 32767;
            Midinit.MouseState = MaterialSkin.MouseState.OUT;
            Midinit.Name = "Midinit";
            Midinit.PasswordChar = '\0';
            Midinit.PrefixSuffixText = null;
            Midinit.ReadOnly = false;
            Midinit.RightToLeft = RightToLeft.No;
            Midinit.SelectedText = "";
            Midinit.SelectionLength = 0;
            Midinit.SelectionStart = 0;
            Midinit.ShortcutsEnabled = true;
            Midinit.Size = new Size(83, 48);
            Midinit.TabIndex = 24;
            Midinit.TabStop = false;
            Midinit.TextAlign = HorizontalAlignment.Left;
            Midinit.TrailingIcon = null;
            Midinit.UseSystemPasswordChar = false;
            // 
            // age
            // 
            age.AnimateReadOnly = false;
            age.BackgroundImageLayout = ImageLayout.None;
            age.CharacterCasing = CharacterCasing.Normal;
            age.Depth = 0;
            age.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            age.HideSelection = true;
            age.LeadingIcon = null;
            age.Location = new Point(204, 321);
            age.MaxLength = 32767;
            age.MouseState = MaterialSkin.MouseState.OUT;
            age.Name = "age";
            age.PasswordChar = '\0';
            age.PrefixSuffixText = null;
            age.ReadOnly = false;
            age.RightToLeft = RightToLeft.No;
            age.SelectedText = "";
            age.SelectionLength = 0;
            age.SelectionStart = 0;
            age.ShortcutsEnabled = true;
            age.Size = new Size(83, 48);
            age.TabIndex = 25;
            age.TabStop = false;
            age.TextAlign = HorizontalAlignment.Left;
            age.TrailingIcon = null;
            age.UseSystemPasswordChar = false;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.FromArgb(130, 194, 227);
            Addbtn.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addbtn.Location = new Point(837, 1381);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(364, 105);
            Addbtn.TabIndex = 28;
            Addbtn.Text = "Add Appointment";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += createbtn_Click;
            // 
            // refresh
            // 
            refresh.BackColor = Color.FromArgb(249, 249, 249);
            refresh.FlatAppearance.BorderSize = 0;
            refresh.FlatStyle = FlatStyle.Flat;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(763, 470);
            refresh.Name = "refresh";
            refresh.Size = new Size(66, 62);
            refresh.TabIndex = 29;
            refresh.UseVisualStyleBackColor = false;
            refresh.Click += refresh_Click;
            // 
            // coursecombo
            // 
            coursecombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            coursecombo.Font = new Font("Segoe UI", 13F);
            coursecombo.FormattingEnabled = true;
            coursecombo.Items.AddRange(new object[] { "BSCpE", "BSCS", "BSArch", "BSChe", "BSCE", "BSEE", "BSECE", "BSIE", "BSME", "BSMinE" });
            coursecombo.Location = new Point(206, 95);
            coursecombo.Name = "coursecombo";
            coursecombo.Size = new Size(157, 44);
            coursecombo.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.ForeColor = Color.FromArgb(38, 50, 56);
            label11.Location = new Point(39, 96);
            label11.Name = "label11";
            label11.Size = new Size(103, 38);
            label11.TabIndex = 30;
            label11.Text = "Course";
            // 
            // Contact
            // 
            Contact.AnimateReadOnly = false;
            Contact.BackgroundImageLayout = ImageLayout.None;
            Contact.CharacterCasing = CharacterCasing.Normal;
            Contact.Depth = 0;
            Contact.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Contact.HideSelection = true;
            Contact.LeadingIcon = null;
            Contact.Location = new Point(204, 506);
            Contact.MaxLength = 32767;
            Contact.MouseState = MaterialSkin.MouseState.OUT;
            Contact.Name = "Contact";
            Contact.PasswordChar = '\0';
            Contact.PrefixSuffixText = null;
            Contact.ReadOnly = false;
            Contact.RightToLeft = RightToLeft.No;
            Contact.SelectedText = "";
            Contact.SelectionLength = 0;
            Contact.SelectionStart = 0;
            Contact.ShortcutsEnabled = true;
            Contact.Size = new Size(320, 48);
            Contact.TabIndex = 33;
            Contact.TabStop = false;
            Contact.TextAlign = HorizontalAlignment.Left;
            Contact.TrailingIcon = null;
            Contact.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F);
            label12.ForeColor = Color.FromArgb(38, 50, 56);
            label12.Location = new Point(19, 516);
            label12.Name = "label12";
            label12.Size = new Size(162, 38);
            label12.TabIndex = 32;
            label12.Text = "Contact No.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F);
            label13.ForeColor = Color.FromArgb(38, 50, 56);
            label13.Location = new Point(26, 452);
            label13.Name = "label13";
            label13.Size = new Size(116, 38);
            label13.TabIndex = 35;
            label13.Text = "Address";
            // 
            // addres
            // 
            addres.AnimateReadOnly = false;
            addres.BackgroundImageLayout = ImageLayout.None;
            addres.CharacterCasing = CharacterCasing.Normal;
            addres.Depth = 0;
            addres.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            addres.HideSelection = true;
            addres.LeadingIcon = null;
            addres.Location = new Point(204, 442);
            addres.MaxLength = 32767;
            addres.MouseState = MaterialSkin.MouseState.OUT;
            addres.Name = "addres";
            addres.PasswordChar = '\0';
            addres.PrefixSuffixText = null;
            addres.ReadOnly = false;
            addres.RightToLeft = RightToLeft.No;
            addres.SelectedText = "";
            addres.SelectionLength = 0;
            addres.SelectionStart = 0;
            addres.ShortcutsEnabled = true;
            addres.Size = new Size(320, 48);
            addres.TabIndex = 36;
            addres.TabStop = false;
            addres.TextAlign = HorizontalAlignment.Left;
            addres.TrailingIcon = null;
            addres.UseSystemPasswordChar = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(38, 50, 56);
            label14.Location = new Point(175, 586);
            label14.Name = "label14";
            label14.Size = new Size(473, 42);
            label14.TabIndex = 37;
            label14.Text = "Parent/Guardian Information";
            // 
            // parentlname
            // 
            parentlname.AnimateReadOnly = false;
            parentlname.BackgroundImageLayout = ImageLayout.None;
            parentlname.CharacterCasing = CharacterCasing.Normal;
            parentlname.Depth = 0;
            parentlname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            parentlname.HideSelection = true;
            parentlname.LeadingIcon = null;
            parentlname.Location = new Point(184, 722);
            parentlname.MaxLength = 32767;
            parentlname.MouseState = MaterialSkin.MouseState.OUT;
            parentlname.Name = "parentlname";
            parentlname.PasswordChar = '\0';
            parentlname.PrefixSuffixText = null;
            parentlname.ReadOnly = false;
            parentlname.RightToLeft = RightToLeft.No;
            parentlname.SelectedText = "";
            parentlname.SelectionLength = 0;
            parentlname.SelectionStart = 0;
            parentlname.ShortcutsEnabled = true;
            parentlname.Size = new Size(320, 48);
            parentlname.TabIndex = 41;
            parentlname.TabStop = false;
            parentlname.TextAlign = HorizontalAlignment.Left;
            parentlname.TrailingIcon = null;
            parentlname.UseSystemPasswordChar = false;
            // 
            // parentfname
            // 
            parentfname.AnimateReadOnly = false;
            parentfname.BackgroundImageLayout = ImageLayout.None;
            parentfname.CharacterCasing = CharacterCasing.Normal;
            parentfname.Depth = 0;
            parentfname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            parentfname.HideSelection = true;
            parentfname.LeadingIcon = null;
            parentfname.Location = new Point(184, 668);
            parentfname.MaxLength = 32767;
            parentfname.MouseState = MaterialSkin.MouseState.OUT;
            parentfname.Name = "parentfname";
            parentfname.PasswordChar = '\0';
            parentfname.PrefixSuffixText = null;
            parentfname.ReadOnly = false;
            parentfname.RightToLeft = RightToLeft.No;
            parentfname.SelectedText = "";
            parentfname.SelectionLength = 0;
            parentfname.SelectionStart = 0;
            parentfname.ShortcutsEnabled = true;
            parentfname.Size = new Size(320, 48);
            parentfname.TabIndex = 40;
            parentfname.TabStop = false;
            parentfname.TextAlign = HorizontalAlignment.Left;
            parentfname.TrailingIcon = null;
            parentfname.UseSystemPasswordChar = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F);
            label15.ForeColor = Color.FromArgb(38, 50, 56);
            label15.Location = new Point(19, 722);
            label15.Name = "label15";
            label15.Size = new Size(142, 38);
            label15.TabIndex = 39;
            label15.Text = "Last name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F);
            label16.ForeColor = Color.FromArgb(38, 50, 56);
            label16.Location = new Point(19, 668);
            label16.Name = "label16";
            label16.Size = new Size(146, 38);
            label16.TabIndex = 38;
            label16.Text = "First name";
            // 
            // parentcontact
            // 
            parentcontact.AnimateReadOnly = false;
            parentcontact.BackgroundImageLayout = ImageLayout.None;
            parentcontact.CharacterCasing = CharacterCasing.Normal;
            parentcontact.Depth = 0;
            parentcontact.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            parentcontact.HideSelection = true;
            parentcontact.LeadingIcon = null;
            parentcontact.Location = new Point(828, 668);
            parentcontact.MaxLength = 32767;
            parentcontact.MouseState = MaterialSkin.MouseState.OUT;
            parentcontact.Name = "parentcontact";
            parentcontact.PasswordChar = '\0';
            parentcontact.PrefixSuffixText = null;
            parentcontact.ReadOnly = false;
            parentcontact.RightToLeft = RightToLeft.No;
            parentcontact.SelectedText = "";
            parentcontact.SelectionLength = 0;
            parentcontact.SelectionStart = 0;
            parentcontact.ShortcutsEnabled = true;
            parentcontact.Size = new Size(320, 48);
            parentcontact.TabIndex = 45;
            parentcontact.TabStop = false;
            parentcontact.TextAlign = HorizontalAlignment.Left;
            parentcontact.TrailingIcon = null;
            parentcontact.UseSystemPasswordChar = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F);
            label17.ForeColor = Color.FromArgb(38, 50, 56);
            label17.Location = new Point(643, 732);
            label17.Name = "label17";
            label17.Size = new Size(116, 38);
            label17.TabIndex = 44;
            label17.Text = "Address";
            // 
            // parentaddress
            // 
            parentaddress.AnimateReadOnly = false;
            parentaddress.BackgroundImageLayout = ImageLayout.None;
            parentaddress.CharacterCasing = CharacterCasing.Normal;
            parentaddress.Depth = 0;
            parentaddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            parentaddress.HideSelection = true;
            parentaddress.LeadingIcon = null;
            parentaddress.Location = new Point(828, 732);
            parentaddress.MaxLength = 32767;
            parentaddress.MouseState = MaterialSkin.MouseState.OUT;
            parentaddress.Name = "parentaddress";
            parentaddress.PasswordChar = '\0';
            parentaddress.PrefixSuffixText = null;
            parentaddress.ReadOnly = false;
            parentaddress.RightToLeft = RightToLeft.No;
            parentaddress.SelectedText = "";
            parentaddress.SelectionLength = 0;
            parentaddress.SelectionStart = 0;
            parentaddress.ShortcutsEnabled = true;
            parentaddress.Size = new Size(320, 48);
            parentaddress.TabIndex = 43;
            parentaddress.TabStop = false;
            parentaddress.TextAlign = HorizontalAlignment.Left;
            parentaddress.TrailingIcon = null;
            parentaddress.UseSystemPasswordChar = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F);
            label18.ForeColor = Color.FromArgb(38, 50, 56);
            label18.Location = new Point(646, 668);
            label18.Name = "label18";
            label18.Size = new Size(162, 38);
            label18.TabIndex = 42;
            label18.Text = "Contact No.";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(38, 50, 56);
            label19.Location = new Point(175, 834);
            label19.Name = "label19";
            label19.Size = new Size(393, 42);
            label19.TabIndex = 47;
            label19.Text = "Reason for Appointment";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F);
            label20.ForeColor = Color.FromArgb(38, 50, 56);
            label20.Location = new Point(0, 895);
            label20.Name = "label20";
            label20.Size = new Size(859, 38);
            label20.TabIndex = 49;
            label20.Text = "Have you been in contact with a COVID-19 positive person recently?";
            // 
            // covidgroup
            // 
            covidgroup.Controls.Add(nocovid);
            covidgroup.Controls.Add(yescovid);
            covidgroup.Location = new Point(877, 873);
            covidgroup.Name = "covidgroup";
            covidgroup.Size = new Size(215, 95);
            covidgroup.TabIndex = 48;
            covidgroup.TabStop = false;
            covidgroup.Enter += groupBox1_Enter;
            // 
            // nocovid
            // 
            nocovid.AutoSize = true;
            nocovid.Font = new Font("Calibri", 13F);
            nocovid.Location = new Point(122, 33);
            nocovid.Name = "nocovid";
            nocovid.Size = new Size(70, 36);
            nocovid.TabIndex = 18;
            nocovid.TabStop = true;
            nocovid.Text = "No";
            nocovid.UseVisualStyleBackColor = true;
            // 
            // yescovid
            // 
            yescovid.AutoSize = true;
            yescovid.Font = new Font("Calibri", 13F);
            yescovid.Location = new Point(6, 30);
            yescovid.Name = "yescovid";
            yescovid.Size = new Size(73, 36);
            yescovid.TabIndex = 17;
            yescovid.TabStop = true;
            yescovid.Text = "Yes";
            yescovid.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F);
            label21.ForeColor = Color.FromArgb(38, 50, 56);
            label21.Location = new Point(3, 1057);
            label21.Name = "label21";
            label21.Size = new Size(327, 38);
            label21.TabIndex = 50;
            label21.Text = "Explain your Symptomps:";
            // 
            // symptoms
            // 
            symptoms.Location = new Point(341, 998);
            symptoms.Multiline = true;
            symptoms.Name = "symptoms";
            symptoms.Size = new Size(598, 189);
            symptoms.TabIndex = 51;
            // 
            // UserControlAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(249, 249, 249);
            Controls.Add(symptoms);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(covidgroup);
            Controls.Add(label19);
            Controls.Add(parentcontact);
            Controls.Add(label17);
            Controls.Add(parentaddress);
            Controls.Add(label18);
            Controls.Add(parentlname);
            Controls.Add(parentfname);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(addres);
            Controls.Add(label13);
            Controls.Add(Contact);
            Controls.Add(label12);
            Controls.Add(coursecombo);
            Controls.Add(label11);
            Controls.Add(refresh);
            Controls.Add(Addbtn);
            Controls.Add(age);
            Controls.Add(Midinit);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(apptime);
            Controls.Add(label10);
            Controls.Add(date);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Apptype);
            Controls.Add(label7);
            Controls.Add(Gender);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvappoint);
            Name = "UserControlAdd";
            Size = new Size(1409, 839);
            Load += UserControlAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dgvappoint).EndInit();
            Apptype.ResumeLayout(false);
            Apptype.PerformLayout();
            covidgroup.ResumeLayout(false);
            covidgroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvappoint;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox Gender;
        private Label label7;
        private GroupBox Apptype;
        private RadioButton Virtual;
        private RadioButton Onsite;
        private Label label8;
        private Label label9;
        private DateTimePicker date;
        private Label label10;
        private ComboBox apptime;
        private ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialTextBox2 fname;
        private MaterialSkin.Controls.MaterialTextBox2 lname;
        private MaterialSkin.Controls.MaterialTextBox2 Midinit;
        private MaterialSkin.Controls.MaterialTextBox2 age;
        private Button Addbtn;
        private circlebutton refresh;
        private ComboBox coursecombo;
        private Label label11;
        private MaterialSkin.Controls.MaterialTextBox2 Contact;
        private Label label12;
        private Label label13;
        private MaterialSkin.Controls.MaterialTextBox2 addres;
        private Label label14;
        private MaterialSkin.Controls.MaterialTextBox2 parentlname;
        private MaterialSkin.Controls.MaterialTextBox2 parentfname;
        private Label label15;
        private Label label16;
        private MaterialSkin.Controls.MaterialTextBox2 parentcontact;
        private Label label17;
        private MaterialSkin.Controls.MaterialTextBox2 parentaddress;
        private Label label18;
        private Label label19;
        private Label label20;
        private GroupBox covidgroup;
        private RadioButton nocovid;
        private RadioButton yescovid;
        private Label label21;
        private TextBox symptoms;
    }
}
