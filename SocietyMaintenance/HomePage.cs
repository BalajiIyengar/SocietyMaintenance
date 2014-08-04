using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SocietyMaintenance
{
    public partial class HomePage : Form
    {
        SMEntities db = CommonUtility.getConnection();
        long selectedFlatId = 0;

    
        public HomePage()
        {
            InitializeComponent();
        }

        private void button_searchUsers_Click(object sender, EventArgs e)
        {
            groupBox_userDetails.Visible = false;

            String username = "";
            if (textBox_username.Text.Trim().Length != 0)
                username = textBox_username.Text.Trim();


            long flatNumber = long.Parse(comboBox_flatNumber.Text);
            
            List<UserDetail> users = db.UserDetails.Where(x => x.FlatNumber == flatNumber && x.OwnerName.Contains(username)).ToList();
            dataGridView_users.DataSource = users;

            dataGridView_users.Columns["OwnerDetails"].Visible = false;
            dataGridView_users.Columns["LastPaid"].Visible = false;
            dataGridView_users.Columns["OwnerDetails"].Visible = false;

            dataGridView_users.CellClick -= dataGridView_users_clicked;
            dataGridView_users.CellClick += dataGridView_users_clicked;
        }

        private void dataGridView_users_clicked(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView button = sender as DataGridView;
            DataGridViewCellCollection selectedUser = button.CurrentRow.Cells as DataGridViewCellCollection;

            //Returns the selected FlatNumber ID
            Int32 flatId = Int32.Parse(selectedUser["FlatNumber"].Value.ToString());

            selectedFlatId = long.Parse(flatId.ToString());

            String ownerName = db.UserDetails.Where(x => x.FlatNumber == selectedFlatId).Single().OwnerName;

            groupBox_userDetails.Visible = true;
            linkLabel_editUserDetails.Text = ownerName + "'s Details";
            linkLabel_userPaymentHistory.Text = ownerName + "'s Payments";

            linkLabel_bills.Text = db.UserBills.Where(x => x.FlatNumber == flatId).Count().ToString();

            long totalBillAmount = 0;
            long totalPaidAmount = 0;
            long totalBalance = 0;

            if (db.UserBills.Where(x => x.FlatNumber == flatId).Count() != 0)
                totalBillAmount = db.UserBills.Where(x => x.FlatNumber == flatId).Sum(x => x.Amount);

            if (db.UserPayments.Where(x => x.FlatNumber == flatId).Count() != 0)
                totalPaidAmount = db.UserPayments.Where(x => x.FlatNumber == flatId).Sum(x => x.AmountPaid);
               
             totalBalance = totalBillAmount - totalPaidAmount;

                if (totalBalance < 0)
                {
                    textBox_carryForward.Text = ((-1) * totalBalance).ToString();
                    totalBalance = 0;

                }
                textBox_balance.Text = totalBalance.ToString();
                textBox_billAmount.Text = totalBillAmount.ToString();
                textBox_paid.Text = totalPaidAmount.ToString();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            comboBox_flatNumber.DataSource = CommonUtility.getFlatNumbers();
        }

        private void linkLabel_addUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddFlats newFlat = new AddFlats();
            newFlat.Show();
        }

        private void linkLabel_editUserDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddFlats editFlat = new AddFlats();
            editFlat.setFlatId(selectedFlatId);
            editFlat.Show();
        }

        private void linkLabel_userPayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserPayments userPayments = new UserPayments();
            userPayments.Show();
        }

        private void linkLabel_userPaymentHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PaymentHistory payHistory = new PaymentHistory();
            payHistory.setFlatId(selectedFlatId);
            payHistory.Show();
        }

        private void linkLabel_newPayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserPayments userPayment = new UserPayments();
            userPayment.setFlatId(selectedFlatId);
            userPayment.Show();
        }

        private void linkLabel_generateBill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GenerateBill bill = new GenerateBill();
            bill.Show();
        }

        private void linkLabel_bills_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserBills userBills = new UserBills();
            userBills.setFlatId(selectedFlatId);
            userBills.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage newPage = new HomePage();
            newPage.Show();
           // new HomePage().Show();
        }

        private void linkLabel_accounts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.Show();
        }

        private void linkLabel_userBill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GenerateBill newBill = new GenerateBill(selectedFlatId);
            newBill.Show();
            
        }

        private void linkLabel_overall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Overall overall = new Overall();
            overall.Show();
        }

        private void button_exportUserBills_Click(object sender, EventArgs e)
        {
            progressBar_export.Maximum = 100;
            progressBar_export.Step = 10;
            progressBar_export.Value = 0;

            List<UserBill> bills = db.UserBills.Where(x => x.FlatNumber == selectedFlatId).ToList();
            UserDetail user = db.UserDetails.Where(x => x.FlatNumber == selectedFlatId).Single();

            CommonUtility.exportUserBills(user, bills, selectedFlatId, progressBar_export);
            progressBar_export.Value = 0;

        }

       


        private void button_exportPayments_Click(object sender, EventArgs e)
        {

            progressBar_export.Maximum = 100;
            progressBar_export.Step = 10;
            progressBar_export.Value = 0;

            List<UserPayment> payments = db.UserPayments.Where(x => x.FlatNumber == selectedFlatId).ToList();
            UserDetail user = db.UserDetails.Where(x => x.FlatNumber == selectedFlatId).Single();
            
            CommonUtility.exportUserPayments(user, payments, selectedFlatId , progressBar_export);
            progressBar_export.Value = 0;
           
        }

        private void linkLabel_employees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employees employee = new Employees(0);
            employee.Show();
        }

        private void linkLabel_getEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewEmployees employees = new ViewEmployees();
            employees.Show();
        }

        private void linkLabel_expense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddExpense expense = new AddExpense();
            expense.Show();
        }

        private void linkLabel_viewExpenses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
        }

        private void linkLabel_adminFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Files adminFiles = new Admin_Files();
            adminFiles.Show();
        }

        private void linkLabel_addVisitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddVisitor newVisitor = new AddVisitor();
            newVisitor.Show();
        }

        private void linkLabel_addVisitor_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddVisitor newVisitor = new AddVisitor();
            newVisitor.Show();
        }

        private void linkLabel_sendFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendFiles sendFiles = new SendFiles();
            sendFiles.Show();
        }

        private void linkLabel_userFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserFiles userFiles = new UserFiles();
            userFiles.Show();
        }

        private void linkLabel_visitorSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitorSearch visitorSearch = new VisitorSearch();
            visitorSearch.Show();
        }



    }
}
