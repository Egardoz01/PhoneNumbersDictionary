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
            this.lbOrganizations = new System.Windows.Forms.ListBox();
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxOrgName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNameComplete = new System.Windows.Forms.RadioButton();
            this.rbNamePart = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbxOrgProfile = new System.Windows.Forms.TextBox();
            this.rbProfilePart = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbProfileComplete = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbxOrgLocation = new System.Windows.Forms.TextBox();
            this.tbLocationPart = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbLocationComplete = new System.Windows.Forms.RadioButton();
            this.btnOrgSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOrganizations
            // 
            this.lbOrganizations.FormattingEnabled = true;
            this.lbOrganizations.Location = new System.Drawing.Point(13, 13);
            this.lbOrganizations.Name = "lbOrganizations";
            this.lbOrganizations.Size = new System.Drawing.Size(310, 446);
            this.lbOrganizations.TabIndex = 0;
            this.lbOrganizations.DoubleClick += new System.EventHandler(this.lbOrganizations_DoubleClick);
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganization.Location = new System.Drawing.Point(820, 542);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(201, 41);
            this.btnAddOrganization.TabIndex = 1;
            this.btnAddOrganization.Text = "AddOrganization";
            this.btnAddOrganization.UseVisualStyleBackColor = true;
            this.btnAddOrganization.Click += new System.EventHandler(this.btnAddOrganization_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            this.groupBox1.Size = new System.Drawing.Size(322, 446);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by Organization info";
            // 
            // rbNameComplete
            // 
            this.rbNameComplete.AutoSize = true;
            this.rbNameComplete.Location = new System.Drawing.Point(37, 71);
            this.rbNameComplete.Name = "rbNameComplete";
            this.rbNameComplete.Size = new System.Drawing.Size(100, 17);
            this.rbNameComplete.TabIndex = 5;
            this.rbNameComplete.Text = "complete match";
            this.rbNameComplete.UseVisualStyleBackColor = true;
            // 
            // rbNamePart
            // 
            this.rbNamePart.AutoSize = true;
            this.rbNamePart.Checked = true;
            this.rbNamePart.Location = new System.Drawing.Point(172, 71);
            this.rbNamePart.Name = "rbNamePart";
            this.rbNamePart.Size = new System.Drawing.Size(105, 17);
            this.rbNamePart.TabIndex = 6;
            this.rbNamePart.TabStop = true;
            this.rbNamePart.Text = "Part of the Name";
            this.rbNamePart.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Organization Profile";
            // 
            // rbProfileComplete
            // 
            this.rbProfileComplete.AutoSize = true;
            this.rbProfileComplete.Location = new System.Drawing.Point(37, 71);
            this.rbProfileComplete.Name = "rbProfileComplete";
            this.rbProfileComplete.Size = new System.Drawing.Size(100, 17);
            this.rbProfileComplete.TabIndex = 5;
            this.rbProfileComplete.Text = "complete match";
            this.rbProfileComplete.UseVisualStyleBackColor = true;
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
            this.rbLocationComplete.Size = new System.Drawing.Size(100, 17);
            this.rbLocationComplete.TabIndex = 5;
            this.rbLocationComplete.Text = "complete match";
            this.rbLocationComplete.UseVisualStyleBackColor = true;
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
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(214, 466);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(88, 23);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 595);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddOrganization);
            this.Controls.Add(this.lbOrganizations);
            this.Name = "MainForm";
            this.Text = "Phone Numbers Dictionary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
    }
}