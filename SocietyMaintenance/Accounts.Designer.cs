namespace SocietyMaintenance
{
    partial class Accounts
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
            this.comboBox_fromMonth = new System.Windows.Forms.ComboBox();
            this.comboBox_fromYear = new System.Windows.Forms.ComboBox();
            this.comboBox_toYear = new System.Windows.Forms.ComboBox();
            this.comboBox_toMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_billCount = new System.Windows.Forms.LinkLabel();
            this.button_fetchBills = new System.Windows.Forms.Button();
            this.dataGridView_bills = new System.Windows.Forms.DataGridView();
            this.radioButton_allUsers = new System.Windows.Forms.RadioButton();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.label_flatNumber = new System.Windows.Forms.Label();
            this.groupBox_totalPayments = new System.Windows.Forms.GroupBox();
            this.textBox_pending = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel_showPayments = new System.Windows.Forms.LinkLabel();
            this.comboBox_flatNumber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bills)).BeginInit();
            this.groupBox_totalPayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // comboBox_fromMonth
            // 
            this.comboBox_fromMonth.FormattingEnabled = true;
            this.comboBox_fromMonth.Location = new System.Drawing.Point(326, 27);
            this.comboBox_fromMonth.Name = "comboBox_fromMonth";
            this.comboBox_fromMonth.Size = new System.Drawing.Size(80, 21);
            this.comboBox_fromMonth.TabIndex = 2;
            // 
            // comboBox_fromYear
            // 
            this.comboBox_fromYear.FormattingEnabled = true;
            this.comboBox_fromYear.Location = new System.Drawing.Point(412, 27);
            this.comboBox_fromYear.Name = "comboBox_fromYear";
            this.comboBox_fromYear.Size = new System.Drawing.Size(80, 21);
            this.comboBox_fromYear.TabIndex = 3;
            // 
            // comboBox_toYear
            // 
            this.comboBox_toYear.FormattingEnabled = true;
            this.comboBox_toYear.Location = new System.Drawing.Point(412, 70);
            this.comboBox_toYear.Name = "comboBox_toYear";
            this.comboBox_toYear.Size = new System.Drawing.Size(80, 21);
            this.comboBox_toYear.TabIndex = 5;
            // 
            // comboBox_toMonth
            // 
            this.comboBox_toMonth.FormattingEnabled = true;
            this.comboBox_toMonth.Location = new System.Drawing.Point(326, 70);
            this.comboBox_toMonth.Name = "comboBox_toMonth";
            this.comboBox_toMonth.Size = new System.Drawing.Size(80, 21);
            this.comboBox_toMonth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bills";
            // 
            // linkLabel_billCount
            // 
            this.linkLabel_billCount.AutoSize = true;
            this.linkLabel_billCount.Location = new System.Drawing.Point(236, 157);
            this.linkLabel_billCount.Name = "linkLabel_billCount";
            this.linkLabel_billCount.Size = new System.Drawing.Size(48, 13);
            this.linkLabel_billCount.TabIndex = 7;
            this.linkLabel_billCount.TabStop = true;
            this.linkLabel_billCount.Text = "BillCount";
            // 
            // button_fetchBills
            // 
            this.button_fetchBills.Location = new System.Drawing.Point(367, 126);
            this.button_fetchBills.Name = "button_fetchBills";
            this.button_fetchBills.Size = new System.Drawing.Size(75, 23);
            this.button_fetchBills.TabIndex = 8;
            this.button_fetchBills.Text = "Search";
            this.button_fetchBills.UseVisualStyleBackColor = true;
            this.button_fetchBills.Click += new System.EventHandler(this.button_fetchBills_Click);
            // 
            // dataGridView_bills
            // 
            this.dataGridView_bills.AllowUserToAddRows = false;
            this.dataGridView_bills.AllowUserToDeleteRows = false;
            this.dataGridView_bills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bills.Location = new System.Drawing.Point(12, 182);
            this.dataGridView_bills.Name = "dataGridView_bills";
            this.dataGridView_bills.ReadOnly = true;
            this.dataGridView_bills.RowHeadersVisible = false;
            this.dataGridView_bills.Size = new System.Drawing.Size(394, 233);
            this.dataGridView_bills.TabIndex = 9;
            // 
            // radioButton_allUsers
            // 
            this.radioButton_allUsers.AutoSize = true;
            this.radioButton_allUsers.Location = new System.Drawing.Point(179, 35);
            this.radioButton_allUsers.Name = "radioButton_allUsers";
            this.radioButton_allUsers.Size = new System.Drawing.Size(66, 17);
            this.radioButton_allUsers.TabIndex = 10;
            this.radioButton_allUsers.TabStop = true;
            this.radioButton_allUsers.Text = "All Users";
            this.radioButton_allUsers.UseVisualStyleBackColor = true;
            this.radioButton_allUsers.CheckedChanged += new System.EventHandler(this.radioButton_allUsers_CheckedChanged);
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Location = new System.Drawing.Point(179, 68);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(88, 17);
            this.radioButton_user.TabIndex = 11;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "Specific User";
            this.radioButton_user.UseVisualStyleBackColor = true;
            this.radioButton_user.CheckedChanged += new System.EventHandler(this.radioButton_user_CheckedChanged);
            // 
            // label_flatNumber
            // 
            this.label_flatNumber.AutoSize = true;
            this.label_flatNumber.Location = new System.Drawing.Point(12, 68);
            this.label_flatNumber.Name = "label_flatNumber";
            this.label_flatNumber.Size = new System.Drawing.Size(64, 13);
            this.label_flatNumber.TabIndex = 12;
            this.label_flatNumber.Text = "Flat Number";
            this.label_flatNumber.Visible = false;
            // 
            // groupBox_totalPayments
            // 
            this.groupBox_totalPayments.Controls.Add(this.textBox_pending);
            this.groupBox_totalPayments.Controls.Add(this.label5);
            this.groupBox_totalPayments.Controls.Add(this.textBox_amount);
            this.groupBox_totalPayments.Controls.Add(this.label4);
            this.groupBox_totalPayments.Location = new System.Drawing.Point(522, 13);
            this.groupBox_totalPayments.Name = "groupBox_totalPayments";
            this.groupBox_totalPayments.Size = new System.Drawing.Size(186, 402);
            this.groupBox_totalPayments.TabIndex = 14;
            this.groupBox_totalPayments.TabStop = false;
            this.groupBox_totalPayments.Text = "Total Amount";
            // 
            // textBox_pending
            // 
            this.textBox_pending.Location = new System.Drawing.Point(83, 115);
            this.textBox_pending.Name = "textBox_pending";
            this.textBox_pending.ReadOnly = true;
            this.textBox_pending.Size = new System.Drawing.Size(87, 20);
            this.textBox_pending.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Pending";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(83, 62);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.ReadOnly = true;
            this.textBox_amount.Size = new System.Drawing.Size(87, 20);
            this.textBox_amount.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Amount";
            // 
            // linkLabel_showPayments
            // 
            this.linkLabel_showPayments.AutoSize = true;
            this.linkLabel_showPayments.Location = new System.Drawing.Point(448, 131);
            this.linkLabel_showPayments.Name = "linkLabel_showPayments";
            this.linkLabel_showPayments.Size = new System.Drawing.Size(53, 13);
            this.linkLabel_showPayments.TabIndex = 15;
            this.linkLabel_showPayments.TabStop = true;
            this.linkLabel_showPayments.Text = "Payments";
            this.linkLabel_showPayments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_showPayments_LinkClicked);
            // 
            // comboBox_flatNumber
            // 
            this.comboBox_flatNumber.FormattingEnabled = true;
            this.comboBox_flatNumber.Location = new System.Drawing.Point(83, 68);
            this.comboBox_flatNumber.Name = "comboBox_flatNumber";
            this.comboBox_flatNumber.Size = new System.Drawing.Size(78, 21);
            this.comboBox_flatNumber.TabIndex = 16;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 436);
            this.Controls.Add(this.comboBox_flatNumber);
            this.Controls.Add(this.linkLabel_showPayments);
            this.Controls.Add(this.groupBox_totalPayments);
            this.Controls.Add(this.label_flatNumber);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.radioButton_allUsers);
            this.Controls.Add(this.dataGridView_bills);
            this.Controls.Add(this.button_fetchBills);
            this.Controls.Add(this.linkLabel_billCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_toYear);
            this.Controls.Add(this.comboBox_toMonth);
            this.Controls.Add(this.comboBox_fromYear);
            this.Controls.Add(this.comboBox_fromMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bills)).EndInit();
            this.groupBox_totalPayments.ResumeLayout(false);
            this.groupBox_totalPayments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_fromMonth;
        private System.Windows.Forms.ComboBox comboBox_fromYear;
        private System.Windows.Forms.ComboBox comboBox_toYear;
        private System.Windows.Forms.ComboBox comboBox_toMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel_billCount;
        private System.Windows.Forms.Button button_fetchBills;
        private System.Windows.Forms.DataGridView dataGridView_bills;
        private System.Windows.Forms.RadioButton radioButton_allUsers;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.Label label_flatNumber;
        private System.Windows.Forms.GroupBox groupBox_totalPayments;
        private System.Windows.Forms.LinkLabel linkLabel_showPayments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_pending;
        private System.Windows.Forms.ComboBox comboBox_flatNumber;
    }
}