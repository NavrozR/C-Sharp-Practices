using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    class Program
    {

        Double Balance = 0;
        Double Deposit;
        Double Transfer;
        
        public void Welcome() 
        {

            Console.WriteLine("Welcome to the Bank Sheetal");
        
        }

        public void DepositMethod()
        {
            
            Console.WriteLine("Please enter the amount you want to deposit");
            Console.WriteLine("Current balance is :" + Balance);
            Deposit = Convert.ToInt32(Console.ReadLine());
            Balance = Balance + Deposit;
            Console.WriteLine("Balance is equal to :" + Balance);
            
        }

        public void BalanceCalculation() 
        {

            Console.WriteLine("Please enter the amount you want to Transfer");
            Transfer = Convert.ToInt32(Console.ReadLine());

            if (Balance < Transfer)

            {
                Console.WriteLine("Insufficient Balance");
            }

            else 
            {

                Balance = Balance - Transfer;
                Console.WriteLine("Balance is equal to : " + Balance);

            }

                  
                       
        }

        static public void Main(string[] args)
        {
            Program X1 = new Program();
            X1.Welcome();
            X1.DepositMethod();
            X1.BalanceCalculation();
            
        }

  
    }
}
