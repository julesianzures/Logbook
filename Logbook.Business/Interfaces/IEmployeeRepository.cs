using Logbook.Business.Models;

namespace Logbook.Business.Interface
{
    public interface IEmployeeRepository
    {
        Employee CreateEmployeeAccount(string name);
        Employee GetByEmployeeId(int id);
    }
}
