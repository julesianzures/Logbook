using System;
using System.Windows.Forms;

namespace LogBook
{
    public partial class logHistoryForm : Form
    {
        public logHistoryForm()
        {
            InitializeComponent();
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

        private void dataGridViewLogHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
