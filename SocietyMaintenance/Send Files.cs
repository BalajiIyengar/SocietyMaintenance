using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace SocietyMaintenance
{
    public partial class SendFiles : Form
    {
        SMEntities db = CommonUtility.getConnection();

        public SendFiles()
        {
            InitializeComponent();
        }

        private void SendFiles_Load(object sender, EventArgs e)
        {
            comboBox_flatNumber.DataSource = db.UserDetails.Select(x => x.FlatNumber).ToList();
            CommonUtility.setDropDownSearchable(comboBox_flatNumber);

           

        }

        private void comboBox_flatNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
             long flatNumber = long.Parse(comboBox_flatNumber.Text);
            List<string> emailIds = db.UserDetails.Where(x=>x.FlatNumber == flatNumber). Select(x => x.EmailId).ToList();

           
            emailIds.AddRange(db.TenantDetails.Where(x => x.FlatNumber == flatNumber).Select(x => x.TenantEmailId).ToList());

            comboBox_associatedEmailIds.DataSource = emailIds;
            CommonUtility.setDropDownSearchable(comboBox_associatedEmailIds);
        }
        List<string> attachments = new List<string>();
        private void button_browse_Click(object sender, EventArgs e)
        {
            attachments = CommonUtility.openFileDialog();
        }

        private void button_sendMail_Click(object sender, EventArgs e)
        {
            progressBar_sendMail.Maximum = 100;
            progressBar_sendMail.Minimum = 0;
            progressBar_sendMail.Step = 20;

            MailAddress fromEmailId = new MailAddress("devitsfangs@gmail.com","Balaji Iyengar");
            MailAddress toEmailId = new MailAddress(comboBox_associatedEmailIds.Text);

            if (richTextBox_subject.Text.Length == 0)
            {
                DialogResult result = MessageBox.Show("Email has Empty Subject! Are you Sure?", "Empty Subject", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    progressBar_sendMail.Value = 20;

                    CommonUtility.sendMail(fromEmailId, toEmailId, richTextBox_subject.Text, richTextBox_body.Text, attachments, progressBar_sendMail);
                    CommonUtility.showSuccessPopUp("Successfully Sent Mail to " + comboBox_associatedEmailIds.Text);

                    this.Close();
                }
            }
        }
    }
}
