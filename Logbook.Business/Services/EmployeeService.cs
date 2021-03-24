using System;
using Logbook.Business.Interface;
using Logbook.Business.Models;
using Logbook.Business.Repository;
using Logbook.TemporaryStorage.Services;
using Logbook.TemporaryStorage;


namespace Logbook.Business.Services
{
    public class EmployeeService
    {
        private IEmployeeRepository employeeRepository = new EmployeeRepository();
        private ILogRepository log = new LogRepository();
        private TemporaryStorageService temporaryStorageService = new TemporaryStorageService();


        public int RegisterEmployee(string name)
        {
            Employee employee = employeeRepository.CreateEmployeeAccount(name);
            temporaryStorageService.SetEmployeeId(employee.EmployeeId);

            return employee.EmployeeId;
        }

        public Employee LoginEmployee(int employeeId)
        {
            Employee employee = employeeRepository.GetByEmployeeId(employeeId);
            
            if (employee != null)
            {
                temporaryStorageService.SetEmployeeId(Convert.ToInt32(employee.EmployeeId));
                return employee;
            }
            
            return employee;
        }

        public Employee GetById(int employeeId)
        {
            Employee employee = employeeRepository.GetByEmployeeId(employeeId);
            
            return employee;
        }
    }
}
