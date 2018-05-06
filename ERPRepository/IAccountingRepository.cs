using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
    interface IAccountingRepository
    {
       // bool Insert(AccountingR i);
       // bool Update(AccountingR i);
       // bool Delete(string date);
       // AccountingR GetTransiction(string date);
        List<AccountingR> GetAllTransiction();
    }
}
