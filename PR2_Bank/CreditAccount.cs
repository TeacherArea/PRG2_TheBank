using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Bank
{
    class CreditAccount : BankAccount
    {
        private decimal CreditLimit { get; }

        public CreditAccount(string accountNumber, decimal balance, decimal creditLimit)
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
                Console.WriteLine("Otillräckliga medel på kontot!");
            }
        }
    }
}
