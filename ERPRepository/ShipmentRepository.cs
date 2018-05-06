using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
   public class ShipmentRepository : IShipmentRepository
    {
       public bool Insert(ShipmentR i)
        {
            try
            {
              //INSERT INTO shipment(ShipementID,OrderId,ShipmentProgress,Status) VALUES ("1",20%,"on the way");

                string query = "INSERT into all_shipment VALUES ('"+i.OrderId+"',"+i.ShipmentProgress+",'"+i.Status+"')";
                DatabaseConnection dc = new DatabaseConnection();
                dc.ConnectWithDB();
                int x = dc.ExecuteSQL(query);
                dc.CloseConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(ShipmentR i)
        {
            try
            {
                //UPDATE all_shipment SET ShipmentProgress=50, Status='haha' WHERE ShipmentId=26;
                string query = "UPDATE all_shipment SET Status='"+i.Status+"',ShipmentProgress="+i.ShipmentProgress+ "WHERE ShipmentId = "+i.ShipmentId+" ";
                DatabaseConnection dc = new DatabaseConnection();
                dc.ConnectWithDB();
                int x = dc.ExecuteSQL(query);
                dc.CloseConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       public bool Delete(int Id)
        {
            try
            {
                string query = "DELETE From all_shipment WHERE ShipmentId="+Id+" ";
                DatabaseConnection dc = new DatabaseConnection();
                dc.ConnectWithDB();
                int x = dc.ExecuteSQL(query);
                dc.CloseConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       /* public ShipmentR GetProduct(string productId)
        {
            string query = "SELECT * from inventory WHERE ProductId = '" + productId + "'";
            InventoryR i = null;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                //(ProductName,ProductId,Volume,Price,Store,Category,Tax)
                i = new InventoryR();
                i.ProductId = sdr["ProductId"].ToString();
                i.ProductName = sdr["ProductName"].ToString();
                i.Price = Convert.ToDouble(sdr["Volume"]);
                i.Volume = Convert.ToInt32(sdr["Price"]);
                i.Store = sdr["Quantity"].ToString();
                i.Category = sdr["Catagory"].ToString();
                i.Tax = Convert.ToInt32(sdr["Tax"]);
            }
            dc.CloseConnection();
            return i;
        }*/

       

        public List<ShipmentR> GetAllShipment()
        {
            string query = "SELECT * from all_shipment";
            List<ShipmentR> iList = new List<ShipmentR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                ShipmentR i = new ShipmentR();

               /* OrderR iorder = new OrderR();
                OrderRepository order = new OrderRepository();*/

                i.ShipmentId =Convert.ToInt32( sdr["ShipmentId"] );
                i.OrderId = sdr["OrderId"].ToString();
                i.ShipmentProgress = Convert.ToInt32(sdr["ShipmentProgress"]);
                i.Status = sdr["Status"].ToString();

               /* //getting other data from all_order table with this order Id 
                iorder = order.GetProduct( sdr["OrderId"].ToString() );
                i.ProductName = iorder.ProductName;
                i.Address = iorder.Address;
                i.EmployeeName = iorder.EmployeeName;*/
                
                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;
        }


      public List<ShipmentR> searchShipment(string text)
        {
            string query = "SELECT * from all_shipment WHERE OrderId like '%" + text + "%' or ShipmentId like '%" + text + "%' or ShipmentProgress like '%" + text + "%' or Status like '%" + text + "%' ";
            List<ShipmentR> iList = new List<ShipmentR>();
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                ShipmentR i = new ShipmentR();

                i.ShipmentId = Convert.ToInt32(sdr["ShipmentId"]);
                i.OrderId = sdr["OrderId"].ToString();
                i.ShipmentProgress = Convert.ToInt32(sdr["ShipmentProgress"]);
                i.Status = sdr["Status"].ToString();

                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;

        }


      public int countAllShipment()
      {
          string query = "SELECT COUNT(*)  as shipments FROM all_shipment ";
          int result = 0;
          DatabaseConnection dc = new DatabaseConnection();
          dc.ConnectWithDB();
          SqlDataReader sdr = dc.GetData(query);

          if (sdr.Read())
          {
              result = Convert.ToInt32(sdr["shipments"]);
          }
          dc.CloseConnection();
          return result;

      }


      public int countShipment(string status)
      {
          string query = "SELECT COUNT(*) as shipment FROM all_shipment where Status='"+status+"' ";
          int result = 0;
          DatabaseConnection dc = new DatabaseConnection();
          dc.ConnectWithDB();
          SqlDataReader sdr = dc.GetData(query);


          if (sdr.Read())
          {
              if (sdr["shipment"] == DBNull.Value)
              {
                  return result;
              }
              else
              {
                  result = Convert.ToInt32(sdr["shipment"]);
              }


          }


          dc.CloseConnection();
          return result;

      }

    }
}
