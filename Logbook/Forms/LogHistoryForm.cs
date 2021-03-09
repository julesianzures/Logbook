using System.Windows.Forms;
using System.Collections.Generic;
using Logbook.Business.Models;
using Logbook.Business.Services;

namespace Logbook
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
            List<Log> logs = LogServices.GetLogs();

            for (int i = 0; i < logs.Count; i++)
            {
                Log log = logs[i];
                logListView.Items.Add(log.TolistViewItem());
            }
        }

        private void DisplayInfoFromCurrentUser()
        {
            int temporaryId = TemporaryStorage.EmployeeId;
            foreach (ListViewItem log in logListView.Items)
            {
                if (!log.ToString().Contains(temporaryId.ToString()))
                {
                    logListView.Items.Remove(log);
                }
            }
        }
    }
}
