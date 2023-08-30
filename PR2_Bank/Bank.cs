using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Bank
{
    internal class Bank
    {
        private List<BankAccount> Accounts { get; }

        public Bank()
        {
            Accounts = new List<BankAccount>();
        }

        public BankAccount CreateAccount(string accountType, string accountNumber, decimal initialBalance, decimal interest)
        {
            BankAccount account = null;

            if (accountType == "sparkonto")
            {
                account = new SavingsAccount(accountNumber, initialBalance, interest);
            }
            else if (accountType == "kreditkonto")
            {
                account = new CreditAccount(accountNumber, initialBalance, interest);
            }
            else
            {
                Console.WriteLine("Ogilitlig kontoslag! Välj mellan sparkonto eller kreditkonto.");
            }

            if (account != null)
            {
                Accounts.Add(account);
            }

            return account;
        }
    }
}
