
using BankAccountGIT.Models.Domain;
using BankingApp.Models.Domain;
using System;
using System.Collections.Generic;

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
            var tranactions = myBA.Transactions;
            foreach (var items in myBA.Transactions)
                Console.WriteLine($"{items.Amount} -- {items.DateOfTransaction} -- {items.TransactionType}");
            Console.ReadKey();

        }
    }
}
