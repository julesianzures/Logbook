using System.Collections.Generic;
using Logbook.Business.Models;

namespace Logbook.Business.Interface
{
    public interface ILogRepository
    {
        List<Log> GetByEmployeeId(int employeeId);
        Log AddLogInfo(int employeeId, string date, string time, string temperature, string lastPlaceVisited);
    }
}
