namespace timetable
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.helpBtn = new System.Windows.Forms.Button();
            this.panelProjectsSubmenu = new System.Windows.Forms.Panel();
            this.addAProjectBtn = new System.Windows.Forms.Button();
            this.viewAllProjectsBtn = new System.Windows.Forms.Button();
            this.Projects = new System.Windows.Forms.Button();
            this.panelEmployeesSubmenu = new System.Windows.Forms.Panel();
            this.addAnEmployeeBtn = new System.Windows.Forms.Button();
            this.viewAllEmployeesBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelProjectsSubmenu.SuspendLayout();
            this.panelEmployeesSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.helpBtn);
            this.panelSideMenu.Controls.Add(this.panelProjectsSubmenu);
            this.panelSideMenu.Controls.Add(this.Projects);
            this.panelSideMenu.Controls.Add(this.panelEmployeesSubmenu);
            this.panelSideMenu.Controls.Add(this.employeesBtn);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // helpBtn
            // 
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.helpBtn.Location = new System.Drawing.Point(0, 349);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.helpBtn.Size = new System.Drawing.Size(250, 45);
            this.helpBtn.TabIndex = 7;
            this.helpBtn.Text = "Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // panelProjectsSubmenu
            // 
            this.panelProjectsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelProjectsSubmenu.Controls.Add(this.addAProjectBtn);
            this.panelProjectsSubmenu.Controls.Add(this.viewAllProjectsBtn);
            this.panelProjectsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProjectsSubmenu.Location = new System.Drawing.Point(0, 273);
            this.panelProjectsSubmenu.Name = "panelProjectsSubmenu";
            this.panelProjectsSubmenu.Size = new System.Drawing.Size(250, 76);
            this.panelProjectsSubmenu.TabIndex = 6;
            // 
            // addAProjectBtn
            // 
            this.addAProjectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addAProjectBtn.FlatAppearance.BorderSize = 0;
            this.addAProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAProjectBtn.ForeColor = System.Drawing.Color.LightGray;
            this.addAProjectBtn.Location = new System.Drawing.Point(0, 40);
            this.addAProjectBtn.Name = "addAProjectBtn";
            this.addAProjectBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addAProjectBtn.Size = new System.Drawing.Size(250, 36);
            this.addAProjectBtn.TabIndex = 1;
            this.addAProjectBtn.Text = "Add a project";
            this.addAProjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAProjectBtn.UseVisualStyleBackColor = true;
            this.addAProjectBtn.Click += new System.EventHandler(this.addAProjectBtn_Click);
            // 
            // viewAllProjectsBtn
            // 
            this.viewAllProjectsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewAllProjectsBtn.FlatAppearance.BorderSize = 0;
            this.viewAllProjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllProjectsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllProjectsBtn.ForeColor = System.Drawing.Color.LightGray;
            this.viewAllProjectsBtn.Location = new System.Drawing.Point(0, 0);
            this.viewAllProjectsBtn.Name = "viewAllProjectsBtn";
            this.viewAllProjectsBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.viewAllProjectsBtn.Size = new System.Drawing.Size(250, 40);
            this.viewAllProjectsBtn.TabIndex = 0;
            this.viewAllProjectsBtn.Text = "View All";
            this.viewAllProjectsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewAllProjectsBtn.UseVisualStyleBackColor = true;
            this.viewAllProjectsBtn.Click += new System.EventHandler(this.viewAllProjectsBtn_Click);
            // 
            // Projects
            // 
            this.Projects.Dock = System.Windows.Forms.DockStyle.Top;
            this.Projects.FlatAppearance.BorderSize = 0;
            this.Projects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.Projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.ForeColor = System.Drawing.Color.Gainsboro;
            this.Projects.Location = new System.Drawing.Point(0, 228);
            this.Projects.Name = "Projects";
            this.Projects.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Projects.Size = new System.Drawing.Size(250, 45);
            this.Projects.TabIndex = 5;
            this.Projects.Text = "Projects";
            this.Projects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Projects.UseVisualStyleBackColor = true;
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // panelEmployeesSubmenu
            // 
            this.panelEmployeesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelEmployeesSubmenu.Controls.Add(this.addAnEmployeeBtn);
            this.panelEmployeesSubmenu.Controls.Add(this.viewAllEmployeesBtn);
            this.panelEmployeesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeesSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelEmployeesSubmenu.Name = "panelEmployeesSubmenu";
            this.panelEmployeesSubmenu.Size = new System.Drawing.Size(250, 83);
            this.panelEmployeesSubmenu.TabIndex = 2;
            // 
            // addAnEmployeeBtn
            // 
            this.addAnEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addAnEmployeeBtn.FlatAppearance.BorderSize = 0;
            this.addAnEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAnEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnEmployeeBtn.ForeColor = System.Drawing.Color.LightGray;
            this.addAnEmployeeBtn.Location = new System.Drawing.Point(0, 40);
            this.addAnEmployeeBtn.Name = "addAnEmployeeBtn";
            this.addAnEmployeeBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addAnEmployeeBtn.Size = new System.Drawing.Size(250, 43);
            this.addAnEmployeeBtn.TabIndex = 1;
            this.addAnEmployeeBtn.Text = "Add an employee";
            this.addAnEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAnEmployeeBtn.UseVisualStyleBackColor = true;
            this.addAnEmployeeBtn.Click += new System.EventHandler(this.addAnEmployeeBtn_Click);
            // 
            // viewAllEmployeesBtn
            // 
            this.viewAllEmployeesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewAllEmployeesBtn.FlatAppearance.BorderSize = 0;
            this.viewAllEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllEmployeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllEmployeesBtn.ForeColor = System.Drawing.Color.LightGray;
            this.viewAllEmployeesBtn.Location = new System.Drawing.Point(0, 0);
            this.viewAllEmployeesBtn.Name = "viewAllEmployeesBtn";
            this.viewAllEmployeesBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.viewAllEmployeesBtn.Size = new System.Drawing.Size(250, 40);
            this.viewAllEmployeesBtn.TabIndex = 0;
            this.viewAllEmployeesBtn.Text = "View All";
            this.viewAllEmployeesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewAllEmployeesBtn.UseVisualStyleBackColor = true;
            this.viewAllEmployeesBtn.Click += new System.EventHandler(this.viewAllEmployeesBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeesBtn.FlatAppearance.BorderSize = 0;
            this.employeesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.employeesBtn.Location = new System.Drawing.Point(0, 100);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.employeesBtn.Size = new System.Drawing.Size(250, 45);
            this.employeesBtn.TabIndex = 1;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesBtn.UseVisualStyleBackColor = true;
            this.employeesBtn.Click += new System.EventHandler(this.Employees_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::timetable.Properties.Resources.smalllogo;
            this.pictureBox2.Location = new System.Drawing.Point(26, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 561);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::timetable.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(93, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.Text = "Time Table ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelProjectsSubmenu.ResumeLayout(false);
            this.panelEmployeesSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelEmployeesSubmenu;
        private System.Windows.Forms.Button addAnEmployeeBtn;
        private System.Windows.Forms.Button viewAllEmployeesBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelProjectsSubmenu;
        private System.Windows.Forms.Button addAProjectBtn;
        private System.Windows.Forms.Button viewAllProjectsBtn;
        private System.Windows.Forms.Button Projects;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

