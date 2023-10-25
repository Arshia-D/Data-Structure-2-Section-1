using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ST2_S1
{
    internal class Company
    {
        public Department TopDepartment { get; set; }

        public Company(string companyName, string managerName)
        {
            TopDepartment = new Department { Name = companyName, ManagerName = managerName };
        }

        public void AddSubDepartment(Department parentDepartment, Department subDepartment)
        {
            parentDepartment?.SubDepartments?.Add(subDepartment);
            UpdateEmployeeCount(parentDepartment);
        }

        public void RemoveSubDepartment(Department parentDepartment, Department subDepartment)
        {
            parentDepartment?.SubDepartments?.Remove(subDepartment);
            UpdateEmployeeCount(parentDepartment);
        }

        public void AddEmployee(Department department, Employee employee)
        {
            department?.Employees?.Add(employee);
            UpdateEmployeeCount(department);
        }

        public void RemoveEmployee(Department department, Employee employee)
        {
            department?.Employees?.Remove(employee);
            UpdateEmployeeCount(department);
        }

        public void MoveEmployee(Employee employee, Department sourceDepartment, Department destinationDepartment)
        {
           
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "Employee cannot be null.");
            }

            if (sourceDepartment == null)
            {
                throw new ArgumentNullException(nameof(sourceDepartment), "Source department cannot be null.");
            }

            if (destinationDepartment == null)
            {
                throw new ArgumentNullException(nameof(destinationDepartment), "Destination department cannot be null.");
            }

           
            if (!sourceDepartment.Employees.Contains(employee))
            {
                throw new ArgumentException("The specified employee is not present in the source department.", nameof(employee));
            }

            
            if (destinationDepartment.Employees.Contains(employee))
            {
                throw new ArgumentException("The specified employee is already present in the destination department.", nameof(employee));
            }

            
            sourceDepartment?.Employees?.Remove(employee);
            destinationDepartment?.Employees?.Add(employee);

            UpdateEmployeeCount(sourceDepartment);
            UpdateEmployeeCount(destinationDepartment);
        }

        public void MoveSubDepartment(Department subDepartment, Department sourceDepartment, Department destinationDepartment)
        {
            sourceDepartment?.SubDepartments?.Remove(subDepartment);
            destinationDepartment?.SubDepartments?.Add(subDepartment);
            UpdateEmployeeCount(sourceDepartment);
            UpdateEmployeeCount(destinationDepartment);
        }

        public void UpdateEmployeeCount(Department department)
        {
           
            if (department != null)
            {
                department.EmployeeCount = CalculateTotalEmployees(department);
            }
        }

        public int CalculateTotalEmployees(Department department)
        {
            if (department == null) return 0;

            int totalEmployees = department.Employees?.Count ?? 0;

            foreach (var subDept in department.SubDepartments ?? Enumerable.Empty<Department>())
            {
                totalEmployees += CalculateTotalEmployees(subDept);
            }

            return totalEmployees;
            
        }

    }

}

