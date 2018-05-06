using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
  public class ItRepository
    {
        public List<EmployeeR> GetAllEmployee()
        {
            string query = "SELECT EmployeeId,EmployeeName,EDepartmentName,EStatus,EPassword FROM employee where EPassword='' ";
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
                i.EPassword = sdr["EPassword"].ToString();
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

                string query = "UPDATE employee SET EmployeeId ='"+er.EmployeeId +" ',EPassword ='" +er.EPassword + "' WHERE EmployeeId = '" +er.EmployeeId+ "' ";
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
      //Passwordcheck        
       public int countPass(string s)
        {
            string query = "SELECT COUNT(EPassword) as employee FROM employee where EPassword ='"+s+"' ";
            int result=0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                result = Convert.ToInt32( sdr["employee"] );
                
            }
            dc.CloseConnection();
            return result;

        }
            
        
    }
}
