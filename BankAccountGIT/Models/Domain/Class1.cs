using System;

namespace BankingApp.Models.Domain
{
    public class BankAccount
    {
        private decimal _balance;

        #region Properties.
        public const decimal WithdrawCost = 0.10M; //Hier plak je de M achter het getal, want het is een double maar je toont zo aan de compiler dat het eigelijk een decimal is.
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
        #endregion 
        #region Constructors
        public BankAccount(string accountNumber)         //Constructor 1

        {
            AccountNumber = accountNumber;
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
        }

        public void Withdraw(decimal value)
        {
            Balance -= value + WithdrawCost;
        }
        #endregion


    }
}
