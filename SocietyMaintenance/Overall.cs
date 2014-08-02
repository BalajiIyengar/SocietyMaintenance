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
    public partial class Overall : Form
    {
        SMEntities db = CommonUtility.getConnection();
        public Overall()
        {
            InitializeComponent();
        }

        private void Overall_Load(object sender, EventArgs e)
        {
            comboBox_flatNumbers_Bills.DataSource = CommonUtility.getFlatNumbers();
            comboBox_flatNumbers_paid.DataSource = CommonUtility.getFlatNumbers();


            List<UserBill> userBills = db.UserBills.OrderBy(x=>x.FlatNumber).ToList();
            dataGridView_bills.DataSource = userBills;

            List<UserPayment> userPayments = db.UserPayments.OrderBy(x => x.FlatNumber).ToList();
            dataGridView_paid.DataSource = userPayments;
            
                dataGridView_paid.Columns["FlatNumber"].DisplayIndex = 0;
                dataGridView_paid.Columns["UserPayment1"].Visible = false;
                dataGridView_paid.Columns["UserPayment2"].Visible = false;
                dataGridView_paid.Columns["PaidTime"].Visible = false;
                dataGridView_paid.Columns["PaymentMode"].Visible = false;

                dataGridView_bills.Columns["FlatNumber"].DisplayIndex = 0;
        }

        private void button_filterBills_Click(object sender, EventArgs e)
        {
            long flatNumber = long.Parse(comboBox_flatNumbers_Bills.Text);


            if (flatNumber != 0)
            {
                dataGridView_bills.DataSource = db.UserBills.Where(x => x.FlatNumber == flatNumber).ToList();              
            }
        }

        private void button_filterPaid_Click(object sender, EventArgs e)
        {
            long flatNumber = long.Parse(comboBox_flatNumbers_paid.Text);


            if (flatNumber != 0)
            {
                dataGridView_paid.DataSource = db.UserPayments.Where(x => x.FlatNumber == flatNumber).ToList();
                dataGridView_paid.Columns["UserPayment1"].Visible = false;
                dataGridView_paid.Columns["UserPayment2"].Visible = false;
                dataGridView_paid.Columns["PaidTime"].Visible = false;
                dataGridView_paid.Columns["PaymentMode"].Visible = false;
   
            }
        }
    }
}
