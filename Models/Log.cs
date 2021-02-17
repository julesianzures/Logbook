using System;
using System.Windows.Forms;


namespace LogBook.Models
{
    public class Log
    {
        public string employeeId { get; set; }
       //public string name { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string temp { get; set; }
        public string lastPlaceVisited { get; set; }

        public Log(string rowData)
        {
            string[] data = rowData.Split(',');

            this.employeeId = data[0];
            this.date = data[1];
            this.time = data[2];
            this.temp = data[3];
            this.lastPlaceVisited = data[4];
            
        }

        public override string ToString()
        {
            string data = $" {employeeId} {date} {time} {temp} {lastPlaceVisited}";
            return data;
        }

        public ListViewItem TolistViewItem()
        {
            string[] row = { Convert.ToString(employeeId), Convert.ToString(date), Convert.ToString(time), Convert.ToString(temp), lastPlaceVisited };
            ListViewItem listViewItem = new ListViewItem(row);
            return listViewItem;
        }
    }


}
