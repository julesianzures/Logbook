using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using LogBook.Models;



namespace LogBook
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

            if (employeeId == String.Empty)
            {
                MessageBox.Show("Input field is empty. Try again.");
            }
            
            else 
            {
                string employeePath = $"{Environment.CurrentDirectory}\\employees.csv";
                
                if (!File.Exists(employeePath))
                {
                    MessageBox.Show("No users found.");
                    File.Create(employeePath).Close();
                }

                using (StreamReader streamReaderForEmployee = new StreamReader(employeePath))
                {
                    string employeeCsvLine = streamReaderForEmployee.ReadLine();
                    bool userFound = false;
                    while (employeeCsvLine != null)
                    {

                        string[] EmployeeSubstring = employeeCsvLine.Split(',');
                        if (EmployeeSubstring[0] == employeeId)
                        {
                            userFound = true;
                            TemporaryStorage.EmployeeId = Convert.ToInt32(EmployeeSubstring[0]);
                            CheckDateStored();
                            new HomeForm().Show();
                            this.Hide();
                            break;
                        }

                        employeeCsvLine = streamReaderForEmployee.ReadLine();
                    }

                    if (!userFound)   
                    {
                        MessageBox.Show("User not registered");
                        employeeIdTextBox.Clear();
                    }
                }

            }
        }

        private void CheckDateStored()
        {
            string logPath = $"{Environment.CurrentDirectory}\\log.csv";
            if (!File.Exists(logPath))
            {
                File.Create(logPath).Close();
            }
            using (StreamReader streamReaderForLog = new StreamReader(logPath))
            {
                string logCsvLine = streamReaderForLog.ReadLine();
                while (logCsvLine != null)
                {
                    string[] LogSubstring = logCsvLine.Split(',');
                    if (LogSubstring[0] == TemporaryStorage.EmployeeId.ToString())
                    {
                        TemporaryStorage.DateStored = Convert.ToString(LogSubstring[1]);
                    }
                    logCsvLine = streamReaderForLog.ReadLine();
                }
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
