using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_Bank
{
    class CreditAccount : BankAccount
    {
        private decimal CreditLimit { get; }

        public CreditAccount(string accountNumber, decimal balance, decimal interest, decimal creditLimit)
            : base(accountNumber, balance)
        {
            CreditLimit = creditLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance + CreditLimit >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Otillräckliga medel på kreditkontot!");
            }
        }
    }
}
