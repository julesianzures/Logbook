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

        private void logButton_Click(object sender, EventArgs e)
        {
            Form form = new LogbookForm();
            form.Show();
        }

        private void viewLogHistory_Click(object sender, EventArgs e)
        {
            Form form = new LogHistoryForm();
            form.Show();
        }

        private void logButton_Click_1(object sender, EventArgs e)
        {
            Form form = new LogbookForm();
            form.Show();
            this.Hide();
        }

        private void logHistoryButton_Click(object sender, EventArgs e)
        {
            Form form = new LogHistoryForm();
            form.Show();
            this.Hide();
        }

        private void WelcomeEmployee()
        {
            string temporaryId = TemporaryStorage.employeeId.ToString();
            string path = $"{Environment.CurrentDirectory}\\employees.csv";
            using (StreamReader streamReader = new StreamReader(path))
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
    }
}
