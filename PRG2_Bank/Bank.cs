namespace PRG2_Bank
{
    internal class Bank
    {
        public List<BankAccount> AccountsList { get; }

        public Bank()
        {
            AccountsList = new List<BankAccount>();
        }

        public BankAccount CreateAccount(string accountType, string accountNumber, decimal initialBalance, decimal interest, decimal creditLimit)
        {
            BankAccount account = null;

            if (accountType == "sparkonto")
            {
                account = new SavingsAccount(accountNumber, initialBalance, interest);
            }
            else if (accountType == "kreditkonto")
            {
                account = new CreditAccount(accountNumber, initialBalance, interest, creditLimit);
            }
            else
            {
                Console.WriteLine("Ogilitlig kontoslag! Välj mellan sparkonto eller kreditkonto.");
            }

            if (account != null)
            {
                AccountsList.Add(account);
            }

            return account;
        }
    }
}
