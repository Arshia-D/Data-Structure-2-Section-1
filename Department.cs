using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ST2_S1
{
    internal class Department
    {
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Department> SubDepartments { get; set; }
        public int EmployeeCount { get; set; }

        public Department(string name, string managerName)
        {
            Name = name;
            ManagerName = managerName;
            Employees = new List<Employee>();
            SubDepartments = new List<Department>();
        }

        public Department()
        {
            Employees = new List<Employee>();
            SubDepartments = new List<Department>();
        }
    }
}
    

