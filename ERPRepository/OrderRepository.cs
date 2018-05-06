using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
   public class OrderRepository
    {
        public bool Insert(OrderR i)
        {
            try
            {

                //INSERT INTO order(OrderID,ProductId,ProductName,Quantity,Address,EmployeeID) VALUES ("y120","y180",y180,10,"basundhora","S101");
                string query = " INSERT into all_order VALUES ('"+i.OrderId+"','"+i.ProductId+"',' "+i.ProductName+"', "+i.Quantity+", '"+i.Address+"', '"+i.EmployeeName+"' ,'"+i.Status+"','"+i.Catagory+"' ) ";
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

        

       public bool Update(OrderR i)
        {
            try
            {
                //string query = "UPDATE all_order SET  OrderId= '"+i.OrderId+"',ProductId = '" + i.ProductId + "',ProductName  = '" + i.ProductName + "', Quantity =" + i.Quantity + ", Address = '" + i.Address + "', EmployeeName = '" + i.EmployeeName + "WHERE OrderId = " + i.OrderId + " ";
                string query = "UPDATE all_order SET  ProductId = '" + i.ProductId + "',OrderId= '" + i.OrderId + "', ProductName  = '" + i.ProductName + "', Address = '" + i.Address + "',EmployeeName = '" + i.EmployeeName + "',Quantity =" + i.Quantity + "WHERE OrderId = " + i.OrderId + " ";
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

        public bool Delete(string OrderId)
        {
            try
            {
                string query = "DELETE From all_order WHERE OrderId='"+OrderId+"'";
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

        public OrderR GetProduct(string orderId)
        {
            string query = "SELECT * from all_order WHERE OrderId = '" + orderId + "'";
            OrderR i = null;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                //(ProductName,ProductId,Volume,Price,Store,Category,Tax)
                i = new OrderR();
                i.OrderId = sdr["OrderId"].ToString();
                i.ProductId = sdr["ProductId"].ToString();
                i.ProductName = sdr["ProductName"].ToString();
                i.Quantity = Convert.ToInt32(sdr["Quantity"]);
                i.Address = sdr["Address"].ToString();
                i.EmployeeName = sdr["EmployeeName"].ToString();
            }
            dc.CloseConnection();
            return i;
        }

        public List<OrderR> GetAllOrder()
        {
            string query = "SELECT * from all_order WHERE Status='Order' ";
            List<OrderR> orderList = new List<OrderR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);
            InventoryRepository ir = new InventoryRepository();

            while (sdr.Read())
            {
               OrderR i = new OrderR();

                i.OrderId = sdr["OrderId"].ToString();
                i.ProductId = sdr["ProductId"].ToString();
                i.ProductName = sdr["ProductName"].ToString();
                i.Quantity = Convert.ToInt32(sdr["Quantity"]);
                i.Address = sdr["Address"].ToString();
                i.EmployeeName = sdr["EmployeeName"].ToString();
                i.Catagory = sdr["Catagory"].ToString();
                i.Available = ir.checkAvailable(i.ProductId); 

                orderList.Add(i);
            }
            dc.CloseConnection();
            return orderList;
        }


        public List<OrderR> searchOrder(string text)
        {
            string query = "SELECT * from all_order WHERE ProductId like '%" +text +"%' or ProductName like '%" + text + "%' or Quantity like '%" + text + "%' or Address like '%" + text + "%' or EmployeeName like '%" + text + "%' ";

            List<OrderR> iList = new List<OrderR>();
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                OrderR i = new OrderR();

                i.OrderId = sdr["OrderId"].ToString();
                i.ProductId = sdr["ProductId"].ToString();
                i.ProductName = sdr["ProductName"].ToString();
                i.Quantity = Convert.ToInt32(sdr["Quantity"]);
                i.Address = sdr["Address"].ToString();
                i.EmployeeName = sdr["EmployeeName"].ToString();

                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;

        }

        public bool updateStatus( string orderId)
        {
            try
            {
                //string query = "UPDATE all_order SET  OrderId= '"+i.OrderId+"',ProductId = '" + i.ProductId + "',ProductName  = '" + i.ProductName + "', Quantity =" + i.Quantity + ", Address = '" + i.Address + "', EmployeeName = '" + i.EmployeeName + "WHERE OrderId = " + i.OrderId + " ";
                string query = "UPDATE all_order SET  Status ='Shipment'  WHERE OrderId = "+orderId+" ";
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

       public int countOrder(string catagory)
        {
            string query = "SELECT COUNT(Quantity) as Quantity FROM all_order where Catagory='"+catagory+"' ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                result = Convert.ToInt32(sdr["Quantity"]);

            }
            dc.CloseConnection();
            return result;

        }

        public int countAllOrder()
        {
            string query = "SELECT COUNT(*) as orders FROM all_order ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                result = Convert.ToInt32(sdr["orders"]);

            }
            dc.CloseConnection();
            return result;

        }

    }
}
