using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
    interface IInventoryRepository
    {
        bool Insert(InventoryR i);
        bool Update(InventoryR i);
        bool Delete(string ProductId);
        InventoryR GetProduct(string ProductId);
        List<InventoryR> GetAllProduct();
    }
}
