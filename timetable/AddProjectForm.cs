using System;
using timetable.AppClasses;
using System.Windows.Forms;
using System.Globalization;

namespace timetable
{
    public partial class AddProjectForm : Form
    {
        public AddProjectForm()
        {
            InitializeComponent();
        }

        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterProjectBtn_Click(object sender, EventArgs e)
        {
            var cultureInfo = new CultureInfo("en-GB");
            Project pr = new Project();

            pr.ProjectName = textBoxProjectName.Text;
            pr.ProjectBegin = DateTime.Parse(textBoxStartOfProject.Text, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
            pr.ProjectEnd = DateTime.Parse(textBoxEndOfProject.Text, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
            pr.ProjectDescription = textBoxDescriptionOfProj.Text;
            pr.ProjectStatus = char.Parse(textBoxStatus.Text);
            pr.ProjectMaxHours = int.Parse(textBoxMaxHours.Text);

            pr.Insert(pr);

            MessageBox.Show("Project added successfully!");

            var helperMethods = new Methods();
            helperMethods.Clear(this);
        }
    }
}
