using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
  public class InventoryRepository: IInventoryRepository
    {
        public bool Insert(InventoryR i)
        {
            try
            {
               // INSERT INTO inventory(ProductName,ProductId,Volume,Price,Store,Category,Tax) VALUES ("yamaha 180","y180",10,120000,"basundhora","bike",5);

                string query = " INSERT into inventory VALUES ('"+i.ProductId+"','"+i.ProductName+"', "+i.Volume+", "+i.Price+", '"+i.Store +"', '"+i.Category+"' , "+i.Tax+") ";
                DatabaseConnection dc = new DatabaseConnection();
                dc.ConnectWithDB();
                int x = dc.ExecuteSQL(query);
                dc.CloseConnection();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool Update(InventoryR i)
        {
            try
            {
                // INSERT INTO inventory(ProductName,ProductId,Volume,Price,Store,Category,Tax) VALUES ("yamaha 180","y180",10,120000,"basundhora","bike",5);

                string query = "UPDATE inventory SET ProductId = '"+i.ProductId+"',ProductName  = '"+ i.ProductName+"', Volume ="+i.Volume+", Price = "+i.Price+", Store= '"+i.Store+"',Catagory= '"+i.Category+"',Tax= "+i.Tax+ "WHERE ProductId = '"+i.ProductId+"' ";
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

        public bool Delete(string ProductId)
        {
            try
            {
                string query = "DELETE From inventory WHERE ProductId='" + ProductId + "'";
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

        public InventoryR GetProduct(string productId)
        {
            string query = "SELECT * from inventory WHERE ProductId = '"+productId+"'";
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
        }

        public List<InventoryR> GetAllProduct()
        {
            string query = "SELECT * from inventory";
            List<InventoryR> iList = new List<InventoryR>();

            DatabaseConnection dc= new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                InventoryR i = new InventoryR();

                i.ProductId = sdr["ProductId"].ToString();
                i.ProductName = sdr["ProductName"].ToString();
                i.Volume = Convert.ToInt32(sdr["Volume"]);
                i.Price = Convert.ToDouble(sdr["Price"]);
                i.Store = sdr["Store"].ToString();
                i.Category = sdr["Catagory"].ToString();
                i.Tax = Convert.ToInt32(sdr["Tax"]);

                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;
        }


        public List<InventoryR> searchInventory(string text)
        {
            string query = "SELECT * from inventory WHERE ProductId like '%" + text + "%' or ProductName like '%" + text + "%' or Volume like '%" + text + "%' or Price like '%" + text + "%' or Store like '%" + text + "%' or Catagory like '%" + text + "%' or  Tax like '%" + text + "%'";
            List<InventoryR> iList = new List<InventoryR>();
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                InventoryR i = new InventoryR();

                i.ProductId = sdr["ProductId"].ToString();
                i.ProductName = sdr["ProductName"].ToString();
                i.Price = Convert.ToDouble(sdr["Price"]);
                i.Volume = Convert.ToInt32(sdr["Volume"]);
                i.Store = sdr["Store"].ToString();
                i.Category = sdr["Catagory"].ToString();
                i.Tax = Convert.ToInt32(sdr["Tax"]);

                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;

        }

        public List<string> GetAllId()
        {
            string query = "SELECT ProductId from inventory";
            List<string> iList = new List<string>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                string s;

                s = sdr["ProductId"].ToString();

                iList.Add(s);
            }
            dc.CloseConnection();
            return iList;
        }

        public string GetProductName(string id)
        {
            string query = "SELECT ProductName from inventory WHERE ProductId='"+id+"' ";
            string name = "";

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                name = sdr["ProductName"].ToString();

            }
            dc.CloseConnection();
            return name;
        }

        public int checkAvailable(string id)
        {

            string query = "SELECT Volume from inventory WHERE ProductId='"+id+"' ";
            int volume = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {

                volume = Convert.ToInt32(sdr["Volume"]);

            }
            dc.CloseConnection();
            return volume;

        }

        public bool updateInventory(string id , int volume)
        {
            try
            {
                string query = "UPDATE inventory SET Volume="+volume+ "WHERE ProductId = '"+id+"' ";
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

        public string GetProductCatagory(string id)
        {
            string query = "SELECT Catagory from inventory WHERE ProductId='"+id+"' ";
            string name = "";

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                name = sdr["Catagory"].ToString();

            }
            dc.CloseConnection();
            return name;
        }

        public int countAllInventory()
        {
            string query = "SELECT SUM(Volume) as inventories FROM inventory ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                if (sdr["inventories"] == DBNull.Value)
                {
                    return result;
                }
                else
                {
                    result = Convert.ToInt32(sdr["inventories"]);
                }
                
            }
            dc.CloseConnection();
            return result;

        }

        public int countAllInventoryAnd()
        {
            string query = "SELECT COUNT(*)  as inventories FROM inventory WHERE Price=0 ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                if (sdr["inventories"] == DBNull.Value)
                {
                    return result;
                }
                else
                {
                    result = Convert.ToInt32(sdr["inventories"]);
                }

            }
            dc.CloseConnection();
            return result;

        }

       

        public int countInventory(string catagory)
        {
            string query = "SELECT SUM(Volume) as inventories FROM inventory where Catagory='"+catagory+"' ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

        
                if (sdr.Read())
                {
                    if (sdr["inventories"] == DBNull.Value)
                    {
                        return result;
                    }
                    else
                    {
                        result = Convert.ToInt32(sdr["inventories"]);
                    }
                    

                }
     
            
            dc.CloseConnection();
            return result;

        }



    }
}
