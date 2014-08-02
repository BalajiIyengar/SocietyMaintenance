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
    public partial class AddExpense : Form
    {
        SMEntities db = CommonUtility.getConnection();

        public AddExpense()
        {
            InitializeComponent();
        }

        private void button_addExpense_Click(object sender, EventArgs e)
        {
            String errors = "";

            if (textBox_amount.Text.Trim().Length == 0)
                errors += "Please Enter Amount \n";

            if (textBox_comments.Text.Trim().Length == 0)
                errors += "Please Enter Comments \n";

            int result;
            
            if (!Int32.TryParse(textBox_amount.Text.Trim(), out result))
                errors += "Please Enter Valid Amount \n";

            if(errors.Length > 0)
            {
                CommonUtility.showSuccessPopUp(errors);
                return;
            }

            long expenseId = 0;

            if (db.SocietyExpenses.Count() > 0)
                expenseId = db.SocietyExpenses.Select(x => x.ExpenseId).Max();

            SocietyExpens expenses = new SocietyExpens();
            expenses.Amount = long.Parse(textBox_amount.Text.Trim());
            expenses.Comments = textBox_comments.Text.Trim();
            expenses.ExpenseId = expenseId + 1;
            expenses.Date = DateTime.Parse(dateTimePicker_expenseDate.Text);

            db.SocietyExpenses.Add(expenses);
            db.SaveChanges();

            CommonUtility.showSuccessPopUp("Added Expenses Successfully");
            this.Close();


        }
    }
}
