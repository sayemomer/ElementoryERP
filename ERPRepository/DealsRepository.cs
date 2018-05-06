using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
   public class DealsRepository
    {
        public bool Insert(DealsR i)
        {
            try
            {

                // INSERT INTO(CompanyId,ContactId,DealersName,DealersAddress,DealersPhone,DealersEmail,ParentCompany,IndustryType,AnnualRevenue,CurrencyId,PaymentTerms) 
                //VALUES ("101","y100","Pathao","Banani DOHS","01865226555","uber","ride sharing","1M","taka","one year EMI" );

                string query = " INSERT into deal VALUES (' " + i.CompanyId + " ',' " + i.ContactId + " ', " + i.DealersName + ", " + i.DealersAddress + ", '" + i.DealersPhone + "', '"
                    + i.DealersEmail + "' , " + i.ParentCompany + " , " + i.IndustryType + " , " + i.AnnualRevenue + " , " + i.CurrencyId + " , " + i.PaymentTerms + ") ";
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

        public bool Update(DealsR i)
        {
            try
            {
                // update INTO deal(CompanyId,ContactId,DealersName,DealersAddress,DealersPhone,DealersEmail,ParentCompany,IndustryType,AnnualRevenue,CurrencyId,PaymentTerms) 
                //VALUES ("101","y100","Pathao","Banani DOHS","01865226555","uber","ride sharing","1M","taka","one year EMI" )

                string query = "UPDATE deal SET CompanyId = '" + i.CompanyId + "', ContactId  = '" + i.ContactId + "', DealersName  = '" + i.DealersName + "',DealersAddress = '"
                    + i.DealersAddress + "',DealersPhone   = '" + i.DealersPhone + "', i.DealersEmail  = '" + i.DealersEmail + "',ParentCompany   = '" + i.ParentCompany + "',  IndustryType  = '"
                    + i.IndustryType + "', AnnualRevenue  = '" + i.AnnualRevenue + "', CurrencyId = '" + i.CurrencyId
                    + "', PaymentTerms = '" + i.PaymentTerms + "'  WHERE CompanyId = " + i.CompanyId + " ";
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
        public bool Delete(string CompanyId)
        {
            try
            {
                string query = "DELETE From deal WHERE CompanyId ='" + CompanyId + "'";
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
        public DealsR GetDealerCompany(string CompanyId)
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
        //allget
        public List<DealsR> GetAllDealerCompany()
        {
            string query = "SELECT * from deal";
            List<DealsR> iList = new List<DealsR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                DealsR i = new DealsR();

                i.CompanyId = sdr["CompanyId"].ToString();
                i.ContactId = sdr["ContactId"].ToString();
                i.DealersName = sdr["DealersName"].ToString();
                i.DealersAddress = sdr["DealersAddress"].ToString();
                i.DealersPhone = sdr["DealersPhone"].ToString();
                i.DealersEmail = sdr["DealersEmail"].ToString();
                i.ParentCompany = sdr["ParentCompany"].ToString();
                i.IndustryType = sdr["IndustryType"].ToString();
                i.AnnualRevenue = sdr["AnnualRevenue"].ToString();
                i.CurrencyId = sdr["CurrencyId"].ToString();
                i.PaymentTerms = sdr["PaymentTerms"].ToString();

                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;
        }

        //search
        public List<DealsR> searchInventory(string text)
        {
            string query = "SELECT * from deal WHERE CompanyId  like '%" + text + "%' or ContactId like '%"
                + text + "%' or DealersName like '%" + text + "%' or DealersAddress like '%" + text + "%' or DealersPhone like '%"
                + text + "%' or DealersEmail like '%" + text + "%' or  ParentCompany like '%" + text + "%' or IndustryType like '%"
                + text + "%' or AnnualRevenue  like '%" + text + "%' or CurrencyId  like '%"
                + text + "%'or CurrencyId  like '%" + text + "%'or PaymentTerms  like '%" + text + "%' ";
            List<DealsR> iList = new List<DealsR>();
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                DealsR i = new DealsR();

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


                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;

        }
    }
}
