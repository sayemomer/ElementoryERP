using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
    interface IShipmentRepository
    {
          bool Insert(ShipmentR s);
       // bool Update(ShipmentR s);
        //bool Delete(string shipmentId);
        //ShipmentR GetProduct(string shipmentId);
        List<ShipmentR> GetAllShipment();

    }
}
