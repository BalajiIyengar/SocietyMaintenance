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
    public partial class Employees : Form
    {
        SMEntities db = CommonUtility.getConnection();

        private static Image employeeImage = null;
        private long employeeId = 0;

        public Employees(long employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }


        string validateEmployeeForm()
        {
            bool error = false;
            String errors = "";

            if (textBox_address.Text.Trim().Length == 0)
                errors += "Please Enter Address \n";

            if (textBox_employeeName.Text.Trim().Length == 0)
                errors += "Please enter Employee Name \n";

            if (textBox_phoneNumber.Text.Trim().Length == 0)
                errors += "Please Enter Phone Number \n";


            if (textBox_salary.Text.Trim().Length == 0)
                errors += "Please Enter Salary \n";

            int result;
            if (!Int32.TryParse(textBox_salary.Text.Trim(), out result))
                errors += "Please Enter Valid Salary \n";

            if (!Int32.TryParse(textBox_phoneNumber.Text.Trim(), out result))
                errors += "Please Enter Valid Phone Number \n";

            if (errors.Length > 0)
            {
                CommonUtility.showErrorPopUp(errors);
                error = true;
            }
            return errors;
        }


        private void button_addEmployee_Click(object sender, EventArgs e)
        {
            string errors = validateEmployeeForm();
           
            if(errors.Length > 0)
            {
                CommonUtility.showErrorPopUp(errors);
                return;
            }

            long lastEmployeeId = 0;
            if(db.EmployeeDetails.Count() > 0)
                lastEmployeeId = db.EmployeeDetails.Select(x=>x.EmployeeId).Max();

            String employeeName = textBox_employeeName.Text.Trim();

            EmployeeDetail employee = new EmployeeDetail();
            employee.Address = textBox_address.Text.Trim();
            employee.EmployeeId = lastEmployeeId + 1;
            employee.EmployeeName = textBox_employeeName.Text.Trim();
            employee.PhoneNumber = textBox_phoneNumber.Text.Trim();
            employee.Salary = Int32.Parse(textBox_salary.Text.Trim());

            if (employeeImage != null)
            {
                byte[] imageInBytes = CommonUtility.getByteArrayFromImage(employeeImage);
                employee.EmpImage = imageInBytes;
            }
            db.EmployeeDetails.Add(employee);
            
            db.SaveChanges();

            CommonUtility.showSuccessPopUp("Added "+employeeName+"'s Details Successfully");
            this.Close();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images Only. | *.jpg; *.jpeg; *.png; *.bmp ";

            DialogResult dialogResult = fileDialog.ShowDialog();

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                employeeImage = Image.FromFile(fileDialog.FileName);
            }
            pictureBox1.Image = employeeImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            if (employeeId != 0)
            {
                button_updateEmployeeDetails.Visible = true;
                button_addEmployee.Visible = false;

                EmployeeDetail empDetails = db.EmployeeDetails.Where(x => x.EmployeeId == employeeId).Single();

                textBox_address.Text = empDetails.Address;
                textBox_employeeName.Text = empDetails.EmployeeName;
                textBox_phoneNumber.Text = empDetails.PhoneNumber;
                textBox_salary.Text = empDetails.Salary.ToString();

                if (empDetails.EmpImage != null)
                {
                    pictureBox1.Image = CommonUtility.getImageFromByteArray(empDetails.EmpImage);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void button_updateEmployeeDetails_Click(object sender, EventArgs e)
        {

            string errors = validateEmployeeForm();

            if (errors.Length > 0)
            {
                CommonUtility.showErrorPopUp(errors);
                return;
            }

            EmployeeDetail empDetails = db.EmployeeDetails.Where(x => x.EmployeeId == employeeId).Single();

            empDetails.Address = textBox_address.Text;
            empDetails.EmployeeName = textBox_employeeName.Text;
            empDetails.PhoneNumber = textBox_phoneNumber.Text;
            empDetails.Salary = Int32.Parse(textBox_salary.Text);
           

             if(pictureBox1.Image != null)
             {
                 empDetails.EmpImage = CommonUtility.getByteArrayFromImage(pictureBox1.Image);
             }

            db.SaveChanges();
            CommonUtility.showSuccessPopUp("Data Successfully Updated");
        }

      
    }
}
