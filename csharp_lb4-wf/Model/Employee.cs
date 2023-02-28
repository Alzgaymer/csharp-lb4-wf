using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace csharp_lb4_wf.Model
{
    [Serializable]
    public class Employee
    {
        public string EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee name is required.")]
        [StringLength(50, ErrorMessage = "Employee name cannot be longer than 50 characters.")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Salary value is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive number.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "DepartmentId is required")]
        public Department Department { get; set; }

        public Employee(string employeeId, string employeeName, decimal salary, Department department)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Salary = salary;
            Department = department;
        }

        public bool IsValid()
        {
            var validationContext = new ValidationContext(this, null, null);
            var results = new List<ValidationResult>();
            return Validator.TryValidateObject(this, validationContext, results, true);
        }
    }

}