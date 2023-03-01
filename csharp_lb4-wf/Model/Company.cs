using System;
using System.Collections.Generic;

namespace csharp_lb4_wf.Model
{
    public class Company
    {
        public string Name { get; }
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }

        public Company(string name)
        {
            Departments = new List<Department>();
            Employees = new List<Employee>();
            Name = name;
        }
        
        public Company(string name, List<Department> departments, List<Employee> employees)
        {
            Departments = departments;
            Employees = employees;
            Name = name;
        }
        public Company()
        {
            
        }
        public void AddDepartment(Department department)
        {
            if (department.IsValid())            
                Departments.Add(department);            
            else            
                throw new ArgumentException("Invalid department information");
            
        }

        public void UpdateDepartment(string departmentId, string name)
        {
            var department = Departments.Find(d => d.Id == departmentId);
            if (department != null)
            {
                department.Name = name;
            }
            else
            {
                throw new ArgumentException("Department not found");
            }
        }

        public void RemoveDepartment(string departmentId)
        {
            var department = Departments.Find(d => d.Id == departmentId);
            if (department is null)
                throw new ArgumentException("Department not found");


            var employeesToRemove = Employees.Where(x => x.Department == department).ToList();
            foreach (var item in employeesToRemove)
            {
                Employees.Remove(item);
            }            
            Departments.Remove(department);
        }

        public void AddEmployee(Employee employee)
        {
            if (employee.IsValid())
            {
                Employees.Add(employee);
            }
            else
            {
                throw new ArgumentException("Invalid employee information");
            }
        }

        public void UpdateEmployee(string employeeId, string fullName, decimal salary)
        {
            var employee = Employees.Find(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                employee.EmployeeName = fullName;
                employee.Salary = salary;
            }
            else
            {
                throw new ArgumentException("Employee not found");
            }
        }

        public void RemoveEmployee(string employeeId)
        {
            var employee = Employees.Find(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                Employees.Remove(employee);
            }
            else
            {
                throw new ArgumentException("Employee not found");
            }
        }

        public List<Employee> GetEmployeesByDepartment(string departmentId)
        {
            return Employees.FindAll(e => e.Department.Id == departmentId);
        }

        public List<Employee> GetEmployeesSortedByName()
        {
            var sortedEmployees = Employees;
            sortedEmployees.Sort((e1, e2) => e1.EmployeeName.CompareTo(e2.EmployeeName));
            return sortedEmployees;
        }
        public List<Employee> GetEmployeesSortedByID()
        {
            var sortedEmployees = Employees;
            sortedEmployees.Sort((e1, e2) => e1.EmployeeId.CompareTo(e2.EmployeeId));
            return sortedEmployees;
        }

        public List<Employee> GetEmployeesSortedByDepartment()
        {
            var sortedEmployees = Employees;
            sortedEmployees.Sort((e1, e2) => e1.Department.Id.CompareTo(e2.Department.Id));
            return sortedEmployees;
        }

        public List<Employee> GetEmployeesSortedBySalary()
        {
            var sortedEmployees = Employees;
            sortedEmployees.Sort((e1, e2) => e1.Salary.CompareTo(e2.Salary));
            return sortedEmployees;
        }        
    }
}
