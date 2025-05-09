namespace Schedully.Controls
{
    partial class UserControlUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUpdate));
            dgvupdate = new DataGridView();
            label2 = new Label();
            Fname = new TextBox();
            Lname = new TextBox();
            age = new TextBox();
            Mid = new TextBox();
            Gender = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Apptype = new GroupBox();
            Virtual = new RadioButton();
            Onsite = new RadioButton();
            date = new DateTimePicker();
            apptime = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            updatebtn = new Button();
            clientsearch = new TextBox();
            label1 = new Label();
            checkbtn = new circlebutton();
            refresh = new circlebutton();
            label13 = new Label();
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
            address = new TextBox();
            contact = new TextBox();
            label22 = new Label();
            coursecombo = new ComboBox();
            clientid = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)dgvupdate).BeginInit();
            Apptype.SuspendLayout();
            covidgroup.SuspendLayout();
            SuspendLayout();
            // 
            // dgvupdate
            // 
            dgvupdate.BackgroundColor = Color.Beige;
            dgvupdate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvupdate.Location = new Point(733, -1);
            dgvupdate.Name = "dgvupdate";
            dgvupdate.RowHeadersWidth = 62;
            dgvupdate.Size = new Size(702, 440);
            dgvupdate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20F);
            label2.ForeColor = Color.FromArgb(38, 50, 56);
            label2.Location = new Point(125, 104);
            label2.Name = "label2";
            label2.Size = new Size(336, 47);
            label2.TabIndex = 10;
            label2.Text = "Client Information";
            // 
            // Fname
            // 
            Fname.BackColor = Color.Cornsilk;
            Fname.Font = new Font("Segoe UI", 13F);
            Fname.Location = new Point(229, 172);
            Fname.Name = "Fname";
            Fname.Size = new Size(309, 42);
            Fname.TabIndex = 11;
            // 
            // Lname
            // 
            Lname.BackColor = Color.Cornsilk;
            Lname.Font = new Font("Segoe UI", 13F);
            Lname.Location = new Point(229, 241);
            Lname.Name = "Lname";
            Lname.Size = new Size(309, 42);
            Lname.TabIndex = 12;
            // 
            // age
            // 
            age.BackColor = Color.Cornsilk;
            age.Font = new Font("Segoe UI", 13F);
            age.Location = new Point(254, 352);
            age.Name = "age";
            age.Size = new Size(44, 42);
            age.TabIndex = 13;
            // 
            // Mid
            // 
            Mid.BackColor = Color.Cornsilk;
            Mid.CharacterCasing = CharacterCasing.Upper;
            Mid.Font = new Font("Segoe UI", 13F);
            Mid.Location = new Point(254, 303);
            Mid.Name = "Mid";
            Mid.Size = new Size(44, 42);
            Mid.TabIndex = 14;
            // 
            // Gender
            // 
            Gender.AutoCompleteMode = AutoCompleteMode.Suggest;
            Gender.Font = new Font("Segoe UI", 13F);
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            Gender.Location = new Point(229, 406);
            Gender.Name = "Gender";
            Gender.Size = new Size(157, 44);
            Gender.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(38, 50, 56);
            label3.Location = new Point(52, 172);
            label3.Name = "label3";
            label3.Size = new Size(146, 38);
            label3.TabIndex = 16;
            label3.Text = "First name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(38, 50, 56);
            label4.Location = new Point(52, 234);
            label4.Name = "label4";
            label4.Size = new Size(142, 38);
            label4.TabIndex = 17;
            label4.Text = "Last name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.FromArgb(38, 50, 56);
            label5.Location = new Point(52, 295);
            label5.Name = "label5";
            label5.Size = new Size(178, 38);
            label5.TabIndex = 18;
            label5.Text = "Middle Initial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.FromArgb(38, 50, 56);
            label6.Location = new Point(61, 352);
            label6.Name = "label6";
            label6.Size = new Size(66, 38);
            label6.TabIndex = 19;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.FromArgb(38, 50, 56);
            label7.Location = new Point(52, 406);
            label7.Name = "label7";
            label7.Size = new Size(108, 38);
            label7.TabIndex = 20;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(38, 50, 56);
            label8.Location = new Point(254, 1214);
            label8.Name = "label8";
            label8.Size = new Size(336, 42);
            label8.TabIndex = 21;
            label8.Text = "Appointment Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.ForeColor = Color.FromArgb(38, 50, 56);
            label9.Location = new Point(31, 1329);
            label9.Name = "label9";
            label9.Size = new Size(245, 38);
            label9.TabIndex = 22;
            label9.Text = "Appointment Type";
            // 
            // Apptype
            // 
            Apptype.Controls.Add(Virtual);
            Apptype.Controls.Add(Onsite);
            Apptype.Location = new Point(282, 1304);
            Apptype.Name = "Apptype";
            Apptype.Size = new Size(269, 85);
            Apptype.TabIndex = 23;
            Apptype.TabStop = false;
            // 
            // Virtual
            // 
            Virtual.AutoSize = true;
            Virtual.Font = new Font("Calibri", 13F);
            Virtual.Location = new Point(130, 30);
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
            // date
            // 
            date.Font = new Font("Segoe UI", 13F);
            date.Location = new Point(316, 1414);
            date.Name = "date";
            date.Size = new Size(434, 42);
            date.TabIndex = 19;
            // 
            // apptime
            // 
            apptime.AutoCompleteMode = AutoCompleteMode.Suggest;
            apptime.Font = new Font("Segoe UI", 13F);
            apptime.FormattingEnabled = true;
            apptime.Items.AddRange(new object[] { "9:00 AM", "10:00 AM", "11:00 AM", "2:00 PM", "3:00 PM", "4:00 PM" });
            apptime.Location = new Point(316, 1483);
            apptime.Name = "apptime";
            apptime.Size = new Size(168, 44);
            apptime.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.ForeColor = Color.FromArgb(38, 50, 56);
            label10.Location = new Point(151, 1407);
            label10.Name = "label10";
            label10.Size = new Size(75, 38);
            label10.TabIndex = 25;
            label10.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.ForeColor = Color.FromArgb(38, 50, 56);
            label11.Location = new Point(130, 1483);
            label11.Name = "label11";
            label11.Size = new Size(78, 38);
            label11.TabIndex = 26;
            label11.Text = "Time";
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.FromArgb(130, 194, 227);
            updatebtn.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(916, 1359);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(364, 105);
            updatebtn.TabIndex = 27;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // clientsearch
            // 
            clientsearch.Font = new Font("Segoe UI", 12F);
            clientsearch.Location = new Point(254, 25);
            clientsearch.Name = "clientsearch";
            clientsearch.Size = new Size(327, 39);
            clientsearch.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(38, 50, 56);
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 8;
            label1.Text = "Enter Client Name";
            // 
            // checkbtn
            // 
            checkbtn.BackColor = Color.FromArgb(249, 249, 249);
            checkbtn.FlatAppearance.BorderSize = 0;
            checkbtn.FlatStyle = FlatStyle.Flat;
            checkbtn.Image = (Image)resources.GetObject("checkbtn.Image");
            checkbtn.Location = new Point(638, 15);
            checkbtn.Name = "checkbtn";
            checkbtn.Size = new Size(66, 62);
            checkbtn.TabIndex = 28;
            checkbtn.UseVisualStyleBackColor = false;
            checkbtn.Click += checkbtn_Click;
            // 
            // refresh
            // 
            refresh.BackColor = Color.FromArgb(249, 249, 249);
            refresh.FlatAppearance.BorderSize = 0;
            refresh.FlatStyle = FlatStyle.Flat;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(733, 445);
            refresh.Name = "refresh";
            refresh.Size = new Size(66, 62);
            refresh.TabIndex = 30;
            refresh.UseVisualStyleBackColor = false;
            refresh.Click += refresh_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F);
            label13.ForeColor = Color.FromArgb(38, 50, 56);
            label13.Location = new Point(52, 483);
            label13.Name = "label13";
            label13.Size = new Size(116, 38);
            label13.TabIndex = 39;
            label13.Text = "Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F);
            label12.ForeColor = Color.FromArgb(38, 50, 56);
            label12.Location = new Point(45, 547);
            label12.Name = "label12";
            label12.Size = new Size(162, 38);
            label12.TabIndex = 37;
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
            parentcontact.Location = new Point(843, 690);
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
            label17.Location = new Point(658, 754);
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
            parentaddress.Location = new Point(843, 754);
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
            label18.Location = new Point(661, 690);
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
            parentlname.Location = new Point(199, 744);
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
            parentfname.Location = new Point(199, 690);
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
            label15.Location = new Point(34, 744);
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
            label16.Location = new Point(34, 690);
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
            label14.Location = new Point(190, 608);
            label14.Name = "label14";
            label14.Size = new Size(473, 42);
            label14.TabIndex = 46;
            label14.Text = "Parent/Guardian Information";
            // 
            // symptoms
            // 
            symptoms.Location = new Point(363, 998);
            symptoms.Multiline = true;
            symptoms.Name = "symptoms";
            symptoms.Size = new Size(598, 189);
            symptoms.TabIndex = 59;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F);
            label21.ForeColor = Color.FromArgb(38, 50, 56);
            label21.Location = new Point(25, 1057);
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
            label20.Location = new Point(22, 895);
            label20.Name = "label20";
            label20.Size = new Size(859, 38);
            label20.TabIndex = 57;
            label20.Text = "Have you been in contact with a COVID-19 positive person recently?";
            // 
            // covidgroup
            // 
            covidgroup.Controls.Add(nocovid);
            covidgroup.Controls.Add(yescovid);
            covidgroup.Location = new Point(899, 873);
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
            label19.Location = new Point(197, 834);
            label19.Name = "label19";
            label19.Size = new Size(393, 42);
            label19.TabIndex = 55;
            label19.Text = "Reason for Appointment";
            // 
            // address
            // 
            address.BackColor = Color.Cornsilk;
            address.Font = new Font("Segoe UI", 13F);
            address.Location = new Point(229, 483);
            address.Name = "address";
            address.Size = new Size(309, 42);
            address.TabIndex = 60;
            // 
            // contact
            // 
            contact.BackColor = Color.Cornsilk;
            contact.Font = new Font("Segoe UI", 13F);
            contact.Location = new Point(229, 547);
            contact.Name = "contact";
            contact.Size = new Size(309, 42);
            contact.TabIndex = 61;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 13F);
            label22.ForeColor = Color.FromArgb(38, 50, 56);
            label22.Location = new Point(412, 414);
            label22.Name = "label22";
            label22.Size = new Size(95, 36);
            label22.TabIndex = 63;
            label22.Text = "Course";
            // 
            // coursecombo
            // 
            coursecombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            coursecombo.Font = new Font("Segoe UI", 14F);
            coursecombo.FormattingEnabled = true;
            coursecombo.Items.AddRange(new object[] { "BSCpE", "BSCS", "BSArch", "BSChe", "BSCE", "BSEE", "BSECE", "BSIE", "BSME", "BSMinE" });
            coursecombo.Location = new Point(559, 409);
            coursecombo.Name = "coursecombo";
            coursecombo.Size = new Size(157, 46);
            coursecombo.TabIndex = 62;
            // 
            // clientid
            // 
            clientid.AnimateReadOnly = false;
            clientid.BackgroundImageLayout = ImageLayout.None;
            clientid.CharacterCasing = CharacterCasing.Normal;
            clientid.Depth = 0;
            clientid.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            clientid.HideSelection = true;
            clientid.LeadingIcon = null;
            clientid.Location = new Point(15, 103);
            clientid.MaxLength = 32767;
            clientid.MouseState = MaterialSkin.MouseState.OUT;
            clientid.Name = "clientid";
            clientid.PasswordChar = '\0';
            clientid.PrefixSuffixText = null;
            clientid.ReadOnly = false;
            clientid.RightToLeft = RightToLeft.No;
            clientid.SelectedText = "";
            clientid.SelectionLength = 0;
            clientid.SelectionStart = 0;
            clientid.ShortcutsEnabled = true;
            clientid.Size = new Size(64, 48);
            clientid.TabIndex = 64;
            clientid.TabStop = false;
            clientid.TextAlign = HorizontalAlignment.Left;
            clientid.TrailingIcon = null;
            clientid.UseSystemPasswordChar = false;
            // 
            // UserControlUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(249, 249, 249);
            Controls.Add(clientid);
            Controls.Add(label22);
            Controls.Add(coursecombo);
            Controls.Add(contact);
            Controls.Add(address);
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
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(refresh);
            Controls.Add(checkbtn);
            Controls.Add(updatebtn);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(apptime);
            Controls.Add(date);
            Controls.Add(Apptype);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Gender);
            Controls.Add(Mid);
            Controls.Add(age);
            Controls.Add(Lname);
            Controls.Add(Fname);
            Controls.Add(label2);
            Controls.Add(clientsearch);
            Controls.Add(label1);
            Controls.Add(dgvupdate);
            Name = "UserControlUpdate";
            Size = new Size(1409, 839);
            Load += UserControlUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dgvupdate).EndInit();
            Apptype.ResumeLayout(false);
            Apptype.PerformLayout();
            covidgroup.ResumeLayout(false);
            covidgroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvupdate;
        private Label label2;
        private TextBox Fname;
        private TextBox Lname;
        private TextBox age;
        private TextBox Mid;
        private ComboBox Gender;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox Apptype;
        private RadioButton Virtual;
        private RadioButton Onsite;
        private DateTimePicker date;
        private ComboBox apptime;
        private Label label10;
        private Label label11;
        private Button updatebtn;
        private TextBox clientsearch;
        private Label label1;
        private circlebutton checkbtn;
        private circlebutton refresh;
        private Label label13;
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
        private TextBox address;
        private TextBox contact;
        private Label label22;
        private ComboBox coursecombo;
        private MaterialSkin.Controls.MaterialTextBox2 clientid;
    }
}
