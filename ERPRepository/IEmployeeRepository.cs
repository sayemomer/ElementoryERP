using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
    interface IEmployeeRepository
    {
        //bool Insert(EmployeeR r);
       // bool Update(EmployeeR r);
       // bool Delete(string employeeId);
       // EmployeeR GetEmployee(string employeeId);
        List<EmployeeR> GetAllEmployee();

    }
}
