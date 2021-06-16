using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_Acc1 ob1 = new Bank_Acc1();
            ob1.Account_Number = 12345678;
            Console.WriteLine("Account Holder Number : " + ob1.Account_Number);
            AccHolderName obj = new AccHolderName();
            Console.WriteLine("Account Holder Name1 : " + obj.myList[0]);
            Console.WriteLine("Account Holder Name2 : " + obj.myList[1]);
            ob1.Acc_opening_date = "08/11/2020";
            Console.WriteLine("Account Opening Date : " + ob1.Acc_opening_date);
            
            
            for (int i = 1; i <=10; i++)
            {

                Console.WriteLine("User can select the options, Press:1 for Savings Account, Press:2 for Checking Account");
                int option = Convert.ToInt32(Console.ReadLine());
                
                // For Savings Account

                if (option == 1)
                {
                    Console.WriteLine("Enter the amount to withdraw from Saving  Account: ");
                    Savings_Acc ob2 = new Savings_Acc();
                    int Amt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Transaction of Debited Amount: "+ ob2.Debit(Amt));
                    double trans =  ob2.Debit(Amt);
                    ob1.TransactionList.Add(trans);
                }

            
                else if (option == 2)
                {
                
                    //For Checking Account

                  Console.WriteLine("Enter the amount to withdraw from Checking Account : ");
                  Checking_Acc ob3 = new Checking_Acc();
                  int Amt = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Transaction of Debited Amount : " + ob3.Debit(Amt));
                  double trans = ob3.Debit(Amt);
                  ob1.TransactionList.Add(trans);
                }

            }
                  for (int j = 5; j < 10; j++)
                  {
                    Console.WriteLine(j+ "th" + "Transaction amout : " + ob1.TransactionList[j]);
                  }

        }
    }
}


 
