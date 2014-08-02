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
    public partial class PaymentHistory : Form
    {
        long selectedFlatId;
        SMEntities db = CommonUtility.getConnection();
        public PaymentHistory()
        {
            InitializeComponent();
        }

        internal void setFlatId(long selectedFlatId)
        {
            this.selectedFlatId = selectedFlatId;
            


          //s  throw new NotImplementedException();pa
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.UserPayments.Where(x => x.FlatNumber == selectedFlatId).ToList();
            
            dataGridView1.Columns["UserPayment1"].Visible = false;
            dataGridView1.Columns["UserPayment2"].Visible = false;
            dataGridView1.Columns["PaidTime"].Visible = false;
        }
    }
}
