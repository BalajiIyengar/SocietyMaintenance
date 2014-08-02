namespace SocietyMaintenance
{
    partial class UserPayments
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
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_ownerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_flatNumbers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_paymentMode = new System.Windows.Forms.TextBox();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.button_addPayment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_paymentDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_owner = new System.Windows.Forms.TextBox();
            this.label_ownerName = new System.Windows.Forms.Label();
            this.groupBox_search.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_search
            // 
            this.groupBox_search.Controls.Add(this.button_search);
            this.groupBox_search.Controls.Add(this.textBox_ownerName);
            this.groupBox_search.Controls.Add(this.label2);
            this.groupBox_search.Controls.Add(this.label1);
            this.groupBox_search.Controls.Add(this.comboBox_flatNumbers);
            this.groupBox_search.Location = new System.Drawing.Point(13, 13);
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.Size = new System.Drawing.Size(363, 141);
            this.groupBox_search.TabIndex = 0;
            this.groupBox_search.TabStop = false;
            this.groupBox_search.Text = "Search";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(207, 44);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_ownerName
            // 
            this.textBox_ownerName.Location = new System.Drawing.Point(70, 60);
            this.textBox_ownerName.Name = "textBox_ownerName";
            this.textBox_ownerName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ownerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Owner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flat";
            // 
            // comboBox_flatNumbers
            // 
            this.comboBox_flatNumbers.FormattingEnabled = true;
            this.comboBox_flatNumbers.Location = new System.Drawing.Point(72, 29);
            this.comboBox_flatNumbers.Name = "comboBox_flatNumbers";
            this.comboBox_flatNumbers.Size = new System.Drawing.Size(98, 21);
            this.comboBox_flatNumbers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_users);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users";
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.AllowUserToAddRows = false;
            this.dataGridView_users.AllowUserToDeleteRows = false;
            this.dataGridView_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_users.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.ReadOnly = true;
            this.dataGridView_users.RowHeadersVisible = false;
            this.dataGridView_users.Size = new System.Drawing.Size(360, 262);
            this.dataGridView_users.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_paymentMode);
            this.groupBox3.Controls.Add(this.comboBox_year);
            this.groupBox3.Controls.Add(this.comboBox_month);
            this.groupBox3.Controls.Add(this.button_addPayment);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePicker_paymentDate);
            this.groupBox3.Controls.Add(this.textBox_amount);
            this.groupBox3.Controls.Add(this.textBox_owner);
            this.groupBox3.Controls.Add(this.label_ownerName);
            this.groupBox3.Location = new System.Drawing.Point(466, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 410);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Payment Mode";
            // 
            // textBox_paymentMode
            // 
            this.textBox_paymentMode.Location = new System.Drawing.Point(136, 75);
            this.textBox_paymentMode.Name = "textBox_paymentMode";
            this.textBox_paymentMode.Size = new System.Drawing.Size(100, 20);
            this.textBox_paymentMode.TabIndex = 11;
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(220, 190);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(69, 21);
            this.comboBox_year.TabIndex = 10;
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(136, 190);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(70, 21);
            this.comboBox_month.TabIndex = 9;
            // 
            // button_addPayment
            // 
            this.button_addPayment.Location = new System.Drawing.Point(92, 251);
            this.button_addPayment.Name = "button_addPayment";
            this.button_addPayment.Size = new System.Drawing.Size(103, 23);
            this.button_addPayment.TabIndex = 8;
            this.button_addPayment.Text = "Add payment";
            this.button_addPayment.UseVisualStyleBackColor = true;
            this.button_addPayment.Click += new System.EventHandler(this.button_addPayment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Payment For Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount";
            // 
            // dateTimePicker_paymentDate
            // 
            this.dateTimePicker_paymentDate.Location = new System.Drawing.Point(135, 147);
            this.dateTimePicker_paymentDate.Name = "dateTimePicker_paymentDate";
            this.dateTimePicker_paymentDate.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker_paymentDate.TabIndex = 3;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(135, 108);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount.TabIndex = 2;
            // 
            // textBox_owner
            // 
            this.textBox_owner.Location = new System.Drawing.Point(116, 28);
            this.textBox_owner.Name = "textBox_owner";
            this.textBox_owner.ReadOnly = true;
            this.textBox_owner.Size = new System.Drawing.Size(100, 20);
            this.textBox_owner.TabIndex = 1;
            // 
            // label_ownerName
            // 
            this.label_ownerName.AutoSize = true;
            this.label_ownerName.Location = new System.Drawing.Point(56, 31);
            this.label_ownerName.Name = "label_ownerName";
            this.label_ownerName.Size = new System.Drawing.Size(38, 13);
            this.label_ownerName.TabIndex = 0;
            this.label_ownerName.Text = "Owner";
            // 
            // UserPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_search);
            this.Name = "UserPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPayments";
            this.Load += new System.EventHandler(this.UserPayments_Load);
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_ownerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_flatNumbers;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_paymentDate;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_owner;
        private System.Windows.Forms.Label label_ownerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_addPayment;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_paymentMode;
    }
}