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
    public partial class UserBills : Form
    {
        SMEntities db = CommonUtility.getConnection();
        long selectedFlatId = 0;

        public UserBills()
        {
            InitializeComponent();
        }

        internal void setFlatId(long selectedFlatId)
        {
            this.selectedFlatId = selectedFlatId;
            //throw new NotImplementedException();
        }

        private void UserBills_Load(object sender, EventArgs e)
        {
            dataGridView_userBills.DataSource = db.UserBills.Where(x => x.FlatNumber == selectedFlatId).ToList();
            
        }
    }
}
