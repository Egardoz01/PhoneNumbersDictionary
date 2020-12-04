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
            this.components = new System.ComponentModel.Container();
          
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
            this.SuspendLayout();
           
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddOrganization.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganization.Location = new System.Drawing.Point(824, 504);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(166, 42);
            this.btnAddOrganization.TabIndex = 23;
            this.btnAddOrganization.Text = "Add Organization";
            this.btnAddOrganization.UseVisualStyleBackColor = false;
            this.btnAddOrganization.Click += new System.EventHandler(this.btnAddOrganization_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(183, 40);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(179, 20);
            this.lblMain.TabIndex = 22;
            this.lblMain.Text = "Write Organization Data";
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Location = new System.Drawing.Point(881, 71);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(109, 23);
            this.btnAddInfo.TabIndex = 21;
            this.btnAddInfo.Text = "Add Additional Info";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnAddPhoneNumber
            // 
            this.btnAddPhoneNumber.Location = new System.Drawing.Point(528, 71);
            this.btnAddPhoneNumber.Name = "btnAddPhoneNumber";
            this.btnAddPhoneNumber.Size = new System.Drawing.Size(106, 23);
            this.btnAddPhoneNumber.TabIndex = 20;
            this.btnAddPhoneNumber.Text = "Add Phone Nmber";
            this.btnAddPhoneNumber.UseVisualStyleBackColor = true;
            this.btnAddPhoneNumber.Click += new System.EventHandler(this.btnAddPhoneNumber_Click);
            // 
            // lbAdditionalInfo
            // 
            this.lbAdditionalInfo.FormattingEnabled = true;
            this.lbAdditionalInfo.Location = new System.Drawing.Point(669, 100);
            this.lbAdditionalInfo.Name = "lbAdditionalInfo";
            this.lbAdditionalInfo.Size = new System.Drawing.Size(321, 212);
            this.lbAdditionalInfo.TabIndex = 19;
            // 
            // txtbxProfile
            // 
            this.txtbxProfile.Location = new System.Drawing.Point(187, 268);
            this.txtbxProfile.MaxLength = 200;
            this.txtbxProfile.Multiline = true;
            this.txtbxProfile.Name = "txtbxProfile";
            this.txtbxProfile.Size = new System.Drawing.Size(189, 44);
            this.txtbxProfile.TabIndex = 18;
            // 
            // txtbxLocation
            // 
            this.txtbxLocation.Location = new System.Drawing.Point(187, 175);
            this.txtbxLocation.MaxLength = 200;
            this.txtbxLocation.Multiline = true;
            this.txtbxLocation.Name = "txtbxLocation";
            this.txtbxLocation.Size = new System.Drawing.Size(189, 51);
            this.txtbxLocation.TabIndex = 17;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(187, 100);
            this.txtbxName.MaxLength = 50;
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(189, 20);
            this.txtbxName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Organization Profile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Organization Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Organization Name:";
            // 
            // lbPhoneNumbers
            // 
            this.lbPhoneNumbers.FormattingEnabled = true;
            this.lbPhoneNumbers.Location = new System.Drawing.Point(406, 100);
            this.lbPhoneNumbers.Name = "lbPhoneNumbers";
            this.lbPhoneNumbers.Size = new System.Drawing.Size(228, 212);
            this.lbPhoneNumbers.TabIndex = 12;
            // 
            // btnRemoveOrganization
            // 
            this.btnRemoveOrganization.BackColor = System.Drawing.Color.Red;
            this.btnRemoveOrganization.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrganization.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveOrganization.Location = new System.Drawing.Point(588, 504);
            this.btnRemoveOrganization.Name = "btnRemoveOrganization";
            this.btnRemoveOrganization.Size = new System.Drawing.Size(200, 42);
            this.btnRemoveOrganization.TabIndex = 24;
            this.btnRemoveOrganization.Text = "Remove Organization";
            this.btnRemoveOrganization.UseVisualStyleBackColor = false;
            this.btnRemoveOrganization.Visible = false;
            this.btnRemoveOrganization.Click += new System.EventHandler(this.btnRemoveOrganization_Click);
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 587);
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
            this.Name = "OrganizationForm";
            this.Text = "Phone Numbers Dictionary";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
    }
}

