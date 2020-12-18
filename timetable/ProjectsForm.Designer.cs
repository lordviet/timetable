namespace timetable
{
    partial class ProjectsForm
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
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.UpdateProjectBtn = new System.Windows.Forms.Button();
            this.deleteProjectBtn = new System.Windows.Forms.Button();
            this.ProjectGV = new System.Windows.Forms.DataGridView();
            this.SearchBoxProject = new System.Windows.Forms.TextBox();
            this.timetableDBDataSet = new timetable.TimetableDBDataSet();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new timetable.TimetableDBDataSetTableAdapters.EMPLOYEESTableAdapter();
            this.ProjectSearchComboBox = new System.Windows.Forms.ComboBox();
            this.timetableDBProject = new timetable.TimetableDBProject();
            this.pROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTTableAdapter = new timetable.TimetableDBProjectTableAdapters.PROJECTTableAdapter();
            this.ExcelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.FlatAppearance.BorderSize = 0;
            this.closeFormBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.closeFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFormBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.closeFormBtn.Location = new System.Drawing.Point(12, 12);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(27, 30);
            this.closeFormBtn.TabIndex = 8;
            this.closeFormBtn.Text = "X";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.closeFormBtn_Click);
            // 
            // UpdateProjectBtn
            // 
            this.UpdateProjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.UpdateProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProjectBtn.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateProjectBtn.Location = new System.Drawing.Point(516, 526);
            this.UpdateProjectBtn.Name = "UpdateProjectBtn";
            this.UpdateProjectBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateProjectBtn.TabIndex = 7;
            this.UpdateProjectBtn.Text = "Update";
            this.UpdateProjectBtn.UseVisualStyleBackColor = true;
            this.UpdateProjectBtn.Click += new System.EventHandler(this.UpdateProjectBtn_Click);
            // 
            // deleteProjectBtn
            // 
            this.deleteProjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.deleteProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProjectBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteProjectBtn.Location = new System.Drawing.Point(597, 526);
            this.deleteProjectBtn.Name = "deleteProjectBtn";
            this.deleteProjectBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteProjectBtn.TabIndex = 6;
            this.deleteProjectBtn.Text = "Delete";
            this.deleteProjectBtn.UseVisualStyleBackColor = true;
            this.deleteProjectBtn.Click += new System.EventHandler(this.deleteProjectBtn_Click);
            // 
            // ProjectGV
            // 
            this.ProjectGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectGV.Location = new System.Drawing.Point(12, 149);
            this.ProjectGV.Name = "ProjectGV";
            this.ProjectGV.Size = new System.Drawing.Size(660, 343);
            this.ProjectGV.TabIndex = 5;
            // 
            // SearchBoxProject
            // 
            this.SearchBoxProject.Location = new System.Drawing.Point(12, 123);
            this.SearchBoxProject.Name = "SearchBoxProject";
            this.SearchBoxProject.Size = new System.Drawing.Size(502, 20);
            this.SearchBoxProject.TabIndex = 9;
            this.SearchBoxProject.TextChanged += new System.EventHandler(this.SearchBoxProject_TextChanged);
            // 
            // timetableDBDataSet
            // 
            this.timetableDBDataSet.DataSetName = "TimetableDBDataSet";
            this.timetableDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.timetableDBDataSet;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // ProjectSearchComboBox
            // 
            this.ProjectSearchComboBox.FormattingEnabled = true;
            this.ProjectSearchComboBox.Items.AddRange(new object[] {
            "PROJECT_ID",
            "PROJECT_NAME",
            "PROJECT_BEGIN",
            "PROJECT_END",
            "PROJECT_DESCRIPTION",
            "PROJECT_STATUS",
            "PROJECT_MAXHOURS"});
            this.ProjectSearchComboBox.Location = new System.Drawing.Point(520, 122);
            this.ProjectSearchComboBox.Name = "ProjectSearchComboBox";
            this.ProjectSearchComboBox.Size = new System.Drawing.Size(152, 21);
            this.ProjectSearchComboBox.TabIndex = 10;
            // 
            // timetableDBProject
            // 
            this.timetableDBProject.DataSetName = "TimetableDBProject";
            this.timetableDBProject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECTBindingSource
            // 
            this.pROJECTBindingSource.DataMember = "PROJECT";
            this.pROJECTBindingSource.DataSource = this.timetableDBProject;
            // 
            // pROJECTTableAdapter
            // 
            this.pROJECTTableAdapter.ClearBeforeFill = true;
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
            this.ExcelBtn.TabIndex = 11;
            this.ExcelBtn.Text = "Export";
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.ProjectSearchComboBox);
            this.Controls.Add(this.SearchBoxProject);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.UpdateProjectBtn);
            this.Controls.Add(this.deleteProjectBtn);
            this.Controls.Add(this.ProjectGV);
            this.Name = "ProjectsForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.ProjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.Button UpdateProjectBtn;
        private System.Windows.Forms.Button deleteProjectBtn;
        private System.Windows.Forms.DataGridView ProjectGV;
        private System.Windows.Forms.TextBox SearchBoxProject;
        private TimetableDBDataSet timetableDBDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private TimetableDBDataSetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.ComboBox ProjectSearchComboBox;
        private TimetableDBProject timetableDBProject;
        private System.Windows.Forms.BindingSource pROJECTBindingSource;
        private TimetableDBProjectTableAdapters.PROJECTTableAdapter pROJECTTableAdapter;
        private System.Windows.Forms.Button ExcelBtn;
    }
}