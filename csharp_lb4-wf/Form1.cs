using csharp_lb4_wf.Model;

namespace csharp_lb4_wf
{
    public partial class Form1 : Form
    {
        public List<Company> Companies = new();
        public Form1()
        {
            InitializeComponent();        
        }

        private Company? GetSelectedCompany()
        {
            if (lvCompanies.SelectedItems.Count == 0 || lvCompanies.Items.Count == 0 )
                return null;

            return lvCompanies.SelectedItems[0].Tag as Company;
        }

        private void btAddCompany_Click(object sender, EventArgs e)
        {
            Company company = new(tbCompanyName.Text);    
            Companies.Add(company);
            UpdateListView();
        }

        private void UpdateListView()
        {            
            lvCompanies.Items.Clear();
          
            foreach (var company in Companies)
            {
                ListViewItem item = new ListViewItem(company.Name);
               
                item.Tag = company;

                lvCompanies.Items.Add(item);
            }
        }

        private void lvCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCompanies.SelectedItems.Count > 0)
            {             
                UpdateDepartmentsDataGrid();
            }
        }
        private void UpdateDepartmentsDataGrid()
        {
            if (GetSelectedCompany() is null)
            {
                dgDepartments.DataSource = null;    
                return;
            }
            dgDepartments.DataSource = new List<Department>();
            var departments = GetSelectedCompany().Departments;
            dgDepartments.DataSource = departments.Count > 0 ? departments : null;
        }

        private void btAddDepartment_Click(object sender, EventArgs e)
        {
            var company = GetSelectedCompany();
            if ( company is null)
                return;         

            AddDepartment addDepartment = new(company);

            addDepartment.ShowDialog();

            UpdateDepartmentsDataGrid();
        }

        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            var company = GetSelectedCompany();
            if (company is null)
                return;                      

            AddEmployee addEmployee = new(company);

            addEmployee.ShowDialog();

            UpdateEmployeeDataGrid();

        }
        private void UpdateEmployeeDataGrid()
        {
            if (GetSelectedCompany() is null)
            {
                dgEmployees.DataSource = null;
                return;
            }


            //dgEmployees.DataSource = null;
            var employees = GetSelectedCompany().Employees;

            dgEmployees.DataSource = employees.Count > 0 ? employees: null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var dep = new Department("01", "f");
            var companies = new List<Company>() {
                new Company(
                    "11",
                new List<Department>()
                {
                   dep
                },
                new List<Employee>()
                {
                    new Employee("000","a", 1000, dep),
                    new Employee("100","b", 1000, dep),
                }
                )
            };


            foreach (var item in companies)
            {
                ListViewItem listViewItem = new(item.Name);

                listViewItem.Tag = item;

                lvCompanies.Items.Add(listViewItem);
            }

        }

        private void dgDepartments_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDepartments.SelectedRows.Count == 0)
                return;

            if (GetSelectedCompany() is null)
                return;

            var department = dgDepartments.SelectedRows[0].DataBoundItem as Department;

            if (department is null) return;

            try
            {
                dgEmployees.DataSource = GetSelectedCompany()?.GetEmployeesByDepartment(department.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                UpdateEmployeeDataGrid();
            }
        }

        private void btDeleteEmloyee_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count == 0)
                return;

            if (GetSelectedCompany() is null)
                return;

            var employee = dgEmployees.SelectedRows[0].DataBoundItem as Employee;

            if (employee is null) return;

            try
            {
                GetSelectedCompany()?.RemoveEmployee(employee.EmployeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateEmployeeDataGrid();
            }
        }

        private void btDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (GetSelectedCompany() is null) return;

            if (dgDepartments.SelectedRows.Count == 0 ) return;   

            var department = dgDepartments.SelectedRows[0].DataBoundItem as Department;

            if (department is null) return;

            try
            {
                GetSelectedCompany().RemoveDepartment(department.Id);       
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateDepartmentsDataGrid();
                UpdateEmployeeDataGrid();
            }
        }

        private void btDeleteCompany_Click(object sender, EventArgs e)
        {
            var company = GetSelectedCompany();
            if (company is null) return;

            foreach (ListViewItem item in lvCompanies.Items)
            {
                if (item.Tag == company)
                {
                    lvCompanies.Items.Remove(item);
                    break;
                }
            }

            UpdateDepartmentsDataGrid();
            UpdateEmployeeDataGrid();

        }
        int descendingID = 0;
        private void btSortByID_Click(object sender, EventArgs e)
        {
            if (GetSelectedCompany() is null)
                return;

            if (descendingID % 2 == 0)
            {
                dgEmployees.DataSource = null;

                dgEmployees.DataSource = GetSelectedCompany().GetEmployeesSortedByID();
            }
            else
            {
                var data = GetSelectedCompany().GetEmployeesSortedByID();
                data.Reverse();
                dgEmployees.DataSource = null;

                dgEmployees.DataSource = data;
            }
            descendingID++;
        }

        int descendingName = 0;
        private void btSortByName_Click(object sender, EventArgs e)
        {
            if (GetSelectedCompany() is null)
                return;

            if (descendingName % 2 == 0)
            {
                dgEmployees.DataSource = null;

                dgEmployees.DataSource = GetSelectedCompany().GetEmployeesSortedByName();
            }
            else
            {
                var data = GetSelectedCompany().GetEmployeesSortedByName();
                data.Reverse();
                dgEmployees.DataSource = null;

                dgEmployees.DataSource = data;
            }            
            descendingName++;
        }

        int descendingSalary = 0;
        private void btSortBySalary_Click(object sender, EventArgs e)
        {
            if (GetSelectedCompany() is null)
                return;

            if (descendingSalary % 2 == 0)
            {
                dgEmployees.DataSource = null;

                dgEmployees.DataSource = GetSelectedCompany().GetEmployeesSortedBySalary();
            }
            else
            {
                var data = GetSelectedCompany().GetEmployeesSortedBySalary();
                data.Reverse();
                dgEmployees.DataSource = null;

                dgEmployees.DataSource = data;
            }
            descendingSalary++;
        }
        
        int descendingDepartment = 0;
        private void btSortByDepartment_Click(object sender, EventArgs e)
        {
            if (GetSelectedCompany() is null)
                return;

            if (descendingDepartment % 2 == 0)
            {
                dgEmployees.DataSource = null;

                dgEmployees.DataSource = GetSelectedCompany().GetEmployeesSortedByDepartment();
            }
            else
            {
                var data = GetSelectedCompany().GetEmployeesSortedByDepartment();
                data.Reverse();
                dgEmployees.DataSource = null;

                dgEmployees.DataSource = data;
            }
            descendingDepartment++;
        }

        private void btShoAll_Click(object sender, EventArgs e)
        {
            var company = GetSelectedCompany();
            if (company is null) return;

            if (dgDepartments.SelectedRows.Count == 0) return;

            var department =  dgDepartments.SelectedRows[0].DataBoundItem as Department;

            ShowAllEmployees showAllEmployees = new(company.Employees.Where(x => x.Department == department).ToList());

            showAllEmployees.ShowDialog();
        }
    }
}