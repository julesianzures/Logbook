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

        public void LogHistory(string path)        
        {
            DataTable logHistory = new DataTable();
            string[] lines = File.ReadAllLines(path);
            StreamReader sr = new StreamReader(path);

            if (lines.Length>0)
            {
                string firstline = lines[0];
                string[] values = firstline.Split(',');

                foreach (string headerWord in values)
                {
                    logHistory.Columns.Add(new DataColumn(headerWord));
                }

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow logHistoryRows = logHistory.NewRow();
                    int columnIndex = 0;

                    foreach (string  headerWord in values)
                    {
                        logHistoryRows[headerWord] = dataWords[columnIndex++];
                    }
                    logHistory.Rows.Add(logHistoryRows);
                    
                }

            }
            if(logHistory.Rows.Count>0)
            {
                dataGridViewLogHistory.DataSource = logHistory;
            }
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            searchTextBox.Text = openFileDialog1.FileName;
            LogHistory(searchTextBox.Text);
            
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

        private void dataGridViewLogHistory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
