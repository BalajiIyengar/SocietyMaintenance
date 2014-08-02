namespace SocietyMaintenance
{
    partial class GenerateBill
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
            this.comboBox_flatNumbers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_billAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.button_generateBill = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ownerName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_billDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_email = new System.Windows.Forms.CheckBox();
            this.textBox_emailId = new System.Windows.Forms.TextBox();
            this.richTextBox_mailBody = new System.Windows.Forms.RichTextBox();
            this.richTextBox_mailSubject = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_addAttachments = new System.Windows.Forms.CheckBox();
            this.progressBar_generateBill = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flat";
            // 
            // comboBox_flatNumbers
            // 
            this.comboBox_flatNumbers.FormattingEnabled = true;
            this.comboBox_flatNumbers.Location = new System.Drawing.Point(129, 36);
            this.comboBox_flatNumbers.Name = "comboBox_flatNumbers";
            this.comboBox_flatNumbers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_flatNumbers.TabIndex = 1;
            this.comboBox_flatNumbers.SelectedIndexChanged += new System.EventHandler(this.comboBox_flatNumbers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Month & Year of Bill";
            // 
            // textBox_billAmount
            // 
            this.textBox_billAmount.Location = new System.Drawing.Point(129, 104);
            this.textBox_billAmount.Name = "textBox_billAmount";
            this.textBox_billAmount.Size = new System.Drawing.Size(121, 20);
            this.textBox_billAmount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount";
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(129, 144);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(60, 21);
            this.comboBox_month.TabIndex = 5;
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(204, 144);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(60, 21);
            this.comboBox_year.TabIndex = 6;
            // 
            // button_generateBill
            // 
            this.button_generateBill.Location = new System.Drawing.Point(243, 356);
            this.button_generateBill.Name = "button_generateBill";
            this.button_generateBill.Size = new System.Drawing.Size(75, 23);
            this.button_generateBill.TabIndex = 7;
            this.button_generateBill.Text = "Generate ";
            this.button_generateBill.UseVisualStyleBackColor = true;
            this.button_generateBill.Click += new System.EventHandler(this.button_generateBill_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Owner";
            // 
            // textBox_ownerName
            // 
            this.textBox_ownerName.Location = new System.Drawing.Point(129, 69);
            this.textBox_ownerName.Name = "textBox_ownerName";
            this.textBox_ownerName.ReadOnly = true;
            this.textBox_ownerName.Size = new System.Drawing.Size(121, 20);
            this.textBox_ownerName.TabIndex = 9;
            // 
            // dateTimePicker_billDate
            // 
            this.dateTimePicker_billDate.Location = new System.Drawing.Point(129, 188);
            this.dateTimePicker_billDate.Name = "dateTimePicker_billDate";
            this.dateTimePicker_billDate.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker_billDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bill Date";
            // 
            // checkBox_email
            // 
            this.checkBox_email.AutoSize = true;
            this.checkBox_email.Location = new System.Drawing.Point(96, 227);
            this.checkBox_email.Name = "checkBox_email";
            this.checkBox_email.Size = new System.Drawing.Size(79, 17);
            this.checkBox_email.TabIndex = 12;
            this.checkBox_email.Text = "Send Email";
            this.checkBox_email.UseVisualStyleBackColor = true;
            this.checkBox_email.CheckedChanged += new System.EventHandler(this.checkBox_email_CheckedChanged);
            // 
            // textBox_emailId
            // 
            this.textBox_emailId.Location = new System.Drawing.Point(204, 227);
            this.textBox_emailId.Name = "textBox_emailId";
            this.textBox_emailId.Size = new System.Drawing.Size(100, 20);
            this.textBox_emailId.TabIndex = 13;
            this.textBox_emailId.Visible = false;
            // 
            // richTextBox_mailBody
            // 
            this.richTextBox_mailBody.Location = new System.Drawing.Point(390, 87);
            this.richTextBox_mailBody.Name = "richTextBox_mailBody";
            this.richTextBox_mailBody.Size = new System.Drawing.Size(192, 160);
            this.richTextBox_mailBody.TabIndex = 14;
            this.richTextBox_mailBody.Text = "";
            // 
            // richTextBox_mailSubject
            // 
            this.richTextBox_mailSubject.Location = new System.Drawing.Point(390, 36);
            this.richTextBox_mailSubject.Name = "richTextBox_mailSubject";
            this.richTextBox_mailSubject.Size = new System.Drawing.Size(192, 45);
            this.richTextBox_mailSubject.TabIndex = 15;
            this.richTextBox_mailSubject.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Body";
            // 
            // checkBox_addAttachments
            // 
            this.checkBox_addAttachments.AutoSize = true;
            this.checkBox_addAttachments.Location = new System.Drawing.Point(204, 269);
            this.checkBox_addAttachments.Name = "checkBox_addAttachments";
            this.checkBox_addAttachments.Size = new System.Drawing.Size(85, 17);
            this.checkBox_addAttachments.TabIndex = 18;
            this.checkBox_addAttachments.Text = "Attachments";
            this.checkBox_addAttachments.UseVisualStyleBackColor = true;
            this.checkBox_addAttachments.Visible = false;
            this.checkBox_addAttachments.CheckedChanged += new System.EventHandler(this.checkBox_addAttachments_CheckedChanged);
            // 
            // progressBar_generateBill
            // 
            this.progressBar_generateBill.Location = new System.Drawing.Point(243, 314);
            this.progressBar_generateBill.Name = "progressBar_generateBill";
            this.progressBar_generateBill.Size = new System.Drawing.Size(100, 23);
            this.progressBar_generateBill.TabIndex = 19;
            // 
            // GenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 455);
            this.Controls.Add(this.progressBar_generateBill);
            this.Controls.Add(this.checkBox_addAttachments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_mailSubject);
            this.Controls.Add(this.richTextBox_mailBody);
            this.Controls.Add(this.textBox_emailId);
            this.Controls.Add(this.checkBox_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_billDate);
            this.Controls.Add(this.textBox_ownerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_generateBill);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_billAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_flatNumbers);
            this.Controls.Add(this.label1);
            this.Name = "GenerateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateBill";
            this.Load += new System.EventHandler(this.GenerateBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_flatNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_billAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.Button button_generateBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ownerName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_billDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_email;
        private System.Windows.Forms.TextBox textBox_emailId;
        private System.Windows.Forms.RichTextBox richTextBox_mailBody;
        private System.Windows.Forms.RichTextBox richTextBox_mailSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_addAttachments;
        private System.Windows.Forms.ProgressBar progressBar_generateBill;
    }
}