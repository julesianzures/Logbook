using System;
using System.Windows.Forms;


namespace Logbook.Business.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public ListViewItem ToListViewItem()
        {
            string[] row = { Convert.ToString(EmployeeId), Name };
            ListViewItem listViewItem = new ListViewItem(row);

            return listViewItem;
        }
    }
}
