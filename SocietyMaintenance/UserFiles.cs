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
    public partial class UserFiles : Form
    {
        SMEntities db = CommonUtility.getConnection();
        long flatNumber;
        long tenantId;
        public UserFiles()
        {
            InitializeComponent();
        }

        private void UserFiles_Load(object sender, EventArgs e)
        {
            comboBox_flatNumber.DataSource = CommonUtility.getFlatNumbers();
            CommonUtility.setDropDownSearchable(comboBox_flatNumber);
        }

        private void comboBox_flatNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            long flatNumber = long.Parse(comboBox_flatNumber.Text);
            this.flatNumber = flatNumber;

            if (db.UserDocuments.Where(x => x.FlatNumber == flatNumber && x.TenantId == 0).Count() > 0)
            {
                dataGridView_ownerFiles.DataSource = db.UserDocuments.Where(x => x.FlatNumber == flatNumber && x.TenantId == 0).ToList();

                dataGridView_ownerFiles.Columns["FlatNumber"].Visible = false;
                dataGridView_ownerFiles.Columns["TenantId"].Visible = false;
                dataGridView_ownerFiles.Columns["DocumentData"].Visible = false;
            }
            comboBox_tenant.SelectedIndex = -1;

            comboBox_tenant.DisplayMember = "TenantName";
            comboBox_tenant.ValueMember = "TenantId";
            comboBox_tenant.DataSource = db.TenantDetails.Where(x => x.FlatNumber == flatNumber).ToList();
            CommonUtility.setDropDownSearchable(comboBox_tenant);

        }

        private void comboBox_tenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            TenantDetail tenantDetails = comboBox_tenant.SelectedItem as TenantDetail;

            if (tenantDetails != null)
            {
                long tenantId = tenantDetails.TenantId;
                this.tenantId = tenantId;

                if (tenantId != 0)
                {
                    if (db.UserDocuments.Where(x => x.TenantId == tenantId).Count() > 0)
                    {
                        dataGridView_tenantFiles.DataSource = db.UserDocuments.Where(x => x.TenantId == tenantId).ToList();

                        dataGridView_tenantFiles.Columns["FlatNumber"].Visible = false;
                        dataGridView_tenantFiles.Columns["TenantId"].Visible = false;
                        dataGridView_tenantFiles.Columns["DocumentData"].Visible = false;
                    }
                }
            }
            else
            {
                dataGridView_tenantFiles.DataSource = "";
            }
        }

        private void button_ownerFileDownload_Click(object sender, EventArgs e)
        {
            if (dataGridView_ownerFiles.CurrentRow != null)
            {
                int index = dataGridView_ownerFiles.CurrentRow.Index;

                String documentName = dataGridView_ownerFiles.Rows[index].Cells["DocumentName"].Value.ToString();
                byte[] fileData = db.UserDocuments.Where(x => x.FlatNumber == flatNumber && x.DocumentName.Equals(documentName)).Single().DocumentData;
                string filePath = CommonUtility.getFilePathWithoutExtension();

                if (filePath.Length > 0)
                {
                    CommonUtility.writeToFile(filePath, fileData);
                    CommonUtility.showSuccessPopUp("Successfully Written to " + filePath);
                }
            }
        }

        private void button_tenantFileDownload_Click(object sender, EventArgs e)
        {
            if (dataGridView_tenantFiles.CurrentRow != null)
            {
                int index = dataGridView_tenantFiles.CurrentRow.Index;

                String documentName = dataGridView_tenantFiles.Rows[index].Cells["DocumentName"].Value.ToString();
                byte[] fileData = db.UserDocuments.Where(x => x.FlatNumber == flatNumber && x.TenantId == tenantId && x.DocumentName.Equals(documentName)).Single().DocumentData;
                string filePath = CommonUtility.getFilePathWithoutExtension();

                if (filePath.Length > 0)
                {
                    CommonUtility.writeToFile(filePath, fileData);
                    CommonUtility.showSuccessPopUp("Successfully Written to " + filePath);
                }
            }
        }
    }
}
