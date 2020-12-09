namespace PhoneNumbersDictionary
{
    partial class MainForm
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

            System.Drawing.Color label_forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202))))); 

            this.lbOrganizations = new System.Windows.Forms.ListBox();
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxOrgName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrgSearch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbxOrgLocation = new System.Windows.Forms.TextBox();
            this.tbLocationPart = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbLocationComplete = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbxOrgProfile = new System.Windows.Forms.TextBox();
            this.rbProfilePart = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbProfileComplete = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNamePart = new System.Windows.Forms.RadioButton();
            this.rbNameComplete = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPhoneSearch = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbPhoneOldNumbers = new System.Windows.Forms.CheckBox();
            this.txtbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbPhoneCompleteMatch = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtbxInfoData = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rbInfoDataComplete = new System.Windows.Forms.RadioButton();
            this.btnSearchByInfo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtbxInfoType = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbInoTypeComlete = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnSearchByFile = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtbxFileName = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rbFileComleteMatch = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOrganizations
            // 
            this.lbOrganizations.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbOrganizations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOrganizations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOrganizations.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrganizations.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbOrganizations.FormattingEnabled = true;
            this.lbOrganizations.ItemHeight = 17;
            this.lbOrganizations.Location = new System.Drawing.Point(13, 13);
            this.lbOrganizations.Name = "lbOrganizations";
            this.lbOrganizations.Size = new System.Drawing.Size(337, 444);
            this.lbOrganizations.TabIndex = 0;
            this.lbOrganizations.DoubleClick += new System.EventHandler(this.lbOrganizations_DoubleClick);
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.BackColor = System.Drawing.Color.Silver;
            this.btnAddOrganization.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganization.Location = new System.Drawing.Point(122, 529);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(201, 41);
            this.btnAddOrganization.TabIndex = 1;
            this.btnAddOrganization.Text = "AddOrganization";
            this.btnAddOrganization.UseVisualStyleBackColor = false;
            this.btnAddOrganization.Click += new System.EventHandler(this.btnAddOrganization_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = label_forecolor;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Organization Name";
            // 
            // txtbxOrgName
            // 
            this.txtbxOrgName.Location = new System.Drawing.Point(124, 30);
            this.txtbxOrgName.Name = "txtbxOrgName";
            this.txtbxOrgName.Size = new System.Drawing.Size(180, 20);
            this.txtbxOrgName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrgSearch);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(384, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 446);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnOrgSearch
            // 
            this.btnOrgSearch.Location = new System.Drawing.Point(178, 408);
            this.btnOrgSearch.Name = "btnOrgSearch";
            this.btnOrgSearch.Size = new System.Drawing.Size(118, 23);
            this.btnOrgSearch.TabIndex = 10;
            this.btnOrgSearch.Text = "Search";
            this.btnOrgSearch.UseVisualStyleBackColor = true;
            this.btnOrgSearch.Click += new System.EventHandler(this.btnOrgSearch_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtbxOrgLocation);
            this.groupBox4.Controls.Add(this.tbLocationPart);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.rbLocationComplete);
            this.groupBox4.Location = new System.Drawing.Point(6, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 105);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // txtbxOrgLocation
            // 
            this.txtbxOrgLocation.Location = new System.Drawing.Point(125, 30);
            this.txtbxOrgLocation.Name = "txtbxOrgLocation";
            this.txtbxOrgLocation.Size = new System.Drawing.Size(179, 20);
            this.txtbxOrgLocation.TabIndex = 3;
            // 
            // tbLocationPart
            // 
            this.tbLocationPart.AutoSize = true;
            this.tbLocationPart.Checked = true;
            this.tbLocationPart.Location = new System.Drawing.Point(172, 71);
            this.tbLocationPart.Name = "tbLocationPart";
            this.tbLocationPart.Size = new System.Drawing.Size(118, 17);
            this.tbLocationPart.TabIndex = 6;
            this.tbLocationPart.TabStop = true;
            this.tbLocationPart.Text = "Part of the Location";
            this.tbLocationPart.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Organization Location";
            // 
            // rbLocationComplete
            // 
            this.rbLocationComplete.AutoSize = true;
            this.rbLocationComplete.Location = new System.Drawing.Point(37, 71);
            this.rbLocationComplete.Name = "rbLocationComplete";
            this.rbLocationComplete.Size = new System.Drawing.Size(101, 17);
            this.rbLocationComplete.TabIndex = 5;
            this.rbLocationComplete.Text = "Complete match";
            this.rbLocationComplete.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbxOrgProfile);
            this.groupBox3.Controls.Add(this.rbProfilePart);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rbProfileComplete);
            this.groupBox3.Location = new System.Drawing.Point(6, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 105);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // txtbxOrgProfile
            // 
            this.txtbxOrgProfile.Location = new System.Drawing.Point(125, 30);
            this.txtbxOrgProfile.Name = "txtbxOrgProfile";
            this.txtbxOrgProfile.Size = new System.Drawing.Size(179, 20);
            this.txtbxOrgProfile.TabIndex = 3;
            // 
            // rbProfilePart
            // 
            this.rbProfilePart.AutoSize = true;
            this.rbProfilePart.Checked = true;
            this.rbProfilePart.ForeColor = label_forecolor;
            this.rbProfilePart.Location = new System.Drawing.Point(172, 71);
            this.rbProfilePart.Name = "rbProfilePart";
            this.rbProfilePart.Size = new System.Drawing.Size(106, 17);
            this.rbProfilePart.TabIndex = 6;
            this.rbProfilePart.TabStop = true;
            this.rbProfilePart.Text = "Part of the Profile";
            this.rbProfilePart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = label_forecolor;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Organization Profile";
            // 
            // rbProfileComplete
            // 
            this.rbProfileComplete.AutoSize = true;
            this.rbProfileComplete.ForeColor = label_forecolor;
            this.rbProfileComplete.Location = new System.Drawing.Point(37, 71);
            this.rbProfileComplete.Name = "rbProfileComplete";
            this.rbProfileComplete.Size = new System.Drawing.Size(101, 17);
            this.rbProfileComplete.TabIndex = 5;
            this.rbProfileComplete.Text = "Complete match";
            this.rbProfileComplete.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbxOrgName);
            this.groupBox2.Controls.Add(this.rbNamePart);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rbNameComplete);
            this.groupBox2.Location = new System.Drawing.Point(6, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 97);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rbNamePart
            // 
            this.rbNamePart.AutoSize = true;
            this.rbNamePart.Checked = true;
            this.rbNamePart.ForeColor = label_forecolor;
            this.rbNamePart.Location = new System.Drawing.Point(172, 71);
            this.rbNamePart.Name = "rbNamePart";
            this.rbNamePart.Size = new System.Drawing.Size(105, 17);
            this.rbNamePart.TabIndex = 6;
            this.rbNamePart.TabStop = true;
            this.rbNamePart.Text = "Part of the Name";
            this.rbNamePart.UseVisualStyleBackColor = true;
            // 
            // rbNameComplete
            // 
            this.rbNameComplete.AutoSize = true;
            this.rbNameComplete.ForeColor = label_forecolor;
            this.rbNameComplete.Location = new System.Drawing.Point(37, 71);
            this.rbNameComplete.Name = "rbNameComplete";
            this.rbNameComplete.Size = new System.Drawing.Size(101, 17);
            this.rbNameComplete.TabIndex = 5;
            this.rbNameComplete.Text = "Complete match";
            this.rbNameComplete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = label_forecolor;
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by Organization info";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(251, 465);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(99, 29);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPhoneSearch);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(732, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 213);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // btnPhoneSearch
            // 
            this.btnPhoneSearch.Location = new System.Drawing.Point(198, 184);
            this.btnPhoneSearch.Name = "btnPhoneSearch";
            this.btnPhoneSearch.Size = new System.Drawing.Size(118, 23);
            this.btnPhoneSearch.TabIndex = 11;
            this.btnPhoneSearch.Text = "Search";
            this.btnPhoneSearch.UseVisualStyleBackColor = true;
            this.btnPhoneSearch.Click += new System.EventHandler(this.btnPhoneSearch_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbPhoneOldNumbers);
            this.groupBox6.Controls.Add(this.txtbxPhoneNumber);
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.rbPhoneCompleteMatch);
            this.groupBox6.Location = new System.Drawing.Point(6, 55);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(310, 123);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // cbPhoneOldNumbers
            // 
            this.cbPhoneOldNumbers.AutoSize = true;
            this.cbPhoneOldNumbers.Location = new System.Drawing.Point(172, 100);
            this.cbPhoneOldNumbers.Name = "cbPhoneOldNumbers";
            this.cbPhoneOldNumbers.Size = new System.Drawing.Size(125, 17);
            this.cbPhoneOldNumbers.TabIndex = 7;
            this.cbPhoneOldNumbers.Text = "Include Old Numbers";
            this.cbPhoneOldNumbers.UseVisualStyleBackColor = true;
            // 
            // txtbxPhoneNumber
            // 
            this.txtbxPhoneNumber.Location = new System.Drawing.Point(124, 30);
            this.txtbxPhoneNumber.Name = "txtbxPhoneNumber";
            this.txtbxPhoneNumber.Size = new System.Drawing.Size(180, 20);
            this.txtbxPhoneNumber.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(172, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Part of the Number";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "PhoneNumber";
            // 
            // rbPhoneCompleteMatch
            // 
            this.rbPhoneCompleteMatch.AutoSize = true;
            this.rbPhoneCompleteMatch.Location = new System.Drawing.Point(37, 71);
            this.rbPhoneCompleteMatch.Name = "rbPhoneCompleteMatch";
            this.rbPhoneCompleteMatch.Size = new System.Drawing.Size(101, 17);
            this.rbPhoneCompleteMatch.TabIndex = 5;
            this.rbPhoneCompleteMatch.Text = "Complete match";
            this.rbPhoneCompleteMatch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search by phone number";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.btnSearchByInfo);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(1069, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(322, 304);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtbxInfoData);
            this.groupBox9.Controls.Add(this.radioButton4);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.rbInfoDataComplete);
            this.groupBox9.Location = new System.Drawing.Point(6, 160);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(310, 97);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            // 
            // txtbxInfoData
            // 
            this.txtbxInfoData.Location = new System.Drawing.Point(124, 30);
            this.txtbxInfoData.Name = "txtbxInfoData";
            this.txtbxInfoData.Size = new System.Drawing.Size(180, 20);
            this.txtbxInfoData.TabIndex = 3;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(172, 71);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(100, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Part of the Data";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Info Data";
            // 
            // rbInfoDataComplete
            // 
            this.rbInfoDataComplete.AutoSize = true;
            this.rbInfoDataComplete.Location = new System.Drawing.Point(37, 71);
            this.rbInfoDataComplete.Name = "rbInfoDataComplete";
            this.rbInfoDataComplete.Size = new System.Drawing.Size(101, 17);
            this.rbInfoDataComplete.TabIndex = 5;
            this.rbInfoDataComplete.Text = "Complete match";
            this.rbInfoDataComplete.UseVisualStyleBackColor = true;
            // 
            // btnSearchByInfo
            // 
            this.btnSearchByInfo.Location = new System.Drawing.Point(192, 275);
            this.btnSearchByInfo.Name = "btnSearchByInfo";
            this.btnSearchByInfo.Size = new System.Drawing.Size(118, 23);
            this.btnSearchByInfo.TabIndex = 14;
            this.btnSearchByInfo.Text = "Search";
            this.btnSearchByInfo.UseVisualStyleBackColor = true;
            this.btnSearchByInfo.Click += new System.EventHandler(this.btnSearchByInfo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Search by Additional Info";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtbxInfoType);
            this.groupBox8.Controls.Add(this.radioButton2);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.rbInoTypeComlete);
            this.groupBox8.Location = new System.Drawing.Point(6, 50);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(310, 97);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            // 
            // txtbxInfoType
            // 
            this.txtbxInfoType.Location = new System.Drawing.Point(124, 30);
            this.txtbxInfoType.Name = "txtbxInfoType";
            this.txtbxInfoType.Size = new System.Drawing.Size(180, 20);
            this.txtbxInfoType.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(172, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Part of the Type";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Info Type";
            // 
            // rbInoTypeComlete
            // 
            this.rbInoTypeComlete.AutoSize = true;
            this.rbInoTypeComlete.Location = new System.Drawing.Point(37, 71);
            this.rbInoTypeComlete.Name = "rbInoTypeComlete";
            this.rbInoTypeComlete.Size = new System.Drawing.Size(101, 17);
            this.rbInoTypeComlete.TabIndex = 5;
            this.rbInoTypeComlete.Text = "Complete match";
            this.rbInoTypeComlete.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnSearchByFile);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Location = new System.Drawing.Point(732, 246);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(322, 213);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            // 
            // btnSearchByFile
            // 
            this.btnSearchByFile.Location = new System.Drawing.Point(198, 184);
            this.btnSearchByFile.Name = "btnSearchByFile";
            this.btnSearchByFile.Size = new System.Drawing.Size(118, 23);
            this.btnSearchByFile.TabIndex = 11;
            this.btnSearchByFile.Text = "Search";
            this.btnSearchByFile.UseVisualStyleBackColor = true;
            this.btnSearchByFile.Click += new System.EventHandler(this.btnSearchByFile_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtbxFileName);
            this.groupBox11.Controls.Add(this.radioButton3);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.rbFileComleteMatch);
            this.groupBox11.Location = new System.Drawing.Point(6, 55);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(310, 123);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            // 
            // txtbxFileName
            // 
            this.txtbxFileName.Location = new System.Drawing.Point(124, 30);
            this.txtbxFileName.Name = "txtbxFileName";
            this.txtbxFileName.Size = new System.Drawing.Size(180, 20);
            this.txtbxFileName.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(172, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(105, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Part of the Name";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "File Name";
            // 
            // rbFileComleteMatch
            // 
            this.rbFileComleteMatch.AutoSize = true;
            this.rbFileComleteMatch.Location = new System.Drawing.Point(37, 71);
            this.rbFileComleteMatch.Name = "rbFileComleteMatch";
            this.rbFileComleteMatch.Size = new System.Drawing.Size(101, 17);
            this.rbFileComleteMatch.TabIndex = 5;
            this.rbFileComleteMatch.Text = "Complete match";
            this.rbFileComleteMatch.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Search by phone File Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1428, 617);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddOrganization);
            this.Controls.Add(this.lbOrganizations);
            this.Name = "MainForm";
            this.Text = "Phone Numbers Dictionary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrganizations;
        private System.Windows.Forms.Button btnAddOrganization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxOrgName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNamePart;
        private System.Windows.Forms.RadioButton rbNameComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbxOrgProfile;
        private System.Windows.Forms.RadioButton rbProfilePart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbProfileComplete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbxOrgLocation;
        private System.Windows.Forms.RadioButton tbLocationPart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbLocationComplete;
        private System.Windows.Forms.Button btnOrgSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPhoneSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtbxPhoneNumber;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbPhoneCompleteMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtbxInfoData;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbInfoDataComplete;
        private System.Windows.Forms.Button btnSearchByInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtbxInfoType;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbInoTypeComlete;
        private System.Windows.Forms.CheckBox cbPhoneOldNumbers;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnSearchByFile;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtbxFileName;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbFileComleteMatch;
        private System.Windows.Forms.Label label11;
    }
}