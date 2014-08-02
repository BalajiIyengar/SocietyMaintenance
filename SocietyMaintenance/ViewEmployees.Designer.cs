namespace SocietyMaintenance
{
    partial class ViewEmployees
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
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.AllowUserToAddRows = false;
            this.dataGridView_employees.AllowUserToDeleteRows = false;
            this.dataGridView_employees.AllowUserToResizeRows = false;
            this.dataGridView_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employees.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_employees.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_employees.Name = "dataGridView_employees";
            this.dataGridView_employees.RowHeadersVisible = false;
            this.dataGridView_employees.Size = new System.Drawing.Size(526, 386);
            this.dataGridView_employees.TabIndex = 0;
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 386);
            this.Controls.Add(this.dataGridView_employees);
            this.Name = "ViewEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployees";
            this.Load += new System.EventHandler(this.ViewEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_employees;
    }
}