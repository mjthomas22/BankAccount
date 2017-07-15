using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        private string name = "Oswald Cobblepot";
        private string address = "2531 Adams ST, Gotham City, New Jersey 51335";
        private int checkingAccountNumber = 548321;
        private int savingsAccountNumber = 568215;
        public string Name
        {
            get { return this.name; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public int CheckingAccountNumber
        {
            get { return this.checkingAccountNumber; }
        }

        public int SavingsAccountNumber
        {
            get { return this.savingsAccountNumber; }
        }
        public Client()
        {

        }

        public Client(string name, string address)
        {
            this.name = name;
            this.address = address;
            

        }
        // 1 method
        public void Info()
        {
            Console.WriteLine("Name : {0}\nAddres : {1}\n", name, address );
        }
        // Client information should be filled in here
    }
}
