using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Data.Entity.Infrastructure;
using System.Collections;
using System.IO;


namespace SocietyMaintenance
{
    public partial class AddFlats : Form
    {
        long selectedFlatId = 0;
        SMEntities db = CommonUtility.getConnection();
        long tenantId = 0;
        
        public AddFlats()
        {
            InitializeComponent();
        }

        private void button_addFlat_Click(object sender, EventArgs e)
        {
            String errors = "";

            if (textBox_flatNumber.Text.Trim().Length == 0)
            {
                errors += "Please enter a valid Flat Number \n";
            }

            if (textBox_ownerName.Text.Trim().Length == 0)
                errors += "Please Enter The Owner's Name \n";

            if (textBox_phoneNumber.Text.Trim().Length == 0)
                errors += "Please Enter Owner Phone Number \n";

            if (textBox_emailId.Text.Trim().Length == 0)
                errors += "Please Enter Owner Email Id \n";

            if (textBox_phoneNumber.Text.Trim().Length != 0 && textBox_phoneNumber.Text.Trim().Length > 12)
               errors += "Not a Valid Phone Number \n";
           
            List<long> flats = db.UserDetails.Select(x => x.FlatNumber).ToList();
            if ( textBox_flatNumber.Text.Trim().Length !=0  && flats.Contains(long.Parse(textBox_flatNumber.Text.Trim())))
                errors += "This Flat Number is Already Registered,Try Updating it Instead \n";

            if (checkBox_rented.Checked)
            {
                if (textBox_tenantName.Text.Length == 0)
                    errors += "Please Enter Tenant Name \n";

                if (textBox_tenantEmailId.Text.Length == 0)
                    errors += "Please Enter Tenant Email Id \n";

                if (textBox_tenantPhoneNumber.Text.Length == 0)
                    errors += "Please Enter Tenant Phone Number \n";

                int result = 0;
                if(! Int32.TryParse(textBox_tenantPeopleCount.Text.Trim(),out result))
                    errors += "Please Enter Valid People Count \n";
            }

            if(errors.Length != 0)
            {
                CommonUtility.showErrorPopUp(errors);
                return;
            }

            long flatNumber = long.Parse(textBox_flatNumber.Text);

            List<long> flatNumbers = CommonUtility.getFlatNumbers();
            if (flatNumbers.Contains(flatNumber))
            {
                CommonUtility.showErrorPopUp("This Flat Number is Already Registered");
                return;
            }

            UserDetail userDetails = new UserDetail();
            userDetails.FlatNumber = long.Parse(textBox_flatNumber.Text.Trim());
            userDetails.EmailId = textBox_emailId.Text.Trim();
            userDetails.FlatNumber = flatNumber;
            userDetails.OwnerName = textBox_ownerName.Text;
            userDetails.OwnerDetails = textBox_ownerAddress.Text;
            userDetails.PhoneNumber = textBox_phoneNumber.Text.Trim();
            userDetails.isRented = false;

             TenantDetail tenantDetails = new TenantDetail();
             long lastTenantId = 0;
              
            Boolean success = false;
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    if (checkBox_rented.Checked)
                    { 
                        if(db.TenantDetails.Count() > 0 )
                            lastTenantId = db.TenantDetails.Select(x => x.TenantId).Max();

                            userDetails.isRented = true;
                            tenantDetails.FlatNumber = flatNumber;
                            tenantDetails.isActive = true;
                            tenantDetails.TenantAddress = textBox_tenantAddress.Text.Trim();
                            tenantDetails.TenantEmailId = textBox_tenantEmailId.Text.Trim();
                            tenantDetails.TenantFamilyCount = long.Parse(textBox_tenantPeopleCount.Text.Trim());
                            tenantDetails.TenantId = lastTenantId + 1;
                            tenantDetails.TenantName = textBox_tenantName.Text.Trim();
                            tenantDetails.TenantPhoneNumber = textBox_tenantPhoneNumber.Text.Trim();
                            tenantDetails.VehicleNumbers = textBox_tenantVehicle.Text.Trim();


                            db.TenantDetails.Add(tenantDetails);

                            uploadFiles(flatNumber, lastTenantId + 1,false);
                    }
                    db.UserDetails.Add(userDetails);

                    uploadFiles(flatNumber, 0,true);

                    db.SaveChanges();
                    transaction.Complete();
                    success = true;
                }
                catch (Exception ex)
                {
                    success = false;
                }
            }
            if (success)
               ((IObjectContextAdapter)db).ObjectContext.AcceptAllChanges(); //Transaction was successful, commit all changes.
         
         
            CommonUtility.showSuccessPopUp("Added Flat "+textBox_flatNumber.Text + " Successfully");
            this.Close();
        }


        internal void setFlatId(long selectedFlatId)
        {
            this.selectedFlatId = selectedFlatId;
          
        }

        private void AddFlats_Load(object sender, EventArgs e)
        {
            comboBox_fileType.DataSource = db.DocumentTypeMasters.Select(x=>x.DocType).ToList();
            comboBox_tenantFileType.DataSource = db.DocumentTypeMasters.Select(x=>x.DocType).ToList();
           
            UserDetail userDetails = new UserDetail();

            if (selectedFlatId != 0)
            {
                userDetails = db.UserDetails.Where(x => x.FlatNumber == selectedFlatId).Single();
                button_edit.Visible = true;
                button_addFlat.Visible = false;
                groupBox_ownerDetails.Enabled = false;

                textBox_emailId.Text = userDetails.EmailId;
                textBox_flatNumber.ReadOnly = true;
                textBox_flatNumber.Text = userDetails.FlatNumber.ToString();
                textBox_ownerAddress.Text = userDetails.OwnerDetails;
                textBox_ownerName.Text = userDetails.OwnerName;

                String phoneNumber = "";
                if (userDetails.PhoneNumber != null)
                    phoneNumber = userDetails.PhoneNumber.ToString();
                textBox_phoneNumber.Text = phoneNumber;

                if(userDetails.isRented == true)
                {
                    TenantDetail activeTenant = db.TenantDetails.Where(x => x.isActive == true && x.FlatNumber == selectedFlatId).Single();
                    if (activeTenant != null)
                    {
                        tenantId = activeTenant.TenantId;
                        checkBox_rented.Checked = true;
                        textBox_tenantAddress.Text = activeTenant.TenantAddress;
                        textBox_tenantEmailId.Text = activeTenant.TenantEmailId;
                        textBox_tenantName.Text = activeTenant.TenantName;
                        textBox_tenantPeopleCount.Text = activeTenant.TenantFamilyCount.ToString();
                        textBox_tenantPhoneNumber.Text = activeTenant.TenantPhoneNumber;
                        textBox_tenantVehicle.Text = activeTenant.VehicleNumbers;
                    }
                }
            }
            else
                linkLabel_edit.Visible = false;

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            UserDetail userDetails = new UserDetail();
            userDetails = db.UserDetails.Where(x => x.FlatNumber == selectedFlatId).Single();
            userDetails.EmailId = textBox_emailId.Text.Trim();
            userDetails.OwnerDetails = textBox_ownerAddress.Text.Trim();
            userDetails.OwnerName = textBox_ownerName.Text.Trim();
            userDetails.PhoneNumber = textBox_phoneNumber.Text.Trim();

            if (checkBox_rented.Checked)
            {
                int result;
                if (!Int32.TryParse(textBox_tenantPeopleCount.Text.Trim(), out result))
                {
                    CommonUtility.showErrorPopUp("Please Enter Valid People Count");
                    return;
                }
                userDetails.isRented = true;

                if (db.TenantDetails.Where(x => x.isActive == true && x.FlatNumber == selectedFlatId).Count() > 0)
                {
                    TenantDetail tenantDetails = db.TenantDetails.Where(x => x.isActive == true && x.FlatNumber == selectedFlatId).Single();
                    tenantDetails.TenantAddress = textBox_tenantAddress.Text.Trim();
                    tenantDetails.TenantEmailId = textBox_tenantEmailId.Text.Trim();
                    tenantDetails.TenantFamilyCount = long.Parse(textBox_tenantPeopleCount.Text.Trim());
                    tenantDetails.TenantName = textBox_tenantName.Text.Trim();
                    tenantDetails.TenantPhoneNumber = textBox_tenantPhoneNumber.Text.Trim();
                    tenantDetails.VehicleNumbers = textBox_tenantVehicle.Text.Trim();
                }
                else
                {
                    long lastTenantId = 0;
                    if (db.TenantDetails.Count() > 0)
                        lastTenantId = db.TenantDetails.Select(x => x.TenantId).Max();

                    TenantDetail tenantDetails = new TenantDetail();
                    tenantDetails.TenantAddress = textBox_tenantAddress.Text.Trim();
                    tenantDetails.TenantEmailId = textBox_tenantEmailId.Text.Trim();
                    tenantDetails.TenantFamilyCount = long.Parse(textBox_tenantPeopleCount.Text.Trim());
                    tenantDetails.TenantName = textBox_tenantName.Text.Trim();
                    tenantDetails.TenantPhoneNumber = textBox_tenantPhoneNumber.Text.Trim();
                    tenantDetails.VehicleNumbers = textBox_tenantVehicle.Text.Trim();
                    tenantDetails.TenantId = lastTenantId + 1;
                    tenantDetails.FlatNumber = selectedFlatId;
                    tenantDetails.isActive = true;

                    db.TenantDetails.Add(tenantDetails);
                }
            }
            else
            {
               // UserDetail userDetail = new UserDetail();
               

                 UserDetail userDetail = db.UserDetails.Where(x => x.FlatNumber == selectedFlatId).Single();
                 userDetail.isRented = false;
                 userDetail.FlatNumber = selectedFlatId;

                 

                 TenantDetail tenantDetails = db.TenantDetails.Where(x => x.FlatNumber == selectedFlatId && x.isActive == true).Single();
                 tenantDetails.isActive = false;

                 db.SaveChanges();



            }
            db.SaveChanges();
            CommonUtility.showSuccessPopUp("Successfully Updated");
        }

        private void linkLabel_edit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox_ownerDetails.Enabled = true;
        }

        private void checkBox_rented_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_rented.Checked)
            {
                groupBox_tenantDetails.Visible = true;
                comboBox_tenantFileType.Visible = true;
                button_tenantSelectFiles.Visible = true;
                dataGridView2.Visible = true;
            }
            else
            {
                groupBox_tenantDetails.Visible = false;
                comboBox_tenantFileType.Visible = false;
                button_tenantSelectFiles.Visible = false;
                dataGridView2.Visible = false;
            }
        }
        private void button_selectFiles_Click(object sender, EventArgs e)
        {
                if (textBox_flatNumber.Text.Length == 0)
                {
                    CommonUtility.showErrorPopUp("Please Enter Flat Number");
                    return;
                }
                if (comboBox_fileType.Items.Count > 0)
                {  
                    selectFiles(dataGridView1,false);
                }
         }
        Hashtable userFilesDb = new Hashtable();
        Hashtable userFilesDisplay = new Hashtable();

        Hashtable tenantFilesDb = new Hashtable();
        Hashtable tenantFilesDisplay = new Hashtable();
        List<String> masters = new List<string>();

        void selectFiles(DataGridView dataGridView,bool isTenant)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            DialogResult result = fileDialog.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                String fileType =""; 
                if(!isTenant)
                    fileType = comboBox_fileType.Text;
                if (isTenant)
                    fileType = comboBox_tenantFileType.Text;

                String fileLocation = fileDialog.FileName;
                String fileName = fileDialog.SafeFileName;
                String flatNumber = textBox_flatNumber.Text;

                String fileExtension = CommonUtility.getFileExtension(fileName);
                masters.Add(fileType);

                List<String> docMasters = db.DocumentTypeMasters.Select(x => x.DocType).ToList();

                foreach (String master in masters)
                    docMasters.Remove(master);

                DataTable local = new DataTable();
                local = new DataTable();
                local.Columns.Add("FileName");
                local.Columns.Add("FileType");


                if (!isTenant)
                {
                    String displayFileName = flatNumber + ("_") + fileType + "." + fileExtension;
                    userFilesDb.Add(displayFileName, fileLocation);
                    userFilesDisplay.Add(displayFileName, fileType);
                    comboBox_fileType.DataSource = docMasters;

                    foreach (DictionaryEntry entry in userFilesDisplay)
                    {
                        DataRow dr = local.NewRow();

                        dr["FileName"] = entry.Key;
                        dr["FileType"] = entry.Value;

                        local.Rows.Add(dr);
                    }
                }
                if (isTenant)
                {
                    String displayFileName = flatNumber+"_Tenant" + ("_") + fileType + "." + fileExtension;
                    tenantFilesDb.Add(displayFileName, fileLocation);
                    tenantFilesDisplay.Add(displayFileName, fileType);
                    comboBox_tenantFileType.DataSource = docMasters;

                    foreach (DictionaryEntry entry in tenantFilesDisplay)
                    {
                        DataRow dr = local.NewRow();

                        dr["FileName"] = entry.Key;
                        dr["FileType"] = entry.Value;

                        local.Rows.Add(dr);
                    }
                }
                dataGridView.DataSource = local;
            }
        }

         private void linkLabel_addNewDocType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             AddDocumentType newDocType = new AddDocumentType();
             newDocType.Show();
         }

         private void button_tenantSelectFiles_Click(object sender, EventArgs e)
         {
             if (checkBox_rented.Checked)
             {
                 if (textBox_flatNumber.Text.Length == 0)
                 {
                     CommonUtility.showErrorPopUp("Please Enter Flat Number");
                     return;
                 }

                 if (comboBox_tenantFileType.Items.Count > 0)
                 {
                     selectFiles(dataGridView2, true);
                 }
             }
         }

            void uploadFiles(long flatNumber,long tenantId,bool isOwner)
            {
                 try
                 {
                     if (isOwner)
                     {
                         foreach (DictionaryEntry entry in userFilesDb)
                         {
                             CommonUtility.uploadFile(entry.Value.ToString(), flatNumber, tenantId, entry.Key.ToString());
                         }
                         CommonUtility.showSuccessPopUp("Successfully Uploaded " + userFilesDb.Count + " File(s)");
                     }
                     else 
                     {
                         foreach (DictionaryEntry entry in tenantFilesDb)
                         {
                             CommonUtility.uploadFile(entry.Value.ToString(), flatNumber, tenantId, entry.Key.ToString());
                         }
                         CommonUtility.showSuccessPopUp("Successfully Uploaded " + tenantFilesDb.Count + " File(s)");
                     }
                     
                 }
                 catch (Exception ex)
                 {
                     ex.GetBaseException();
                 }
            }
    }
}
