using System;
using System.IO;

namespace Logbook.Business.Repository
{
    public static class EmployeeAccountManagerRepository
    {
        private static string employeePath = $"{Environment.CurrentDirectory}\\employees.csv";

        private static void CreateFile()
        {
            if (!File.Exists(employeePath))
            {
                File.Create(employeePath).Close();
            }
        }

        public static int Create(string name)
        {
            CreateFile();

            int id = 1;
            using (StreamReader streamReader = new StreamReader(employeePath))
            {
                string csvLine = streamReader.ReadLine();
                while (csvLine != null)
                {
                    id++;
                    csvLine = streamReader.ReadLine();
                }
            }

            File.AppendAllText(employeePath, $"{id},{name}{Environment.NewLine}");

            return id;
        }

        public static Nullable<int> GetById(int id)
        {
            if (!File.Exists(employeePath))
            {
                return null;
            }

            using (StreamReader streamReaderForEmployee = new StreamReader(employeePath))
            {
                string employeeCsvLine = streamReaderForEmployee.ReadLine();
                while (employeeCsvLine != null)
                {
                    string[] employeeSubstring = employeeCsvLine.Split(',');
                    if (employeeSubstring[0] == id.ToString())
                    {
                        return id;
                    }
                    employeeCsvLine = streamReaderForEmployee.ReadLine();
                }

            }
            return null;
        }
    }
}
