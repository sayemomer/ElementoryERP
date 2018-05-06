using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
   public class EmployeeRepository : IEmployeeRepository
    {
       public bool Insert(EmployeeR er)
       {
           try
           {
               // INSERT INTO employee(EmployeeId,EmployeeName,EGender,EDepartmentName,EPhone,EmployeeEmail,EReportsTo,EStatus) 
               //VALUES ("M102","Omer Sayem","M","Marketing","01865226555","Ramos","Regular");

               string query = " INSERT into employee VALUES ('"+er.EmployeeId+"','" + er.EmployeeName + "', '" + er.EGender + "', '" + er.EDepartmentName + "' , '" + er.EPhone + "', '" + er.EmployeeEmail + "', '" + er.EReportsTo + "', '" + er.EStatus + "'," + er.Salary + ",'"+ er.EPassword+"') ";
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

       public bool Update(EmployeeR er)
       {
           try
           {
               // UPDATE employee SET DepartmentName="sales" WHERE id="M102";

               string query = "UPDATE employee SET EmployeeId = '"+ er.EmployeeId + " ',EmployeeName = ' " + er.EmployeeName + " ',EGender= '" + er.EGender + "',EDepartmentName= '" + er.EDepartmentName + "' ,EPhone= '" + er.EPhone + "',EmployeeEmail= '" + er.EmployeeEmail + "',EReportsTo = '" + er.EReportsTo + "',EStatus = '" + er.EStatus + "',Salary =" + er.Salary + ",EPassword='" + er.EPassword + "' WHERE EmployeeId = '"+er.EmployeeId + "' ";
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

       public bool Delete(string EmployeeId)
       {
           try
           {
               //DELETE FROM employee Whare EmployeeID="M102"
               string query = "DELETE From employee WHERE EmployeeId ='" + EmployeeId + "'";
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

       public List<EmployeeR> GetEmployee(string EDepartmentName)
       {
           string query = "SELECT * from employee WHERE EDepartmentName = '" + EDepartmentName + "'";
           List<EmployeeR> iList = new List<EmployeeR>();
           DatabaseConnection dc = new DatabaseConnection();
           dc.ConnectWithDB();
           SqlDataReader sdr = dc.GetData(query);

           while (sdr.Read())
           {
               EmployeeR i = new EmployeeR();

               i.EmployeeId = sdr["EmployeeId"].ToString();
               i.EmployeeName = sdr["EmployeeName"].ToString();
               i.EGender = sdr["EGender"].ToString();
               i.EDepartmentName = sdr["EDepartmentName"].ToString();
               i.EPhone = sdr["EPhone"].ToString();
               i.EmployeeEmail = sdr["EmployeeEmail"].ToString();
               i.EReportsTo = sdr["EReportsTo"].ToString();
               i.EStatus = sdr["EStatus"].ToString();
               i.Salary = Convert.ToInt32(sdr["Salary"]);
               i.EPassword = sdr["EPassword"].ToString();
               iList.Add(i);
           }
           dc.CloseConnection();
           return iList;
       }


        public List<EmployeeR> GetAllEmployee()
        {
            string query = "SELECT * from employee";
            List<EmployeeR> iList = new List<EmployeeR>();

            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                EmployeeR i = new EmployeeR();

                i.EmployeeId = sdr["EmployeeId"].ToString();
                i.EmployeeName = sdr["EmployeeName"].ToString();
                i.EGender = sdr["EGender"].ToString();
                i.EDepartmentName = sdr["EDepartmentName"].ToString();
                i.EPhone = sdr["EPhone"].ToString();
                i.EmployeeEmail = sdr["EmployeeEmail"].ToString();
                i.EReportsTo = sdr["EReportsTo"].ToString();
                i.EStatus = sdr["EStatus"].ToString();
                i.Salary =Convert.ToInt32( sdr["Salary"] );
                i.EPassword =sdr["EPassword"].ToString();
                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;
        }

        public List<EmployeeR> searchEmployee(string text)
        {
            string query = "SELECT * from employee WHERE  EmployeeId  Like '%"
                + text + "%' or EmployeeName like '%" + text + "%' or EGender like '%"
                + text + "%' or EDepartmentName like '%" + text + "%' or EPhone  like '%" + text + "%' or EmployeeEmail like '%"
                + text + "%' or EReportsTo  like '%" + text + "%' or EStatus   like '%" + text + "%'";
            List<EmployeeR> iList = new List<EmployeeR>();
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            while (sdr.Read())
            {
                EmployeeR i = new EmployeeR();

                i.EmployeeId = sdr["EmployeeId"].ToString();
                i.EmployeeName = sdr["EmployeeName"].ToString();
                i.EGender = sdr["EGender"].ToString();
                i.EDepartmentName = sdr["EDepartmentName"].ToString();
                i.EPhone = sdr["EPhone"].ToString();
                i.EmployeeEmail = sdr["EmployeeEmail"].ToString();
                i.EReportsTo = sdr["EReportsTo"].ToString();
                i.EStatus = sdr["EStatus"].ToString();
                i.Salary= Convert.ToInt32(sdr["Salary"]);

                iList.Add(i);
            }
            dc.CloseConnection();
            return iList;

        }


        public int countEmployee( string department)
        {
            string query = "SELECT COUNT(EDepartmentName) as employee FROM employee where EDepartmentName='" + department + "' ";
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

        public int countAllEmployee()
        {
            string query = "SELECT COUNT(*) as employee FROM employee ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                result = Convert.ToInt32(sdr["employee"]);

            }
            dc.CloseConnection();
            return result;

        }

        public int countAllEmployeeAnd()
        {
            string query = "SELECT COUNT(*) as employee FROM employee WHERE Salary=0 ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                result = Convert.ToInt32(sdr["employee"]);

            }
            dc.CloseConnection();
            return result;

        }

        public int countAllStatus(string text)
        {
            string query = "SELECT COUNT(*) as employee FROM employee where EStatus='"+text+"' ";
            int result = 0;
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);

            if (sdr.Read())
            {
                result = Convert.ToInt32(sdr["employee"]);

            }
            dc.CloseConnection();
            return result;

        }
       //validation
        public bool UserLoginValidation(EmployeeR emp)
        {
            string query = "SELECT * from employee WHERE EPassword='"+emp.EPassword+"' AND EmployeeId='"+emp.EmployeeId+"' ";
            DatabaseConnection dc = new DatabaseConnection();
            dc.ConnectWithDB();
            SqlDataReader sdr = dc.GetData(query);
          
            if (sdr.Read())
            {
                dc.CloseConnection();
                return true;
            }
            else
            {
                dc.CloseConnection();
                return false;
            }
        }
        
        
    }
}
