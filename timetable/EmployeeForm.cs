using System;
using System.Globalization;
using System.Windows.Forms;
using timetable.AppClasses;

namespace timetable
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            var dt = em.Select(tableName);
            EmployeeGV.DataSource = dt;
        }

        Employee em = new Employee();
        Methods helperMethods = new Methods();
        string tableName = "EMPLOYEES";

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            em.EmployeeId = Convert.ToInt32(EmployeeGV.Rows[EmployeeGV.CurrentCell.RowIndex].Cells[0].Value);
            bool success = em.Delete(tableName, "EMPLOYEE_ID", em.EmployeeId);
            helperMethods.DisplayMessage(success, "deleted", this, em, tableName, EmployeeGV);
        }

        private void UpdateEmployeeBtn_Click(object sender, EventArgs e)
        {
            em.EmployeeId = Convert.ToInt32(EmployeeGV.Rows[EmployeeGV.CurrentCell.RowIndex].Cells[0].Value);
            em.EmployeeEgn = EmployeeGV.Rows[EmployeeGV.CurrentCell.RowIndex].Cells[1].Value.ToString();
            em.EmployeeName = EmployeeGV.Rows[EmployeeGV.CurrentCell.RowIndex].Cells[2].Value.ToString();
            em.EmployeeSurname = EmployeeGV.Rows[EmployeeGV.CurrentCell.RowIndex].Cells[3].Value.ToString();
            em.EmployeeLastName = EmployeeGV.Rows[EmployeeGV.CurrentCell.RowIndex].Cells[4].Value.ToString();
            em.EmployeePosition = EmployeeGV.Rows[EmployeeGV.CurrentCell.RowIndex].Cells[5].Value.ToString();
            em.EmployeeHireDate = DateTime.Parse(EmployeeGV.Rows[EmployeeGV.CurrentCell.RowIndex].Cells[6].Value.ToString(), new CultureInfo("en-GB"), DateTimeStyles.NoCurrentDateDefault);

            bool success = em.Update(em);
            helperMethods.DisplayMessage(success, "updated", this, em, tableName, EmployeeGV);
        }

        private void SearchBoxEmployee_TextChanged(object sender, EventArgs e)
        {
            EmployeeGV.DataSource = helperMethods.SearchQuery(SearchBoxEmployee.Text, tableName, EmployeeSearchComboBox.Text);
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            helperMethods.ExportToExcel(EmployeeGV);
        }
    }
}
