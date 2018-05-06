using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
   public class FinanceRepository
    {
        public List<EmployeeR> GetAllEmployee()
        {
            string query = "SELECT EmployeeId,EmployeeName,EDepartmentName,EStatus,Salary FROM employee where Salary= 0 ";
            List<EmployeeR> iList = new List<EmployeeR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                EmployeeR i = new EmployeeR();

                i.EmployeeId = sdr["EmployeeId"].ToString();
                i.EmployeeName = sdr["EmployeeName"].ToString();
                i.EDepartmentName = sdr["EDepartmentName"].ToString();
                
                i.EStatus = sdr["EStatus"].ToString();
                i.Salary = Convert.ToInt32(sdr["Salary"]);
                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;
        }

        public List<MarketingR> GetAllCampaign()
        {
            string query = "SELECT * from campaign WHERE Budget=0 ";
            List<MarketingR> iList = new List<MarketingR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                MarketingR i = new MarketingR();

                i.CampaignId =Convert.ToInt32( sdr["CampaignId"] );
                i.CampaignName = sdr["CampaignName"].ToString();
                i.Objective = sdr["Objective"].ToString();
                i.Placement = sdr["Placement"].ToString();
                i.EmployeeName = sdr["EmployeeName"].ToString();
                i.LaunchDate = sdr["LaunchDate"].ToString();
                i.EndDate = sdr["EndDate"].ToString();
                i.RunningCost = Convert.ToDouble(sdr["RunningCost"]);
                i.Report = sdr["Report"].ToString();
                i.Budget = Convert.ToDouble(sdr["Budget"]);
                i.Status = sdr["Status"].ToString();
                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;
        }

        public List<InventoryR> GetAllProduct()
        {
            string query = "SELECT * from inventory WHERE Price=0";
            List<InventoryR> iList = new List<InventoryR>();

            DatabaseConnection dc = new DatabaseConnection();
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
        

        public bool Update(EmployeeR er)
        {
            try
            {
                // UPDATE employee SET DepartmentName="sales" WHERE id="M102";

                string query = "UPDATE employee SET EmployeeId = '" + er.EmployeeId + " ',Salary =" + er.Salary + " WHERE EmployeeId = '" + er.EmployeeId + "' ";
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

        public bool UpdatePrice(InventoryR er)
        {
            try
            {
                // UPDATE employee SET DepartmentName="sales" WHERE id="M102";

                string query = "UPDATE inventory SET ProductId = '" +er.ProductId+ "',Price =" +er.Price+ " WHERE ProductId = '"+er.ProductId+"' ";
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


        public bool UpdateBudget(MarketingR er)
        {
            AccountingRepository ar = new AccountingRepository();

            if ( ar.updateBalance(er.Budget) )
            {
                try
                {
                    // UPDATE employee SET DepartmentName="sales" WHERE id="M102";

                    string query = "UPDATE campaign SET Budget =" + er.Budget + " WHERE  CampaignId="+er.CampaignId+" ";
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
            else
            {
                return false;

            }
            
        }
    }
}
