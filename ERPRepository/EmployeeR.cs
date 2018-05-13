using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
   public class EmployeeR
    {
        // EmployeeID,EmployeeName,EGender,EDepartmentName,EPhone,EmployeeEmail,EReportsTo,EStatus)
        //("M102","Omer Sayem","M","Marketing","01865226555","Ramos","Regular");

        private string employeeId;
        private string employeeName;
        private string eGender;
        private string eDepartmentName;
        private string ePhone;
        private string employeeEmail;
        private string eReportsTo;
        private string eStatus;
        private double salary;
        private string ePassword;

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public string EGender
        {
            get { return eGender; }
            set { eGender = value; }
        }
        public string EDepartmentName
        {
            get { return eDepartmentName; }
            set { eDepartmentName = value; }
        }
        public string EPhone
        {
            get { return ePhone; }
            set { ePhone = value; }
        }
        public string EmployeeEmail
        {
            get { return employeeEmail; }
            set { employeeEmail = value; }
        }
        public string EReportsTo
        {
            get { return eReportsTo; }
            set { eReportsTo = value; }
        }
        public string EStatus
        {
            get { return eStatus; }
            set { eStatus = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string EPassword
        {
            get { return ePassword ; }
            set { ePassword = value; }
        }
    }
}
