using System;
using System.Windows.Forms;
using Logbook.Business.Models;
using Logbook.Business.Services;
using Logbook.TemporaryStorage;


namespace Logbook
{
    public partial class LogbookForm : Form
    {
        LogService logService = new LogService();
      
        public LogbookForm()
        {
            InitializeComponent();
            ShowDateAndTime();      
        }

        private void ShowDateAndTime()
        {
            var dateAndTime = DateTime.Now;
            displayDateLabel.Text = ($"{dateAndTime.ToString("yyyy-MM-dd")}");
            displayTimeLabel.Text = ($"{dateAndTime.ToString("HH: mm")}");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string storedDate = TemporaryIdAndDate.StoredDate;        
         
            if (tempTextBox.Text == "")
            {
                MessageBox.Show("Please input your temperature.");
                lastPlaceTextBox.Clear();
            }
            else if (storedDate == displayDateLabel.Text)
            {
                addButton.Enabled = false;
                MessageBox.Show("You can only add info once per day.");
                tempTextBox.Clear();
                lastPlaceTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Information added.");
                AddInfo();
            }
        }

        public void AddInfo()           
        {
            EmployeeService employeeService = new EmployeeService();

            int employeeId = TemporaryIdAndDate.EmployeeId;
            Employee employee = employeeService.GetById(employeeId);

            string date = displayDateLabel.Text;
            string time = displayTimeLabel.Text;
            string temp = tempTextBox.Text;
            string lastPlaceVisited = lastPlaceTextBox.Text;

            logService.AddLogInfo(employeeId, date, time, temp, lastPlaceVisited);

            tempTextBox.Clear();
            lastPlaceTextBox.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
