using Logbook.Business.Interface;
using System;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Logbook.Business.Models;
using System.Linq;

namespace Logbook.Business.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee CreateEmployeeAccount(string name)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LogbookProjectDB"].ConnectionString))
            {
                int newEmployeeId = connection.ExecuteScalar<int>("INSERT INTO Employee (Name) VALUES (@Name); SELECT CAST(scope_identity() AS int)",
                    new { Name = name });
                Employee employee = GetByEmployeeId(newEmployeeId);
                return employee;
            }
        }

        public Employee GetByEmployeeId(int employeeId)
        { 
            Console.WriteLine(employeeId);
            
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LogbookProjectDB"].ConnectionString))
            {
                Employee employee = connection.Query<Employee>("SELECT * FROM Employee WHERE EmployeeId = @Id", new { Id = employeeId }).SingleOrDefault();
                
                return employee;
            }
        }
    }
}
