﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace LogBook
{
    public partial class LogbookForm : Form
    {
        public LogbookForm()
        {
            InitializeComponent();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "yyyy/MM/dd";
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm:ss";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddInfo();
        }

        public void AddInfo()           
        {
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

            csv.AppendLine(date);
            csv.AppendLine(time);
            csv.AppendLine(temp);
            csv.AppendLine(lastPlaceVisited);
            

            StreamReader sr = new StreamReader(path);
            string csvLine = sr.ReadLine();
            while (csvLine != null)
            {
                csv.AppendLine(csvLine);
                csvLine = sr.ReadLine();
            }

            sr.Close();

            File.AppendAllText(path, $"{date},{time},{temp},{lastPlaceVisited}{Environment.NewLine}");
            MessageBox.Show("Information added.");
            
        }

        private void clearValuesButton_Click(object sender, EventArgs e)
        {
            datePicker.Checked = false;
            timePicker.Checked = false;
            tempTextBox.Clear();
            lastPlaceTextBox.Clear();
           
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewLogHistory_Click(object sender, EventArgs e)
        {
            showLogHistory();
        }

        public void showLogHistory()
        {
            new logHistoryForm().Show();
            this.Hide();
        }

    }
}
