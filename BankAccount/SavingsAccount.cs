﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        private double balance = 15000;


        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
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
