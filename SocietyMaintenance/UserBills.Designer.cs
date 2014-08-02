namespace SocietyMaintenance
{
    partial class UserBills
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
            this.dataGridView_userBills = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_userBills
            // 
            this.dataGridView_userBills.AllowUserToAddRows = false;
            this.dataGridView_userBills.AllowUserToDeleteRows = false;
            this.dataGridView_userBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_userBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_userBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_userBills.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_userBills.Name = "dataGridView_userBills";
            this.dataGridView_userBills.ReadOnly = true;
            this.dataGridView_userBills.RowHeadersVisible = false;
            this.dataGridView_userBills.Size = new System.Drawing.Size(474, 298);
            this.dataGridView_userBills.TabIndex = 0;
            // 
            // UserBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 298);
            this.Controls.Add(this.dataGridView_userBills);
            this.Name = "UserBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserBills";
            this.Load += new System.EventHandler(this.UserBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_userBills;
    }
}