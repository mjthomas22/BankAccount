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
            //instantiating our client and accounts.
            Client oswaldCobblepot = new Client();
            CheckingAccount oswaldChecking = new CheckingAccount();
            SavingsAccount oswaldSavings = new SavingsAccount();

            string firstChoice;
            string secondChoice;
            double deposit;
            double withdraw;

            do
            {
                // Welcome user and give them the menu to make their choices.
                Console.WriteLine("Welcome to Gotham National Bank.");
                Console.WriteLine("Please make a selection from the following menu.\n");
                Console.WriteLine("1. View Client Information\n2. View Account Balance\n3. Deposit Funds\n4. Withdraw Funds\n5. Exit\nPlease enter the number of your choice");
                firstChoice = Console.ReadLine();
                Console.Clear();

                //prints users info
                if (firstChoice == "1")
                {

                    oswaldCobblepot.Info();
                    Console.WriteLine("Press enter when done.");
                    Console.ReadLine();
                    Console.Clear();
                }

                //Shows balances of users accounts
                if (firstChoice == "2")
                {
                    do
                    {

                        Console.WriteLine("1. Checking Account Balance\n2. Savings Account Balance\n3. Back\n4. Exit");
                        secondChoice = Console.ReadLine();
                        Console.Clear();

                        if (secondChoice == "1")
                        {
                            Console.WriteLine("Your checking account balance is :");
                            oswaldChecking.GetBalance();
                        }

                        if (secondChoice == "2")
                        {
                            Console.WriteLine("Your savings account balance is :");
                            oswaldSavings.GetBalance();
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

                //allows user to deposit funds in their account.
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
                            Console.WriteLine("Your new balance is ");
                            oswaldChecking.GetBalance();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();

                        }

                        if (secondChoice == "2")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            deposit = double.Parse(Console.ReadLine());
                            oswaldSavings.Balance = oswaldSavings.Deposit(deposit);
                            Console.WriteLine("Your new balance is ");
                            oswaldSavings.GetBalance();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
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

                //allows user to withdraw money from accounts
                if (firstChoice == "4")
                {
                    do
                    {

                        Console.WriteLine("In which account would you like to make a withdraw?\n1. Checking Account\n2. Savings Account\n3. Back\n4. Exit");
                        secondChoice = Console.ReadLine();
                        Console.Clear();

                        if (secondChoice == "1")
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            withdraw = double.Parse(Console.ReadLine());
                            oswaldChecking.Balance = oswaldChecking.Withdraw(withdraw);
                            Console.WriteLine("Your new balance is ");
                            oswaldChecking.GetBalance();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();

                        }

                        if (secondChoice == "2")
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            withdraw = double.Parse(Console.ReadLine());

                            //Checking to make sure savings account does not go below zero.
                            if (withdraw > oswaldSavings.Balance)
                            {
                                Console.WriteLine("Can not continue this transaction.\nInsuffient Funds.");
                                Console.WriteLine("Press enter to continue.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            oswaldSavings.Balance = oswaldSavings.Withdraw(withdraw);
                            Console.WriteLine("Your new balance is ");
                            oswaldSavings.GetBalance();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
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

            Console.WriteLine("Have a great day!");
        }
    }
}