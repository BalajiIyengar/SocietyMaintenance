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
    public partial class ViewEmployees : Form
    {
        SMEntities db = CommonUtility.getConnection();

        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            dataGridView_employees.DataSource = db.EmployeeDetails.ToList();

            if (db.EmployeeDetails.Count() > 0)
            {
                dataGridView_employees.Columns["EmployeeId"].Visible = false;
                dataGridView_employees.Columns["EmpImage"].Visible = false;
                dataGridView_employees.Columns["Address"].Visible = false;
                dataGridView_employees.Columns["EmpImage"].Visible = false;

                dataGridView_employees.CellClick -= editEmployeeDetail;
                dataGridView_employees.CellClick += editEmployeeDetail;
            }
        }

        private void editEmployeeDetail(object sender, DataGridViewCellEventArgs e)
        {
            long employeeId = 0;

            int index = dataGridView_employees.CurrentRow.Index;
            employeeId = long.Parse(dataGridView_employees.Rows[index].Cells["EmployeeId"].Value.ToString());

            Employees employeeDetails = new Employees(employeeId);
            employeeDetails.Show();

        }

    }
}
