using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SocietyMaintenance
{
    public partial class Accounts : Form
    {
        SMEntities db = CommonUtility.getConnection();

        public Accounts()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            CommonUtility.populateMonths(comboBox_fromMonth);
            CommonUtility.populateMonths(comboBox_toMonth);
            CommonUtility.populateYears(comboBox_fromYear);
            CommonUtility.populateYears(comboBox_toYear);

            comboBox_flatNumber.Visible = false;
            comboBox_flatNumber.DataSource = CommonUtility.getFlatNumbers();

        }

        private void button_fetchBills_Click(object sender, EventArgs e)
        {
            if(comboBox_fromMonth.Text.Trim().Length != 0 && comboBox_toMonth.Text.Trim().Length != 0)
            {
                String fromMonthName = comboBox_fromMonth.Text;
                int monthNumber = DateTime.ParseExact(fromMonthName, "MMMM", CultureInfo.InvariantCulture).Month;

                String toMonthName = comboBox_toMonth.Text;
                int toMonthNumber = DateTime.ParseExact(toMonthName,"MMMM",CultureInfo.InvariantCulture).Month;

                int fromYear = Int32.Parse(comboBox_fromYear.Text);
                int toYear = Int32.Parse(comboBox_toYear.Text);

                List<UserPayment> userPayments = new List<UserPayment>();


                if (toYear < fromYear)
                {
                    CommonUtility.showErrorPopUp("Please select Valid From and To Year!");
                    return;
                }

                if (toYear == fromYear && toMonthNumber < monthNumber)
                {
                    CommonUtility.showErrorPopUp("Please select Valid From and To Month!");
                    return;
                }

                if (!radioButton_allUsers.Checked && !radioButton_user.Checked)
                {
                    CommonUtility.showErrorPopUp("Please select All Users or a specific User");
                    return;
                }


                int daysTo = DateTime.DaysInMonth(toYear, toMonthNumber);
               // int daysFrom = DateTime.DaysInMonth(fromYear, monthNumber);



                DateTime startDate = new DateTime(fromYear, monthNumber, 1);
                DateTime endDate = new DateTime(toYear, toMonthNumber, daysTo);


                if (radioButton_user.Checked)
                {
                    if (comboBox_flatNumber.Text.Trim().Length == 0)
                    {
                        CommonUtility.showErrorPopUp("Please Enter a Flat Number");
                        return;
                    }

                    int result;
                    if (!Int32.TryParse(comboBox_flatNumber.Text.Trim(), out result))
                    {
                        CommonUtility.showErrorPopUp("Please Enter a Valid Flat Number");
                        return;
                    }
                    long flatNumber = long.Parse(comboBox_flatNumber.Text.Trim());
                    if (db.UserDetails.Where(x => x.FlatNumber == flatNumber).Count() == 0)
                    {
                        CommonUtility.showErrorPopUp("Invalid Flat Number "+flatNumber);
                        return;
                    }

                  

                    userPayments = db.UserPayments.Where(x => x.FlatNumber == flatNumber && x.PaidDate >= startDate && x.PaidDate <= endDate).OrderBy(x => x.PaidDate).ToList();
                    linkLabel_billCount.Text = db.UserPayments.Where(x => x.PaidDate >= startDate && x.PaidDate <= endDate && x.FlatNumber == flatNumber).ToList().Count().ToString();
                }
            
                if(radioButton_allUsers.Checked)
                {
                    userPayments = db.UserPayments.Where(x => x.PaidDate >= startDate && x.PaidDate <= endDate).OrderBy(x => x.PaidDate).ToList();
                    linkLabel_billCount.Text = db.UserPayments.Where(x => x.PaidDate >= startDate && x.PaidDate <= endDate).ToList().Count().ToString();
                }
               

                 dataGridView_bills.DataSource = userPayments;

                 dataGridView_bills.Columns["UserPayment1"].Visible = false;
                 dataGridView_bills.Columns["UserPayment2"].Visible = false;
                 
                 dataGridView_bills.Columns["PaidTime"].Visible = false;

            }
        }

        private void radioButton_user_CheckedChanged(object sender, EventArgs e)
        {
            label_flatNumber.Visible = true;
            comboBox_flatNumber.Visible = true;
        }

        private void radioButton_allUsers_CheckedChanged(object sender, EventArgs e)
        {

            label_flatNumber.Visible = false;
            comboBox_flatNumber.Visible = false;
        }

        private void linkLabel_showPayments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox_fromMonth.Text.Trim().Length != 0 && comboBox_toMonth.Text.Trim().Length != 0)
            {
                String fromMonthName = comboBox_fromMonth.Text;
                int monthNumber = DateTime.ParseExact(fromMonthName, "MMMM", CultureInfo.InvariantCulture).Month;

                String toMonthName = comboBox_toMonth.Text;
                int toMonthNumber = DateTime.ParseExact(toMonthName, "MMMM", CultureInfo.InvariantCulture).Month;

                int fromYear = Int32.Parse(comboBox_fromYear.Text);
                int toYear = Int32.Parse(comboBox_toYear.Text);

                if (toYear < fromYear)
                {
                    CommonUtility.showErrorPopUp("Please select Valid From and To Year!");
                    return;
                }

                if (toYear == fromYear && toMonthNumber < monthNumber)
                {
                    CommonUtility.showErrorPopUp("Please select Valid From and To Month!");
                    return;
                }
                
                int daysTo = DateTime.DaysInMonth(toYear, toMonthNumber);
                // int daysFrom = DateTime.DaysInMonth(fromYear, monthNumber);



                DateTime startDate = new DateTime(fromYear, monthNumber, 1);
                DateTime endDate = new DateTime(toYear, toMonthNumber, daysTo);


                if (radioButton_allUsers.Checked)
                {
                    long totalPaid = 0;
                    if (db.UserPayments.Where(x => x.PaidDate >= startDate && x.PaidDate <= endDate).Count() != 0)
                        totalPaid = db.UserPayments.Where(x => x.PaidDate >= startDate && x.PaidDate <= endDate).Sum(x => x.AmountPaid);

                    textBox_amount.Text = totalPaid.ToString();

                    long totalBillAmount = 0;
                    if (db.UserBills.Where(x => x.BillDate >= startDate && x.BillDate <= endDate).Count() != 0)
                    {
                        totalBillAmount = db.UserBills.Where(x => x.BillDate >= startDate && x.BillDate <= endDate).Sum(x => x.Amount);
                        textBox_pending.Text = (totalBillAmount - totalPaid).ToString();
                    }

                }



                if (radioButton_user.Checked)
                {

                    if (comboBox_flatNumber.Text.Trim().Length == 0)
                    {
                        CommonUtility.showErrorPopUp("Please Enter a Flat Number");
                        return;
                    }

                    int result;
                    if (!Int32.TryParse(comboBox_flatNumber.Text.Trim(), out result))
                    {
                        CommonUtility.showErrorPopUp("Please Enter a Valid Flat Number");
                        return;
                    }
                    long flatNumber = long.Parse(comboBox_flatNumber.Text.Trim());
                    if (db.UserDetails.Where(x => x.FlatNumber == flatNumber).Count() == 0)
                    {
                        CommonUtility.showErrorPopUp("Invalid Flat Number " + flatNumber);
                        return;
                    }

                   
                    
                    long totalPaid = 0;
                    if (db.UserPayments.Where(x => x.PaidDate >= startDate && x.PaidDate <= endDate && x.FlatNumber == flatNumber).Count() != 0)
                        totalPaid = db.UserPayments.Where(x => x.PaidDate >= startDate && x.PaidDate <= endDate && x.FlatNumber == flatNumber).Sum(x => x.AmountPaid);

                    textBox_amount.Text = totalPaid.ToString();

                    long totalBillAmount = 0;
                    if (db.UserBills.Where(x => x.BillDate >= startDate && x.BillDate <= endDate && x.FlatNumber == flatNumber).Count() != 0)
                    {
                        totalBillAmount = db.UserBills.Where(x => x.BillDate >= startDate && x.BillDate <= endDate && x.FlatNumber == flatNumber).Sum(x => x.Amount);
                        textBox_pending.Text = (totalBillAmount - totalPaid).ToString();
                    }

                }

            }
        }

    }
}
