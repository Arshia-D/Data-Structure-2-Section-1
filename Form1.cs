using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATA_ST2_S1
{
    public partial class MyCustomForm : Form
    {
        private EmployeeDataTable employeeData;
        private Department currentSelectedDepartment;

        private Company company; 
        public MyCustomForm()
        {
            InitializeComponent();
            employeeData = new EmployeeDataTable();
            dataGridViewEmployees.DataSource = employeeData.DataTable;
            company = new Company("Your Company Name", "Manager Name");
            TreeNode companyTree = company_structure.CreateCompanyHierarchy();
            treeView.Nodes.Add(companyTree);

        }


        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            Department newDepartment = new Department
            {
                Name = txtDepartmentName.Text,
                ManagerName = txtManagerName.Text
            };
            TreeNode newNode = new TreeNode($"{newDepartment.Name} (Manager: {newDepartment.ManagerName})");
            newNode.Tag = newDepartment;
            treeView.Nodes.Add(newNode);
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView.SelectedNode;
            if (selectedNode != null && selectedNode.Tag is Department department)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to remove the department '{department.Name}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    selectedNode.Remove();
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            Employee newEmployee = new Employee(employeeName);

            if (currentSelectedDepartment != null)
            {
                currentSelectedDepartment.Employees.Add(newEmployee);
                employeeData.AddEmployee(newEmployee);
            }            
        }

        private void ConfigureDataGridView()
        {
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.Columns.Clear();
            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Employee_Name",
                HeaderText = "Employee Name"
            });

            if (treeView.SelectedNode?.Tag is Department selectedDepartment)
            {
                dataGridViewEmployees.DataSource = selectedDepartment.Employees;
            }
        }


        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewEmployees.SelectedRows[0].Index;
                string employeeNameToRemove = employeeData.GetEmployeeNameAt(selectedIndex);

                if (currentSelectedDepartment != null)
                {
                    var employeeToRemove = currentSelectedDepartment.Employees.FirstOrDefault(emp => emp.Employee_Name == employeeNameToRemove);
                    if (employeeToRemove != null)
                    {
                        currentSelectedDepartment.Employees.Remove(employeeToRemove);
                    }
                }

                employeeData.DataTable.Rows.RemoveAt(selectedIndex);
            }          
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Department selectedDepartment = (Department)e.Node.Tag;
            currentSelectedDepartment = selectedDepartment;  
            employeeData.LoadEmployees(selectedDepartment.Employees);

        }

        private void btnAddSubDepartment_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                Department parentDepartment = (Department)treeView.SelectedNode.Tag;
                Department subDepartment = new Department
                {
                    Name = txtSubDepartmentName.Text,
                    ManagerName = txtSubDepartmentManager.Text
                };
                TreeNode subDepartmentNode = new TreeNode($"{subDepartment.Name} (Manager: {subDepartment.ManagerName})");
                subDepartmentNode.Tag = subDepartment;
                treeView.SelectedNode.Nodes.Add(subDepartmentNode);
                parentDepartment.SubDepartments.Add(subDepartment);
                company.UpdateEmployeeCount(parentDepartment);
            }
        }

        private void btnRemoveSubDepartment_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null && treeView.SelectedNode.Parent != null)
            {
                TreeNode subDepartmentNode = treeView.SelectedNode;
                TreeNode parentDepartmentNode = treeView.SelectedNode.Parent;

                Department subDepartment = (Department)subDepartmentNode.Tag;
                Department parentDepartment = (Department)parentDepartmentNode.Tag;

                parentDepartment.SubDepartments.Remove(subDepartment);
                company.UpdateEmployeeCount(parentDepartment);

                subDepartmentNode.Remove();
            }
        }

        private void btnMoveEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0 && treeView.SelectedNode != null)
            {
                string selectedEmployeeName = employeeData.GetEmployeeNameAt(dataGridViewEmployees.SelectedRows[0].Index);

                Employee selectedEmployee = currentSelectedDepartment?.Employees.FirstOrDefault(emp => emp.Employee_Name == selectedEmployeeName);

                if (selectedEmployee == null) return; 

                Department currentDepartment = currentSelectedDepartment;

                Department newDepartment = ShowDepartmentSelectionDialog();
                if (newDepartment == null)
                {
                    return;
                }

                if (currentDepartment == newDepartment)
                {
                    MessageBox.Show("The selected department is the same as the current department. No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                currentDepartment.Employees.Remove(selectedEmployee);
                newDepartment.Employees.Add(selectedEmployee);
                
                employeeData.LoadEmployees(currentDepartment.Employees);

                company.UpdateEmployeeCount(currentDepartment);
                company.UpdateEmployeeCount(newDepartment);
            }
            
        }

        private Department ShowDepartmentSelectionDialog()
        {
            using (Form departmentSelectionForm = new Form())
            {
                departmentSelectionForm.Text = "Select Destination Department";
                TreeView departmentTreeView = new TreeView() { Dock = DockStyle.Fill };
                departmentSelectionForm.Controls.Add(departmentTreeView);

                foreach (TreeNode node in treeView.Nodes)
                {
                    departmentTreeView.Nodes.Add((TreeNode)node.Clone());
                }

                Button btnSelect = new Button() { Text = "Select", Dock = DockStyle.Bottom };
                departmentSelectionForm.Controls.Add(btnSelect);

                Department selectedDepartment = null;
                btnSelect.Click += (s, e) =>
                {
                    if (departmentTreeView.SelectedNode != null)
                    {
                        selectedDepartment = (Department)departmentTreeView.SelectedNode.Tag;
                        departmentSelectionForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please select a department first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                departmentSelectionForm.ShowDialog();
                return selectedDepartment;
            }
        }
        private void btnMoveSubDepartment_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode == null || treeView.SelectedNode.Parent == null)
            {
                MessageBox.Show("Please select a sub-department to move.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            TreeNode subDepartmentNode = treeView.SelectedNode;
            Department subDepartment = (Department)subDepartmentNode.Tag;
            Department currentParent = (Department)subDepartmentNode.Parent.Tag;
            
            Department targetDepartment = ShowDepartmentSelectionDialog();
            if (targetDepartment == null)
            {
                return; 
            }

            if (currentParent == targetDepartment)
            {
                MessageBox.Show("The selected department is the same as the current department. No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            currentParent.SubDepartments.Remove(subDepartment);
            subDepartmentNode.Remove();
            company.UpdateEmployeeCount(currentParent);
            
            targetDepartment.SubDepartments.Add(subDepartment);
            TreeNode targetNode = FindTreeNodeForDepartment(targetDepartment);
            TreeNode newNode = new TreeNode(subDepartmentNode.Text);
            newNode.Tag = subDepartment;
            targetNode.Nodes.Add(newNode);
            company.UpdateEmployeeCount(targetDepartment);
        }
        private TreeNode FindTreeNodeForDepartment(Department department)
        {
            return FindTreeNodeForDepartmentRecursively(treeView.Nodes, department);
        }

        private TreeNode FindTreeNodeForDepartmentRecursively(TreeNodeCollection nodes, Department department)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag == department)
                {
                    return node;
                }
                TreeNode found = FindTreeNodeForDepartmentRecursively(node.Nodes, department);
                if (found != null)
                {
                    return found;
                }
            }
            return null;
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                if (e.RowIndex + 1 < dataGridViewEmployees.Rows.Count)
                {
                    dataGridViewEmployees.Rows[e.RowIndex + 1].Selected = true;
                }
                else
                {
                    dataGridViewEmployees.Rows[dataGridViewEmployees.Rows.Count - 1].Selected = true;
                }
            }
            else
            {
                dataGridViewEmployees.ClearSelection();

            }

            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= dataGridViewEmployees.RowCount || e.ColumnIndex >= dataGridViewEmployees.ColumnCount)
                return;

            object cellValue = dataGridViewEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (cellValue == null)
                return;

            string employeeName = cellValue.ToString();
            MessageBox.Show($"You clicked on {employeeName}");
        }

    }
}

