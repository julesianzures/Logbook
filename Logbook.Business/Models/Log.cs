using System;
using System.Windows.Forms;


namespace Logbook.Business.Models
{
    public class Log
    {
        public int EmployeeId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Temperature { get; set; }
        public string LastPlaceVisited { get; set; }

        public ListViewItem TolistViewItem()
        {
            string[] row = { Convert.ToString(EmployeeId), Convert.ToString(Date), Convert.ToString(Time), Convert.ToString(Temperature), LastPlaceVisited };
            ListViewItem listViewItem = new ListViewItem(row);
            return listViewItem;
        }
    }


}
