namespace csharp_lb4_wf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btShoAll = new Button();
            btSortByDepartment = new Button();
            btSortBySalary = new Button();
            btSortByName = new Button();
            btSortByID = new Button();
            btDeleteDepartment = new Button();
            dgDepartments = new DataGridView();
            btDeleteEmloyee = new Button();
            btAddEmployee = new Button();
            btAddDepartment = new Button();
            btDeleteCompany = new Button();
            lvCompanies = new ListView();
            dgEmployees = new DataGridView();
            employeeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btAddCompany = new Button();
            label1 = new Label();
            tbCompanyName = new TextBox();
            departmentsBindingSource = new BindingSource(components);
            companyBindingSource = new BindingSource(components);
            departmentsBindingSource1 = new BindingSource(components);
            btLoadJson = new Button();
            btSaveJson = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDepartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentsBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btSaveJson);
            panel1.Controls.Add(btLoadJson);
            panel1.Controls.Add(btShoAll);
            panel1.Controls.Add(btSortByDepartment);
            panel1.Controls.Add(btSortBySalary);
            panel1.Controls.Add(btSortByName);
            panel1.Controls.Add(btSortByID);
            panel1.Controls.Add(btDeleteDepartment);
            panel1.Controls.Add(dgDepartments);
            panel1.Controls.Add(btDeleteEmloyee);
            panel1.Controls.Add(btAddEmployee);
            panel1.Controls.Add(btAddDepartment);
            panel1.Controls.Add(btDeleteCompany);
            panel1.Controls.Add(lvCompanies);
            panel1.Controls.Add(dgEmployees);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btAddCompany);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbCompanyName);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 814);
            panel1.TabIndex = 0;
            // 
            // btShoAll
            // 
            btShoAll.Location = new Point(319, 373);
            btShoAll.Margin = new Padding(3, 4, 3, 4);
            btShoAll.Name = "btShoAll";
            btShoAll.Size = new Size(154, 31);
            btShoAll.TabIndex = 20;
            btShoAll.Text = "Show all Employees";
            btShoAll.UseVisualStyleBackColor = true;
            btShoAll.Click += btShoAll_Click;
            // 
            // btSortByDepartment
            // 
            btSortByDepartment.Location = new Point(504, 693);
            btSortByDepartment.Margin = new Padding(3, 4, 3, 4);
            btSortByDepartment.Name = "btSortByDepartment";
            btSortByDepartment.Size = new Size(154, 31);
            btSortByDepartment.TabIndex = 19;
            btSortByDepartment.Text = "Sort By Departmnet ID";
            btSortByDepartment.UseVisualStyleBackColor = true;
            btSortByDepartment.Click += btSortByDepartment_Click;
            // 
            // btSortBySalary
            // 
            btSortBySalary.Location = new Point(319, 693);
            btSortBySalary.Margin = new Padding(3, 4, 3, 4);
            btSortBySalary.Name = "btSortBySalary";
            btSortBySalary.Size = new Size(154, 31);
            btSortBySalary.TabIndex = 18;
            btSortBySalary.Text = "Sort By Salary";
            btSortBySalary.UseVisualStyleBackColor = true;
            btSortBySalary.Click += btSortBySalary_Click;
            // 
            // btSortByName
            // 
            btSortByName.Location = new Point(504, 629);
            btSortByName.Margin = new Padding(3, 4, 3, 4);
            btSortByName.Name = "btSortByName";
            btSortByName.Size = new Size(154, 31);
            btSortByName.TabIndex = 17;
            btSortByName.Text = "Sort By Name";
            btSortByName.UseVisualStyleBackColor = true;
            btSortByName.Click += btSortByName_Click;
            // 
            // btSortByID
            // 
            btSortByID.Location = new Point(319, 629);
            btSortByID.Margin = new Padding(3, 4, 3, 4);
            btSortByID.Name = "btSortByID";
            btSortByID.Size = new Size(154, 31);
            btSortByID.TabIndex = 16;
            btSortByID.Text = "Sort By ID";
            btSortByID.UseVisualStyleBackColor = true;
            btSortByID.Click += btSortByID_Click;
            // 
            // btDeleteDepartment
            // 
            btDeleteDepartment.Location = new Point(504, 304);
            btDeleteDepartment.Margin = new Padding(3, 4, 3, 4);
            btDeleteDepartment.Name = "btDeleteDepartment";
            btDeleteDepartment.Size = new Size(162, 31);
            btDeleteDepartment.TabIndex = 15;
            btDeleteDepartment.Text = "Delete";
            btDeleteDepartment.UseVisualStyleBackColor = true;
            btDeleteDepartment.Click += btDeleteDepartment_Click;
            // 
            // dgDepartments
            // 
            dgDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDepartments.Location = new Point(3, 291);
            dgDepartments.Margin = new Padding(3, 4, 3, 4);
            dgDepartments.Name = "dgDepartments";
            dgDepartments.RowHeadersWidth = 51;
            dgDepartments.RowTemplate.Height = 25;
            dgDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDepartments.Size = new Size(274, 200);
            dgDepartments.TabIndex = 14;
            dgDepartments.CellContentClick += dgDepartments_CellContentClick_1;
            // 
            // btDeleteEmloyee
            // 
            btDeleteEmloyee.Location = new Point(504, 564);
            btDeleteEmloyee.Margin = new Padding(3, 4, 3, 4);
            btDeleteEmloyee.Name = "btDeleteEmloyee";
            btDeleteEmloyee.Size = new Size(162, 31);
            btDeleteEmloyee.TabIndex = 13;
            btDeleteEmloyee.Text = "Delete Employee";
            btDeleteEmloyee.UseVisualStyleBackColor = true;
            btDeleteEmloyee.Click += btDeleteEmloyee_Click;
            // 
            // btAddEmployee
            // 
            btAddEmployee.Location = new Point(319, 564);
            btAddEmployee.Margin = new Padding(3, 4, 3, 4);
            btAddEmployee.Name = "btAddEmployee";
            btAddEmployee.Size = new Size(154, 31);
            btAddEmployee.TabIndex = 12;
            btAddEmployee.Text = "Add Employee";
            btAddEmployee.UseVisualStyleBackColor = true;
            btAddEmployee.Click += btAddEmployee_Click;
            // 
            // btAddDepartment
            // 
            btAddDepartment.Location = new Point(319, 304);
            btAddDepartment.Margin = new Padding(3, 4, 3, 4);
            btAddDepartment.Name = "btAddDepartment";
            btAddDepartment.Size = new Size(154, 31);
            btAddDepartment.TabIndex = 11;
            btAddDepartment.Text = "Add Department";
            btAddDepartment.UseVisualStyleBackColor = true;
            btAddDepartment.Click += btAddDepartment_Click;
            // 
            // btDeleteCompany
            // 
            btDeleteCompany.Location = new Point(567, 56);
            btDeleteCompany.Margin = new Padding(3, 4, 3, 4);
            btDeleteCompany.Name = "btDeleteCompany";
            btDeleteCompany.Size = new Size(86, 31);
            btDeleteCompany.TabIndex = 10;
            btDeleteCompany.Text = "Delete";
            btDeleteCompany.UseVisualStyleBackColor = true;
            btDeleteCompany.Click += btDeleteCompany_Click;
            // 
            // lvCompanies
            // 
            lvCompanies.Location = new Point(3, 32);
            lvCompanies.Margin = new Padding(3, 4, 3, 4);
            lvCompanies.Name = "lvCompanies";
            lvCompanies.Size = new Size(274, 211);
            lvCompanies.TabIndex = 9;
            lvCompanies.UseCompatibleStateImageBehavior = false;
            lvCompanies.SelectedIndexChanged += lvCompanies_SelectedIndexChanged;
            // 
            // dgEmployees
            // 
            dgEmployees.AllowUserToAddRows = false;
            dgEmployees.AutoGenerateColumns = false;
            dgEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmployees.Columns.AddRange(new DataGridViewColumn[] { employeeIdDataGridViewTextBoxColumn, employeeNameDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn });
            dgEmployees.DataSource = employeeBindingSource;
            dgEmployees.Location = new Point(3, 547);
            dgEmployees.Margin = new Padding(3, 4, 3, 4);
            dgEmployees.Name = "dgEmployees";
            dgEmployees.RowHeadersWidth = 51;
            dgEmployees.RowTemplate.Height = 25;
            dgEmployees.Size = new Size(274, 200);
            dgEmployees.TabIndex = 8;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            employeeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Model.Employee);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 523);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 7;
            label4.Text = "Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 267);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 6;
            label3.Text = "Departments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "Companies";
            // 
            // btAddCompany
            // 
            btAddCompany.Location = new Point(462, 56);
            btAddCompany.Margin = new Padding(3, 4, 3, 4);
            btAddCompany.Name = "btAddCompany";
            btAddCompany.Size = new Size(86, 31);
            btAddCompany.TabIndex = 3;
            btAddCompany.Text = "Add";
            btAddCompany.UseVisualStyleBackColor = true;
            btAddCompany.Click += btAddCompany_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 32);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "Company name";
            // 
            // tbCompanyName
            // 
            tbCompanyName.Location = new Point(319, 56);
            tbCompanyName.Margin = new Padding(3, 4, 3, 4);
            tbCompanyName.Name = "tbCompanyName";
            tbCompanyName.Size = new Size(114, 27);
            tbCompanyName.TabIndex = 1;
            // 
            // departmentsBindingSource
            // 
            departmentsBindingSource.DataMember = "Departments";
            departmentsBindingSource.DataSource = companyBindingSource;
            // 
            // companyBindingSource
            // 
            companyBindingSource.DataSource = typeof(Model.Company);
            // 
            // departmentsBindingSource1
            // 
            departmentsBindingSource1.DataMember = "Departments";
            departmentsBindingSource1.DataSource = companyBindingSource;
            // 
            // btLoadJson
            // 
            btLoadJson.Location = new Point(319, 137);
            btLoadJson.Margin = new Padding(3, 4, 3, 4);
            btLoadJson.Name = "btLoadJson";
            btLoadJson.Size = new Size(154, 31);
            btLoadJson.TabIndex = 21;
            btLoadJson.Text = "Load from JSON";
            btLoadJson.UseVisualStyleBackColor = true;
            btLoadJson.Click += btLoadJson_Click;
            // 
            // btSaveJson
            // 
            btSaveJson.Location = new Point(499, 137);
            btSaveJson.Margin = new Padding(3, 4, 3, 4);
            btSaveJson.Name = "btSaveJson";
            btSaveJson.Size = new Size(154, 31);
            btSaveJson.TabIndex = 22;
            btSaveJson.Text = "Save into JSON";
            btSaveJson.UseVisualStyleBackColor = true;
            btSaveJson.Click += btSaveJson_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 847);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgDepartments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)companyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentsBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbCompanyName;
        private Label label1;
        private Button btAddCompany;
        private DataGridView dgEmployees;
        private BindingSource employeeBindingSource;
        private Label label4;
        private Label label3;
        private Label label2;
        private BindingSource departmentsBindingSource;
        private BindingSource companyBindingSource;
        private ListView lvCompanies;
        private Button btDeleteCompany;
        private Button btDeleteEmloyee;
        private Button btAddEmployee;
        private Button btAddDepartment;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private BindingSource departmentsBindingSource1;
        private DataGridView dgDepartments;
        private Button btDeleteDepartment;
        private Button btSortByDepartment;
        private Button btSortBySalary;
        private Button btSortByName;
        private Button btSortByID;
        private Button btShoAll;
        private Button btSaveJson;
        private Button btLoadJson;
    }
}