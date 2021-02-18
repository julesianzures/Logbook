using System;
using System.Windows.Forms;
using LogBook.Models;
using System.Collections.Generic;
using System.IO;

namespace LogBook
{
    public partial class LogHistoryForm : Form
    {
        public LogHistoryForm()
        {
            InitializeComponent();
            ConvertEmployeeCsv();
            ConvertLogCsv();
        }

        private void ConvertEmployeeCsv()
        {
            employeeListView.Items.Clear();

            string[] csvLine = File.ReadAllLines($"{Environment.CurrentDirectory}\\employees.csv");

            for (int i = 0; i < csvLine.Length; i++)
            {
                Employee employee = new Employee(csvLine[i]);
                employeeListView.Items.Add(employee.ToListViewItem());
            }
        }

        private void ConvertLogCsv()
        {
            logListView.Items.Clear();

            string[] csvline = File.ReadAllLines($"{Environment.CurrentDirectory}\\log.csv");

            var log = new List<Log>();

            for (int i = 0; i < csvline.Length; i++)
            {
                Log loghistory = new Log(csvline[i]);
                log.Add(loghistory);
                logListView.Items.Add(loghistory.TolistViewItem());
            }
        }

        public void SearchInListView()
        {
            foreach (ListViewItem employee in employeeListView.Items)
            {
                if (!employee.ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                {
                    Console.WriteLine(employee.ToString());
                    employeeListView.Items.Remove(employee);
                }
            }

            foreach (ListViewItem logList in logListView.Items)
            {
                if (!logList.ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                {
                    logListView.Items.Remove(logList);
                }
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchInListView();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form form = new HomeForm();
            form.Show();
            this.Hide();
        }

        private void logbookFormButton_Click(object sender, EventArgs e)
        {
            Form form = new LogbookForm();
            form.Show();
            this.Hide();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ConvertEmployeeCsv();
            ConvertLogCsv();
        }

       
    }
}
