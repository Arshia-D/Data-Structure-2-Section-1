using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace DATA_ST2_S1
{
    internal class company_structure
    {
        
        private const int TotalDepartments = 15;
        private const int SubDepartmentsPerLevel = 4;
        private const int TotalLevels = 4;

        public static TreeNode CreateCompanyHierarchy()
        {
            
            var rootDepartment = new Department("Company Of Management", "CEO");
            var rootNode = new TreeNode(rootDepartment.Name)
            {
                Tag = rootDepartment
            };

            
            for (int i = 1; i <= TotalDepartments; i++)
            {
                var department = new Department($"Department {i}", $"Manager {i}");
                var departmentNode = new TreeNode(department.Name)
                {
                    Tag = department
                };

                
                PopulateSubDepartments(departmentNode, TotalLevels);

                rootNode.Nodes.Add(departmentNode);
            }

            return rootNode;
        }

        private static void PopulateSubDepartments(TreeNode parentNode, int remainingLevels)
        {
            if (remainingLevels <= 0)
                return;

            for (int i = 1; i <= SubDepartmentsPerLevel; i++)
            {
                var subDepartment = new Department($"Sub-Department {i}", $"Manager {i}");
                var subDepartmentNode = new TreeNode(subDepartment.Name)
                {
                    Tag = subDepartment
                };
                
                PopulateSubDepartments(subDepartmentNode, remainingLevels - 1);

                parentNode.Nodes.Add(subDepartmentNode);
            }
        }
    }
}