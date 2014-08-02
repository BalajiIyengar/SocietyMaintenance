namespace SocietyMaintenance
{
    partial class Admin_Files
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_downloadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_fileType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.button_uploadFile = new System.Windows.Forms.Button();
            this.dataGridView_files = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_files)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_files);
            this.groupBox1.Location = new System.Drawing.Point(33, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing Files";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_uploadFile);
            this.groupBox2.Controls.Add(this.textBox_fileName);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox_fileType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(305, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload File";
            // 
            // button_downloadFile
            // 
            this.button_downloadFile.Location = new System.Drawing.Point(110, 310);
            this.button_downloadFile.Name = "button_downloadFile";
            this.button_downloadFile.Size = new System.Drawing.Size(75, 23);
            this.button_downloadFile.TabIndex = 2;
            this.button_downloadFile.Text = "Download";
            this.button_downloadFile.UseVisualStyleBackColor = true;
            this.button_downloadFile.Click += new System.EventHandler(this.button_downloadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Type";
            // 
            // comboBox_fileType
            // 
            this.comboBox_fileType.FormattingEnabled = true;
            this.comboBox_fileType.Location = new System.Drawing.Point(108, 35);
            this.comboBox_fileType.Name = "comboBox_fileType";
            this.comboBox_fileType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_fileType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(50, 156);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(179, 20);
            this.textBox_fileName.TabIndex = 4;
            // 
            // button_uploadFile
            // 
            this.button_uploadFile.Location = new System.Drawing.Point(98, 234);
            this.button_uploadFile.Name = "button_uploadFile";
            this.button_uploadFile.Size = new System.Drawing.Size(75, 23);
            this.button_uploadFile.TabIndex = 5;
            this.button_uploadFile.Text = "Upload";
            this.button_uploadFile.UseVisualStyleBackColor = true;
            this.button_uploadFile.Click += new System.EventHandler(this.button_uploadFile_Click);
            // 
            // dataGridView_files
            // 
            this.dataGridView_files.AllowUserToAddRows = false;
            this.dataGridView_files.AllowUserToDeleteRows = false;
            this.dataGridView_files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_files.Location = new System.Drawing.Point(7, 20);
            this.dataGridView_files.Name = "dataGridView_files";
            this.dataGridView_files.ReadOnly = true;
            this.dataGridView_files.RowHeadersVisible = false;
            this.dataGridView_files.Size = new System.Drawing.Size(241, 237);
            this.dataGridView_files.TabIndex = 0;
            // 
            // Admin_Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 401);
            this.Controls.Add(this.button_downloadFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_Files";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Files";
            this.Load += new System.EventHandler(this.Admin_Files_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_files)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_downloadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_fileType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_uploadFile;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.DataGridView dataGridView_files;

    }
}