using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
   public class DealsR
    {
        //INSERT INTO deal(CompanyID,ContactID,Name,Address,Phone,Email,ParentCompany,IndustryType,AnnualRevenue,CurrencyID,PaymentTerms) VALUES ("101","y100","Pathao","Banani DOHS","01865226555","uber","ride sharing","1M","taka","one year EMI" );


        private string companyId;
        private string contactId;
        private string dealersName;
        private string dealerAddress;
        private string dealerPhone;
        private string dealerEmail;
        private string parentCompany;
        private string industryType;
        private string annualRevenue;
        private string currencyId;
        private string paymentTerms;

        public string CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }
        public string ContactId
        {
            get { return contactId; }
            set { contactId = value; }
        }
        public string DealersName
        {
            get { return dealersName; }
            set { dealersName = value; }
        }
        public string DealersAddress
        {
            get { return dealerAddress; }
            set { dealerAddress = value; }
        }
        public string DealersPhone
        {
            get { return dealerPhone; }
            set { dealerPhone = value; }
        }
        public string DealersEmail
        {
            get { return dealerEmail; }
            set { dealerEmail = value; }
        }
        public string ParentCompany
        {
            get { return parentCompany; }
            set { parentCompany = value; }
        }
        public string IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }
        public string AnnualRevenue
        {
            get { return annualRevenue; }
            set { annualRevenue = value; }
        }
        public string CurrencyId
        {
            get { return currencyId; }
            set { currencyId = value; }
        }
        public string PaymentTerms
        {
            get { return paymentTerms; }
            set { paymentTerms = value; }
        }


    }
}
