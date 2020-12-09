namespace PhoneNumbersDictionary
{
    partial class OrganizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationForm));
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.btnAddPhoneNumber = new System.Windows.Forms.Button();
            this.lbAdditionalInfo = new System.Windows.Forms.ListBox();
            this.txtbxProfile = new System.Windows.Forms.TextBox();
            this.txtbxLocation = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPhoneNumbers = new System.Windows.Forms.ListBox();
            this.btnRemoveOrganization = new System.Windows.Forms.Button();
            this.pbOrgPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowsePhoto = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrgPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnAddOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOrganization.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnAddOrganization.Location = new System.Drawing.Point(1019, 580);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(179, 42);
            this.btnAddOrganization.TabIndex = 23;
            this.btnAddOrganization.Text = "Add Organization";
            this.btnAddOrganization.UseVisualStyleBackColor = false;
            this.btnAddOrganization.Click += new System.EventHandler(this.btnAddOrganization_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lblMain.Location = new System.Drawing.Point(145, 23);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(241, 25);
            this.lblMain.TabIndex = 22;
            this.lblMain.Text = "Write Organization Data";
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.btnAddInfo.FlatAppearance.BorderSize = 0;
            this.btnAddInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnAddInfo.Location = new System.Drawing.Point(1070, 69);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(128, 32);
            this.btnAddInfo.TabIndex = 21;
            this.btnAddInfo.Text = "Add  Info";
            this.btnAddInfo.UseVisualStyleBackColor = false;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnAddPhoneNumber
            // 
            this.btnAddPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.btnAddPhoneNumber.FlatAppearance.BorderSize = 0;
            this.btnAddPhoneNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnAddPhoneNumber.Location = new System.Drawing.Point(524, 69);
            this.btnAddPhoneNumber.Name = "btnAddPhoneNumber";
            this.btnAddPhoneNumber.Size = new System.Drawing.Size(128, 32);
            this.btnAddPhoneNumber.TabIndex = 20;
            this.btnAddPhoneNumber.Text = "Add Phone Nmber";
            this.btnAddPhoneNumber.UseVisualStyleBackColor = false;
            this.btnAddPhoneNumber.Click += new System.EventHandler(this.btnAddPhoneNumber_Click);
            // 
            // lbAdditionalInfo
            // 
            this.lbAdditionalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdditionalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lbAdditionalInfo.FormattingEnabled = true;
            this.lbAdditionalInfo.ItemHeight = 20;
            this.lbAdditionalInfo.Location = new System.Drawing.Point(767, 107);
            this.lbAdditionalInfo.Name = "lbAdditionalInfo";
            this.lbAdditionalInfo.Size = new System.Drawing.Size(431, 184);
            this.lbAdditionalInfo.TabIndex = 19;
            this.lbAdditionalInfo.DoubleClick += new System.EventHandler(this.EditInfoItem);
            // 
            // txtbxProfile
            // 
            this.txtbxProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxProfile.Location = new System.Drawing.Point(108, 467);
            this.txtbxProfile.MaxLength = 200;
            this.txtbxProfile.Multiline = true;
            this.txtbxProfile.Name = "txtbxProfile";
            this.txtbxProfile.Size = new System.Drawing.Size(257, 56);
            this.txtbxProfile.TabIndex = 18;
            // 
            // txtbxLocation
            // 
            this.txtbxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLocation.Location = new System.Drawing.Point(108, 367);
            this.txtbxLocation.MaxLength = 200;
            this.txtbxLocation.Multiline = true;
            this.txtbxLocation.Name = "txtbxLocation";
            this.txtbxLocation.Size = new System.Drawing.Size(257, 61);
            this.txtbxLocation.TabIndex = 17;
            // 
            // txtbxName
            // 
            this.txtbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.txtbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxName.Location = new System.Drawing.Point(108, 293);
            this.txtbxName.MaxLength = 50;
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(257, 26);
            this.txtbxName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(16, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = " Profile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(16, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(16, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbPhoneNumbers
            // 
            this.lbPhoneNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbPhoneNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lbPhoneNumbers.FormattingEnabled = true;
            this.lbPhoneNumbers.ItemHeight = 20;
            this.lbPhoneNumbers.Location = new System.Drawing.Point(417, 107);
            this.lbPhoneNumbers.Name = "lbPhoneNumbers";
            this.lbPhoneNumbers.Size = new System.Drawing.Size(321, 444);
            this.lbPhoneNumbers.TabIndex = 12;
            this.lbPhoneNumbers.DoubleClick += new System.EventHandler(this.EditPhoneNumberItem);
            // 
            // btnRemoveOrganization
            // 
            this.btnRemoveOrganization.BackColor = System.Drawing.Color.Red;
            this.btnRemoveOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveOrganization.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrganization.ForeColor = System.Drawing.Color.White;
            this.btnRemoveOrganization.Location = new System.Drawing.Point(787, 580);
            this.btnRemoveOrganization.Name = "btnRemoveOrganization";
            this.btnRemoveOrganization.Size = new System.Drawing.Size(200, 42);
            this.btnRemoveOrganization.TabIndex = 24;
            this.btnRemoveOrganization.Text = "Remove Organization";
            this.btnRemoveOrganization.UseVisualStyleBackColor = false;
            this.btnRemoveOrganization.Visible = false;
            this.btnRemoveOrganization.Click += new System.EventHandler(this.btnRemoveOrganization_Click);
            // 
            // pbOrgPhoto
            // 
            this.pbOrgPhoto.Location = new System.Drawing.Point(153, 103);
            this.pbOrgPhoto.Name = "pbOrgPhoto";
            this.pbOrgPhoto.Size = new System.Drawing.Size(189, 132);
            this.pbOrgPhoto.TabIndex = 25;
            this.pbOrgPhoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Photo:";
            // 
            // btnBrowsePhoto
            // 
            this.btnBrowsePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.btnBrowsePhoto.FlatAppearance.BorderSize = 0;
            this.btnBrowsePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowsePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnBrowsePhoto.Location = new System.Drawing.Point(10, 162);
            this.btnBrowsePhoto.Name = "btnBrowsePhoto";
            this.btnBrowsePhoto.Size = new System.Drawing.Size(128, 32);
            this.btnBrowsePhoto.TabIndex = 27;
            this.btnBrowsePhoto.Text = "Browse Photo";
            this.btnBrowsePhoto.UseVisualStyleBackColor = false;
            this.btnBrowsePhoto.Click += new System.EventHandler(this.btnBrowsePhoto_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.btnAddFile.FlatAppearance.BorderSize = 0;
            this.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.btnAddFile.Location = new System.Drawing.Point(1070, 329);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(128, 32);
            this.btnAddFile.TabIndex = 29;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 20;
            this.lbFiles.Location = new System.Drawing.Point(767, 367);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(431, 184);
            this.lbFiles.TabIndex = 28;
            this.lbFiles.DoubleClick += new System.EventHandler(this.OpenFileItem);
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1210, 634);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.btnBrowsePhoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbOrgPhoto);
            this.Controls.Add(this.btnRemoveOrganization);
            this.Controls.Add(this.btnAddOrganization);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.btnAddPhoneNumber);
            this.Controls.Add(this.lbAdditionalInfo);
            this.Controls.Add(this.txtbxProfile);
            this.Controls.Add(this.txtbxLocation);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPhoneNumbers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganizationForm";
            this.Text = "Phone Numbers Dictionary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOrgPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAddOrganization;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button btnAddPhoneNumber;
        private System.Windows.Forms.ListBox lbAdditionalInfo;
        private System.Windows.Forms.TextBox txtbxProfile;
        private System.Windows.Forms.TextBox txtbxLocation;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPhoneNumbers;
        private System.Windows.Forms.Button btnRemoveOrganization;
        private System.Windows.Forms.PictureBox pbOrgPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowsePhoto;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListBox lbFiles;
    }
}

