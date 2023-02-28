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
    public partial class ShowAllEmployees : Form
    {
        List<Employee> Employees;
        public ShowAllEmployees(List<Employee> employees)
        {
            InitializeComponent();

            Employees = employees;

            dgEmployees.DataSource = Employees;
        }
    }
}
