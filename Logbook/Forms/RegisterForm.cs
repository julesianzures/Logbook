using System;
using System.Windows.Forms;
using Logbook.Business.Services;

namespace Logbook
{
    public partial class RegisterForm : Form
    {
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

            int id = EmployeeAccountManagerServices.RegisterEmployee(name);
            
                                                            
            MessageBox.Show($"You are now registered. Id: {id}");
        }

        private void loginInInsteadButton_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
