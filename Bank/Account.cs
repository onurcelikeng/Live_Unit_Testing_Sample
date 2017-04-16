using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public sealed class Account
    {
        private string AccountName;
        private double Balance;


        public Account(string accountName, double balance)
        {
            this.AccountName = accountName;
            this.Balance = balance;
        }


        public double getBalance
        {
            get { return Balance; }
        }

        public void WithDraw(double amount)
        {
            if (Balance >= amount)
                Balance -= amount;
        }
    }
}