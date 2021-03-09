using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogBook.Models
{
    class LogHistory
    {
        public DateTime date { get; set; }
        public DateTime time { get; set; }
        public int temp { get; set; }
        public string lastPlaceVisited { get; set; }
    }
}
