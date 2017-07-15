using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        private string accountType = "Savings";
        private double balance = 15000;
        private int accountNumber = 568215;

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }


        public SavingsAccount()
        {
                
        }
        public SavingsAccount(double balance,int accountNumber)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;
        }


        public override double Deposit(double deposit)
        {
            return deposit += Balance;
        }
        public override double Withdraw(double withdraw)
        {
            return Balance -= withdraw;
        }
    }
}
