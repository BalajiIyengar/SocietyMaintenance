namespace SocietyMaintenance
{
    partial class SendFiles
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
            this.comboBox_flatNumber = new System.Windows.Forms.ComboBox();
            this.comboBox_associatedEmailIds = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_body = new System.Windows.Forms.RichTextBox();
            this.richTextBox_subject = new System.Windows.Forms.RichTextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_sendMail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar_sendMail = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flat Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Id";
            // 
            // comboBox_flatNumber
            // 
            this.comboBox_flatNumber.FormattingEnabled = true;
            this.comboBox_flatNumber.Location = new System.Drawing.Point(166, 34);
            this.comboBox_flatNumber.Name = "comboBox_flatNumber";
            this.comboBox_flatNumber.Size = new System.Drawing.Size(121, 21);
            this.comboBox_flatNumber.TabIndex = 2;
            this.comboBox_flatNumber.SelectedIndexChanged += new System.EventHandler(this.comboBox_flatNumber_SelectedIndexChanged);
            // 
            // comboBox_associatedEmailIds
            // 
            this.comboBox_associatedEmailIds.FormattingEnabled = true;
            this.comboBox_associatedEmailIds.Location = new System.Drawing.Point(166, 73);
            this.comboBox_associatedEmailIds.Name = "comboBox_associatedEmailIds";
            this.comboBox_associatedEmailIds.Size = new System.Drawing.Size(121, 21);
            this.comboBox_associatedEmailIds.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Attachments";
            // 
            // richTextBox_body
            // 
            this.richTextBox_body.BackColor = System.Drawing.Color.Wheat;
            this.richTextBox_body.Location = new System.Drawing.Point(384, 73);
            this.richTextBox_body.Name = "richTextBox_body";
            this.richTextBox_body.Size = new System.Drawing.Size(245, 116);
            this.richTextBox_body.TabIndex = 5;
            this.richTextBox_body.Text = "";
            // 
            // richTextBox_subject
            // 
            this.richTextBox_subject.BackColor = System.Drawing.Color.Wheat;
            this.richTextBox_subject.Location = new System.Drawing.Point(384, 23);
            this.richTextBox_subject.Name = "richTextBox_subject";
            this.richTextBox_subject.Size = new System.Drawing.Size(245, 44);
            this.richTextBox_subject.TabIndex = 6;
            this.richTextBox_subject.Text = "";
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(166, 123);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(121, 23);
            this.button_browse.TabIndex = 7;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_sendMail
            // 
            this.button_sendMail.Location = new System.Drawing.Point(278, 296);
            this.button_sendMail.Name = "button_sendMail";
            this.button_sendMail.Size = new System.Drawing.Size(75, 23);
            this.button_sendMail.TabIndex = 8;
            this.button_sendMail.Text = "Send Mail";
            this.button_sendMail.UseVisualStyleBackColor = true;
            this.button_sendMail.Click += new System.EventHandler(this.button_sendMail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Body";
            // 
            // progressBar_sendMail
            // 
            this.progressBar_sendMail.Location = new System.Drawing.Point(272, 227);
            this.progressBar_sendMail.Name = "progressBar_sendMail";
            this.progressBar_sendMail.Size = new System.Drawing.Size(100, 23);
            this.progressBar_sendMail.TabIndex = 11;
            // 
            // SendFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 393);
            this.Controls.Add(this.progressBar_sendMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_sendMail);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.richTextBox_subject);
            this.Controls.Add(this.richTextBox_body);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_associatedEmailIds);
            this.Controls.Add(this.comboBox_flatNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Files";
            this.Load += new System.EventHandler(this.SendFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_flatNumber;
        private System.Windows.Forms.ComboBox comboBox_associatedEmailIds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_body;
        private System.Windows.Forms.RichTextBox richTextBox_subject;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_sendMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar_sendMail;
    }
}