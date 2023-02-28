using csharp_lb4_wf.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_lb4_wf
{
    public partial class AddEmployee : Form
    {
        private Company Company;
        public AddEmployee(Company company)
        {
            InitializeComponent();
            Company = company;

            UpdateCbDepartment();
        }

        private void UpdateCbDepartment()
        {
            cbDepartment.Items.Clear();

            foreach (var department in Company.Departments)
            {
                cbDepartment.Items.Add(department.Id);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Department? department = Company.Departments.Find(x => x.Id == cbDepartment.Text);

            if (department is null)
                return;

            Employee employee = new
                (
                employeeId: tbID.Text,
                employeeName: tbName.Text,
                salary: nudSalary.Value,
                department: department
                );

            try
            {
                Company.AddEmployee(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }
    }
}
