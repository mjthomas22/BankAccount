using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {

        private string accountType = "Checking";
        private double balance = 5000;
        private int accountNumber = 548321;


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


        public CheckingAccount()
        {

        }
        public CheckingAccount(double balance, int accountNumber)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;
        }


        //Methods to deposit/withdraw and get balance
        public override double Deposit(double deposit)
        {
           return deposit += Balance;
        }

        public override double Withdraw(double withdraw)
        {
            return Balance -= withdraw;
        }
        public override void GetBalance()
        {
            Console.WriteLine(balance.ToString("C"));
        }
    }
}
