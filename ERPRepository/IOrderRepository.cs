using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
    interface IOrderRepository
    {
        bool Insert(OrderR od);
        bool Update(OrderR od);
        bool Delete(string OrderId);
        OrderR GetProduct(string OrderId);
        List<OrderR> GetAllProduct();
    }
}
