namespace DATA_ST2_S1
{
    partial class MyCustomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label_EmployeeName = new System.Windows.Forms.Label();
            this.label_ManagerName = new System.Windows.Forms.Label();
            this.label_DepartmentName = new System.Windows.Forms.Label();
            this.btnAddSubDepartment = new System.Windows.Forms.Button();
            this.btnRemoveSubDepartment = new System.Windows.Forms.Button();
            this.btnMoveEmployee = new System.Windows.Forms.Button();
            this.btnMoveSubDepartment = new System.Windows.Forms.Button();
            this.txtSubDepartmentName = new System.Windows.Forms.TextBox();
            this.txtSubDepartmentManager = new System.Windows.Forms.TextBox();
            this.label_SubDepartmentName = new System.Windows.Forms.Label();
            this.label_SubDepartmentManager = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(830, 28);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(723, 251);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(34, 415);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(111, 73);
            this.btnAddDepartment.TabIndex = 1;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.Location = new System.Drawing.Point(151, 415);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(111, 73);
            this.btnRemoveDepartment.TabIndex = 2;
            this.btnRemoveDepartment.Text = "Remove Department";
            this.btnRemoveDepartment.UseVisualStyleBackColor = true;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(34, 494);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(111, 73);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(151, 494);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(111, 73);
            this.btnRemoveEmployee.TabIndex = 4;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(259, 202);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(173, 26);
            this.txtDepartmentName.TabIndex = 5;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(259, 253);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(173, 26);
            this.txtManagerName.TabIndex = 6;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(259, 302);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(173, 26);
            this.txtEmployeeName.TabIndex = 7;
            // 
            // label_EmployeeName
            // 
            this.label_EmployeeName.AutoSize = true;
            this.label_EmployeeName.Location = new System.Drawing.Point(115, 302);
            this.label_EmployeeName.Name = "label_EmployeeName";
            this.label_EmployeeName.Size = new System.Drawing.Size(125, 20);
            this.label_EmployeeName.TabIndex = 9;
            this.label_EmployeeName.Text = "Employee Name";
            // 
            // label_ManagerName
            // 
            this.label_ManagerName.AutoSize = true;
            this.label_ManagerName.Location = new System.Drawing.Point(119, 253);
            this.label_ManagerName.Name = "label_ManagerName";
            this.label_ManagerName.Size = new System.Drawing.Size(118, 20);
            this.label_ManagerName.TabIndex = 10;
            this.label_ManagerName.Text = "Manager Name";
            // 
            // label_DepartmentName
            // 
            this.label_DepartmentName.AutoSize = true;
            this.label_DepartmentName.Location = new System.Drawing.Point(111, 205);
            this.label_DepartmentName.Name = "label_DepartmentName";
            this.label_DepartmentName.Size = new System.Drawing.Size(140, 20);
            this.label_DepartmentName.TabIndex = 11;
            this.label_DepartmentName.Text = "Department Name";
            // 
            // btnAddSubDepartment
            // 
            this.btnAddSubDepartment.Location = new System.Drawing.Point(268, 415);
            this.btnAddSubDepartment.Name = "btnAddSubDepartment";
            this.btnAddSubDepartment.Size = new System.Drawing.Size(111, 73);
            this.btnAddSubDepartment.TabIndex = 12;
            this.btnAddSubDepartment.Text = "Add SubDepartment";
            this.btnAddSubDepartment.UseVisualStyleBackColor = true;
            this.btnAddSubDepartment.Click += new System.EventHandler(this.btnAddSubDepartment_Click);
            // 
            // btnRemoveSubDepartment
            // 
            this.btnRemoveSubDepartment.Location = new System.Drawing.Point(385, 415);
            this.btnRemoveSubDepartment.Name = "btnRemoveSubDepartment";
            this.btnRemoveSubDepartment.Size = new System.Drawing.Size(111, 73);
            this.btnRemoveSubDepartment.TabIndex = 13;
            this.btnRemoveSubDepartment.Text = "Remove SubDepartment";
            this.btnRemoveSubDepartment.UseVisualStyleBackColor = true;
            this.btnRemoveSubDepartment.Click += new System.EventHandler(this.btnRemoveSubDepartment_Click);
            // 
            // btnMoveEmployee
            // 
            this.btnMoveEmployee.Location = new System.Drawing.Point(268, 494);
            this.btnMoveEmployee.Name = "btnMoveEmployee";
            this.btnMoveEmployee.Size = new System.Drawing.Size(111, 73);
            this.btnMoveEmployee.TabIndex = 14;
            this.btnMoveEmployee.Text = "Move Employee";
            this.btnMoveEmployee.UseVisualStyleBackColor = true;
            this.btnMoveEmployee.Click += new System.EventHandler(this.btnMoveEmployee_Click);
            // 
            // btnMoveSubDepartment
            // 
            this.btnMoveSubDepartment.Location = new System.Drawing.Point(385, 494);
            this.btnMoveSubDepartment.Name = "btnMoveSubDepartment";
            this.btnMoveSubDepartment.Size = new System.Drawing.Size(111, 73);
            this.btnMoveSubDepartment.TabIndex = 15;
            this.btnMoveSubDepartment.Text = "Move SubDepartment";
            this.btnMoveSubDepartment.UseVisualStyleBackColor = true;
            this.btnMoveSubDepartment.Click += new System.EventHandler(this.btnMoveSubDepartment_Click);
            // 
            // txtSubDepartmentName
            // 
            this.txtSubDepartmentName.Location = new System.Drawing.Point(259, 156);
            this.txtSubDepartmentName.Name = "txtSubDepartmentName";
            this.txtSubDepartmentName.Size = new System.Drawing.Size(173, 26);
            this.txtSubDepartmentName.TabIndex = 16;
            // 
            // txtSubDepartmentManager
            // 
            this.txtSubDepartmentManager.Location = new System.Drawing.Point(259, 111);
            this.txtSubDepartmentManager.Name = "txtSubDepartmentManager";
            this.txtSubDepartmentManager.Size = new System.Drawing.Size(173, 26);
            this.txtSubDepartmentManager.TabIndex = 17;
            // 
            // label_SubDepartmentName
            // 
            this.label_SubDepartmentName.AutoSize = true;
            this.label_SubDepartmentName.Location = new System.Drawing.Point(82, 156);
            this.label_SubDepartmentName.Name = "label_SubDepartmentName";
            this.label_SubDepartmentName.Size = new System.Drawing.Size(169, 20);
            this.label_SubDepartmentName.TabIndex = 18;
            this.label_SubDepartmentName.Text = "SubDepartment Name";
            // 
            // label_SubDepartmentManager
            // 
            this.label_SubDepartmentManager.AutoSize = true;
            this.label_SubDepartmentManager.Location = new System.Drawing.Point(61, 117);
            this.label_SubDepartmentManager.Name = "label_SubDepartmentManager";
            this.label_SubDepartmentManager.Size = new System.Drawing.Size(190, 20);
            this.label_SubDepartmentManager.TabIndex = 19;
            this.label_SubDepartmentManager.Text = "SubDepartment Manager";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(830, 302);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersVisible = false;
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.RowTemplate.Height = 28;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(723, 355);
            this.dataGridViewEmployees.TabIndex = 20;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // MyCustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 679);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.label_SubDepartmentManager);
            this.Controls.Add(this.label_SubDepartmentName);
            this.Controls.Add(this.txtSubDepartmentManager);
            this.Controls.Add(this.txtSubDepartmentName);
            this.Controls.Add(this.btnMoveSubDepartment);
            this.Controls.Add(this.btnMoveEmployee);
            this.Controls.Add(this.btnRemoveSubDepartment);
            this.Controls.Add(this.btnAddSubDepartment);
            this.Controls.Add(this.label_DepartmentName);
            this.Controls.Add(this.label_ManagerName);
            this.Controls.Add(this.label_EmployeeName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnRemoveDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.treeView);
            this.Name = "MyCustomForm";
            this.Text = "Manager ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label_EmployeeName;
        private System.Windows.Forms.Label label_ManagerName;
        private System.Windows.Forms.Label label_DepartmentName;
        private System.Windows.Forms.Button btnAddSubDepartment;
        private System.Windows.Forms.Button btnRemoveSubDepartment;
        private System.Windows.Forms.Button btnMoveEmployee;
        private System.Windows.Forms.Button btnMoveSubDepartment;
        private System.Windows.Forms.TextBox txtSubDepartmentName;
        private System.Windows.Forms.TextBox txtSubDepartmentManager;
        private System.Windows.Forms.Label label_SubDepartmentName;
        private System.Windows.Forms.Label label_SubDepartmentManager;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
    }
}

