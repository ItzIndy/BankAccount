
using BankAccountGIT.Models.Domain;
using BankingApp.Models.Domain;
using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {


            BankAccount myBA = new BankAccount("6307835468", 50);
            Console.WriteLine($"{myBA}");
            myBA.Deposit(200);
            Console.WriteLine($"{myBA}");
            myBA.Withdraw(200);
            Console.WriteLine($"{myBA}");
            Console.WriteLine($"Accountnumber = {myBA.AccountNumber} and Balance = {myBA.Balance}");
            Console.WriteLine($"Withdrawcost is {BankAccount.WithdrawCost}");
            var tranactions = myBA.Transactions;
            foreach (var items in myBA.Transactions)
                Console.WriteLine($"{items.Amount} -- {items.DateOfTransaction} -- {items.TransactionType}");

            SavingsAccount mySA = new SavingsAccount("123-1231231-67", 0.1M);
            mySA.Deposit(1000);
            mySA.AddInterest();
            mySA.Withdraw(10);
            Console.WriteLine($"Balance of savingsAccount: {mySA.Balance}");
            foreach (var item in mySA.Transactions)
                Console.WriteLine($"{item.Amount} -- {item.DateOfTransaction} -- {item.TransactionType}");


            Console.ReadKey();

        }
    }
}
