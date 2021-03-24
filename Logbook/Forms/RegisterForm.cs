using System;
using System.Windows.Forms;
using Logbook.Business.Services;

namespace Logbook
{
    public partial class RegisterForm : Form
    {
        EmployeeService employeeService = new EmployeeService();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        public void RegisterUser()
        {
            string name = nameTextBox.Text;

            if(name == "")
            {
                MessageBox.Show("Input field empty. Try again.");
                return;
            }

            int employeeId = employeeService.RegisterEmployee(name);
                                                            
            MessageBox.Show($"You are now registered. ID: {employeeId}");
        }

        private void loginInInsteadButton_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
