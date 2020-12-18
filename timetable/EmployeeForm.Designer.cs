namespace timetable
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.deleteEmployeeBtn = new System.Windows.Forms.Button();
            this.UpdateEmployeeBtn = new System.Windows.Forms.Button();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.SearchBoxEmployee = new System.Windows.Forms.TextBox();
            this.EmployeeGV = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEEGNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEESURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEELASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEHIREDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableDBDataSet = new timetable.TimeTableDBDataSet();
            this.eMPLOYEESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.timetableDBDataSet2 = new timetable.TimetableDBDataSet2();
            this.employeesTableAdapter = new timetable.TimeTableDBDataSetTableAdapters.EmployeesTableAdapter();
            this.timetableDBDataSet1 = new timetable.TimetableDBDataSet1();
            this.eMPLOYEESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter1 = new timetable.TimetableDBDataSet1TableAdapters.EMPLOYEESTableAdapter();
            this.eMPLOYEESTableAdapter2 = new timetable.TimetableDBDataSet2TableAdapters.EMPLOYEESTableAdapter();
            this.EmployeeSearchComboBox = new System.Windows.Forms.ComboBox();
            this.ExcelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.deleteEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmployeeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(597, 526);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteEmployeeBtn.TabIndex = 1;
            this.deleteEmployeeBtn.Text = "Delete";
            this.deleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // UpdateEmployeeBtn
            // 
            this.UpdateEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.UpdateEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmployeeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateEmployeeBtn.Location = new System.Drawing.Point(516, 526);
            this.UpdateEmployeeBtn.Name = "UpdateEmployeeBtn";
            this.UpdateEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateEmployeeBtn.TabIndex = 2;
            this.UpdateEmployeeBtn.Text = "Update";
            this.UpdateEmployeeBtn.UseVisualStyleBackColor = true;
            this.UpdateEmployeeBtn.Click += new System.EventHandler(this.UpdateEmployeeBtn_Click);
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.FlatAppearance.BorderSize = 0;
            this.closeFormBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.closeFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFormBtn.ForeColor = System.Drawing.Color.White;
            this.closeFormBtn.Location = new System.Drawing.Point(12, 12);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(27, 30);
            this.closeFormBtn.TabIndex = 4;
            this.closeFormBtn.Text = "X";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.closeFormBtn_Click);
            // 
            // SearchBoxEmployee
            // 
            this.SearchBoxEmployee.Location = new System.Drawing.Point(12, 123);
            this.SearchBoxEmployee.Name = "SearchBoxEmployee";
            this.SearchBoxEmployee.Size = new System.Drawing.Size(502, 20);
            this.SearchBoxEmployee.TabIndex = 5;
            this.SearchBoxEmployee.TextChanged += new System.EventHandler(this.SearchBoxEmployee_TextChanged);
            // 
            // EmployeeGV
            // 
            this.EmployeeGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeGV.AutoGenerateColumns = false;
            this.EmployeeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.eMPLOYEEEGNDataGridViewTextBoxColumn,
            this.eMPLOYEENAMEDataGridViewTextBoxColumn,
            this.eMPLOYEESURNAMEDataGridViewTextBoxColumn,
            this.eMPLOYEELASTNAMEDataGridViewTextBoxColumn,
            this.eMPLOYEEPOSITIONDataGridViewTextBoxColumn,
            this.eMPLOYEEHIREDATEDataGridViewTextBoxColumn});
            this.EmployeeGV.DataSource = this.employeesBindingSource;
            this.EmployeeGV.Location = new System.Drawing.Point(12, 149);
            this.EmployeeGV.Name = "EmployeeGV";
            this.EmployeeGV.Size = new System.Drawing.Size(660, 343);
            this.EmployeeGV.TabIndex = 6;
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Width = 37;
            // 
            // eMPLOYEEEGNDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEEGNDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_EGN";
            this.eMPLOYEEEGNDataGridViewTextBoxColumn.HeaderText = "EGN";
            this.eMPLOYEEEGNDataGridViewTextBoxColumn.Name = "eMPLOYEEEGNDataGridViewTextBoxColumn";
            this.eMPLOYEEEGNDataGridViewTextBoxColumn.Width = 80;
            // 
            // eMPLOYEENAMEDataGridViewTextBoxColumn
            // 
            this.eMPLOYEENAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_NAME";
            this.eMPLOYEENAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.eMPLOYEENAMEDataGridViewTextBoxColumn.Name = "eMPLOYEENAMEDataGridViewTextBoxColumn";
            // 
            // eMPLOYEESURNAMEDataGridViewTextBoxColumn
            // 
            this.eMPLOYEESURNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_SURNAME";
            this.eMPLOYEESURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.eMPLOYEESURNAMEDataGridViewTextBoxColumn.Name = "eMPLOYEESURNAMEDataGridViewTextBoxColumn";
            // 
            // eMPLOYEELASTNAMEDataGridViewTextBoxColumn
            // 
            this.eMPLOYEELASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_LASTNAME";
            this.eMPLOYEELASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST NAME";
            this.eMPLOYEELASTNAMEDataGridViewTextBoxColumn.Name = "eMPLOYEELASTNAMEDataGridViewTextBoxColumn";
            // 
            // eMPLOYEEPOSITIONDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_POSITION";
            this.eMPLOYEEPOSITIONDataGridViewTextBoxColumn.HeaderText = "POSITION";
            this.eMPLOYEEPOSITIONDataGridViewTextBoxColumn.Name = "eMPLOYEEPOSITIONDataGridViewTextBoxColumn";
            // 
            // eMPLOYEEHIREDATEDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEHIREDATEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_HIREDATE";
            this.eMPLOYEEHIREDATEDataGridViewTextBoxColumn.HeaderText = "HIRE DATE";
            this.eMPLOYEEHIREDATEDataGridViewTextBoxColumn.Name = "eMPLOYEEHIREDATEDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.timeTableDBDataSet;
            // 
            // timeTableDBDataSet
            // 
            this.timeTableDBDataSet.DataSetName = "TimeTableDBDataSet";
            this.timeTableDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEESBindingSource2
            // 
            this.eMPLOYEESBindingSource2.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource2.DataSource = this.timetableDBDataSet2;
            // 
            // timetableDBDataSet2
            // 
            this.timetableDBDataSet2.DataSetName = "TimetableDBDataSet2";
            this.timetableDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // timetableDBDataSet1
            // 
            this.timetableDBDataSet1.DataSetName = "TimetableDBDataSet1";
            this.timetableDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEESBindingSource1
            // 
            this.eMPLOYEESBindingSource1.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource1.DataSource = this.timetableDBDataSet1;
            // 
            // eMPLOYEESTableAdapter1
            // 
            this.eMPLOYEESTableAdapter1.ClearBeforeFill = true;
            // 
            // eMPLOYEESTableAdapter2
            // 
            this.eMPLOYEESTableAdapter2.ClearBeforeFill = true;
            // 
            // EmployeeSearchComboBox
            // 
            this.EmployeeSearchComboBox.FormattingEnabled = true;
            this.EmployeeSearchComboBox.Items.AddRange(new object[] {
            "EMPLOYEE_ID",
            "EMPLOYEE_EGN",
            "EMPLOYEE_NAME",
            "EMPLOYEE_SURNAME",
            "EMPLOYEE_LASTNAME",
            "EMPLOYEE_POSITION"});
            this.EmployeeSearchComboBox.Location = new System.Drawing.Point(520, 122);
            this.EmployeeSearchComboBox.Name = "EmployeeSearchComboBox";
            this.EmployeeSearchComboBox.Size = new System.Drawing.Size(152, 21);
            this.EmployeeSearchComboBox.TabIndex = 7;
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.ExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ExcelBtn.Location = new System.Drawing.Point(435, 526);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(75, 23);
            this.ExcelBtn.TabIndex = 8;
            this.ExcelBtn.Text = "Export";
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.EmployeeSearchComboBox);
            this.Controls.Add(this.EmployeeGV);
            this.Controls.Add(this.SearchBoxEmployee);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.UpdateEmployeeBtn);
            this.Controls.Add(this.deleteEmployeeBtn);
            this.Name = "EmployeeForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteEmployeeBtn;
        private System.Windows.Forms.Button UpdateEmployeeBtn;
        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.TextBox SearchBoxEmployee;
        private TimeTableDBDataSet timeTableDBDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private TimeTableDBDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView EmployeeGV;
        private TimetableDBDataSet1 timetableDBDataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource1;
        private TimetableDBDataSet1TableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter1;
        private TimetableDBDataSet2 timetableDBDataSet2;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource2;
        private TimetableDBDataSet2TableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEEGNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEESURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEELASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEPOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEHIREDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox EmployeeSearchComboBox;
        private System.Windows.Forms.Button ExcelBtn;
    }
}