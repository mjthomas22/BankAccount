using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        protected string name;
        protected string address;
        protected int accountNumber;
        Random randomNumber = new Random();
        public string Name
        { get; }

        public string Address
        { get; set; }

        public int AccountNumber
        { get; }

        public Client()
        {

        }

        public Client(string name, string address)
        {
            this.name = name;
            this.address = address;
            accountNumber = randomNumber.Next(100000, 999999);
        }
        // 1 method
        
        // Client information should be filled in here
    }
}
