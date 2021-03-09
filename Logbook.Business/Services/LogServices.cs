using Logbook.Business.Repository;
using Logbook.Business.Models;
using System.Collections.Generic;

namespace Logbook.Business.Services
{
    public static class LogServices
    {
        public static void AddLogInfo(string date, string time, string temp, string lastPlaceVisited)
        {
            string employeeId = TemporaryStorage.EmployeeId.ToString();
            LogRepository.Add(employeeId, date, time, temp, lastPlaceVisited);
            TemporaryStorage.StoredDate = date;
        }

        public static List<Log> GetLogs()
        {
            return LogRepository.Read();
        }

    }
}
