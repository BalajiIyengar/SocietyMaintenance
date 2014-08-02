namespace SocietyMaintenance
{
    partial class Expenses
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
            this.dataGridView_expenses = new System.Windows.Forms.DataGridView();
            this.label_totalExpense = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_expenses
            // 
            this.dataGridView_expenses.AllowUserToAddRows = false;
            this.dataGridView_expenses.AllowUserToDeleteRows = false;
            this.dataGridView_expenses.AllowUserToResizeRows = false;
            this.dataGridView_expenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_expenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_expenses.Location = new System.Drawing.Point(12, 118);
            this.dataGridView_expenses.Name = "dataGridView_expenses";
            this.dataGridView_expenses.ReadOnly = true;
            this.dataGridView_expenses.RowHeadersVisible = false;
            this.dataGridView_expenses.Size = new System.Drawing.Size(529, 309);
            this.dataGridView_expenses.TabIndex = 0;
            // 
            // label_totalExpense
            // 
            this.label_totalExpense.AutoSize = true;
            this.label_totalExpense.Location = new System.Drawing.Point(476, 32);
            this.label_totalExpense.Name = "label_totalExpense";
            this.label_totalExpense.Size = new System.Drawing.Size(35, 13);
            this.label_totalExpense.TabIndex = 1;
            this.label_totalExpense.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(231, 24);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(71, 21);
            this.comboBox_year.TabIndex = 3;
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(128, 24);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(70, 21);
            this.comboBox_month.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Month & Year";
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(167, 70);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(75, 23);
            this.button_filter.TabIndex = 6;
            this.button_filter.Text = "Filter";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 439);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_totalExpense);
            this.Controls.Add(this.dataGridView_expenses);
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_expenses;
        private System.Windows.Forms.Label label_totalExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_filter;
    }
}