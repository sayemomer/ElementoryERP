using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
   public class AccountingR
    {
       private string date;
       private double money;
       private double currentAmount;

       public string Date
       {
           get { return date; }
           set { this.date = value; }
       }

       public double Money
       {
           get { return money; }
           set { this.money = value; }
       }

       public double CurrentAmmount
       {
           get { return currentAmount; }
           set { this.currentAmount = value; }
       }

      
    }
}
