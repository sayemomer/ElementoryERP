using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
   public class InventoryR
    {
        private string productId;
        private string productName;
        private int volume;
        private double price;
        private string store;
        private string category;
        private int tax;

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Store
        {
            get { return store; }
            set { store = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int Tax
        {
            get { return tax; }
            set { tax = value; }
        }
    }
}
