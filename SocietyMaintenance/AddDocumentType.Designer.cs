namespace SocietyMaintenance
{
    partial class AddDocumentType
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
            this.textBox_newDocType = new System.Windows.Forms.TextBox();
            this.button_addNewDocType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Doc Type";
            // 
            // textBox_newDocType
            // 
            this.textBox_newDocType.Location = new System.Drawing.Point(126, 37);
            this.textBox_newDocType.Name = "textBox_newDocType";
            this.textBox_newDocType.Size = new System.Drawing.Size(100, 20);
            this.textBox_newDocType.TabIndex = 1;
            // 
            // button_addNewDocType
            // 
            this.button_addNewDocType.Location = new System.Drawing.Point(78, 87);
            this.button_addNewDocType.Name = "button_addNewDocType";
            this.button_addNewDocType.Size = new System.Drawing.Size(75, 23);
            this.button_addNewDocType.TabIndex = 2;
            this.button_addNewDocType.Text = "Add";
            this.button_addNewDocType.UseVisualStyleBackColor = true;
            this.button_addNewDocType.Click += new System.EventHandler(this.button_addNewDocType_Click);
            // 
            // AddDocumentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 165);
            this.Controls.Add(this.button_addNewDocType);
            this.Controls.Add(this.textBox_newDocType);
            this.Controls.Add(this.label1);
            this.Name = "AddDocumentType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDocumentType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_newDocType;
        private System.Windows.Forms.Button button_addNewDocType;
    }
}