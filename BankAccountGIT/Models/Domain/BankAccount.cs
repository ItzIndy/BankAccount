using BankAccountGIT.Models.Domain;
using System;
using System.Collections.Generic;

namespace BankingApp.Models.Domain
{
    public class BankAccount
    {

        #region Properties en fields.
        public const decimal WithdrawCost = 0.10M; //Hier plak je de M achter het getal, want het is een double maar je toont zo aan de compiler dat het eigelijk een decimal is.
        private decimal _balance;
        private ICollection<Transaction> _transactions;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("No negatve balance");
                _balance = value;
            }
        }

        public string AccountNumber { get; set; }//automatic property

        public IEnumerable<Transaction> Transactions { get { return _transactions; } }
        #endregion 

        #region Constructors
        public BankAccount(string accountNumber)         //Constructor 1

        {
            AccountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }

        //Constructor 2
        // Je roept de vorige constructor op om accountNumber te initialiseren.
        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }

        public BankAccount()
        {

        }
        #endregion
        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount + WithdrawCost;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));

        }
        #endregion


    }
}
