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
    public partial class Admin_Files : Form
    {
        SMEntities db = CommonUtility.getConnection();


        public Admin_Files()
        {
            InitializeComponent();
        }

        private void Admin_Files_Load(object sender, EventArgs e)
        {
            if (db.UserDocuments.Where(x => x.FlatNumber == 0 && x.TenantId == 0).Count() > 0)
            {
                dataGridView_files.DataSource = db.UserDocuments.Where(x => x.FlatNumber == 0 && x.TenantId == 0).ToList();
                dataGridView_files.Columns["FlatNumber"].Visible = false;
                dataGridView_files.Columns["TenantId"].Visible = false;
                dataGridView_files.Columns["DocumentData"].Visible = false;

               // dataGridView_files.CellClick -= new DataGridViewCellEventHandler(dataGridView_files_cellClicked);
               // dataGridView_files.CellClick += new DataGridViewCellEventHandler(dataGridView_files_cellClicked);

            }


            comboBox_fileType.DataSource = db.DocumentTypeMasters.Select(x => x.DocType).ToList();
        }

        private void dataGridView_files_cellClicked(object sender, DataGridViewCellEventArgs e)
        {

           

        }

        String fileLocation = "";
        String displayFileName = "";
        List<string> selectedFileTypes = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox_fileType.Items.Count > 0)
            {  
                OpenFileDialog fileDialog = new OpenFileDialog();

                DialogResult result = fileDialog.ShowDialog();

                if (result.Equals(DialogResult.OK))
                {
                    String fileType = comboBox_fileType.Text;
                    fileLocation = fileDialog.FileName;
                    String fileName = fileDialog.SafeFileName;

                    String fileExtension = CommonUtility.getFileExtension(fileName);
                    displayFileName = "Society" + ("_") + fileType + "." + fileExtension;

                    textBox_fileName.Text = displayFileName;

                    selectedFileTypes.Add(fileType);


                    List<string> dbFileTypes = db.DocumentTypeMasters.Select(x => x.DocType).ToList();

                    foreach (string selectedFileType in selectedFileTypes)
                    {
                        dbFileTypes.Remove(selectedFileType);
                    }


                    comboBox_fileType.DataSource = dbFileTypes;

                }
            }
        }

        private void button_uploadFile_Click(object sender, EventArgs e)
        {
            if (textBox_fileName.Text.Length > 0)
            {
                CommonUtility.uploadFile(fileLocation, 0, 0, displayFileName);
                CommonUtility.showSuccessPopUp("Successfully Uploaded " + displayFileName);
            }
        }

        private void button_downloadFile_Click(object sender, EventArgs e)
        {
            if (dataGridView_files.CurrentRow != null)
            {
                int index = dataGridView_files.CurrentRow.Index;

                String documentName = dataGridView_files.Rows[index].Cells["DocumentName"].Value.ToString();
                byte[] fileData = db.UserDocuments.Where(x => x.FlatNumber == 0 && x.TenantId == 0 && x.DocumentName.Equals(documentName)).Single().DocumentData;
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
