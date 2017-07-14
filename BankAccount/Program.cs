using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Client oswaldCobblepot = new Client();
            CheckingAccount oswaldChecking = new CheckingAccount();
            SavingsAccount oswaldSavings = new SavingsAccount();
            string firstChoice;
            string secondChoice;
            double deposit;

            do
            {

                //You will be designing a console application to manage a client’s bank account.
                //For now, the application will have only one client that is hard - coded into the system.
                //The client has one checking account and one savings account.
                Console.WriteLine("Welcome to Gotham National Bank");
                //Menu Items
                Console.WriteLine("Please make a selection from the following menu.\n");
                Console.WriteLine("1. View Client Information\n2. View Account Balance\n3. Deposit Funds\n4. Withdraw Funds\n5. Exit\nPlease enter the number of your choice");
                firstChoice = Console.ReadLine();
                Console.Clear();


                if (firstChoice == "1")
                {

                    oswaldCobblepot.Info();
                    Console.WriteLine("Press enter when done");
                    Console.ReadLine();
                    Console.Clear();
                }


                if (firstChoice == "2")
                {
                    do
                    {

                        Console.WriteLine("1. Checking Account Balance\n2. Savings Account Balance\n3. Back\n4. Exit");
                        secondChoice = Console.ReadLine();
                        Console.Clear();

                        if (secondChoice == "1")
                        {
                            Console.WriteLine("Your checking account balance is {0}", oswaldChecking.Balance);
                        }

                        if (secondChoice == "2")
                        {
                            Console.WriteLine("Your savings account balance is {0}", oswaldSavings.Balance);
                        }

                        if (secondChoice == "3")
                        {
                            break;
                        }

                        if (secondChoice == "4")
                        {
                            firstChoice = "5";
                            break;
                        }

                    } while (secondChoice != "1" || secondChoice != "2" || secondChoice != "3" || secondChoice != "4");
                }


                if (firstChoice == "3")
                {
                    do
                    {

                        Console.WriteLine("In which account would you like to make a deposit?\n1. Checking Account\n2. Savings Account\n3. Back\n4. Exit");
                        secondChoice = Console.ReadLine();
                        Console.Clear();

                        if (secondChoice == "1")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            deposit = double.Parse(Console.ReadLine());
                            oswaldChecking.Balance = oswaldChecking.Deposit(deposit);
                            Console.WriteLine("Your new balance is {0}", oswaldChecking.Balance);


                        }

                        if (secondChoice == "2")
                        {
                            Console.WriteLine("Your savings account balance is {0}", oswaldSavings.Balance);
                        }

                        if (secondChoice == "3")
                        {
                            break;
                        }

                        if (secondChoice == "4")
                        {
                            firstChoice = "5";
                            break;
                        }

                    } while (secondChoice != "1" || secondChoice != "2" || secondChoice != "3" || secondChoice != "4");

                }





            } while (firstChoice != "5");



            //You must include a functional menu that includes the following choices for the user.
            //- [ ] View Client Information
            //- [ ] View Account Balance
            //  - [ ] Checking Account Balance
            //  - [ ] Savings Account Balance
            //- [ ] Deposit Funds
            //  - [ ] To Checking Account
            //  - [ ] To Savings Account
            //- [ ] Withdraw Funds
            //  - [ ] From Checking Account
            //  - [ ] From Savings Account
            //- [ ] Exit
            //The menu should display the options as shown in the Details section below.
            //In the menu, after a user selects either View Balance, Deposit, or Withdraw, the program should then give the option of selecting which account.
            //Required Classes

            // Client Class
            // 3 properties
            // 1 constructor
            // 1 method
            // Client information should be filled in here
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
            // Program Class
            // Must instantiate one client object
            // Must instantiate one checking account object
            // Must instantiate one savings account object
            // All menu options listed above must have functionality behind them
            // Program should run until user selects 'Exit'
            //Other Tasks

            // After each transaction, the current balance should be displayed on the screen.
            // Your program should include:
            // 1 abstract method(at least)
            // 1 virtual method(at least)
            // 1 override method(at least)
            //Details

            //When a user launches the program the following menu should be displayed to the screen.

            //1. View Client Information
            //2. View Account Balance
            //3. Deposit Funds
            //4. Withdraw Funds
            //5. Exit
            //If the user wants to view account balance, deposit funds, or withdraw money, the user should be prompted to select which account.

            //1. View Client Information
            //2. View Account Balance
            //3. Deposit Funds
            //4. Withdraw Funds
            //5. Exit

            //2

            //a.Checking Account
            //b.Savings Account
            //Be sure the user can continue making selections from the menu until all desired transactions have been completed.

            //Stretch Tasks

            //Right now this program is designed for one user. Giving the ability to enter a user name when the program begins would make the program useful for multiple users. At this point do not worry about trying to add passwords.That is outside of the scope of what we know at this point.Letting the users log in with only their names is less secure, but we're focused on functionality right now.

            //Hints

            //Persistence is not required. Meaning each time you run the program all of the values can reset.

            //You can choose any starting balance to begin the program.

            //Think about what data type should be used for dealing with money.


        }
    }
}