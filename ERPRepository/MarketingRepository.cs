using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
   public class MarketingRepository : IMarketingRepository
    {

        public bool Insert(MarketingR mk)
        {
            try
            {
                // INSERT INTO campaign(CampaignID,CampaignName,Objective,Placement,EmployeeID,LaunchDate,EndDate) 
                //VALUES ("y180_FBIB","Fastest bike bangladesh RoadShow","300 feet","M102",10-12-2018 to 12-12-2018)                

                string query = " INSERT into campaign VALUES ('"+mk.CampaignName+"','"+mk.Objective+"','"+mk.Placement+"','"+mk.EmployeeName+"','"+mk.LaunchDate+"','"+mk.EndDate+"','"+mk.RunningCost+"','"+mk.Report+"' ,"+mk.Budget+",'"+mk.Status+"' ) ";
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
        //
        public bool Update(MarketingR mk)
        {
            try
            {
                // 

                string query = "UPDATE campaign SET CampaignName='"+mk.CampaignName+"',Objective='"+mk.Objective+"',Placement='"+mk.Placement+"',EmployeeName='"+mk.EmployeeName+"', LaunchDate='"+mk.LaunchDate+"',EndDate='"+mk.EndDate+"',RunningCost="+mk.RunningCost+",Status='"+mk.Status+"',Report='"+mk.Report+"',Budget= "+mk.Budget+ "WHERE CampaignId="+mk.CampaignId+" ";
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

        public bool UpdateCost(int id , double cost , string report)
        {
            try
            {
                // 

                string query = "UPDATE campaign SET Report='"+report+"',RunningCost= "+cost+ "WHERE CampaignId="+id+" ";
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

        //
        public bool Delete(string CampaignId)
        {
            try
            {
                //
                string query = "DELETE From campaign WHERE CampaignId='"+CampaignId+"' ";
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
        //
        public List<MarketingR> GetCampaign(string CampaignId)
        {
            string query = "SELECT * from campaign WHERE CampaignId= '" + CampaignId + "'";
            List<MarketingR> iList = new List<MarketingR>();
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                MarketingR i = new MarketingR();

                i.CampaignName = sdr["CampaignName"].ToString();
                i.Objective = sdr["Objective"].ToString();
                i.Placement = sdr["Placement"].ToString();
                i.EmployeeName = sdr["EmployeeId"].ToString();
                i.LaunchDate = sdr["LaunchDate"].ToString();
                i.EndDate = sdr["EndDate"].ToString();
                //i.RunningCost = sdr["RunningCost"].ToString();
                i.Report = sdr["Report"].ToString();

                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;
        }
        //
        public List<MarketingR> GetAllCampaign()
        {
            string query = "SELECT * from campaign";
            List<MarketingR> iList = new List<MarketingR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                MarketingR i = new MarketingR();


                i.CampaignId = Convert.ToInt32( sdr["CampaignId"] );
                i.CampaignName = sdr["CampaignName"].ToString();
                i.Objective = sdr["Objective"].ToString();
                i.Placement = sdr["Placement"].ToString();
                i.EmployeeName = sdr["EmployeeName"].ToString();
                i.LaunchDate = sdr["LaunchDate"].ToString();
                i.EndDate = sdr["EndDate"].ToString();
                i.RunningCost = Convert.ToDouble(sdr["RunningCost"]);
                i.Report = sdr["Report"].ToString();
                i.Budget = Convert.ToDouble( sdr["Budget"] );
                i.Status = sdr["Status"].ToString();
                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;
        }

        public List<MarketingR> GetAllApprovedCampaign()
        {
            string query = "SELECT * from campaign WHERE Status='Approved' ";
            List<MarketingR> iList = new List<MarketingR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                MarketingR i = new MarketingR();

                i.CampaignId = Convert.ToInt32(sdr["CampaignId"]);
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

        public List<MarketingR> GetAllApprovedCampaignAnd()
        {
            string query = "SELECT * from campaign WHERE Status='Approved' and Budget=0";
            List<MarketingR> iList = new List<MarketingR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                MarketingR i = new MarketingR();

                i.CampaignId = Convert.ToInt32(sdr["CampaignId"]);
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
        //
        public List<MarketingR> searchCampaign(string text)
        {
            
            string query = "SELECT * from campaign WHERE  CampaignId  Like '%"
                + text + "%' or CampaignName like '%" + text + "%' or Objective like '%"
                + text + "%' or Placement like '%" + text + "%' or EmployeeName  like '%" + text + "%' or LaunchDate like '%"
                + text + "%' or EndDate  like '%" + text + "%' or RunningCost   like '%" + text + "%' or Report like '%" + text + "%' ";

            List<MarketingR> iList = new List<MarketingR>();
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                MarketingR i = new MarketingR();

                i.CampaignId = Convert.ToInt32( sdr["CampaignId"] );
                i.CampaignName = sdr["CampaignName"].ToString();
                i.Objective = sdr["Objective"].ToString();
                i.Placement = sdr["Placement"].ToString();
                i.EmployeeName = sdr["EmployeeName"].ToString();
                i.LaunchDate = sdr["LaunchDate"].ToString();
                i.EndDate = sdr["EndDate"].ToString();
                //i.RunningCost = sdr["RunningCost"].ToString();
                i.Report = sdr["Report"].ToString();
                i.Status = sdr["Status"].ToString();

                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;

        }
        //FOR approved_campaign Table


        public int countAllCampaigns()
        {
            string query = "SELECT COUNT(*) as campaigns FROM campaign ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                result = Convert.ToInt32(sdr["campaigns"]);

            }
            dc.CloseConnection();
            return result;

        }

        public int countAllApprovedCampaigns(string status)
        {
            string query = "SELECT COUNT(*) as campaigns FROM campaign WHERE Status='"+status+"'  ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                result = Convert.ToInt32(sdr["campaigns"]);

            }
            dc.CloseConnection();
            return result;

        }

        public int countAllApprovedCampaignsAnd(string status)
        {
            string query = "SELECT COUNT(*) as campaigns FROM campaign WHERE Status='" + status + "' and Budget=0 ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                result = Convert.ToInt32(sdr["campaigns"]);

            }
            dc.CloseConnection();
            return result;

        }

    }
}
