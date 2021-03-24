using Logbook.TemporaryStorage.Services;
using Dapper;
using DapperExtensions;

namespace Logbook.TemporaryStorage.Repositories
{
    public class TemporaryStorageRepository
    {
        public void UpsertEmployeeId(int employeeId)
        {
            TemporaryIdAndDate.EmployeeId = employeeId;
        }

        public void UpsertStoredDate(string date)
        {
            TemporaryIdAndDate.StoredDate = date;
        }

        public int GetEmployeeId()
        {
            return TemporaryIdAndDate.EmployeeId;
        }
        
        public string GetStoredDate()
        {
            return TemporaryIdAndDate.StoredDate;
        }
    }
}
