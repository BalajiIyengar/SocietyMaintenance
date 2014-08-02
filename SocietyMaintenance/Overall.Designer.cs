namespace SocietyMaintenance
{
    partial class Overall
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
            this.dataGridView_bills = new System.Windows.Forms.DataGridView();
            this.dataGridView_paid = new System.Windows.Forms.DataGridView();
            this.comboBox_flatNumbers_Bills = new System.Windows.Forms.ComboBox();
            this.comboBox_flatNumbers_paid = new System.Windows.Forms.ComboBox();
            this.button_filterBills = new System.Windows.Forms.Button();
            this.button_filterPaid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_bills
            // 
            this.dataGridView_bills.AllowUserToAddRows = false;
            this.dataGridView_bills.AllowUserToDeleteRows = false;
            this.dataGridView_bills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bills.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_bills.Location = new System.Drawing.Point(30, 92);
            this.dataGridView_bills.Name = "dataGridView_bills";
            this.dataGridView_bills.ReadOnly = true;
            this.dataGridView_bills.RowHeadersVisible = false;
            this.dataGridView_bills.Size = new System.Drawing.Size(365, 386);
            this.dataGridView_bills.TabIndex = 0;
            // 
            // dataGridView_paid
            // 
            this.dataGridView_paid.AllowUserToAddRows = false;
            this.dataGridView_paid.AllowUserToDeleteRows = false;
            this.dataGridView_paid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_paid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_paid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_paid.Location = new System.Drawing.Point(521, 92);
            this.dataGridView_paid.Name = "dataGridView_paid";
            this.dataGridView_paid.ReadOnly = true;
            this.dataGridView_paid.RowHeadersVisible = false;
            this.dataGridView_paid.Size = new System.Drawing.Size(365, 386);
            this.dataGridView_paid.TabIndex = 1;
            // 
            // comboBox_flatNumbers_Bills
            // 
            this.comboBox_flatNumbers_Bills.FormattingEnabled = true;
            this.comboBox_flatNumbers_Bills.Location = new System.Drawing.Point(86, 33);
            this.comboBox_flatNumbers_Bills.Name = "comboBox_flatNumbers_Bills";
            this.comboBox_flatNumbers_Bills.Size = new System.Drawing.Size(121, 21);
            this.comboBox_flatNumbers_Bills.TabIndex = 2;
            // 
            // comboBox_flatNumbers_paid
            // 
            this.comboBox_flatNumbers_paid.FormattingEnabled = true;
            this.comboBox_flatNumbers_paid.Location = new System.Drawing.Point(563, 33);
            this.comboBox_flatNumbers_paid.Name = "comboBox_flatNumbers_paid";
            this.comboBox_flatNumbers_paid.Size = new System.Drawing.Size(121, 21);
            this.comboBox_flatNumbers_paid.TabIndex = 3;
            // 
            // button_filterBills
            // 
            this.button_filterBills.Location = new System.Drawing.Point(260, 33);
            this.button_filterBills.Name = "button_filterBills";
            this.button_filterBills.Size = new System.Drawing.Size(75, 23);
            this.button_filterBills.TabIndex = 4;
            this.button_filterBills.Text = "Filter";
            this.button_filterBills.UseVisualStyleBackColor = true;
            this.button_filterBills.Click += new System.EventHandler(this.button_filterBills_Click);
            // 
            // button_filterPaid
            // 
            this.button_filterPaid.Location = new System.Drawing.Point(731, 33);
            this.button_filterPaid.Name = "button_filterPaid";
            this.button_filterPaid.Size = new System.Drawing.Size(75, 23);
            this.button_filterPaid.TabIndex = 5;
            this.button_filterPaid.Text = "Filter";
            this.button_filterPaid.UseVisualStyleBackColor = true;
            this.button_filterPaid.Click += new System.EventHandler(this.button_filterPaid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(205, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bills";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(680, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Payments";
            // 
            // Overall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_filterPaid);
            this.Controls.Add(this.button_filterBills);
            this.Controls.Add(this.comboBox_flatNumbers_paid);
            this.Controls.Add(this.comboBox_flatNumbers_Bills);
            this.Controls.Add(this.dataGridView_paid);
            this.Controls.Add(this.dataGridView_bills);
            this.Name = "Overall";
            this.Text = "Overall";
            this.Load += new System.EventHandler(this.Overall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_bills;
        private System.Windows.Forms.DataGridView dataGridView_paid;
        private System.Windows.Forms.ComboBox comboBox_flatNumbers_Bills;
        private System.Windows.Forms.ComboBox comboBox_flatNumbers_paid;
        private System.Windows.Forms.Button button_filterBills;
        private System.Windows.Forms.Button button_filterPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}