namespace SocietyMaintenance
{
    partial class VisitorSearch
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
            this.dataGridView_visitors = new System.Windows.Forms.DataGridView();
            this.label_visitorCount = new System.Windows.Forms.Label();
            this.groupBox_searchVisitors = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_toDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fromDate = new System.Windows.Forms.DateTimePicker();
            this.button_searchVisitors = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_flatNumbers = new System.Windows.Forms.ComboBox();
            this.comboBox_visitorTypes = new System.Windows.Forms.ComboBox();
            this.checkBox_flat = new System.Windows.Forms.CheckBox();
            this.checkBox_visitor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visitors)).BeginInit();
            this.groupBox_searchVisitors.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_visitors
            // 
            this.dataGridView_visitors.AllowUserToAddRows = false;
            this.dataGridView_visitors.AllowUserToDeleteRows = false;
            this.dataGridView_visitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_visitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_visitors.Location = new System.Drawing.Point(13, 118);
            this.dataGridView_visitors.Name = "dataGridView_visitors";
            this.dataGridView_visitors.ReadOnly = true;
            this.dataGridView_visitors.RowHeadersVisible = false;
            this.dataGridView_visitors.Size = new System.Drawing.Size(681, 320);
            this.dataGridView_visitors.TabIndex = 9;
            // 
            // label_visitorCount
            // 
            this.label_visitorCount.AutoSize = true;
            this.label_visitorCount.Location = new System.Drawing.Point(625, 81);
            this.label_visitorCount.Name = "label_visitorCount";
            this.label_visitorCount.Size = new System.Drawing.Size(35, 13);
            this.label_visitorCount.TabIndex = 10;
            this.label_visitorCount.Text = "Count";
            // 
            // groupBox_searchVisitors
            // 
            this.groupBox_searchVisitors.Controls.Add(this.checkBox_visitor);
            this.groupBox_searchVisitors.Controls.Add(this.checkBox_flat);
            this.groupBox_searchVisitors.Controls.Add(this.comboBox_visitorTypes);
            this.groupBox_searchVisitors.Controls.Add(this.comboBox_flatNumbers);
            this.groupBox_searchVisitors.Controls.Add(this.label1);
            this.groupBox_searchVisitors.Controls.Add(this.label4);
            this.groupBox_searchVisitors.Controls.Add(this.label3);
            this.groupBox_searchVisitors.Controls.Add(this.dateTimePicker_toDate);
            this.groupBox_searchVisitors.Controls.Add(this.dateTimePicker_fromDate);
            this.groupBox_searchVisitors.Controls.Add(this.button_searchVisitors);
            this.groupBox_searchVisitors.Controls.Add(this.label2);
            this.groupBox_searchVisitors.Location = new System.Drawing.Point(13, 13);
            this.groupBox_searchVisitors.Name = "groupBox_searchVisitors";
            this.groupBox_searchVisitors.Size = new System.Drawing.Size(581, 100);
            this.groupBox_searchVisitors.TabIndex = 11;
            this.groupBox_searchVisitors.TabStop = false;
            this.groupBox_searchVisitors.Text = "Search Visitors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "From";
            // 
            // dateTimePicker_toDate
            // 
            this.dateTimePicker_toDate.Location = new System.Drawing.Point(306, 19);
            this.dateTimePicker_toDate.Name = "dateTimePicker_toDate";
            this.dateTimePicker_toDate.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker_toDate.TabIndex = 19;
            // 
            // dateTimePicker_fromDate
            // 
            this.dateTimePicker_fromDate.Location = new System.Drawing.Point(95, 19);
            this.dateTimePicker_fromDate.Name = "dateTimePicker_fromDate";
            this.dateTimePicker_fromDate.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker_fromDate.TabIndex = 18;
            // 
            // button_searchVisitors
            // 
            this.button_searchVisitors.Location = new System.Drawing.Point(467, 41);
            this.button_searchVisitors.Name = "button_searchVisitors";
            this.button_searchVisitors.Size = new System.Drawing.Size(75, 23);
            this.button_searchVisitors.TabIndex = 17;
            this.button_searchVisitors.Text = "Search";
            this.button_searchVisitors.UseVisualStyleBackColor = true;
            this.button_searchVisitors.Click += new System.EventHandler(this.button_searchVisitors_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Visitor Type";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Flat ";
            this.label1.Visible = false;
            // 
            // comboBox_flatNumbers
            // 
            this.comboBox_flatNumbers.FormattingEnabled = true;
            this.comboBox_flatNumbers.Location = new System.Drawing.Point(95, 73);
            this.comboBox_flatNumbers.Name = "comboBox_flatNumbers";
            this.comboBox_flatNumbers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_flatNumbers.TabIndex = 23;
            this.comboBox_flatNumbers.Visible = false;
            // 
            // comboBox_visitorTypes
            // 
            this.comboBox_visitorTypes.FormattingEnabled = true;
            this.comboBox_visitorTypes.Location = new System.Drawing.Point(306, 76);
            this.comboBox_visitorTypes.Name = "comboBox_visitorTypes";
            this.comboBox_visitorTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBox_visitorTypes.TabIndex = 24;
            this.comboBox_visitorTypes.Visible = false;
            // 
            // checkBox_flat
            // 
            this.checkBox_flat.AutoSize = true;
            this.checkBox_flat.Location = new System.Drawing.Point(35, 47);
            this.checkBox_flat.Name = "checkBox_flat";
            this.checkBox_flat.Size = new System.Drawing.Size(82, 17);
            this.checkBox_flat.TabIndex = 25;
            this.checkBox_flat.Text = "Filter by Flat";
            this.checkBox_flat.UseVisualStyleBackColor = true;
            this.checkBox_flat.CheckedChanged += new System.EventHandler(this.checkBox_flat_CheckedChanged);
            // 
            // checkBox_visitor
            // 
            this.checkBox_visitor.AutoSize = true;
            this.checkBox_visitor.Location = new System.Drawing.Point(259, 47);
            this.checkBox_visitor.Name = "checkBox_visitor";
            this.checkBox_visitor.Size = new System.Drawing.Size(93, 17);
            this.checkBox_visitor.TabIndex = 26;
            this.checkBox_visitor.Text = "Filter by Visitor";
            this.checkBox_visitor.UseVisualStyleBackColor = true;
            this.checkBox_visitor.CheckedChanged += new System.EventHandler(this.checkBox_visitor_CheckedChanged);
            // 
            // VisitorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.groupBox_searchVisitors);
            this.Controls.Add(this.label_visitorCount);
            this.Controls.Add(this.dataGridView_visitors);
            this.Name = "VisitorSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisitorSearch";
            this.Load += new System.EventHandler(this.VisitorSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visitors)).EndInit();
            this.groupBox_searchVisitors.ResumeLayout(false);
            this.groupBox_searchVisitors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_visitors;
        private System.Windows.Forms.Label label_visitorCount;
        private System.Windows.Forms.GroupBox groupBox_searchVisitors;
        private System.Windows.Forms.Button button_searchVisitors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_toDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fromDate;
        private System.Windows.Forms.CheckBox checkBox_visitor;
        private System.Windows.Forms.CheckBox checkBox_flat;
        private System.Windows.Forms.ComboBox comboBox_visitorTypes;
        private System.Windows.Forms.ComboBox comboBox_flatNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}