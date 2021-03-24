using System;
using System.Windows.Forms;
using System.Drawing;
using Logbook.Business.Services;
using Logbook.Business.Interface;
using Logbook.Business.Models;

namespace Logbook
{
    public partial class LoginForm : Form
    {
        EmployeeService employeeService = new EmployeeService();
        

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
                Employee employee = employeeService.LoginEmployee(Convert.ToInt32(employeeId));

                if (employee == null)
                {
                    MessageBox.Show("User not registered.");
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
