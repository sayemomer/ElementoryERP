using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
   public class OrderR
    {
       // INSERT INTO order(OrderID,ProductId,ProductName,Quantity,Address,EmployeeID) VALUES ("y120","y180",y180,10,"basundhora","S101");
        protected string orderId;
        private string productId;
        private string productName;
        private int quantity;
        private string address;
        private string employeeName;
        private int available;
        private string status;
        private string catagory;
        

        public string OrderId
        {
            get { return orderId; }
            set { this.orderId = value; }
        }

        public string ProductId
        {
            get { return productId; }
            set { this.productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { this.productName = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { this.quantity = value; }
        }

        public string Address
        {
            get { return address; }
            set { this.address = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { this.employeeName = value; }
        }

        public int Available
        {
            get { return available; }
            set { this.available = value; }
        }

        public string Status        
        {
            get { return status; }
            set { this.status = value; }
        }

        public string Catagory
        {
            get { return catagory; }
            set { this.catagory = value; }
        }

    }
}
