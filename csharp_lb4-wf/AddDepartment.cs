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
    public partial class AddDepartment : Form
    {
        private Company Company;
        public AddDepartment(Company company)
        {
            InitializeComponent();
            Company = company;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Department department = new(tbID.Text, tbName.Text);

            try
            {              
                Company.AddDepartment(department);
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
