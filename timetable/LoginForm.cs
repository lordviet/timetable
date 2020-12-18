using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = UsernameTextbox.Text;
            string Password = PasswordTextBox.Text;
            Form MainForm = new MainForm();

            if (!Username.Equals("root"))
            {
                MessageBox.Show("Username is invalid, try again!", "Invalid Credentials");
            }
            if (Password.Length < 8)
            {
                MessageBox.Show("Password is invalid, try again!", "Invalid Credentials");
            }
            if (Username == "root" && Password.Length >= 8)
            {
                MainForm.Show();
                this.Hide();
            }
        }
    }
}
