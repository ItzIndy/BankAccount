using BankingApp.Models.Domain;

namespace BankAccountGIT.Models.Domain
{
    public class SavingsAccount : BankAccount
    {
        private const decimal WithdrawCost = 0.10M;
        public decimal InterestRate { get; private set; }

        public SavingsAccount(string accountNumber, decimal interestRate) : base(accountNumber)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(WithdrawCost);
        }

        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }
    }
}
