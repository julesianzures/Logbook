using Logbook.TemporaryStorage.Repositories;
using System;

namespace Logbook.TemporaryStorage.Services
{
    public class TemporaryStorageService
    {
        public int GetEmployeeId()
        {
            TemporaryStorageRepository temporaryStorageRepository = new TemporaryStorageRepository();
            int employeeId = temporaryStorageRepository.GetEmployeeId();
            return employeeId;
        }

        public void SetEmployeeId(int employeeId)
        {
            TemporaryStorageRepository temporaryStorageRepository = new TemporaryStorageRepository();
            temporaryStorageRepository.UpsertEmployeeId(employeeId);
        }

        public void SetStoredDate(string date)
        {
            TemporaryStorageRepository temporaryStorageRepository = new TemporaryStorageRepository();
            temporaryStorageRepository.UpsertStoredDate(date);
        }
    }
}
