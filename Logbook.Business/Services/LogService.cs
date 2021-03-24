using Logbook.Business.Models;
using System.Collections.Generic;
using Logbook.Business.Interface;
using Logbook.Business.Repository;
using Logbook.TemporaryStorage;


namespace Logbook.Business.Services
{
    public class LogService
    {
        private ILogRepository logRepository = new LogRepository();

        public void AddLogInfo(int employeeId, string date, string time, string temp, string lastPlaceVisited)
        {
            string TemporaryEmployeeId = TemporaryIdAndDate.EmployeeId.ToString();
            logRepository.AddLogInfo(employeeId, date, time, temp, lastPlaceVisited);
            TemporaryIdAndDate.StoredDate = date;

        }

        public List<Log> GetLogsByEmployeeId(int employeeId)
        {
            List<Log> logs = logRepository.GetByEmployeeId(employeeId);
           
            if(logs.Count > 0)
            {
                TemporaryIdAndDate.StoredDate = logs[logs.Count - 1].Date;
            }

            return logs;
        }

    }
}
