using System;
using System.Windows.Forms;
using Logbook.TemporaryStorage;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Logbook.Business.Services;
using Logbook.Business.Models;

namespace Logbook
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            WelcomeEmployee();
            ShowLogHistory();
        }

        private void WelcomeEmployee()
        {
            EmployeeService employeeService = new EmployeeService();

            int temporaryId = TemporaryIdAndDate.EmployeeId;
            Employee employee = employeeService.GetById(temporaryId);

            nameLabel.Text = ($"Hello, {employee.Name}");
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            LogbookForm logbookForm = new LogbookForm();
            logbookForm.ShowDialog();
            this.Hide();
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

        private void ShowLogHistory()
        {
            mainPanel.Controls.Clear();
            LogHistoryForm logHistoryForm = new LogHistoryForm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            logHistoryForm.BringToFront();
            logHistoryForm.Update();
            this.mainPanel.Controls.Add(logHistoryForm);
            logHistoryForm.Show();
        }

    }
}
    