using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        protected string name = "Oswald Cobblepot";
        protected string address = "2531 Adams ST, Gotham City, New Jersey 51335";
        protected int accountNumber = 548321;

        public string Name
        {
            get { return this.name; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public Client()
        {

        }

        public Client(string name, string address, int accountNumber)
        {
            this.name = name;
            this.address = address;
            this.accountNumber = accountNumber;

        }
        // 1 method
        public void Info()
        {
            Console.WriteLine("Name : {0}\nAddres : {1}\nAccount Number : {2}\n", name, address, accountNumber);
        }
        // Client information should be filled in here
    }
}
