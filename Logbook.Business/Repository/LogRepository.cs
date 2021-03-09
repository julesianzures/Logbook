using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Logbook.Business.Models;

namespace Logbook.Business.Repository
{
    class LogRepository
    {
        private static string logPath = $"{Environment.CurrentDirectory}\\log.csv";

        public static string GetByEmployeeId(int employeeId)
        {
            if (!File.Exists(logPath))
            {
                File.Create(logPath).Close();
            }

            string lastDate = null;

            using (StreamReader streamReaderForLog = new StreamReader(logPath))
            {
                string logCsvLine = streamReaderForLog.ReadLine();
                while (logCsvLine != null)
                {
                    string[] logSubstring = logCsvLine.Split(',');
                    if (logSubstring[0] == employeeId.ToString())
                    {
                        Console.WriteLine(logSubstring[1]);
                        lastDate = logSubstring[1];
                    }
                    logCsvLine = streamReaderForLog.ReadLine();
                }
                return lastDate;
            }
        }

        public static void Add(string employeeId, string date, string time, string temp, string lastPlaceVisited)
        {
            GetByEmployeeId(Convert.ToInt32(employeeId));

            StringBuilder csv = new StringBuilder();

            csv.AppendLine(employeeId);
            csv.AppendLine(date);
            csv.AppendLine(time);
            csv.AppendLine(temp);
            csv.AppendLine(lastPlaceVisited);

            using (StreamReader streamReader = new StreamReader(logPath))
            {
                string csvLine = streamReader.ReadLine();
                while (csvLine != null)
                {
                    csv.AppendLine(csvLine);
                    csvLine = streamReader.ReadLine();
                }
            }

            File.AppendAllText(logPath, $"{employeeId},{date},{time},{temp},{lastPlaceVisited}{Environment.NewLine}");

            return;
        }

        public static List<Log> Read()
        {
            string[] csvLine = File.ReadAllLines($"{Environment.CurrentDirectory}\\log.csv");
            var logs = new List<Log>();
            for (int i = 0; i < csvLine.Length; i++)
            {
                Log logHistory = new Log(csvLine[i]);
                logs.Add(logHistory);
            }

            return logs;
        }

    }
}
