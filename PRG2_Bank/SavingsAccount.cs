
namespace PRG2_Bank
{
    class SavingsAccount : BankAccount
    {
        private decimal InterestRate { get; }
        public SavingsAccount(string accountNumber, decimal balance, decimal interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            Balance += Balance * InterestRate;
        }
    }
}
