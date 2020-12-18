using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CustomizeDesign()
        {
            panelEmployeesSubmenu.Visible = false;
            panelProjectsSubmenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if (panelEmployeesSubmenu.Visible == true) panelEmployeesSubmenu.Visible = false;
            if (panelProjectsSubmenu.Visible == true) panelProjectsSubmenu.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }

            else
            {
                submenu.Visible = false;
            }
        }

        #region Employees submenu

        private void Employees_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelEmployeesSubmenu);
        }

        private void viewAllEmployeesBtn_Click(object sender, EventArgs e)
        {
            // Code 
            OpenChildForm(new EmployeeForm());
            HideSubmenu();
        }

        private void addAnEmployeeBtn_Click(object sender, EventArgs e)
        {
            // Code 
            OpenChildForm(new AddEmployeeForm());
            HideSubmenu();
        }

        #endregion

        #region Projects submenu

        private void Projects_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelProjectsSubmenu);
        }

        private void viewAllProjectsBtn_Click(object sender, EventArgs e)
        {
            // Code 
            OpenChildForm(new ProjectsForm());
            HideSubmenu();
        }

        private void addAProjectBtn_Click(object sender, EventArgs e)
        {
            // Code
            OpenChildForm(new AddProjectForm());
            HideSubmenu();
        }

        #endregion

        private void helpBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HelpForm());
            HideSubmenu();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
