using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        public abstract double Withdraw(double withdraw);

        public abstract double Deposit(double deposit);
        
        public virtual void GetBalance()
        {

        }

    }
}
