using System;
using System.Windows.Forms;
using System.Drawing;
using Logbook.Business.Services;

namespace Logbook
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            string employeeId = employeeIdTextBox.Text;

            if (employeeId == string.Empty)
            {
                MessageBox.Show("Input field is empty. Try again.");
                return;
            }
            
            else 
            {
                int? loggedInEmployeeId = EmployeeAccountManagerServices.LoginEmployee(Convert.ToInt32(employeeId));
                
                if (loggedInEmployeeId == null)
                {
                    MessageBox.Show("No users found.");
                    return;
                }
                
                new HomeForm().Show();
                this.Hide();
            }
        }

        private void registerHereButton_Click(object sender, EventArgs e)
        {
            Form form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void employeeIdTextBox_Enter(object sender, EventArgs e)
        {      
             employeeIdTextBox.Text = null;
             employeeIdTextBox.ForeColor = Color.Black;              
        }

    }
}
