using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class BankAccount
    {


        private double balance = 0;
        public double GetBalance() { return this.balance; }    // do not test!
        public bool Deposit(double amount)  // test this
        {
            if (amount < 0)
            {
                return false;
            }

            balance += amount;

            return true; 
        }  
        public bool Withdraw(double amount) // test this
        {
            if (balance < amount || amount < 0)
            {
                return false;
            }
            balance -= amount;

            return true; 
        }  


    }
}
