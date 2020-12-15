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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbOrganizations = new System.Windows.Forms.ListBox();
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.txtbxOrgName = new System.Windows.Forms.TextBox();
            this.btnOrgSearch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbxOrgLocation = new System.Windows.Forms.TextBox();
            this.tbLocationPart = new System.Windows.Forms.RadioButton();
            this.rbLocationComplete = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbxOrgProfile = new System.Windows.Forms.TextBox();
            this.rbProfilePart = new System.Windows.Forms.RadioButton();
            this.rbProfileComplete = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNamePart = new System.Windows.Forms.RadioButton();
            this.rbNameComplete = new System.Windows.Forms.RadioButton();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPhoneSearch = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbPhoneOldNumbers = new System.Windows.Forms.CheckBox();
            this.txtbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbPhoneCompleteMatch = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtbxInfoData = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rbInfoDataComplete = new System.Windows.Forms.RadioButton();
            this.btnSearchByInfo = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtbxInfoType = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbInoTypeComlete = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnSearchByFile = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtbxFileName = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbFileComleteMatch = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrgCount = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtbxPageSIze = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurPage = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOrganizations
            // 
            this.lbOrganizations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbOrganizations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOrganizations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOrganizations.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrganizations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lbOrganizations.FormattingEnabled = true;
            this.lbOrganizations.ItemHeight = 17;
            this.lbOrganizations.Location = new System.Drawing.Point(12, 15);
            this.lbOrganizations.Name = "lbOrganizations";
            this.lbOrganizations.Size = new System.Drawing.Size(442, 461);
            this.lbOrganizations.TabIndex = 0;
            this.lbOrganizations.DoubleClick += new System.EventHandler(this.lbOrganizations_DoubleClick);
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnAddOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOrganization.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnAddOrganization.Location = new System.Drawing.Point(12, 694);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(201, 73);
            this.btnAddOrganization.TabIndex = 1;
            this.btnAddOrganization.Text = "Добавить Организацию";
            this.btnAddOrganization.UseVisualStyleBackColor = false;
            this.btnAddOrganization.Click += new System.EventHandler(this.btnAddOrganization_Click);
            // 
            // txtbxOrgName
            // 
            this.txtbxOrgName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxOrgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxOrgName.Location = new System.Drawing.Point(24, 33);
            this.txtbxOrgName.Name = "txtbxOrgName";
            this.txtbxOrgName.Size = new System.Drawing.Size(240, 22);
            this.txtbxOrgName.TabIndex = 3;
            // 
            // btnOrgSearch
            // 
            this.btnOrgSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.btnOrgSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrgSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrgSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrgSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnOrgSearch.Location = new System.Drawing.Point(197, 418);
            this.btnOrgSearch.Name = "btnOrgSearch";
            this.btnOrgSearch.Size = new System.Drawing.Size(128, 32);
            this.btnOrgSearch.TabIndex = 10;
            this.btnOrgSearch.Text = "Искать";
            this.btnOrgSearch.UseVisualStyleBackColor = false;
            this.btnOrgSearch.Click += new System.EventHandler(this.btnOrgSearch_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.groupBox4.Controls.Add(this.txtbxOrgLocation);
            this.groupBox4.Controls.Add(this.tbLocationPart);
            this.groupBox4.Controls.Add(this.rbLocationComplete);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox4.Location = new System.Drawing.Point(15, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 101);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Местоположение";
            // 
            // txtbxOrgLocation
            // 
            this.txtbxOrgLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxOrgLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxOrgLocation.Location = new System.Drawing.Point(37, 30);
            this.txtbxOrgLocation.Name = "txtbxOrgLocation";
            this.txtbxOrgLocation.Size = new System.Drawing.Size(228, 22);
            this.txtbxOrgLocation.TabIndex = 3;
            // 
            // tbLocationPart
            // 
            this.tbLocationPart.AutoSize = true;
            this.tbLocationPart.Checked = true;
            this.tbLocationPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.tbLocationPart.Location = new System.Drawing.Point(210, 75);
            this.tbLocationPart.Name = "tbLocationPart";
            this.tbLocationPart.Size = new System.Drawing.Size(95, 20);
            this.tbLocationPart.TabIndex = 6;
            this.tbLocationPart.TabStop = true;
            this.tbLocationPart.Text = "подстрока";
            this.tbLocationPart.UseVisualStyleBackColor = true;
            // 
            // rbLocationComplete
            // 
            this.rbLocationComplete.AutoSize = true;
            this.rbLocationComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.rbLocationComplete.Location = new System.Drawing.Point(6, 75);
            this.rbLocationComplete.Name = "rbLocationComplete";
            this.rbLocationComplete.Size = new System.Drawing.Size(156, 20);
            this.rbLocationComplete.TabIndex = 5;
            this.rbLocationComplete.Text = "полное совпадение";
            this.rbLocationComplete.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.groupBox3.Controls.Add(this.txtbxOrgProfile);
            this.groupBox3.Controls.Add(this.rbProfilePart);
            this.groupBox3.Controls.Add(this.rbProfileComplete);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 101);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Профиль";
            // 
            // txtbxOrgProfile
            // 
            this.txtbxOrgProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxOrgProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxOrgProfile.Location = new System.Drawing.Point(25, 33);
            this.txtbxOrgProfile.Name = "txtbxOrgProfile";
            this.txtbxOrgProfile.Size = new System.Drawing.Size(240, 22);
            this.txtbxOrgProfile.TabIndex = 3;
            // 
            // rbProfilePart
            // 
            this.rbProfilePart.AutoSize = true;
            this.rbProfilePart.Checked = true;
            this.rbProfilePart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.rbProfilePart.Location = new System.Drawing.Point(204, 75);
            this.rbProfilePart.Name = "rbProfilePart";
            this.rbProfilePart.Size = new System.Drawing.Size(95, 20);
            this.rbProfilePart.TabIndex = 6;
            this.rbProfilePart.TabStop = true;
            this.rbProfilePart.Text = "подстрока";
            this.rbProfilePart.UseVisualStyleBackColor = true;
            // 
            // rbProfileComplete
            // 
            this.rbProfileComplete.AutoSize = true;
            this.rbProfileComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.rbProfileComplete.Location = new System.Drawing.Point(7, 75);
            this.rbProfileComplete.Name = "rbProfileComplete";
            this.rbProfileComplete.Size = new System.Drawing.Size(156, 20);
            this.rbProfileComplete.TabIndex = 5;
            this.rbProfileComplete.Text = "полное совпадение";
            this.rbProfileComplete.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.groupBox2.Controls.Add(this.txtbxOrgName);
            this.groupBox2.Controls.Add(this.rbNamePart);
            this.groupBox2.Controls.Add(this.rbNameComplete);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Название";
            // 
            // rbNamePart
            // 
            this.rbNamePart.AutoSize = true;
            this.rbNamePart.Checked = true;
            this.rbNamePart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.rbNamePart.Location = new System.Drawing.Point(209, 66);
            this.rbNamePart.Name = "rbNamePart";
            this.rbNamePart.Size = new System.Drawing.Size(95, 20);
            this.rbNamePart.TabIndex = 6;
            this.rbNamePart.TabStop = true;
            this.rbNamePart.Text = "подстрока";
            this.rbNamePart.UseVisualStyleBackColor = true;
            // 
            // rbNameComplete
            // 
            this.rbNameComplete.AutoSize = true;
            this.rbNameComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.rbNameComplete.Location = new System.Drawing.Point(6, 66);
            this.rbNameComplete.Name = "rbNameComplete";
            this.rbNameComplete.Size = new System.Drawing.Size(156, 20);
            this.rbNameComplete.TabIndex = 5;
            this.rbNameComplete.Text = "полное совпадение";
            this.rbNameComplete.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnShowAll.Location = new System.Drawing.Point(219, 694);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(128, 39);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Показать все";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPhoneSearch);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox5.Location = new System.Drawing.Point(849, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 225);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поиск по телефонным номерам";
            // 
            // btnPhoneSearch
            // 
            this.btnPhoneSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.btnPhoneSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhoneSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnPhoneSearch.Location = new System.Drawing.Point(188, 184);
            this.btnPhoneSearch.Name = "btnPhoneSearch";
            this.btnPhoneSearch.Size = new System.Drawing.Size(128, 32);
            this.btnPhoneSearch.TabIndex = 11;
            this.btnPhoneSearch.Text = "Искать";
            this.btnPhoneSearch.UseVisualStyleBackColor = false;
            this.btnPhoneSearch.Click += new System.EventHandler(this.btnPhoneSearch_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.groupBox6.Controls.Add(this.cbPhoneOldNumbers);
            this.groupBox6.Controls.Add(this.txtbxPhoneNumber);
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Controls.Add(this.rbPhoneCompleteMatch);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox6.Location = new System.Drawing.Point(6, 44);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(310, 123);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Номер телефона";
            // 
            // cbPhoneOldNumbers
            // 
            this.cbPhoneOldNumbers.AutoSize = true;
            this.cbPhoneOldNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.cbPhoneOldNumbers.Location = new System.Drawing.Point(6, 97);
            this.cbPhoneOldNumbers.Name = "cbPhoneOldNumbers";
            this.cbPhoneOldNumbers.Size = new System.Drawing.Size(202, 20);
            this.cbPhoneOldNumbers.TabIndex = 7;
            this.cbPhoneOldNumbers.Text = "искать по старым номерам";
            this.cbPhoneOldNumbers.UseVisualStyleBackColor = true;
            // 
            // txtbxPhoneNumber
            // 
            this.txtbxPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPhoneNumber.Location = new System.Drawing.Point(13, 30);
            this.txtbxPhoneNumber.Name = "txtbxPhoneNumber";
            this.txtbxPhoneNumber.Size = new System.Drawing.Size(271, 22);
            this.txtbxPhoneNumber.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.radioButton1.Location = new System.Drawing.Point(209, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "подстрока";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbPhoneCompleteMatch
            // 
            this.rbPhoneCompleteMatch.AutoSize = true;
            this.rbPhoneCompleteMatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.rbPhoneCompleteMatch.Location = new System.Drawing.Point(6, 71);
            this.rbPhoneCompleteMatch.Name = "rbPhoneCompleteMatch";
            this.rbPhoneCompleteMatch.Size = new System.Drawing.Size(156, 20);
            this.rbPhoneCompleteMatch.TabIndex = 5;
            this.rbPhoneCompleteMatch.Text = "полное совпадение";
            this.rbPhoneCompleteMatch.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.btnSearchByInfo);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox7.Location = new System.Drawing.Point(1206, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(322, 328);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поиск по дополнительной информации";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.groupBox9.Controls.Add(this.txtbxInfoData);
            this.groupBox9.Controls.Add(this.radioButton4);
            this.groupBox9.Controls.Add(this.rbInfoDataComplete);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox9.Location = new System.Drawing.Point(6, 161);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(310, 97);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Значение доп. информции";
            // 
            // txtbxInfoData
            // 
            this.txtbxInfoData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxInfoData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxInfoData.Location = new System.Drawing.Point(24, 30);
            this.txtbxInfoData.Name = "txtbxInfoData";
            this.txtbxInfoData.Size = new System.Drawing.Size(255, 22);
            this.txtbxInfoData.TabIndex = 3;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.radioButton4.Location = new System.Drawing.Point(209, 70);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 20);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "подстрока";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rbInfoDataComplete
            // 
            this.rbInfoDataComplete.AutoSize = true;
            this.rbInfoDataComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.rbInfoDataComplete.Location = new System.Drawing.Point(6, 70);
            this.rbInfoDataComplete.Name = "rbInfoDataComplete";
            this.rbInfoDataComplete.Size = new System.Drawing.Size(156, 20);
            this.rbInfoDataComplete.TabIndex = 5;
            this.rbInfoDataComplete.Text = "полное совпадение";
            this.rbInfoDataComplete.UseVisualStyleBackColor = true;
            // 
            // btnSearchByInfo
            // 
            this.btnSearchByInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.btnSearchByInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchByInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnSearchByInfo.Location = new System.Drawing.Point(188, 287);
            this.btnSearchByInfo.Name = "btnSearchByInfo";
            this.btnSearchByInfo.Size = new System.Drawing.Size(128, 32);
            this.btnSearchByInfo.TabIndex = 14;
            this.btnSearchByInfo.Text = "Искать";
            this.btnSearchByInfo.UseVisualStyleBackColor = false;
            this.btnSearchByInfo.Click += new System.EventHandler(this.btnSearchByInfo_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.groupBox8.Controls.Add(this.txtbxInfoType);
            this.groupBox8.Controls.Add(this.radioButton2);
            this.groupBox8.Controls.Add(this.rbInoTypeComlete);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox8.Location = new System.Drawing.Point(6, 44);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(310, 97);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Название доп. информации";
            // 
            // txtbxInfoType
            // 
            this.txtbxInfoType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxInfoType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxInfoType.Location = new System.Drawing.Point(24, 30);
            this.txtbxInfoType.Name = "txtbxInfoType";
            this.txtbxInfoType.Size = new System.Drawing.Size(255, 22);
            this.txtbxInfoType.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.radioButton2.Location = new System.Drawing.Point(209, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "подстрока";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbInoTypeComlete
            // 
            this.rbInoTypeComlete.AutoSize = true;
            this.rbInoTypeComlete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.rbInoTypeComlete.Location = new System.Drawing.Point(6, 71);
            this.rbInoTypeComlete.Name = "rbInoTypeComlete";
            this.rbInoTypeComlete.Size = new System.Drawing.Size(156, 20);
            this.rbInoTypeComlete.TabIndex = 5;
            this.rbInoTypeComlete.Text = "полное совпадение";
            this.rbInoTypeComlete.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnSearchByFile);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox10.Location = new System.Drawing.Point(849, 246);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(322, 230);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Поиск по файлам";
            // 
            // btnSearchByFile
            // 
            this.btnSearchByFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.btnSearchByFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchByFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnSearchByFile.Location = new System.Drawing.Point(188, 184);
            this.btnSearchByFile.Name = "btnSearchByFile";
            this.btnSearchByFile.Size = new System.Drawing.Size(128, 32);
            this.btnSearchByFile.TabIndex = 11;
            this.btnSearchByFile.Text = "Искать";
            this.btnSearchByFile.UseVisualStyleBackColor = false;
            this.btnSearchByFile.Click += new System.EventHandler(this.btnSearchByFile_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.groupBox11.Controls.Add(this.txtbxFileName);
            this.groupBox11.Controls.Add(this.radioButton3);
            this.groupBox11.Controls.Add(this.rbFileComleteMatch);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox11.Location = new System.Drawing.Point(6, 56);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(310, 105);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Имя файла";
            // 
            // txtbxFileName
            // 
            this.txtbxFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxFileName.Location = new System.Drawing.Point(22, 21);
            this.txtbxFileName.Name = "txtbxFileName";
            this.txtbxFileName.Size = new System.Drawing.Size(254, 22);
            this.txtbxFileName.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.radioButton3.Location = new System.Drawing.Point(209, 79);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 20);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "подстрока";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbFileComleteMatch
            // 
            this.rbFileComleteMatch.AutoSize = true;
            this.rbFileComleteMatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.rbFileComleteMatch.Location = new System.Drawing.Point(6, 79);
            this.rbFileComleteMatch.Name = "rbFileComleteMatch";
            this.rbFileComleteMatch.Size = new System.Drawing.Size(156, 20);
            this.rbFileComleteMatch.TabIndex = 5;
            this.rbFileComleteMatch.Text = "полное совпадение";
            this.rbFileComleteMatch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrgSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox1.Location = new System.Drawing.Point(485, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 461);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по информации об организации";
            // 
            // lblOrgCount
            // 
            this.lblOrgCount.AutoSize = true;
            this.lblOrgCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lblOrgCount.Location = new System.Drawing.Point(8, 499);
            this.lblOrgCount.Name = "lblOrgCount";
            this.lblOrgCount.Size = new System.Drawing.Size(174, 20);
            this.lblOrgCount.TabIndex = 14;
            this.lblOrgCount.Text = "найдено организаций";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtbxPageSIze);
            this.groupBox12.Controls.Add(this.label1);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.groupBox12.Location = new System.Drawing.Point(485, 614);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(332, 151);
            this.groupBox12.TabIndex = 15;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Настройки ";
            // 
            // txtbxPageSIze
            // 
            this.txtbxPageSIze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxPageSIze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPageSIze.Location = new System.Drawing.Point(231, 37);
            this.txtbxPageSIze.Name = "txtbxPageSIze";
            this.txtbxPageSIze.Size = new System.Drawing.Size(95, 26);
            this.txtbxPageSIze.TabIndex = 7;
            this.txtbxPageSIze.Text = "100";
            this.txtbxPageSIze.Leave += new System.EventHandler(this.txtbxPageSIze_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Организаций на старнице:";
            // 
            // lblCurPage
            // 
            this.lblCurPage.AutoSize = true;
            this.lblCurPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lblCurPage.Location = new System.Drawing.Point(12, 584);
            this.lblCurPage.Name = "lblCurPage";
            this.lblCurPage.Size = new System.Drawing.Size(148, 20);
            this.lblCurPage.TabIndex = 17;
            this.lblCurPage.Text = "Текущая страница";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1283, 789);
            this.Controls.Add(this.lblCurPage);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.lblOrgCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnAddOrganization);
            this.Controls.Add(this.lbOrganizations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Телефонная Книга Организаций";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrganizations;
        private System.Windows.Forms.Button btnAddOrganization;
        private System.Windows.Forms.TextBox txtbxOrgName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNamePart;
        private System.Windows.Forms.RadioButton rbNameComplete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbxOrgProfile;
        private System.Windows.Forms.RadioButton rbProfilePart;
        private System.Windows.Forms.RadioButton rbProfileComplete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbxOrgLocation;
        private System.Windows.Forms.RadioButton tbLocationPart;
        private System.Windows.Forms.RadioButton rbLocationComplete;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPhoneSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtbxPhoneNumber;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbPhoneCompleteMatch;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtbxInfoData;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rbInfoDataComplete;
        private System.Windows.Forms.Button btnSearchByInfo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtbxInfoType;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbInoTypeComlete;
        private System.Windows.Forms.CheckBox cbPhoneOldNumbers;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnSearchByFile;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtbxFileName;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbFileComleteMatch;
        internal System.Windows.Forms.Button btnOrgSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrgCount;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox txtbxPageSIze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurPage;
    }
}