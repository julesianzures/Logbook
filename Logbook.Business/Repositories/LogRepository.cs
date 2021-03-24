using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Logbook.Business.Models;
using Logbook.Business.Interface;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using Logbook.TemporaryStorage;

namespace Logbook.Business.Repository
{
    public class LogRepository : ILogRepository
    {
        public List<Log> GetByEmployeeId(int employeeId) 
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LogbookProjectDB"].ConnectionString))
            {
                IEnumerable<Log> logs = connection.Query<Log>("SELECT * FROM LOG WHERE EmployeeId = @Id", new { Id = employeeId });

                List<Log> logsList = logs.ToList<Log>();
                return logsList;
            }
        }

        public Log AddLogInfo(int employeeId, string date, string time, string temperature, string lastPlaceVisited)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LogbookProjectDB"].ConnectionString))
            {

                int newLogInfo = connection.ExecuteScalar<int>("INSERT INTO Log (EmployeeId, Date, Time, Temperature, LastPlaceVisited) VALUES (@EmployeeId, @Date, @Time, @Temperature, @LastPlaceVisited); SELECT CAST(scope_identity() AS int)",
                    new { EmployeeId = employeeId, Date = date, Time = time, Temperature = temperature, LastPlaceVisited = lastPlaceVisited });
                Log log = GetByLogId(newLogInfo);

                    return log;
            }
        }

        public Log GetByLogId(int logId)
        {
            Console.WriteLine(logId);
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LogbookProjectDB"].ConnectionString))
            {
               Log log = connection.QueryFirst<Log>("SELECT * FROM Log WHERE Id = @id", new { id = logId });

                return log;
            }
        }
         
    }
}
