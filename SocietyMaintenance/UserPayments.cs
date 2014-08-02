using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SocietyMaintenance
{
    public partial class UserPayments : Form
    {
        SMEntities db = CommonUtility.getConnection();
        long selectedFlatId; 

        public UserPayments()
        {
            InitializeComponent();
        }

        private void UserPayments_Load(object sender, EventArgs e)
        {
            comboBox_flatNumbers.DataSource = db.UserDetails.Select(x => x.FlatNumber).ToList();

            CommonUtility.populateMonths(comboBox_month);
            CommonUtility.populateYears(comboBox_year);

            if (selectedFlatId != 0)
            {
                groupBox_search.Visible = false;
                groupBox2.Visible = false;

                textBox_owner.Text = db.UserDetails.Where(x => x.FlatNumber == selectedFlatId).Single().OwnerName;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            String username = "";
            if (textBox_ownerName.Text.Trim().Length != 0)
                username = textBox_ownerName.Text.Trim();


            long flatNumber = long.Parse(comboBox_flatNumbers.Text);

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
            DataGridView gridView = sender as DataGridView;

            DataGridViewCellCollection selectedUser = gridView.CurrentRow.Cells as DataGridViewCellCollection;

            //Returns the selected customer ID
            long flatId = long.Parse(selectedUser["FlatNumber"].Value.ToString());

            selectedFlatId = flatId;

            UserDetail userDetail = db.UserDetails.Where(x => x.FlatNumber == flatId).Single();

            textBox_owner.Text = userDetail.OwnerName;

            //throw new NotImplementedException();
        }

        private void button_addPayment_Click(object sender, EventArgs e)
        {
            if (textBox_amount.Text.Trim().Length == 0)
            {
                CommonUtility.showErrorPopUp("Please Enter Payment Amount");
                return;
            }

            int output;
            if (!Int32.TryParse(textBox_amount.Text.Trim(), out output))
            {
                CommonUtility.showErrorPopUp("Invalid Amount.");
                return;
            }

            UserPayment payment = new UserPayment();
            payment.FlatNumber = selectedFlatId;
            payment.AmountPaid = long.Parse(textBox_amount.Text.Trim());
            payment.PaidDate = DateTime.Parse(dateTimePicker_paymentDate.Text);
            payment.PaidForTheMonthOf = comboBox_month.Text + " , " +comboBox_year.Text;
            payment.PaidTime = DateTime.Now.TimeOfDay;
            payment.PaymentMode = textBox_paymentMode.Text;

            db.UserPayments.Add(payment);
            db.SaveChanges();

            CommonUtility.showSuccessPopUp("Payment Details Successfully Added");
            this.Close();
        }


        internal void setFlatId(long selectedFlatId)
        {
            this.selectedFlatId = selectedFlatId;
            //throw new NotImplementedException();
        }

    }
}
