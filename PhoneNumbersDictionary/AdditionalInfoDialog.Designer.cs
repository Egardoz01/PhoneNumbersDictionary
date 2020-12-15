namespace PhoneNumbersDictionary
{
    partial class AdditionalInfoDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxInfoType = new System.Windows.Forms.TextBox();
            this.txtbxInfoData = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название доп. информации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Значение доп. информции";
            // 
            // txtbxInfoType
            // 
            this.txtbxInfoType.Location = new System.Drawing.Point(166, 25);
            this.txtbxInfoType.MaxLength = 100;
            this.txtbxInfoType.Name = "txtbxInfoType";
            this.txtbxInfoType.Size = new System.Drawing.Size(181, 20);
            this.txtbxInfoType.TabIndex = 2;
            // 
            // txtbxInfoData
            // 
            this.txtbxInfoData.Location = new System.Drawing.Point(166, 55);
            this.txtbxInfoData.MaxLength = 100;
            this.txtbxInfoData.Name = "txtbxInfoData";
            this.txtbxInfoData.Size = new System.Drawing.Size(181, 20);
            this.txtbxInfoData.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(272, 114);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrors.Location = new System.Drawing.Point(12, 90);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(58, 16);
            this.lblErrors.TabIndex = 5;
            this.lblErrors.Text = "Ошибки";
            this.lblErrors.Visible = false;
            // 
            // AdditionalInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 149);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtbxInfoData);
            this.Controls.Add(this.txtbxInfoType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdditionalInfoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введите дополнительную информацию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxInfoType;
        private System.Windows.Forms.TextBox txtbxInfoData;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblErrors;
    }
}