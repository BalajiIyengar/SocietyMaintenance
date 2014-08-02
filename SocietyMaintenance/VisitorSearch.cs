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
    public partial class VisitorSearch : Form
    {
        SMEntities db = CommonUtility.getConnection();

        public VisitorSearch()
        {
            InitializeComponent();
        }

        private void VisitorSearch_Load(object sender, EventArgs e)
        {
            comboBox_flatNumbers.DataSource = CommonUtility.getFlatNumbers();

            comboBox_visitorTypes.DataSource = db.VisitorTypesMasters.ToList();
            comboBox_visitorTypes.DisplayMember = "TypeName";
            comboBox_visitorTypes.ValueMember = "TypeId";

            dateTimePicker_fromDate.Text = DateTime.Now.Date.ToString();
            dateTimePicker_toDate.Text = DateTime.Now.Date.ToString();

        }

        private void button_searchVisitors_Click(object sender, EventArgs e)
        {
            DateTime fromDate = DateTime.Parse(dateTimePicker_fromDate.Text);
            DateTime toDate = DateTime.Parse( dateTimePicker_toDate.Text);

            List<VisitorDetail> visitors =  db.VisitorDetails.Where(x=>x.VisitDate >= fromDate && x.VisitDate <= toDate).ToList();

            if (checkBox_flat.Checked && checkBox_visitor.Checked)
            {
                VisitorTypesMaster master = comboBox_visitorTypes.SelectedItem as VisitorTypesMaster;
                long flatNumber = long.Parse(comboBox_flatNumbers.Text);

                visitors = db.VisitorDetails.Where(x => x.FlatNumber == flatNumber && x.VisitorType == master.TypeId && x.VisitDate >= fromDate && x.VisitDate <= toDate).ToList();
            }
            if (checkBox_flat.Checked)
            {
                long flatNumber = long.Parse(comboBox_flatNumbers.Text);
                visitors = db.VisitorDetails.Where(x => x.FlatNumber == flatNumber && x.VisitDate >= fromDate && x.VisitDate <= toDate).ToList();
            }

            if (checkBox_visitor.Checked)
            {
                VisitorTypesMaster master = comboBox_visitorTypes.SelectedItem as VisitorTypesMaster;
                visitors = db.VisitorDetails.Where(x => x.VisitorType == master.TypeId && x.VisitDate >= fromDate && x.VisitDate <= toDate).ToList();
            }
            dataGridView_visitors.DataSource = visitors;
            if (visitors.Count > 0)
            {
                dataGridView_visitors.Columns["VisitDate"].Visible = false;
                dataGridView_visitors.Columns["VisitTime"].Visible = false;
                dataGridView_visitors.Columns["VisitPurpose"].Visible = false;
                dataGridView_visitors.Columns["VisitorImage"].Visible = false;
                dataGridView_visitors.Columns["VisitorType"].Visible = false;
            }

            label_visitorCount.Text = visitors.Count.ToString();
        }

        private void checkBox_flat_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_flat.Checked)
                comboBox_flatNumbers.Visible = true;
            else
                comboBox_flatNumbers.Visible = false;
        }

        private void checkBox_visitor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_visitor.Checked)
                comboBox_visitorTypes.Visible = true;
            else
                comboBox_visitorTypes.Visible = false;
        }

        
    }
}
