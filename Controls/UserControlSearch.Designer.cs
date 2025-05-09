namespace Schedully.Controls
{
    partial class UserControlSearch
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
            label1 = new Label();
            label2 = new Label();
            Gender = new ComboBox();
            label8 = new Label();
            Apptype = new GroupBox();
            Virtual = new RadioButton();
            Onsite = new RadioButton();
            label9 = new Label();
            date = new DateTimePicker();
            apptime = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            fname = new MaterialSkin.Controls.MaterialTextBox();
            lname = new MaterialSkin.Controls.MaterialTextBox();
            Midinit = new MaterialSkin.Controls.MaterialTextBox();
            age = new MaterialSkin.Controls.MaterialTextBox();
            addres = new MaterialSkin.Controls.MaterialTextBox2();
            label13 = new Label();
            Contact = new MaterialSkin.Controls.MaterialTextBox2();
            label12 = new Label();
            parentcontact = new MaterialSkin.Controls.MaterialTextBox2();
            label17 = new Label();
            parentaddress = new MaterialSkin.Controls.MaterialTextBox2();
            label18 = new Label();
            parentlname = new MaterialSkin.Controls.MaterialTextBox2();
            parentfname = new MaterialSkin.Controls.MaterialTextBox2();
            label15 = new Label();
            label16 = new Label();
            label14 = new Label();
            symptoms = new TextBox();
            label21 = new Label();
            label20 = new Label();
            covidgroup = new GroupBox();
            nocovid = new RadioButton();
            yescovid = new RadioButton();
            label19 = new Label();
            label22 = new Label();
            coursecombo = new ComboBox();
            Apptype.SuspendLayout();
            covidgroup.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 50, 56);
            label1.Location = new Point(581, 8);
            label1.Name = "label1";
            label1.Size = new Size(277, 60);
            label1.TabIndex = 9;
            label1.Text = "Client Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(38, 50, 56);
            label2.Location = new Point(65, 26);
            label2.Name = "label2";
            label2.Size = new Size(302, 42);
            label2.TabIndex = 11;
            label2.Text = "Client Information";
            // 
            // Gender
            // 
            Gender.AutoCompleteMode = AutoCompleteMode.Suggest;
            Gender.Font = new Font("Segoe UI", 14F);
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            Gender.Location = new Point(174, 484);
            Gender.Name = "Gender";
            Gender.Size = new Size(157, 46);
            Gender.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(38, 50, 56);
            label8.Location = new Point(930, 180);
            label8.Name = "label8";
            label8.Size = new Size(336, 42);
            label8.TabIndex = 22;
            label8.Text = "Appointment Details";
            // 
            // Apptype
            // 
            Apptype.Controls.Add(Virtual);
            Apptype.Controls.Add(Onsite);
            Apptype.Location = new Point(914, 234);
            Apptype.Name = "Apptype";
            Apptype.Size = new Size(398, 118);
            Apptype.TabIndex = 24;
            Apptype.TabStop = false;
            // 
            // Virtual
            // 
            Virtual.AutoSize = true;
            Virtual.Font = new Font("Calibri", 20F);
            Virtual.Location = new Point(213, 37);
            Virtual.Name = "Virtual";
            Virtual.Size = new Size(155, 53);
            Virtual.TabIndex = 18;
            Virtual.TabStop = true;
            Virtual.Text = "Virtual";
            Virtual.UseVisualStyleBackColor = true;
            // 
            // Onsite
            // 
            Onsite.AutoSize = true;
            Onsite.Font = new Font("Calibri", 20F);
            Onsite.Location = new Point(28, 44);
            Onsite.Name = "Onsite";
            Onsite.Size = new Size(163, 53);
            Onsite.TabIndex = 17;
            Onsite.TabStop = true;
            Onsite.Text = "On Site";
            Onsite.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.ForeColor = Color.FromArgb(38, 50, 56);
            label9.Location = new Point(599, 275);
            label9.Name = "label9";
            label9.Size = new Size(284, 45);
            label9.TabIndex = 23;
            label9.Text = "Appointment Type";
            // 
            // date
            // 
            date.Font = new Font("Segoe UI", 15F);
            date.Location = new Point(876, 376);
            date.Name = "date";
            date.Size = new Size(505, 47);
            date.TabIndex = 25;
            // 
            // apptime
            // 
            apptime.AutoCompleteMode = AutoCompleteMode.Suggest;
            apptime.Font = new Font("Segoe UI", 13F);
            apptime.FormattingEnabled = true;
            apptime.Items.AddRange(new object[] { "9:00 AM", "10:00 AM", "11:00 AM", "2:00 PM", "3:00 PM", "4:00 PM" });
            apptime.Location = new Point(876, 474);
            apptime.Name = "apptime";
            apptime.Size = new Size(113, 44);
            apptime.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F);
            label10.ForeColor = Color.FromArgb(38, 50, 56);
            label10.Location = new Point(771, 376);
            label10.Name = "label10";
            label10.Size = new Size(86, 45);
            label10.TabIndex = 27;
            label10.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F);
            label11.ForeColor = Color.FromArgb(38, 50, 56);
            label11.Location = new Point(766, 470);
            label11.Name = "label11";
            label11.Size = new Size(90, 45);
            label11.TabIndex = 28;
            label11.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.FromArgb(38, 50, 56);
            label3.Location = new Point(24, 180);
            label3.Name = "label3";
            label3.Size = new Size(134, 36);
            label3.TabIndex = 29;
            label3.Text = "First name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.FromArgb(38, 50, 56);
            label4.Location = new Point(27, 254);
            label4.Name = "label4";
            label4.Size = new Size(131, 36);
            label4.TabIndex = 30;
            label4.Text = "Last name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = Color.FromArgb(38, 50, 56);
            label5.Location = new Point(13, 325);
            label5.Name = "label5";
            label5.Size = new Size(163, 36);
            label5.TabIndex = 31;
            label5.Text = "Middle Initial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = Color.FromArgb(38, 50, 56);
            label6.Location = new Point(57, 402);
            label6.Name = "label6";
            label6.Size = new Size(61, 36);
            label6.TabIndex = 32;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = Color.FromArgb(38, 50, 56);
            label7.Location = new Point(27, 484);
            label7.Name = "label7";
            label7.Size = new Size(100, 36);
            label7.TabIndex = 33;
            label7.Text = "Gender";
            // 
            // fname
            // 
            fname.AnimateReadOnly = false;
            fname.BorderStyle = BorderStyle.None;
            fname.Depth = 0;
            fname.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fname.LeadingIcon = null;
            fname.Location = new Point(174, 180);
            fname.MaxLength = 50;
            fname.MouseState = MaterialSkin.MouseState.OUT;
            fname.Multiline = false;
            fname.Name = "fname";
            fname.ReadOnly = true;
            fname.Size = new Size(201, 50);
            fname.TabIndex = 34;
            fname.Text = "";
            fname.TrailingIcon = null;
            // 
            // lname
            // 
            lname.AnimateReadOnly = false;
            lname.BorderStyle = BorderStyle.None;
            lname.Depth = 0;
            lname.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lname.LeadingIcon = null;
            lname.Location = new Point(174, 254);
            lname.MaxLength = 50;
            lname.MouseState = MaterialSkin.MouseState.OUT;
            lname.Multiline = false;
            lname.Name = "lname";
            lname.ReadOnly = true;
            lname.Size = new Size(201, 50);
            lname.TabIndex = 35;
            lname.Text = "";
            lname.TrailingIcon = null;
            // 
            // Midinit
            // 
            Midinit.AnimateReadOnly = false;
            Midinit.BorderStyle = BorderStyle.None;
            Midinit.Depth = 0;
            Midinit.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Midinit.LeadingIcon = null;
            Midinit.Location = new Point(174, 330);
            Midinit.MaxLength = 50;
            Midinit.MouseState = MaterialSkin.MouseState.OUT;
            Midinit.Multiline = false;
            Midinit.Name = "Midinit";
            Midinit.ReadOnly = true;
            Midinit.Size = new Size(70, 50);
            Midinit.TabIndex = 36;
            Midinit.Text = "";
            Midinit.TrailingIcon = null;
            // 
            // age
            // 
            age.AnimateReadOnly = false;
            age.BorderStyle = BorderStyle.None;
            age.Depth = 0;
            age.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            age.LeadingIcon = null;
            age.Location = new Point(174, 415);
            age.MaxLength = 50;
            age.MouseState = MaterialSkin.MouseState.OUT;
            age.Multiline = false;
            age.Name = "age";
            age.ReadOnly = true;
            age.Size = new Size(78, 50);
            age.TabIndex = 37;
            age.Text = "";
            age.TrailingIcon = null;
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
            addres.Location = new Point(174, 536);
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
            addres.TabIndex = 41;
            addres.TabStop = false;
            addres.TextAlign = HorizontalAlignment.Left;
            addres.TrailingIcon = null;
            addres.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F);
            label13.ForeColor = Color.FromArgb(38, 50, 56);
            label13.Location = new Point(12, 546);
            label13.Name = "label13";
            label13.Size = new Size(116, 38);
            label13.TabIndex = 40;
            label13.Text = "Address";
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
            Contact.Location = new Point(174, 600);
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
            Contact.TabIndex = 39;
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
            label12.Location = new Point(5, 610);
            label12.Name = "label12";
            label12.Size = new Size(162, 38);
            label12.TabIndex = 38;
            label12.Text = "Contact No.";
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
            parentcontact.Location = new Point(835, 685);
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
            parentcontact.TabIndex = 54;
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
            label17.Location = new Point(642, 831);
            label17.Name = "label17";
            label17.Size = new Size(116, 38);
            label17.TabIndex = 53;
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
            parentaddress.Location = new Point(835, 749);
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
            parentaddress.TabIndex = 52;
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
            label18.Location = new Point(645, 767);
            label18.Name = "label18";
            label18.Size = new Size(162, 38);
            label18.TabIndex = 51;
            label18.Text = "Contact No.";
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
            parentlname.Location = new Point(183, 821);
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
            parentlname.TabIndex = 50;
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
            parentfname.Location = new Point(183, 767);
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
            parentfname.TabIndex = 49;
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
            label15.Location = new Point(18, 821);
            label15.Name = "label15";
            label15.Size = new Size(142, 38);
            label15.TabIndex = 48;
            label15.Text = "Last name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F);
            label16.ForeColor = Color.FromArgb(38, 50, 56);
            label16.Location = new Point(18, 767);
            label16.Name = "label16";
            label16.Size = new Size(146, 38);
            label16.TabIndex = 47;
            label16.Text = "First name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(38, 50, 56);
            label14.Location = new Point(174, 685);
            label14.Name = "label14";
            label14.Size = new Size(473, 42);
            label14.TabIndex = 46;
            label14.Text = "Parent/Guardian Information";
            // 
            // symptoms
            // 
            symptoms.Location = new Point(344, 1063);
            symptoms.Multiline = true;
            symptoms.Name = "symptoms";
            symptoms.Size = new Size(598, 148);
            symptoms.TabIndex = 59;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F);
            label21.ForeColor = Color.FromArgb(38, 50, 56);
            label21.Location = new Point(10, 1064);
            label21.Name = "label21";
            label21.Size = new Size(327, 38);
            label21.TabIndex = 58;
            label21.Text = "Explain your Symptomps:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F);
            label20.ForeColor = Color.FromArgb(38, 50, 56);
            label20.Location = new Point(-1, 984);
            label20.Name = "label20";
            label20.Size = new Size(859, 38);
            label20.TabIndex = 57;
            label20.Text = "Have you been in contact with a COVID-19 positive person recently?";
            // 
            // covidgroup
            // 
            covidgroup.Controls.Add(nocovid);
            covidgroup.Controls.Add(yescovid);
            covidgroup.Location = new Point(884, 880);
            covidgroup.Name = "covidgroup";
            covidgroup.Size = new Size(215, 95);
            covidgroup.TabIndex = 56;
            covidgroup.TabStop = false;
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
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(38, 50, 56);
            label19.Location = new Point(174, 923);
            label19.Name = "label19";
            label19.Size = new Size(393, 42);
            label19.TabIndex = 55;
            label19.Text = "Reason for Appointment";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 13F);
            label22.ForeColor = Color.FromArgb(38, 50, 56);
            label22.Location = new Point(28, 126);
            label22.Name = "label22";
            label22.Size = new Size(95, 36);
            label22.TabIndex = 61;
            label22.Text = "Course";
            // 
            // coursecombo
            // 
            coursecombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            coursecombo.Font = new Font("Segoe UI", 14F);
            coursecombo.FormattingEnabled = true;
            coursecombo.Items.AddRange(new object[] { "BSCpE", "BSArch", "BSChe", "BSCE", "BSEE", "BSECE", "BSIE", "BSME", "BSMinE" });
            coursecombo.Location = new Point(175, 126);
            coursecombo.Name = "coursecombo";
            coursecombo.Size = new Size(157, 46);
            coursecombo.TabIndex = 60;
            // 
            // UserControlSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(249, 249, 249);
            Controls.Add(label22);
            Controls.Add(coursecombo);
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
            Controls.Add(age);
            Controls.Add(Midinit);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(apptime);
            Controls.Add(date);
            Controls.Add(label9);
            Controls.Add(Apptype);
            Controls.Add(label8);
            Controls.Add(Gender);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlSearch";
            Size = new Size(1435, 865);
            Load += UserControlSearch_Load;
            Apptype.ResumeLayout(false);
            Apptype.PerformLayout();
            covidgroup.ResumeLayout(false);
            covidgroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ComboBox Gender;
        private Label label8;
        private GroupBox Apptype;
        private RadioButton Virtual;
        private RadioButton Onsite;
        private Label label9;
        private DateTimePicker date;
        private ComboBox apptime;
        private Label label10;
        private Label label11;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaterialSkin.Controls.MaterialTextBox fname;
        private MaterialSkin.Controls.MaterialTextBox lname;
        private MaterialSkin.Controls.MaterialTextBox Midinit;
        private MaterialSkin.Controls.MaterialTextBox age;
        private MaterialSkin.Controls.MaterialTextBox2 addres;
        private Label label13;
        private MaterialSkin.Controls.MaterialTextBox2 Contact;
        private Label label12;
        private MaterialSkin.Controls.MaterialTextBox2 parentcontact;
        private Label label17;
        private MaterialSkin.Controls.MaterialTextBox2 parentaddress;
        private Label label18;
        private MaterialSkin.Controls.MaterialTextBox2 parentlname;
        private MaterialSkin.Controls.MaterialTextBox2 parentfname;
        private Label label15;
        private Label label16;
        private Label label14;
        private TextBox symptoms;
        private Label label21;
        private Label label20;
        private GroupBox covidgroup;
        private RadioButton nocovid;
        private RadioButton yescovid;
        private Label label19;
        private Label label22;
        private ComboBox coursecombo;
    }
}
