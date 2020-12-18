using System;
using System.Globalization;
using System.Windows.Forms;
using timetable.AppClasses;

namespace timetable
{
    public partial class ProjectsForm : Form
    {
        public ProjectsForm()
        {
            InitializeComponent();
        }

        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            var dt = pr.Select(tableName);
            ProjectGV.DataSource = dt;
        }

        Project pr = new Project();
        Methods helperMethods = new Methods();
        string tableName = "PROJECT";

        private void deleteProjectBtn_Click(object sender, EventArgs e)
        {
            pr.ProjectId = Convert.ToInt32(ProjectGV.Rows[ProjectGV.CurrentCell.RowIndex].Cells[0].Value);
            bool success = pr.Delete(tableName, "PROJECT_ID", pr.ProjectId);
            helperMethods.DisplayMessage(success, "deleted", this, pr, tableName, ProjectGV);
        }

        private void UpdateProjectBtn_Click(object sender, EventArgs e)
        {
            var cultureInfo = new CultureInfo("en-GB");
            pr.ProjectId = Convert.ToInt32(ProjectGV.Rows[ProjectGV.CurrentCell.RowIndex].Cells[0].Value);
            pr.ProjectName = ProjectGV.Rows[ProjectGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            pr.ProjectBegin = DateTime.Parse(ProjectGV.Rows[ProjectGV.CurrentCell.RowIndex].Cells[2].Value.ToString(), cultureInfo, DateTimeStyles.NoCurrentDateDefault);
            pr.ProjectEnd = DateTime.Parse(ProjectGV.Rows[ProjectGV.CurrentCell.RowIndex].Cells[3].Value.ToString(), cultureInfo, DateTimeStyles.NoCurrentDateDefault);
            pr.ProjectDescription = ProjectGV.Rows[ProjectGV.CurrentCell.RowIndex].Cells[4].Value.ToString();
            pr.ProjectStatus = char.Parse(ProjectGV.Rows[ProjectGV.CurrentCell.RowIndex].Cells[5].Value.ToString());
            pr.ProjectMaxHours = Convert.ToInt32(ProjectGV.Rows[ProjectGV.CurrentCell.RowIndex].Cells[6].Value.ToString());

            bool success = pr.Update(pr);
            helperMethods.DisplayMessage(success, "updated", this, pr, tableName, ProjectGV);
        }

        private void SearchBoxProject_TextChanged(object sender, EventArgs e)
        {
            ProjectGV.DataSource = helperMethods.SearchQuery(SearchBoxProject.Text, tableName, ProjectSearchComboBox.Text);
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            helperMethods.ExportToExcel(ProjectGV);
        }
    }
}
