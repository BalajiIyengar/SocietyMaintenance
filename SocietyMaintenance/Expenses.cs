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
    public partial class Expenses : Form
    {
        SMEntities db = CommonUtility.getConnection();

        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            comboBox_month.DataSource = months;


            CommonUtility.populateMonths(comboBox_month);
            CommonUtility.populateYears(comboBox_year);

            CommonUtility.setDropDownSearchable(comboBox_month);

            dataGridView_expenses.DataSource = db.SocietyExpenses.ToList();
            dataGridView_expenses.Columns["ExpenseId"].Visible = false;

            long expenses = 0;
            if (db.SocietyExpenses.Count() > 0)
                expenses = db.SocietyExpenses.Sum(x => x.Amount);
           
            label_totalExpense.Text = expenses.ToString();
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            String month = "";
            int year = 0;
            if(comboBox_month.Text.Trim().Length > 0)
                month = comboBox_month.Text;
            
            if (comboBox_year.Text.Trim().Length > 0)
              year = Int32.Parse(comboBox_year.Text);

            long expenseSum = 0;
            List<SocietyExpens> expenses = new List<SocietyExpens>();

            if (comboBox_month.Text.Trim().Length > 0 && comboBox_year.Text.Trim().Length > 0)
            {
                int monthNumber = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

                DateTime startDate = new DateTime(year, monthNumber, 1);
                //DateTime.DaysInMonth(year, monthNumber);
                DateTime endDate = new DateTime(year, monthNumber, DateTime.DaysInMonth(year, monthNumber));

                expenses = db.SocietyExpenses.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();               

                if (expenses.Count() > 0)
                    expenseSum = expenses.Sum(x => x.Amount);

                
            }

            label_totalExpense.Text = expenseSum.ToString();
            dataGridView_expenses.DataSource = expenses;

            dataGridView_expenses.Columns["ExpenseId"].Visible = false;

        }
    }
}
