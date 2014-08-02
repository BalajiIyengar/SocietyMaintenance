namespace SocietyMaintenance
{
    partial class Employees
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
            this.textBox_employeeName = new System.Windows.Forms.TextBox();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_addEmployee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_browse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_updateEmployeeDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // textBox_employeeName
            // 
            this.textBox_employeeName.Location = new System.Drawing.Point(148, 51);
            this.textBox_employeeName.Name = "textBox_employeeName";
            this.textBox_employeeName.Size = new System.Drawing.Size(100, 20);
            this.textBox_employeeName.TabIndex = 1;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(148, 90);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_phoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(148, 129);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(100, 20);
            this.textBox_address.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(148, 171);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(100, 20);
            this.textBox_salary.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salary";
            // 
            // button_addEmployee
            // 
            this.button_addEmployee.Location = new System.Drawing.Point(95, 393);
            this.button_addEmployee.Name = "button_addEmployee";
            this.button_addEmployee.Size = new System.Drawing.Size(75, 23);
            this.button_addEmployee.TabIndex = 10;
            this.button_addEmployee.Text = "Add";
            this.button_addEmployee.UseVisualStyleBackColor = true;
            this.button_addEmployee.Click += new System.EventHandler(this.button_addEmployee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Image";
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(148, 211);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 12;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(276, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 461);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button_updateEmployeeDetails
            // 
            this.button_updateEmployeeDetails.Location = new System.Drawing.Point(95, 346);
            this.button_updateEmployeeDetails.Name = "button_updateEmployeeDetails";
            this.button_updateEmployeeDetails.Size = new System.Drawing.Size(75, 23);
            this.button_updateEmployeeDetails.TabIndex = 14;
            this.button_updateEmployeeDetails.Text = "Update";
            this.button_updateEmployeeDetails.UseVisualStyleBackColor = true;
            this.button_updateEmployeeDetails.Visible = false;
            this.button_updateEmployeeDetails.Click += new System.EventHandler(this.button_updateEmployeeDetails_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 494);
            this.Controls.Add(this.button_updateEmployeeDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_addEmployee);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_phoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_employeeName);
            this.Controls.Add(this.label1);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_employeeName;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_addEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_updateEmployeeDetails;
    }
}