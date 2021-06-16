using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank_Acc1
    {

        public double Account_Number { get; set; }
        public string Acc_opening_date { get; set; }
        public double Balance_Ammount { get; set; }
        public double Credit { get; set; }

        public List<double> TransactionList = new List<double>();


        public virtual double Debit(double Withdraw_Amt)
        {

            return Withdraw_Amt;

        }
    }


        public class AccHolderName
        {
            public List<string> myList = new List<string>() { "Megha", "Hiremath" };
        }



        public class Savings_Acc : Bank_Acc1
        {
          public override double Debit(double Withdraw_Amt)
          {
            
            return  Withdraw_Amt + (Withdraw_Amt * 0.1);
            
            
          }
        }

        public class Checking_Acc : Bank_Acc1
        {
          public override double Debit(double Withdraw_Amt)
          {
            
            return Withdraw_Amt + (Withdraw_Amt * 0.25);


          }
            
        }
    
}

