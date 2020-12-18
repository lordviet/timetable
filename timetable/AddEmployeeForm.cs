using System;
using System.Windows.Forms;
using timetable.AppClasses;
using System.Globalization;

namespace timetable
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerEmployeeBtn_Click(object sender, EventArgs e)
        {
            var cultureInfo = new CultureInfo("en-GB");
            Employee em = new Employee();
            
            em.EmployeeEgn = textBoxEmployeeEgn.Text;
            em.EmployeeName = textBoxEmployeeName.Text;
            em.EmployeeSurname = textBoxEmployeeMidName.Text;
            em.EmployeeLastName = textBoxEmployeeFamilyName.Text;
            em.EmployeePosition = textBoxEmployeeOccupation.Text;
            em.EmployeeHireDate = DateTime.Parse(textBoxEmployeeStartingDate.Text, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
            em.Insert(em);

            MessageBox.Show("Employee added successfully!");

            var helperMethods = new Methods();
            helperMethods.Clear(this);
        }

     
    }
}
