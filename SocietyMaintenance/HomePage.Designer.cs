namespace SocietyMaintenance
{
    partial class HomePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_flatNumber = new System.Windows.Forms.ComboBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_searchUsers = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel_generateBill = new System.Windows.Forms.LinkLabel();
            this.linkLabel_userPayment = new System.Windows.Forms.LinkLabel();
            this.linkLabel_accounts = new System.Windows.Forms.LinkLabel();
            this.linkLabel_overall = new System.Windows.Forms.LinkLabel();
            this.linkLabel_getEmployees = new System.Windows.Forms.LinkLabel();
            this.linkLabel_expense = new System.Windows.Forms.LinkLabel();
            this.linkLabel_viewExpenses = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel_userFiles = new System.Windows.Forms.LinkLabel();
            this.linkLabel_sendFiles = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_addVisitor = new System.Windows.Forms.LinkLabel();
            this.linkLabel_employees = new System.Windows.Forms.LinkLabel();
            this.linkLabel_addUsers = new System.Windows.Forms.LinkLabel();
            this.linkLabel_adminFiles = new System.Windows.Forms.LinkLabel();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel_editUserDetails = new System.Windows.Forms.LinkLabel();
            this.linkLabel_userPaymentHistory = new System.Windows.Forms.LinkLabel();
            this.linkLabel_newPayment = new System.Windows.Forms.LinkLabel();
            this.linkLabel_userBill = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_bills = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.textBox_billAmount = new System.Windows.Forms.TextBox();
            this.textBox_paid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_carryForward = new System.Windows.Forms.TextBox();
            this.button_exportUserBills = new System.Windows.Forms.Button();
            this.button_exportPayments = new System.Windows.Forms.Button();
            this.progressBar_export = new System.Windows.Forms.ProgressBar();
            this.groupBox_userDetails = new System.Windows.Forms.GroupBox();
            this.linkLabel_visitorSearch = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox_userDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flat No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // comboBox_flatNumber
            // 
            this.comboBox_flatNumber.FormattingEnabled = true;
            this.comboBox_flatNumber.Location = new System.Drawing.Point(84, 30);
            this.comboBox_flatNumber.Name = "comboBox_flatNumber";
            this.comboBox_flatNumber.Size = new System.Drawing.Size(90, 21);
            this.comboBox_flatNumber.TabIndex = 2;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(84, 70);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(90, 20);
            this.textBox_username.TabIndex = 3;
            // 
            // button_searchUsers
            // 
            this.button_searchUsers.Location = new System.Drawing.Point(205, 48);
            this.button_searchUsers.Name = "button_searchUsers";
            this.button_searchUsers.Size = new System.Drawing.Size(75, 23);
            this.button_searchUsers.TabIndex = 4;
            this.button_searchUsers.Text = "Search";
            this.button_searchUsers.UseVisualStyleBackColor = true;
            this.button_searchUsers.Click += new System.EventHandler(this.button_searchUsers_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(286, 48);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(70, 23);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_refresh);
            this.groupBox1.Controls.Add(this.button_searchUsers);
            this.groupBox1.Controls.Add(this.textBox_username);
            this.groupBox1.Controls.Add(this.comboBox_flatNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // linkLabel_generateBill
            // 
            this.linkLabel_generateBill.AutoSize = true;
            this.linkLabel_generateBill.Location = new System.Drawing.Point(122, 265);
            this.linkLabel_generateBill.Name = "linkLabel_generateBill";
            this.linkLabel_generateBill.Size = new System.Drawing.Size(67, 13);
            this.linkLabel_generateBill.TabIndex = 1;
            this.linkLabel_generateBill.TabStop = true;
            this.linkLabel_generateBill.Text = "Generate Bill";
            this.linkLabel_generateBill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_generateBill_LinkClicked);
            // 
            // linkLabel_userPayment
            // 
            this.linkLabel_userPayment.AutoSize = true;
            this.linkLabel_userPayment.Location = new System.Drawing.Point(32, 265);
            this.linkLabel_userPayment.Name = "linkLabel_userPayment";
            this.linkLabel_userPayment.Size = new System.Drawing.Size(73, 13);
            this.linkLabel_userPayment.TabIndex = 2;
            this.linkLabel_userPayment.TabStop = true;
            this.linkLabel_userPayment.Text = "User Payment";
            this.linkLabel_userPayment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_userPayment_LinkClicked);
            // 
            // linkLabel_accounts
            // 
            this.linkLabel_accounts.AutoSize = true;
            this.linkLabel_accounts.Location = new System.Drawing.Point(41, 322);
            this.linkLabel_accounts.Name = "linkLabel_accounts";
            this.linkLabel_accounts.Size = new System.Drawing.Size(52, 13);
            this.linkLabel_accounts.TabIndex = 3;
            this.linkLabel_accounts.TabStop = true;
            this.linkLabel_accounts.Text = "Accounts";
            this.linkLabel_accounts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_accounts_LinkClicked);
            // 
            // linkLabel_overall
            // 
            this.linkLabel_overall.AutoSize = true;
            this.linkLabel_overall.Location = new System.Drawing.Point(122, 322);
            this.linkLabel_overall.Name = "linkLabel_overall";
            this.linkLabel_overall.Size = new System.Drawing.Size(40, 13);
            this.linkLabel_overall.TabIndex = 4;
            this.linkLabel_overall.TabStop = true;
            this.linkLabel_overall.Text = "Overall";
            this.linkLabel_overall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_overall_LinkClicked);
            // 
            // linkLabel_getEmployees
            // 
            this.linkLabel_getEmployees.AutoSize = true;
            this.linkLabel_getEmployees.Location = new System.Drawing.Point(45, 211);
            this.linkLabel_getEmployees.Name = "linkLabel_getEmployees";
            this.linkLabel_getEmployees.Size = new System.Drawing.Size(29, 13);
            this.linkLabel_getEmployees.TabIndex = 6;
            this.linkLabel_getEmployees.TabStop = true;
            this.linkLabel_getEmployees.Text = "Staff";
            this.linkLabel_getEmployees.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_getEmployees_LinkClicked);
            // 
            // linkLabel_expense
            // 
            this.linkLabel_expense.AutoSize = true;
            this.linkLabel_expense.Location = new System.Drawing.Point(102, 55);
            this.linkLabel_expense.Name = "linkLabel_expense";
            this.linkLabel_expense.Size = new System.Drawing.Size(70, 13);
            this.linkLabel_expense.TabIndex = 7;
            this.linkLabel_expense.TabStop = true;
            this.linkLabel_expense.Text = "Add Expense";
            this.linkLabel_expense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_expense_LinkClicked);
            // 
            // linkLabel_viewExpenses
            // 
            this.linkLabel_viewExpenses.AutoSize = true;
            this.linkLabel_viewExpenses.Location = new System.Drawing.Point(121, 211);
            this.linkLabel_viewExpenses.Name = "linkLabel_viewExpenses";
            this.linkLabel_viewExpenses.Size = new System.Drawing.Size(53, 13);
            this.linkLabel_viewExpenses.TabIndex = 8;
            this.linkLabel_viewExpenses.TabStop = true;
            this.linkLabel_viewExpenses.Text = "Expenses";
            this.linkLabel_viewExpenses.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_viewExpenses_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel_visitorSearch);
            this.groupBox2.Controls.Add(this.linkLabel_userFiles);
            this.groupBox2.Controls.Add(this.linkLabel_sendFiles);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.linkLabel_addVisitor);
            this.groupBox2.Controls.Add(this.linkLabel_employees);
            this.groupBox2.Controls.Add(this.linkLabel_addUsers);
            this.groupBox2.Controls.Add(this.linkLabel_adminFiles);
            this.groupBox2.Controls.Add(this.linkLabel_viewExpenses);
            this.groupBox2.Controls.Add(this.linkLabel_expense);
            this.groupBox2.Controls.Add(this.linkLabel_getEmployees);
            this.groupBox2.Controls.Add(this.linkLabel_overall);
            this.groupBox2.Controls.Add(this.linkLabel_accounts);
            this.groupBox2.Controls.Add(this.linkLabel_userPayment);
            this.groupBox2.Controls.Add(this.linkLabel_generateBill);
            this.groupBox2.Location = new System.Drawing.Point(978, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 474);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel_userFiles
            // 
            this.linkLabel_userFiles.AutoSize = true;
            this.linkLabel_userFiles.Location = new System.Drawing.Point(87, 130);
            this.linkLabel_userFiles.Name = "linkLabel_userFiles";
            this.linkLabel_userFiles.Size = new System.Drawing.Size(53, 13);
            this.linkLabel_userFiles.TabIndex = 19;
            this.linkLabel_userFiles.TabStop = true;
            this.linkLabel_userFiles.Text = "User Files";
            this.linkLabel_userFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_userFiles_LinkClicked);
            // 
            // linkLabel_sendFiles
            // 
            this.linkLabel_sendFiles.AutoSize = true;
            this.linkLabel_sendFiles.Location = new System.Drawing.Point(84, 157);
            this.linkLabel_sendFiles.Name = "linkLabel_sendFiles";
            this.linkLabel_sendFiles.Size = new System.Drawing.Size(56, 13);
            this.linkLabel_sendFiles.TabIndex = 18;
            this.linkLabel_sendFiles.TabStop = true;
            this.linkLabel_sendFiles.Text = "Send Files";
            this.linkLabel_sendFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_sendFiles_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(84, 157);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 17;
            // 
            // linkLabel_addVisitor
            // 
            this.linkLabel_addVisitor.AutoSize = true;
            this.linkLabel_addVisitor.Location = new System.Drawing.Point(28, 55);
            this.linkLabel_addVisitor.Name = "linkLabel_addVisitor";
            this.linkLabel_addVisitor.Size = new System.Drawing.Size(57, 13);
            this.linkLabel_addVisitor.TabIndex = 16;
            this.linkLabel_addVisitor.TabStop = true;
            this.linkLabel_addVisitor.Text = "Add Visitor";
            this.linkLabel_addVisitor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_addVisitor_LinkClicked_1);
            // 
            // linkLabel_employees
            // 
            this.linkLabel_employees.AutoSize = true;
            this.linkLabel_employees.Location = new System.Drawing.Point(99, 16);
            this.linkLabel_employees.Name = "linkLabel_employees";
            this.linkLabel_employees.Size = new System.Drawing.Size(75, 13);
            this.linkLabel_employees.TabIndex = 15;
            this.linkLabel_employees.TabStop = true;
            this.linkLabel_employees.Text = "Add Employee";
            this.linkLabel_employees.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_employees_LinkClicked);
            // 
            // linkLabel_addUsers
            // 
            this.linkLabel_addUsers.AutoSize = true;
            this.linkLabel_addUsers.Location = new System.Drawing.Point(28, 16);
            this.linkLabel_addUsers.Name = "linkLabel_addUsers";
            this.linkLabel_addUsers.Size = new System.Drawing.Size(46, 13);
            this.linkLabel_addUsers.TabIndex = 14;
            this.linkLabel_addUsers.TabStop = true;
            this.linkLabel_addUsers.Text = "Add Flat";
            this.linkLabel_addUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_addUsers_LinkClicked);
            // 
            // linkLabel_adminFiles
            // 
            this.linkLabel_adminFiles.AutoSize = true;
            this.linkLabel_adminFiles.Location = new System.Drawing.Point(80, 104);
            this.linkLabel_adminFiles.Name = "linkLabel_adminFiles";
            this.linkLabel_adminFiles.Size = new System.Drawing.Size(60, 13);
            this.linkLabel_adminFiles.TabIndex = 9;
            this.linkLabel_adminFiles.TabStop = true;
            this.linkLabel_adminFiles.Text = "Admin Files";
            this.linkLabel_adminFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_adminFiles_LinkClicked);
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.AllowUserToAddRows = false;
            this.dataGridView_users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            this.dataGridView_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_users.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.ReadOnly = true;
            this.dataGridView_users.RowHeadersVisible = false;
            this.dataGridView_users.Size = new System.Drawing.Size(371, 306);
            this.dataGridView_users.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_users);
            this.groupBox3.Location = new System.Drawing.Point(29, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 325);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Users";
            // 
            // linkLabel_editUserDetails
            // 
            this.linkLabel_editUserDetails.AutoSize = true;
            this.linkLabel_editUserDetails.Location = new System.Drawing.Point(79, 37);
            this.linkLabel_editUserDetails.Name = "linkLabel_editUserDetails";
            this.linkLabel_editUserDetails.Size = new System.Drawing.Size(50, 13);
            this.linkLabel_editUserDetails.TabIndex = 0;
            this.linkLabel_editUserDetails.TabStop = true;
            this.linkLabel_editUserDetails.Text = "Edit User";
            this.linkLabel_editUserDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_editUserDetails_LinkClicked);
            // 
            // linkLabel_userPaymentHistory
            // 
            this.linkLabel_userPaymentHistory.AutoSize = true;
            this.linkLabel_userPaymentHistory.Location = new System.Drawing.Point(359, 38);
            this.linkLabel_userPaymentHistory.Name = "linkLabel_userPaymentHistory";
            this.linkLabel_userPaymentHistory.Size = new System.Drawing.Size(115, 13);
            this.linkLabel_userPaymentHistory.TabIndex = 1;
            this.linkLabel_userPaymentHistory.TabStop = true;
            this.linkLabel_userPaymentHistory.Text = "User\'s Payment History";
            this.linkLabel_userPaymentHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_userPaymentHistory_LinkClicked);
            // 
            // linkLabel_newPayment
            // 
            this.linkLabel_newPayment.AutoSize = true;
            this.linkLabel_newPayment.Location = new System.Drawing.Point(380, 91);
            this.linkLabel_newPayment.Name = "linkLabel_newPayment";
            this.linkLabel_newPayment.Size = new System.Drawing.Size(73, 13);
            this.linkLabel_newPayment.TabIndex = 2;
            this.linkLabel_newPayment.TabStop = true;
            this.linkLabel_newPayment.Text = "New Payment";
            this.linkLabel_newPayment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_newPayment_LinkClicked);
            // 
            // linkLabel_userBill
            // 
            this.linkLabel_userBill.AutoSize = true;
            this.linkLabel_userBill.Location = new System.Drawing.Point(82, 91);
            this.linkLabel_userBill.Name = "linkLabel_userBill";
            this.linkLabel_userBill.Size = new System.Drawing.Size(45, 13);
            this.linkLabel_userBill.TabIndex = 3;
            this.linkLabel_userBill.TabStop = true;
            this.linkLabel_userBill.Text = "New Bill";
            this.linkLabel_userBill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_userBill_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Bills";
            // 
            // linkLabel_bills
            // 
            this.linkLabel_bills.AutoSize = true;
            this.linkLabel_bills.Location = new System.Drawing.Point(252, 192);
            this.linkLabel_bills.Name = "linkLabel_bills";
            this.linkLabel_bills.Size = new System.Drawing.Size(55, 13);
            this.linkLabel_bills.TabIndex = 5;
            this.linkLabel_bills.TabStop = true;
            this.linkLabel_bills.Text = "linkLabel1";
            this.linkLabel_bills.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_bills_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Bill Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Paid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Balance";
            // 
            // textBox_balance
            // 
            this.textBox_balance.Location = new System.Drawing.Point(249, 342);
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.ReadOnly = true;
            this.textBox_balance.Size = new System.Drawing.Size(90, 20);
            this.textBox_balance.TabIndex = 5;
            // 
            // textBox_billAmount
            // 
            this.textBox_billAmount.Location = new System.Drawing.Point(249, 247);
            this.textBox_billAmount.Name = "textBox_billAmount";
            this.textBox_billAmount.ReadOnly = true;
            this.textBox_billAmount.Size = new System.Drawing.Size(90, 20);
            this.textBox_billAmount.TabIndex = 9;
            // 
            // textBox_paid
            // 
            this.textBox_paid.Location = new System.Drawing.Point(249, 292);
            this.textBox_paid.Name = "textBox_paid";
            this.textBox_paid.ReadOnly = true;
            this.textBox_paid.Size = new System.Drawing.Size(90, 20);
            this.textBox_paid.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CarryForward Amount";
            // 
            // textBox_carryForward
            // 
            this.textBox_carryForward.Location = new System.Drawing.Point(249, 386);
            this.textBox_carryForward.Name = "textBox_carryForward";
            this.textBox_carryForward.ReadOnly = true;
            this.textBox_carryForward.Size = new System.Drawing.Size(90, 20);
            this.textBox_carryForward.TabIndex = 12;
            // 
            // button_exportUserBills
            // 
            this.button_exportUserBills.Location = new System.Drawing.Point(157, 104);
            this.button_exportUserBills.Name = "button_exportUserBills";
            this.button_exportUserBills.Size = new System.Drawing.Size(75, 23);
            this.button_exportUserBills.TabIndex = 13;
            this.button_exportUserBills.Text = "Export Bills";
            this.button_exportUserBills.UseVisualStyleBackColor = true;
            this.button_exportUserBills.Click += new System.EventHandler(this.button_exportUserBills_Click);
            // 
            // button_exportPayments
            // 
            this.button_exportPayments.Location = new System.Drawing.Point(255, 104);
            this.button_exportPayments.Name = "button_exportPayments";
            this.button_exportPayments.Size = new System.Drawing.Size(107, 23);
            this.button_exportPayments.TabIndex = 14;
            this.button_exportPayments.Text = "Export Payments";
            this.button_exportPayments.UseVisualStyleBackColor = true;
            this.button_exportPayments.Click += new System.EventHandler(this.button_exportPayments_Click);
            // 
            // progressBar_export
            // 
            this.progressBar_export.Location = new System.Drawing.Point(173, 141);
            this.progressBar_export.Name = "progressBar_export";
            this.progressBar_export.Size = new System.Drawing.Size(166, 23);
            this.progressBar_export.TabIndex = 15;
            // 
            // groupBox_userDetails
            // 
            this.groupBox_userDetails.Controls.Add(this.progressBar_export);
            this.groupBox_userDetails.Controls.Add(this.button_exportPayments);
            this.groupBox_userDetails.Controls.Add(this.button_exportUserBills);
            this.groupBox_userDetails.Controls.Add(this.textBox_carryForward);
            this.groupBox_userDetails.Controls.Add(this.label7);
            this.groupBox_userDetails.Controls.Add(this.textBox_paid);
            this.groupBox_userDetails.Controls.Add(this.textBox_billAmount);
            this.groupBox_userDetails.Controls.Add(this.textBox_balance);
            this.groupBox_userDetails.Controls.Add(this.label6);
            this.groupBox_userDetails.Controls.Add(this.label5);
            this.groupBox_userDetails.Controls.Add(this.label4);
            this.groupBox_userDetails.Controls.Add(this.linkLabel_bills);
            this.groupBox_userDetails.Controls.Add(this.label3);
            this.groupBox_userDetails.Controls.Add(this.linkLabel_userBill);
            this.groupBox_userDetails.Controls.Add(this.linkLabel_newPayment);
            this.groupBox_userDetails.Controls.Add(this.linkLabel_userPaymentHistory);
            this.groupBox_userDetails.Controls.Add(this.linkLabel_editUserDetails);
            this.groupBox_userDetails.Location = new System.Drawing.Point(412, 12);
            this.groupBox_userDetails.Name = "groupBox_userDetails";
            this.groupBox_userDetails.Size = new System.Drawing.Size(560, 474);
            this.groupBox_userDetails.TabIndex = 3;
            this.groupBox_userDetails.TabStop = false;
            this.groupBox_userDetails.Text = "User Details";
            this.groupBox_userDetails.Visible = false;
            // 
            // linkLabel_visitorSearch
            // 
            this.linkLabel_visitorSearch.AutoSize = true;
            this.linkLabel_visitorSearch.Location = new System.Drawing.Point(38, 364);
            this.linkLabel_visitorSearch.Name = "linkLabel_visitorSearch";
            this.linkLabel_visitorSearch.Size = new System.Drawing.Size(72, 13);
            this.linkLabel_visitorSearch.TabIndex = 20;
            this.linkLabel_visitorSearch.TabStop = true;
            this.linkLabel_visitorSearch.Text = "Visitor Search";
            this.linkLabel_visitorSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_visitorSearch_LinkClicked);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 498);
            this.Controls.Add(this.groupBox_userDetails);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Society Maintenance";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox_userDetails.ResumeLayout(false);
            this.groupBox_userDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_flatNumber;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Button button_searchUsers;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel_generateBill;
        private System.Windows.Forms.LinkLabel linkLabel_userPayment;
        private System.Windows.Forms.LinkLabel linkLabel_accounts;
        private System.Windows.Forms.LinkLabel linkLabel_overall;
        private System.Windows.Forms.LinkLabel linkLabel_getEmployees;
        private System.Windows.Forms.LinkLabel linkLabel_expense;
        private System.Windows.Forms.LinkLabel linkLabel_viewExpenses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel_editUserDetails;
        private System.Windows.Forms.LinkLabel linkLabel_userPaymentHistory;
        private System.Windows.Forms.LinkLabel linkLabel_newPayment;
        private System.Windows.Forms.LinkLabel linkLabel_userBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel_bills;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.TextBox textBox_billAmount;
        private System.Windows.Forms.TextBox textBox_paid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_carryForward;
        private System.Windows.Forms.Button button_exportUserBills;
        private System.Windows.Forms.Button button_exportPayments;
        private System.Windows.Forms.ProgressBar progressBar_export;
        private System.Windows.Forms.GroupBox groupBox_userDetails;
        private System.Windows.Forms.LinkLabel linkLabel_adminFiles;
        private System.Windows.Forms.LinkLabel linkLabel_addVisitor;
        private System.Windows.Forms.LinkLabel linkLabel_employees;
        private System.Windows.Forms.LinkLabel linkLabel_addUsers;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel_sendFiles;
        private System.Windows.Forms.LinkLabel linkLabel_userFiles;
        private System.Windows.Forms.LinkLabel linkLabel_visitorSearch;


    }
}

