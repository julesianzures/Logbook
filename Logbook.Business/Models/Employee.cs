using System;
using System.Windows.Forms;


namespace Logbook.Business.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        

        //public override string ToString()
        //{
        //    string data = $"{EmployeeId} {Name}";
        //    return data;
        //}

        public ListViewItem ToListViewItem()
        {
            string[] row = { Convert.ToString(EmployeeId), Name };
            ListViewItem listViewItem = new ListViewItem(row);

            return listViewItem;
        }
    }
}
