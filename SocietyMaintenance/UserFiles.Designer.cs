namespace SocietyMaintenance
{
    partial class UserFiles
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
            this.comboBox_flatNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_tenant = new System.Windows.Forms.ComboBox();
            this.dataGridView_ownerFiles = new System.Windows.Forms.DataGridView();
            this.dataGridView_tenantFiles = new System.Windows.Forms.DataGridView();
            this.button_ownerFileDownload = new System.Windows.Forms.Button();
            this.button_tenantFileDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ownerFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tenantFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flat";
            // 
            // comboBox_flatNumber
            // 
            this.comboBox_flatNumber.FormattingEnabled = true;
            this.comboBox_flatNumber.Location = new System.Drawing.Point(100, 22);
            this.comboBox_flatNumber.Name = "comboBox_flatNumber";
            this.comboBox_flatNumber.Size = new System.Drawing.Size(121, 21);
            this.comboBox_flatNumber.TabIndex = 1;
            this.comboBox_flatNumber.SelectedIndexChanged += new System.EventHandler(this.comboBox_flatNumber_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tenant";
            // 
            // comboBox_tenant
            // 
            this.comboBox_tenant.FormattingEnabled = true;
            this.comboBox_tenant.Location = new System.Drawing.Point(345, 22);
            this.comboBox_tenant.Name = "comboBox_tenant";
            this.comboBox_tenant.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tenant.TabIndex = 3;
            this.comboBox_tenant.SelectedIndexChanged += new System.EventHandler(this.comboBox_tenant_SelectedIndexChanged);
            // 
            // dataGridView_ownerFiles
            // 
            this.dataGridView_ownerFiles.AllowUserToAddRows = false;
            this.dataGridView_ownerFiles.AllowUserToDeleteRows = false;
            this.dataGridView_ownerFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ownerFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ownerFiles.Location = new System.Drawing.Point(22, 131);
            this.dataGridView_ownerFiles.Name = "dataGridView_ownerFiles";
            this.dataGridView_ownerFiles.ReadOnly = true;
            this.dataGridView_ownerFiles.RowHeadersVisible = false;
            this.dataGridView_ownerFiles.Size = new System.Drawing.Size(240, 174);
            this.dataGridView_ownerFiles.TabIndex = 4;
            // 
            // dataGridView_tenantFiles
            // 
            this.dataGridView_tenantFiles.AllowUserToAddRows = false;
            this.dataGridView_tenantFiles.AllowUserToDeleteRows = false;
            this.dataGridView_tenantFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tenantFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tenantFiles.Location = new System.Drawing.Point(289, 131);
            this.dataGridView_tenantFiles.Name = "dataGridView_tenantFiles";
            this.dataGridView_tenantFiles.ReadOnly = true;
            this.dataGridView_tenantFiles.RowHeadersVisible = false;
            this.dataGridView_tenantFiles.Size = new System.Drawing.Size(240, 174);
            this.dataGridView_tenantFiles.TabIndex = 5;
            // 
            // button_ownerFileDownload
            // 
            this.button_ownerFileDownload.Location = new System.Drawing.Point(100, 332);
            this.button_ownerFileDownload.Name = "button_ownerFileDownload";
            this.button_ownerFileDownload.Size = new System.Drawing.Size(75, 23);
            this.button_ownerFileDownload.TabIndex = 6;
            this.button_ownerFileDownload.Text = "Download";
            this.button_ownerFileDownload.UseVisualStyleBackColor = true;
            this.button_ownerFileDownload.Click += new System.EventHandler(this.button_ownerFileDownload_Click);
            // 
            // button_tenantFileDownload
            // 
            this.button_tenantFileDownload.Location = new System.Drawing.Point(368, 332);
            this.button_tenantFileDownload.Name = "button_tenantFileDownload";
            this.button_tenantFileDownload.Size = new System.Drawing.Size(75, 23);
            this.button_tenantFileDownload.TabIndex = 7;
            this.button_tenantFileDownload.Text = "Download";
            this.button_tenantFileDownload.UseVisualStyleBackColor = true;
            this.button_tenantFileDownload.Click += new System.EventHandler(this.button_tenantFileDownload_Click);
            // 
            // UserFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 390);
            this.Controls.Add(this.button_tenantFileDownload);
            this.Controls.Add(this.button_ownerFileDownload);
            this.Controls.Add(this.dataGridView_tenantFiles);
            this.Controls.Add(this.dataGridView_ownerFiles);
            this.Controls.Add(this.comboBox_tenant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_flatNumber);
            this.Controls.Add(this.label1);
            this.Name = "UserFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserFiles";
            this.Load += new System.EventHandler(this.UserFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ownerFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tenantFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_flatNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_tenant;
        private System.Windows.Forms.DataGridView dataGridView_ownerFiles;
        private System.Windows.Forms.DataGridView dataGridView_tenantFiles;
        private System.Windows.Forms.Button button_ownerFileDownload;
        private System.Windows.Forms.Button button_tenantFileDownload;
    }
}