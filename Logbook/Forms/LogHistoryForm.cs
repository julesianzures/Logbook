using System.Windows.Forms;
using System.Collections.Generic;
using Logbook.Business.Models;
using Logbook.Business.Services;
using Logbook.TemporaryStorage;
using System.Linq;

namespace Logbook
{
    public partial class LogHistoryForm : Form
    {
        LogService logService = new LogService();
        public LogHistoryForm()
        {
            InitializeComponent();
            ConvertLogInfo();
            DisplayInfoFromCurrentUser();
        }

        private void ConvertLogInfo()
        {
            int temporaryId = TemporaryIdAndDate.EmployeeId;
            List<Log> logs = logService.GetLogsByEmployeeId(temporaryId);

            for (int i = 0; i < logs.Count; i++)
            {
                Log log = logs[i];
                logListView.Items.Add(log.TolistViewItem());
            }
        }

        private void DisplayInfoFromCurrentUser()
        {
            int temporaryId = TemporaryIdAndDate.EmployeeId;

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
