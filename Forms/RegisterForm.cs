using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using LogBook.Models;

namespace LogBook
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

            StringBuilder csv = new StringBuilder();
            int employeeId = 1;

            string path = $"{Environment.CurrentDirectory}\\employees.csv";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            
            csv.AppendLine(name);

            using (StreamReader streamReader = new StreamReader(path))
            {
                string csvLine = streamReader.ReadLine();
                while (csvLine != null)
                {
                    employeeId++;
                    csv.AppendLine(csvLine);
                    csvLine = streamReader.ReadLine();
                }
            }

            File.AppendAllText(path, $"{employeeId},{name}{Environment.NewLine}");
            nameTextBox.Clear();

            TemporaryStorage.EmployeeId = employeeId;
            MessageBox.Show($"You are now registered. Id: {TemporaryStorage.EmployeeId}");
        }

        private void loginInInsteadButton_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
