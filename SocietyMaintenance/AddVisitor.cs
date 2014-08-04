using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SocietyMaintenance
{
    public partial class AddVisitor : Form
    {
        static SMEntities db = CommonUtility.getConnection();
        WebCam webcam;
        private long flatId;
        private TimeSpan visitTime;
        private DateTime visitDate;

        public AddVisitor()
        {
            InitializeComponent();
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox_recording);
        }

        public AddVisitor(long flatId, TimeSpan visitTime, DateTime visitDate)
        {
            InitializeComponent();
            this.flatId = flatId;
            this.visitTime = visitTime;
            this.visitDate = visitDate;
        }

        private void AddVisitor_Load(object sender, EventArgs e)
        {
            if (flatId != 0 && visitDate != null && visitTime != null)
            {
                button_addVisitor.Visible = false;
                button_capture.Visible = false;
                button_saveImage.Visible = false;
                button_addVisitorType.Visible = false;
                comboBox_flatNumbers.Enabled = false;
                comboBox_attendingEmployee.Enabled = false;
                comboBox_visitorType.Enabled = false;
                dateTimePicker_date.Enabled = false;
                dateTimePicker_time.Enabled = false;

                VisitorDetail visitorDetails = db.VisitorDetails.Where(x => x.FlatNumber == flatId && x.VisitDate == visitDate && x.VisitTime == visitTime).Single();

                comboBox_flatNumbers.Text = visitorDetails.FlatNumber.ToString();
                textBox_visitorAddress.Text = visitorDetails.VisitorAddress;
                textBox_visitorName.Text = visitorDetails.VisitorName;
                textBox_visitPurpose.Text = visitorDetails.VisitPurpose;
                dateTimePicker_date.Text = visitorDetails.VisitDate.ToString();
                dateTimePicker_time.Text = visitorDetails.VisitTime.ToString();

                if(visitorDetails.VisitorImage != null)
                pictureBox_capturedImage.Image = CommonUtility.getImageFromByteArray(visitorDetails.VisitorImage);

                dateTimePicker_time.Format = DateTimePickerFormat.Custom;
                dateTimePicker_time.CustomFormat = "HH:mm";
                dateTimePicker_time.ShowUpDown = true;

                dateTimePicker_time.Text = new DateTime(visitorDetails.VisitTime.Ticks).ToString("HH:mm"); ;

                if (visitorDetails.EmployeeId != null)
                comboBox_attendingEmployee.Text = db.EmployeeDetails.Where(x => x.EmployeeId == visitorDetails.EmployeeId).Single().EmployeeName.ToString();
               
                if (visitorDetails.VisitorType != 0)
                comboBox_visitorType.Text = db.VisitorTypesMasters.Where(x => x.TypeId == visitorDetails.VisitorType).Single().TypeName;

               return;
            }
            
            button_addVisitorType.Visible = false;
           
            CommonUtility.setDropDownSearchable(comboBox_visitorType);
            CommonUtility.setDropDownSearchable(comboBox_flatNumbers);
            CommonUtility.setDropDownSearchable(comboBox_attendingEmployee);

            comboBox_attendingEmployee.DataSource = db.EmployeeDetails.ToList();
            comboBox_attendingEmployee.DisplayMember = "EmployeeName";
            comboBox_attendingEmployee.ValueMember = "EmployeeId";

            comboBox_flatNumbers.DataSource = db.UserDetails.Select(x => x.FlatNumber).ToList();

            comboBox_visitorType.DataSource = db.VisitorTypesMasters.ToList();
            comboBox_visitorType.DisplayMember = "TypeName";
            comboBox_visitorType.ValueMember = "TypeId";

            dateTimePicker_time.Format = DateTimePickerFormat.Custom;
            dateTimePicker_time.CustomFormat = "HH:mm"; 
            dateTimePicker_time.ShowUpDown = true;

            dateTimePicker_time.Text = DateTime.Now.ToString("HH:mm");

        }

        private void button_addVisitor_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            
            String errors = "";
            if (textBox_visitorName.Text.Trim().Length == 0)
                errors += "Please Enter Visitor Name \n";

            if (textBox_visitorAddress.Text.Trim().Length == 0)
                errors += "Please Enter Visitor Address \n";

            if (textBox_visitPurpose.Text.Trim().Length == 0)
                errors += "Please Enter Visit Purpose \n";

            if (errors.Length > 0)
            {
                CommonUtility.showErrorPopUp(errors);
                return;
            }
            byte[] visitorImage = null;

            if (pictureBox_capturedImage.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox_capturedImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                visitorImage = ms.ToArray();

            }
            VisitorTypesMaster visitorMaster = comboBox_visitorType.SelectedItem as VisitorTypesMaster;

            VisitorDetail visitorDetails = new VisitorDetail();
            visitorDetails.FlatNumber = long.Parse(comboBox_flatNumbers.Text);
            visitorDetails.VisitDate = DateTime.Parse(dateTimePicker_date.Text);
            visitorDetails.VisitorAddress = textBox_visitorAddress.Text;
            visitorDetails.VisitorImage = visitorImage;
            visitorDetails.VisitorName = textBox_visitorName.Text;
            visitorDetails.VisitorType = visitorMaster.TypeId;
            visitorDetails.VisitPurpose = textBox_visitPurpose.Text;
            visitorDetails.VisitTime = TimeSpan.Parse(dateTimePicker_time.Text);

            EmployeeDetail employeeDetails = comboBox_attendingEmployee.SelectedItem as EmployeeDetail;

            visitorDetails.EmployeeId = employeeDetails.EmployeeId;
            db.VisitorDetails.Add(visitorDetails);

            db.SaveChanges();

            CommonUtility.showSuccessPopUp("Successfully Added Visitor");
        }

        private void linkLabel_addVisitorType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox_addVisitorType_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_addVisitorType.Checked)
            {
                textBox_newVisitorType.Visible = true;
                button_addVisitorType.Visible = true;
            }
            else
            {
                textBox_newVisitorType.Visible = false;
                button_addVisitorType.Visible = false;
            }
        }

        private void button_addVisitorType_Click(object sender, EventArgs e)
        {
            if (textBox_newVisitorType.Text.Trim().Length == 0)
            {
                CommonUtility.showErrorPopUp("Please Enter a Visitor Type");
                return;
            }

            long lastVisitorCount = 0;

            if (db.VisitorTypesMasters.Count() > 0)
                lastVisitorCount = db.VisitorTypesMasters.Max(x => x.TypeId);


            VisitorTypesMaster addNewVisitor = new VisitorTypesMaster();
            addNewVisitor.TypeId = lastVisitorCount + 1;
            addNewVisitor.TypeName = textBox_newVisitorType.Text;

            db.VisitorTypesMasters.Add(addNewVisitor);

            db.SaveChanges();

            CommonUtility.showSuccessPopUp("New Visitor Added Successfully");

            comboBox_visitorType.DataSource = db.VisitorTypesMasters.Select(x => x.TypeName).ToList();
        }
        

        private void button_capture_Click(object sender, EventArgs e)
        {
            button_saveImage.Visible = true;
            webcam.Continue();
        }

       

        private void button_saveImage_Click(object sender, EventArgs e)
        {
            pictureBox_capturedImage.Image = pictureBox_recording.Image;
           // webcam.Continue();
            //webcam.Stop();
           // SaveImageCapture(pictureBox_capturedImage.Image);
        }




        public static void SaveImageCapture(System.Drawing.Image image)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Visitor";// Default file name
            saveFileDialog.DefaultExt = ".Jpg";// Default file extension
            saveFileDialog.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

            // Show save file dialog box
            // Process save file dialog box results
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save Image
                string filename = saveFileDialog.FileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();
            }

        }

        private void comboBox_visitorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_visitPurpose.Text = comboBox_visitorType.Text;
        }

       



    }
}
