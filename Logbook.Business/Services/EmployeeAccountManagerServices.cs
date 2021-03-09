using Logbook.Business.Repository;
using Logbook.Business.Models;
using System;

namespace Logbook.Business.Services
{
    public static class EmployeeAccountManagerServices
    {
        public static int RegisterEmployee(string name)
        {
            int employeeId = EmployeeAccountManagerRepository.Create(name);
            TemporaryStorage.EmployeeId = employeeId;
            return employeeId;
        }

        public static int? LoginEmployee(int id)
        {
            int? employeeId = EmployeeAccountManagerRepository.GetById(id);

            if (employeeId == null)
            {
                return null;
            }

            TemporaryStorage.EmployeeId = Convert.ToInt32(employeeId);
            TemporaryStorage.StoredDate = LogRepository.GetByEmployeeId(Convert.ToInt32(employeeId));

            return employeeId;
        }
    }
}
