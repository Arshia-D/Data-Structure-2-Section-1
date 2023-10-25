using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ST2_S1
{
    internal class EmployeeDataTable
    {
        private DataTable dataTable;

        public EmployeeDataTable()
        {
            Initialize();
        }

        private void Initialize()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Employee_Name", typeof(string));
        }

        public DataTable DataTable
        {
            get { return dataTable; }
        }

        public void LoadEmployees(List<Employee> employees)
        {
            dataTable.Clear();
            foreach (var employee in employees)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Employee_Name"] = employee.Employee_Name;
                dataTable.Rows.Add(newRow);
            }
        }

        public void AddEmployee(Employee employee)
        {
            DataRow newRow = dataTable.NewRow();
            newRow["Employee_Name"] = employee.Employee_Name;
            dataTable.Rows.Add(newRow);
        }

        public string GetEmployeeNameAt(int index)
        {
            if (index >= 0 && index < dataTable.Rows.Count)
            {
                return dataTable.Rows[index]["Employee_Name"].ToString();
            }
            return null;
        }
    }
}
