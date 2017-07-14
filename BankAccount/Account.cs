using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        public abstract void Withdraw();

        public abstract void Deposit();

       

       
        // Accounts(ALL Accounts should include the following)
        // An account number
        // Balance
        // An account type(savings or checking)
        // A way to view the current balance
        // User must be able to deposit money into either account
        // User must be able to withdraw money from either account
        // Make sure to include the following Classes
        // Account Class(base)
        // Checking Account Class(derived)
        // 1 constructor
        // Savings Account Class(derived)
        //Note: Savings Account must include a minimum balance.User cannot withdraw money if balance will drop below minimum.
        // 1 property
        // 1 constructor

    }
}
