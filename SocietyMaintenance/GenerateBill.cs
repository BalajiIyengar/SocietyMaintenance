using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace SocietyMaintenance
{
    public partial class GenerateBill : Form
    {
        SMEntities db = CommonUtility.getConnection();
        private long selectedFlatId = 0;
        public GenerateBill()
        {
            InitializeComponent();
        }

        public GenerateBill(long selectedFlatId)
        {
            // TODO: Complete member initialization
            this.selectedFlatId = selectedFlatId;
            InitializeComponent();
        }

        private void GenerateBill_Load(object sender, EventArgs e)
        {
            if (selectedFlatId != 0)
            {
                List<long> flats = new List<long>();
                flats.Add(db.UserDetails.Where(x => x.FlatNumber == selectedFlatId).Single().FlatNumber);
                comboBox_flatNumbers.DataSource = flats;
                comboBox_flatNumbers.Enabled = false;
                textBox_ownerName.Text = db.UserDetails.Where(x => x.FlatNumber == selectedFlatId).Single().OwnerName;
            }
            else
            {
                comboBox_flatNumbers.DataSource = db.UserDetails.Select(x => x.FlatNumber).ToList();
            }
            CommonUtility.populateMonths(comboBox_month);
            CommonUtility.populateYears(comboBox_year);
            
        }

        private void comboBox_flatNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            long flatId = long.Parse(comboBox_flatNumbers.Text);
            textBox_ownerName.Text = db.UserDetails.Where(x => x.FlatNumber == flatId).Single().OwnerName;
            

        }



        List<String> attachments = new List<string>();
        private void button_generateBill_Click(object sender, EventArgs e)
        {
            


            String errors = "";
            if (textBox_billAmount.Text.Trim().Length == 0)
                errors += "Please enter Bill Amount \n";

            if (comboBox_month.Text.Trim().Length == 0)
                errors += "Please select a month \n";

            if (checkBox_email.Checked)
            {
                if(textBox_emailId.Text.Trim().Length == 0)
                errors += "Please Enter an Email Id \n";

                if( !(textBox_emailId.Text.Contains("@") && textBox_emailId.Text.Trim().Contains(".") && textBox_emailId.Text.LastIndexOf("@")< textBox_emailId.Text.LastIndexOf(".")))
                {
                    errors += "Please Enter a Valid Email Id \n";
                }
            
            
            }

            if (errors.Length != 0)
            {
                CommonUtility.showErrorPopUp(errors);
                return;
            }
           

            if (db.UserBills.Where(x => x.BillForMonth.Equals(comboBox_month.Text) && x.BillForYear.Equals(comboBox_year.Text)).Count() != 0)
            {
                CommonUtility.showErrorPopUp("A Bill Already Exists for " + comboBox_month.Text + " " + comboBox_year.Text);
                return;
            }
            progressBar_generateBill.Minimum = 0;
            progressBar_generateBill.Maximum = 100;
            progressBar_generateBill.Step = 20;
           
            long flatNumber = long.Parse(comboBox_flatNumbers.Text);

            UserBill userBill = new UserBill();
            userBill.Amount = long.Parse(textBox_billAmount.Text.Trim());
            userBill.BillDate = DateTime.Parse(dateTimePicker_billDate.Text);
            userBill.BillForMonth = comboBox_month.Text;
            userBill.BillForYear = comboBox_year.Text;
            userBill.FlatNumber = flatNumber;

            db.UserBills.Add(userBill);
            db.SaveChanges();

            if (checkBox_email.Checked)
            {

                MailAddress fromEmailId = new MailAddress("devitsfangs@gmail.com", "Balaji Iyengar");
                MailAddress toEmailId = new MailAddress(textBox_emailId.Text);

                String subject = richTextBox_mailSubject.Text;
                string body = richTextBox_mailBody.Text;

                progressBar_generateBill.Value = 20;

                bool mailSent = CommonUtility.sendMail(fromEmailId,toEmailId,subject,body,attachments,progressBar_generateBill);


                CommonUtility.showSuccessPopUp("Bill Added Successfully and Mail Sent to " + textBox_emailId.Text);
                this.Close();
                return;
            }

            CommonUtility.showSuccessPopUp("Bill Added Successfully");
            this.Close();
        }

        private void checkBox_email_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_email.Checked)
            {
                textBox_emailId.Visible = true;
                checkBox_addAttachments.Visible = true;

                if (comboBox_flatNumbers.Text.Length > 0)
                {
                    long flatNumber = long.Parse(comboBox_flatNumbers.Text);
                    string subject = "Bill For the Month of " + comboBox_month.Text + " " + comboBox_year.Text + " With Amount " + textBox_billAmount.Text.Trim();
                    string body = " Dear " + db.UserDetails.Where(x => x.FlatNumber == flatNumber).Single().OwnerName + ", \n Please Pay your Dues at the Earliest.\n \n Regards, \n Society Committee";
                    richTextBox_mailBody.Text = body;
                    richTextBox_mailSubject.Text = subject;

                }
            }
            else
            {
                textBox_emailId.Visible = false;
                checkBox_addAttachments.Visible = false;
            }
        }

        private void checkBox_addAttachments_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_addAttachments.Checked)
            {
                attachments = CommonUtility.openFileDialog();
            }
            else
            {
                attachments = new List<string>();
            }
        }

    }
}
