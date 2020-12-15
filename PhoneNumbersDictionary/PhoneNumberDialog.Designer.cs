namespace PhoneNumbersDictionary
{
    partial class PhoneNumberDialog
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
            this.txtbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtbxtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер телефона:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя контакта:";
            // 
            // txtbxPhoneNumber
            // 
            this.txtbxPhoneNumber.Location = new System.Drawing.Point(104, 29);
            this.txtbxPhoneNumber.MaxLength = 20;
            this.txtbxPhoneNumber.Name = "txtbxPhoneNumber";
            this.txtbxPhoneNumber.Size = new System.Drawing.Size(244, 20);
            this.txtbxPhoneNumber.TabIndex = 2;
            // 
            // txtbxtName
            // 
            this.txtbxtName.Location = new System.Drawing.Point(104, 64);
            this.txtbxtName.MaxLength = 100;
            this.txtbxtName.Name = "txtbxtName";
            this.txtbxtName.Size = new System.Drawing.Size(244, 20);
            this.txtbxtName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(12, 107);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(58, 16);
            this.lblErrors.TabIndex = 5;
            this.lblErrors.Text = "Ошибки";
            this.lblErrors.Visible = false;
            // 
            // PhoneNumberDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 166);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbxtName);
            this.Controls.Add(this.txtbxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhoneNumberDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введите данные контакта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxPhoneNumber;
        private System.Windows.Forms.TextBox txtbxtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblErrors;
    }
}