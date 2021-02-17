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
            datePicker.Value = DateTime.Now;
            datePicker.Enabled = false;
            timePicker.Enabled = false;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "yyyy-MM-dd";
        }

        private void timePicker_ValueChanged_1(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm:ss";
        }

        private void addButton_Click(object sender, EventArgs e) 
        {
            if (tempTextBox.Text == ""
                || lastPlaceTextBox.Text == "")
            {
                MessageBox.Show("Empty input fields. Try again.");
            }
            else
            {
                MessageBox.Show("Information added.");
                AddInfo();
            }
        }

        public void AddInfo()           
        {
            string employeeId = TemporaryStorage.employeeId.ToString();
            string date = datePicker.Text;
            string time = timePicker.Text;
            string temp = tempTextBox.Text;
            string lastPlaceVisited = lastPlaceTextBox.Text;
            

            StringBuilder csv = new StringBuilder();

            string path = $"{Environment.CurrentDirectory}\\log.csv"; 
            if (!File.Exists(path))
            {
                File.Create(path).Close();  
            }

            csv.AppendLine(employeeId);
            csv.AppendLine(date);
            csv.AppendLine(time);
            csv.AppendLine(temp);
            csv.AppendLine(lastPlaceVisited);


            using (StreamReader streamReader = new StreamReader(path))
            {
                string csvLine = streamReader.ReadLine();
                while (csvLine != null)
                {
                    csv.AppendLine(csvLine);
                    csvLine = streamReader.ReadLine();
                }
            }

            File.AppendAllText(path, $"{employeeId},{date},{time},{temp},{lastPlaceVisited}{Environment.NewLine}");
        }

        private void clearValuesButton_Click(object sender, EventArgs e)
        {
            datePicker.Checked = false;
            timePicker.Checked = false;
            tempTextBox.Clear();
            lastPlaceTextBox.Clear();
        }
        
        private void viewLogHistory_Click(object sender, EventArgs e)
        {
            Form form = new LogHistoryForm();
            form.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form form = new HomeForm();
            form.Show();
            this.Hide();
        }
    }
}
