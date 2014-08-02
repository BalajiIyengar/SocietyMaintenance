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
    public partial class AddDocumentType : Form
    {
        SMEntities db = CommonUtility.getConnection();

        public AddDocumentType()
        {
            InitializeComponent();
        }

        private void button_addNewDocType_Click(object sender, EventArgs e)
        {
            if (textBox_newDocType.Text.Length > 0)
            {
                List<string> docTypes = db.DocumentTypeMasters.Select(x => x.DocType).ToList();

                if (docTypes.Contains(textBox_newDocType.Text))
                {
                    CommonUtility.showErrorPopUp("Already Contains " + textBox_newDocType.Text);
                    return;
                }

                DocumentTypeMaster newMaster = new DocumentTypeMaster();
                long lastDocId = 0;

                if(db.DocumentTypeMasters.Count() > 0)
                 lastDocId = db.DocumentTypeMasters.Max(x => x.DocId) + 1;
                
                newMaster.DocType = textBox_newDocType.Text;
                newMaster.DocId = lastDocId + 1;

                db.DocumentTypeMasters.Add(newMaster);

                db.SaveChanges();

                CommonUtility.showSuccessPopUp("Successfully Added " + textBox_newDocType.Text + " Doc Type");

                this.Close();

                new AddFlats().Show();
            }

        }
    }
}
