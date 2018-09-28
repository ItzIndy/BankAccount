
using BankingApp.Models.Domain;
using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount anotherBA = new BankAccount()
            {
                AccountNumber = "123-123456789-99",
                Balance = 200
            };

            BankAccount myBA = new BankAccount("6307835468", 50);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Deposit(200);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Withdraw(200);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            Console.WriteLine($"Accountnumber = {myBA.AccountNumber} and Balance = {myBA.Balance}");
            Console.WriteLine($"Withdrawcost is {BankAccount.WithdrawCost}");
            Console.ReadKey();

        }
    }
}
