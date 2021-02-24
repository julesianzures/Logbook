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
            ConvertLogCsv();
            DisplayInfoFromCurrentUser();
        }

        private void ConvertLogCsv()
        {
            logListView.Items.Clear();

            string[] csvLine = File.ReadAllLines($"{Environment.CurrentDirectory}\\log.csv");

            var log = new List<Log>();

            for (int i = 0; i < csvLine.Length; i++)
            {
                Log loghistory = new Log(csvLine[i]);
                log.Add(loghistory);
                logListView.Items.Add(loghistory.TolistViewItem()); 
            }
            
        }

        private void DisplayInfoFromCurrentUser()
        {
            string temporaryId = TemporaryStorage.EmployeeId.ToString();
            foreach (ListViewItem log in logListView.Items)
            {
                if (!log.ToString().Contains(temporaryId.ToString()))
                {
                    logListView.Items.Remove(log);
                }
                logListView.Refresh();
            }
        }
    }
}
