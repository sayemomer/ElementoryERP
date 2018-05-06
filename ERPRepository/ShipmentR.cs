using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
   public class ShipmentR : OrderR
    {

        //INSERT INTO shipment(ShipementID,OrderId,ShipmentProgress,Status) VALUES ("1",20%,"on the way");

        private int shipmentId;
        private int shipmentProgress;
        private string status;
        // orderId from parent 

        public int ShipmentId
        {
            get { return shipmentId; }
            set { this.shipmentId = value; }
        }

        public int ShipmentProgress
        {
            get { return shipmentProgress; }
            set { this.shipmentProgress = value; }
        }

        public string Status
        {
            get { return status; }
            set { this.status = value; }
        }

    }
}
