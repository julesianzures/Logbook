using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using LogBook.Models;


namespace LogBook
{
    public partial class LogbookForm : Form
    {

        public LogbookForm()
        {
            InitializeComponent();
            var dateAndTime = DateTime.Now;
            displayDateLabel.Text = ($"{dateAndTime.ToString("yyyy-MM-dd")}");
            displayTimeLabel.Text = ($"{dateAndTime.ToString("HH: mm")}");    
        }

        private void addButton_Click(object sender, EventArgs e) 
        {
            string storedDate = TemporaryStorage.StoredDate;
            Console.WriteLine("storedDate," + storedDate);
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
            string employeeId = TemporaryStorage.EmployeeId.ToString();
            string date = displayDateLabel.Text;
            string time = displayTimeLabel.Text;
            string temp = tempTextBox.Text;
            string lastPlaceVisited = lastPlaceTextBox.Text;

            StringBuilder csv = new StringBuilder();

            string logPath = $"{Environment.CurrentDirectory}\\log.csv"; 
            if (!File.Exists(logPath))
            {
                File.Create(logPath).Close();  
            }

            csv.AppendLine(employeeId);
            csv.AppendLine(date);
            csv.AppendLine(time);
            csv.AppendLine(temp);
            csv.AppendLine(lastPlaceVisited);

            TemporaryStorage.StoredDate = date;

            using (StreamReader streamReader = new StreamReader(logPath))
            {
                string csvLine = streamReader.ReadLine();
                while (csvLine != null)
                {
                    csv.AppendLine(csvLine);
                    csvLine = streamReader.ReadLine();
                }
            }

            File.AppendAllText(logPath, $"{employeeId},{date},{time},{temp},{lastPlaceVisited}{Environment.NewLine}");
            tempTextBox.Clear();
            lastPlaceTextBox.Clear();
        }

        private void clearValuesButton_Click(object sender, EventArgs e)
        {
            tempTextBox.Clear();
            lastPlaceTextBox.Clear();
        }
        
    }
}
