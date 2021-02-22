using System;
using System.Windows.Forms;
using System.IO;
using LogBook.Models;

namespace LogBook
{
    public partial class HomeForm : Form
    {

        public HomeForm()
        {
            InitializeComponent();
            WelcomeEmployee();
        }

        private void WelcomeEmployee()
        {
            string temporaryId = TemporaryStorage.EmployeeId.ToString();
            string employeePath = $"{Environment.CurrentDirectory}\\employees.csv";
            using (StreamReader streamReader = new StreamReader(employeePath))
            {
                string csvLine = streamReader.ReadLine();
                bool userFound = false;
                while (csvLine != null)
                {
                    string[] substring = csvLine.Split(',');
                    if (substring[0] == temporaryId)
                    {
                        Console.WriteLine(substring);
                        nameLabel.Text = ($"Hello, {substring[1]}");
                        userFound = true;
                    }
                    csvLine = streamReader.ReadLine();
                }
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LogbookForm logbookForm = new LogbookForm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            logbookForm.BringToFront();
            this.mainPanel.Controls.Add(logbookForm);
            if (logbookForm.addButton.Enabled == false)
            {
                logButton.Enabled = false;
            }
            else
            {
                logbookForm.Show();
            }

        }

        private void logHistoryButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LogHistoryForm logHistoryForm = new LogHistoryForm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            logHistoryForm.BringToFront();
            this.mainPanel.Controls.Add(logHistoryForm);
            logHistoryForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Form loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
    