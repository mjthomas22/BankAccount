using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        private double balance = 5000;


        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public override void Deposit()
        {
            throw new NotImplementedException();
        }
        
        public override void Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
