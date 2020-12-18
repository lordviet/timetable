using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
