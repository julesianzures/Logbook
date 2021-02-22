using System;
using System.Windows.Forms;


namespace LogBook.Models
{
    public class Log
    {
        public string EmployeeId { get; set; }
       //public string Name { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Temperature { get; set; }
        public string LastPlaceVisited { get; set; }

        public Log(string rowData)
        {
            string[] data = rowData.Split(',');

            this.EmployeeId = data[0];
            this.Date = data[1];
            this.Time = data[2];
            this.Temperature = data[3];
            this.LastPlaceVisited = data[4];
            
        }

        public override string ToString()
        {
            string data = $" {EmployeeId} {Date} {Time} {Temperature} {LastPlaceVisited}";
            return data;
        }

        public ListViewItem TolistViewItem()
        {
            string[] row = { Convert.ToString(EmployeeId), Convert.ToString(Date), Convert.ToString(Time), Convert.ToString(Temperature), LastPlaceVisited };
            ListViewItem listViewItem = new ListViewItem(row);
            return listViewItem;
        }
    }


}
