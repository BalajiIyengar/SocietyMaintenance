namespace SocietyMaintenance
{
    partial class AddExpense
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
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.button_addExpense = new System.Windows.Forms.Button();
            this.textBox_comments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_expenseDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(167, 35);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount.TabIndex = 1;
            // 
            // button_addExpense
            // 
            this.button_addExpense.Location = new System.Drawing.Point(104, 205);
            this.button_addExpense.Name = "button_addExpense";
            this.button_addExpense.Size = new System.Drawing.Size(97, 23);
            this.button_addExpense.TabIndex = 2;
            this.button_addExpense.Text = "Add Expense";
            this.button_addExpense.UseVisualStyleBackColor = true;
            this.button_addExpense.Click += new System.EventHandler(this.button_addExpense_Click);
            // 
            // textBox_comments
            // 
            this.textBox_comments.Location = new System.Drawing.Point(167, 83);
            this.textBox_comments.Name = "textBox_comments";
            this.textBox_comments.Size = new System.Drawing.Size(100, 20);
            this.textBox_comments.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comments";
            // 
            // dateTimePicker_expenseDate
            // 
            this.dateTimePicker_expenseDate.Location = new System.Drawing.Point(167, 137);
            this.dateTimePicker_expenseDate.Name = "dateTimePicker_expenseDate";
            this.dateTimePicker_expenseDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker_expenseDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_expenseDate);
            this.Controls.Add(this.textBox_comments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_addExpense);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.label1);
            this.Name = "AddExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Button button_addExpense;
        private System.Windows.Forms.TextBox textBox_comments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_expenseDate;
        private System.Windows.Forms.Label label3;
    }
}