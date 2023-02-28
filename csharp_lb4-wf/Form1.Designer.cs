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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSortByDepartment = new System.Windows.Forms.Button();
            this.btSortBySalary = new System.Windows.Forms.Button();
            this.btSortByName = new System.Windows.Forms.Button();
            this.btSortByID = new System.Windows.Forms.Button();
            this.btDeleteDepartment = new System.Windows.Forms.Button();
            this.dgDepartments = new System.Windows.Forms.DataGridView();
            this.btDeleteEmloyee = new System.Windows.Forms.Button();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.btAddDepartment = new System.Windows.Forms.Button();
            this.btDeleteCompany = new System.Windows.Forms.Button();
            this.lvCompanies = new System.Windows.Forms.ListView();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAddCompany = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btShoAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btShoAll);
            this.panel1.Controls.Add(this.btSortByDepartment);
            this.panel1.Controls.Add(this.btSortBySalary);
            this.panel1.Controls.Add(this.btSortByName);
            this.panel1.Controls.Add(this.btSortByID);
            this.panel1.Controls.Add(this.btDeleteDepartment);
            this.panel1.Controls.Add(this.dgDepartments);
            this.panel1.Controls.Add(this.btDeleteEmloyee);
            this.panel1.Controls.Add(this.btAddEmployee);
            this.panel1.Controls.Add(this.btAddDepartment);
            this.panel1.Controls.Add(this.btDeleteCompany);
            this.panel1.Controls.Add(this.lvCompanies);
            this.panel1.Controls.Add(this.dgEmployees);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btAddCompany);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbCompanyName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 611);
            this.panel1.TabIndex = 0;
            // 
            // btSortByDepartment
            // 
            this.btSortByDepartment.Location = new System.Drawing.Point(441, 520);
            this.btSortByDepartment.Name = "btSortByDepartment";
            this.btSortByDepartment.Size = new System.Drawing.Size(135, 23);
            this.btSortByDepartment.TabIndex = 19;
            this.btSortByDepartment.Text = "Sort By Departmnet ID";
            this.btSortByDepartment.UseVisualStyleBackColor = true;
            this.btSortByDepartment.Click += new System.EventHandler(this.btSortByDepartment_Click);
            // 
            // btSortBySalary
            // 
            this.btSortBySalary.Location = new System.Drawing.Point(279, 520);
            this.btSortBySalary.Name = "btSortBySalary";
            this.btSortBySalary.Size = new System.Drawing.Size(135, 23);
            this.btSortBySalary.TabIndex = 18;
            this.btSortBySalary.Text = "Sort By Salary";
            this.btSortBySalary.UseVisualStyleBackColor = true;
            this.btSortBySalary.Click += new System.EventHandler(this.btSortBySalary_Click);
            // 
            // btSortByName
            // 
            this.btSortByName.Location = new System.Drawing.Point(441, 472);
            this.btSortByName.Name = "btSortByName";
            this.btSortByName.Size = new System.Drawing.Size(135, 23);
            this.btSortByName.TabIndex = 17;
            this.btSortByName.Text = "Sort By Name";
            this.btSortByName.UseVisualStyleBackColor = true;
            this.btSortByName.Click += new System.EventHandler(this.btSortByName_Click);
            // 
            // btSortByID
            // 
            this.btSortByID.Location = new System.Drawing.Point(279, 472);
            this.btSortByID.Name = "btSortByID";
            this.btSortByID.Size = new System.Drawing.Size(135, 23);
            this.btSortByID.TabIndex = 16;
            this.btSortByID.Text = "Sort By ID";
            this.btSortByID.UseVisualStyleBackColor = true;
            this.btSortByID.Click += new System.EventHandler(this.btSortByID_Click);
            // 
            // btDeleteDepartment
            // 
            this.btDeleteDepartment.Location = new System.Drawing.Point(441, 228);
            this.btDeleteDepartment.Name = "btDeleteDepartment";
            this.btDeleteDepartment.Size = new System.Drawing.Size(142, 23);
            this.btDeleteDepartment.TabIndex = 15;
            this.btDeleteDepartment.Text = "Delete";
            this.btDeleteDepartment.UseVisualStyleBackColor = true;
            this.btDeleteDepartment.Click += new System.EventHandler(this.btDeleteDepartment_Click);
            // 
            // dgDepartments
            // 
            this.dgDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartments.Location = new System.Drawing.Point(3, 218);
            this.dgDepartments.Name = "dgDepartments";
            this.dgDepartments.RowTemplate.Height = 25;
            this.dgDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepartments.Size = new System.Drawing.Size(240, 150);
            this.dgDepartments.TabIndex = 14;
            this.dgDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepartments_CellContentClick_1);
            // 
            // btDeleteEmloyee
            // 
            this.btDeleteEmloyee.Location = new System.Drawing.Point(441, 423);
            this.btDeleteEmloyee.Name = "btDeleteEmloyee";
            this.btDeleteEmloyee.Size = new System.Drawing.Size(142, 23);
            this.btDeleteEmloyee.TabIndex = 13;
            this.btDeleteEmloyee.Text = "Delete Employee";
            this.btDeleteEmloyee.UseVisualStyleBackColor = true;
            this.btDeleteEmloyee.Click += new System.EventHandler(this.btDeleteEmloyee_Click);
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.Location = new System.Drawing.Point(279, 423);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(135, 23);
            this.btAddEmployee.TabIndex = 12;
            this.btAddEmployee.Text = "Add Employee";
            this.btAddEmployee.UseVisualStyleBackColor = true;
            this.btAddEmployee.Click += new System.EventHandler(this.btAddEmployee_Click);
            // 
            // btAddDepartment
            // 
            this.btAddDepartment.Location = new System.Drawing.Point(279, 228);
            this.btAddDepartment.Name = "btAddDepartment";
            this.btAddDepartment.Size = new System.Drawing.Size(135, 23);
            this.btAddDepartment.TabIndex = 11;
            this.btAddDepartment.Text = "Add Department";
            this.btAddDepartment.UseVisualStyleBackColor = true;
            this.btAddDepartment.Click += new System.EventHandler(this.btAddDepartment_Click);
            // 
            // btDeleteCompany
            // 
            this.btDeleteCompany.Location = new System.Drawing.Point(496, 42);
            this.btDeleteCompany.Name = "btDeleteCompany";
            this.btDeleteCompany.Size = new System.Drawing.Size(75, 23);
            this.btDeleteCompany.TabIndex = 10;
            this.btDeleteCompany.Text = "Delete";
            this.btDeleteCompany.UseVisualStyleBackColor = true;
            this.btDeleteCompany.Click += new System.EventHandler(this.btDeleteCompany_Click);
            // 
            // lvCompanies
            // 
            this.lvCompanies.Location = new System.Drawing.Point(3, 24);
            this.lvCompanies.Name = "lvCompanies";
            this.lvCompanies.Size = new System.Drawing.Size(240, 159);
            this.lvCompanies.TabIndex = 9;
            this.lvCompanies.UseCompatibleStateImageBehavior = false;
            this.lvCompanies.SelectedIndexChanged += new System.EventHandler(this.lvCompanies_SelectedIndexChanged);
            // 
            // dgEmployees
            // 
            this.dgEmployees.AllowUserToAddRows = false;
            this.dgEmployees.AutoGenerateColumns = false;
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dgEmployees.DataSource = this.employeeBindingSource;
            this.dgEmployees.Location = new System.Drawing.Point(3, 410);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.RowTemplate.Height = 25;
            this.dgEmployees.Size = new System.Drawing.Size(240, 150);
            this.dgEmployees.TabIndex = 8;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(csharp_lb4_wf.Model.Employee);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Companies";
            // 
            // btAddCompany
            // 
            this.btAddCompany.Location = new System.Drawing.Point(404, 42);
            this.btAddCompany.Name = "btAddCompany";
            this.btAddCompany.Size = new System.Drawing.Size(75, 23);
            this.btAddCompany.TabIndex = 3;
            this.btAddCompany.Text = "Add";
            this.btAddCompany.UseVisualStyleBackColor = true;
            this.btAddCompany.Click += new System.EventHandler(this.btAddCompany_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company name";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(279, 42);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(100, 23);
            this.tbCompanyName.TabIndex = 1;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.companyBindingSource;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(csharp_lb4_wf.Model.Company);
            // 
            // departmentsBindingSource1
            // 
            this.departmentsBindingSource1.DataMember = "Departments";
            this.departmentsBindingSource1.DataSource = this.companyBindingSource;
            // 
            // btShoAll
            // 
            this.btShoAll.Location = new System.Drawing.Point(279, 280);
            this.btShoAll.Name = "btShoAll";
            this.btShoAll.Size = new System.Drawing.Size(135, 23);
            this.btShoAll.TabIndex = 20;
            this.btShoAll.Text = "Show all Employees";
            this.btShoAll.UseVisualStyleBackColor = true;
            this.btShoAll.Click += new System.EventHandler(this.btShoAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 635);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).EndInit();
            this.ResumeLayout(false);

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
    }
}