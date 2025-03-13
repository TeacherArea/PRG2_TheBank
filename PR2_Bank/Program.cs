using PR2_Bank;
using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        BankAccount savingsAccount = bank.CreateAccount("sparkonto", "SA001", 1000, 0.1m);
        BankAccount creditAccount = bank.CreateAccount("kreditkonto", "CA001", 500, 1000);

        bank.Accounts.Add(savingsAccount); // glöm inte lägga till kontona i listan
        
        savingsAccount.Deposit(500);
        ((SavingsAccount)savingsAccount).ApplyInterest();
        Console.WriteLine("Sparkonto kontoutdrag: " + savingsAccount.GetBalance());

        creditAccount.Withdraw(800);
        Console.WriteLine("Kreditkonto kontoutdrag: " + creditAccount.GetBalance());
    }
}
