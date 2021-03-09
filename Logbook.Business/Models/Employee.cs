using System;
using System.Windows.Forms;


namespace Logbook.Business.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(string rowData)
        {
            string[] data = rowData.Split(',');

            this.Id = Convert.ToInt32(data[0]);
            this.Name = data[1];
        }

        public override string ToString()
        {
            string data = $"{Id} {Name}";
            return data;
        }

        public ListViewItem ToListViewItem()
        {
            string[] row = { Convert.ToString(Id), Name };
            ListViewItem listViewItem = new ListViewItem(row);

            return listViewItem;
        }
    }
}
