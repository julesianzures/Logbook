using System;
using System.Windows.Forms;

namespace LogBook.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public Employee(string rowData)
        {
            string[] data = rowData.Split(',');

            this.id = Convert.ToInt32(data[0]);
            this.name = data[1];
        }

        public override string ToString()
        {
            string data = $"{id} {name}";
            return data;
        }

        public ListViewItem ToListViewItem()
        {
            string[] row = { Convert.ToString(id), name };
            ListViewItem listViewItem = new ListViewItem(row);

            return listViewItem;
        }
    }
}
