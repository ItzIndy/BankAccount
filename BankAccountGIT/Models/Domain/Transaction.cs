using System;

namespace BankAccountGIT.Models.Domain
{
    public class Transaction
    {
        #region MyRegion
        public decimal Amount { get; }

        public TransactionType TransactionType { get; }

        public DateTime DateOfTransaction { get; }
        #endregion

        #region Constructor
        public Transaction(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
            DateOfTransaction = DateTime.Now;
        }
        #endregion

        public bool IsWithdraw { get { return TransactionType == TransactionType.Withdraw; } }

        public bool isDesposit { get { return TransactionType == TransactionType.Deposit; } }
    }
}
