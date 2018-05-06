using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
    interface IDealsRepository
    {
        bool Insert(DealsR i);
        bool Update(DealsR i);
        bool Delete(string CompanyId);
        DealsR GetDealerCompany(string CompanyId);
        List<DealsR> GetAllDealerCompany();

    }
}
