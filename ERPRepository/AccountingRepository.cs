using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
   public  class AccountingRepository : IAccountingRepository
    {
        public bool Insert(AccountingR i)
        {
            try
            {

                string query = " INSERT into Banking  VALUES ('"+i.Date+"', "+i.Money+" ,"+i.CurrentAmmount+") ";
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

        public bool Update(AccountingR i)
        {
            try
            {
             
                string query = "UPDATE Banking SET Date = '"+i.Date+"', Ammount="+i.Money+ "WHERE Date= '"+i.Date+"' ";
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


        //delete
       public bool Delete(string date)
        {
            try
            {
                string query = "DELETE From Banking WHERE Date ='"+date+"' ";
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
        //getProduct
       /* public DealsR GetDealerCompany(string CompanyId)
        {
            string query = "SELECT * from deal WHERE CompanyId = '" + CompanyId + "'";
            DealsR i = null;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                //(CompanyId,ContactId,DealersName,DealersAddress,DealersPhone,DealersEmail,ParentCompany,IndustryType,AnnualRevenue,CurrencyId,PaymentTerms) 
                i = new DealsR();
                i.CompanyId = sdr["CompanyId"].ToString();
                i.ContactId = sdr["ContactId"].ToString();
                i.DealersName = sdr["DealersName"].ToString();
                i.DealersAddress = sdr["DealersAddress "].ToString();
                i.DealersPhone = sdr["DealersPhone "].ToString();
                i.DealersEmail = sdr["DealersEmail"].ToString();
                i.ParentCompany = sdr["ParentCompany"].ToString();
                i.IndustryType = sdr["IndustryType"].ToString();
                i.AnnualRevenue = sdr["AnnualRevenue"].ToString();
                i.CurrencyId = sdr["CurrencyId"].ToString();
                i.PaymentTerms = sdr["PaymentTerms"].ToString();

            }
            dc.CloseConnection();
            return i;
        }
        //allget*/
        public List<AccountingR> GetAllTransiction()
        {
            string query = "SELECT * from Banking";
            List<AccountingR> iList = new List<AccountingR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                AccountingR i = new AccountingR();

                i.Date = sdr["Date"].ToString();
                i.Money = Convert.ToDouble( sdr["Ammount"] );
                i.CurrentAmmount = Convert.ToDouble(sdr["CurrentAmount"]);
               
                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;
        }

        public double countTotalCash()
        {
            string query = "SELECT TOP 1 CurrentAmount FROM Banking ORDER BY TransitionId DESC";
            double result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                if (sdr["CurrentAmount"] == DBNull.Value)
                {
                    return result;
                }
                else
                {
                    result = Convert.ToInt32(sdr["CurrentAmount"]);
                }
                
            }
            dc.CloseConnection();
            return result;

        }

        public bool updateBalance(double amount  )
        {
            double currentBalance = this.countTotalCash();

            

            if (amount <= currentBalance)
            {
                double updatedBalance = currentBalance - amount;

                try
                {
                    string query = "UPDATE Banking SET CurrentAmount ="+updatedBalance+" WHERE TransitionId=(SELECT TOP 1 TransitionId FROM Banking ORDER BY TransitionId DESC)";
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

        public double GetCurrentAmmount()
        {
            string query = "SELECT TOP 1 CurrentAmount FROM Banking ORDER BY TransitionId DESC";
            double result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                if (sdr["CurrentAmount"] == DBNull.Value)
                {
                    return result;
                }
                else
                {
                    result = Convert.ToInt32(sdr["CurrentAmount"]);
                }

            }
            dc.CloseConnection();
            return result;

        }

        //search
        public List<AccountingR> searchTransiction(string text)
        {
            string query = "SELECT * from Banking WHERE Date  like '%" + text + "%' ";
            List<AccountingR> iList = new List<AccountingR>();
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                AccountingR i = new AccountingR();

                i.Date = sdr["Date"].ToString();
                i.Money = Convert.ToDouble(sdr["Ammount"]);

                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;

        }
    }
}
