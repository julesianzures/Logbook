using System;
using System.Windows.Forms;
using System.IO;
using System.Data;


namespace LogBook
{
    public partial class logHistoryForm : Form
    {
        public logHistoryForm()
        {
            InitializeComponent();
        }

        private void dataGridViewLogHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LogHistory();
        }

        public void LogHistory()        
        {
            string path = $"{Environment.CurrentDirectory}\\employees.csv";

            DataTable logHistoryTable = new DataTable();
            StreamReader sr = new StreamReader(path);
            string csvLine = sr.ReadLine();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
        public void showLogBookForm()
        {
            new LogbookForm().Show();
            this.Hide();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            showLogBookForm();
        }
    }
}
