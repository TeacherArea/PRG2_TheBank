﻿using PR2_Bank;
using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        // Skapa ett lämpligt användargränssitt som gör att en användare kan mata in värden iställer för att ha statiska värden.
        BankAccount savingsAccount = bank.CreateAccount("savings", "SA001", 1000, 0.1m);
        BankAccount creditAccount = bank.CreateAccount("credit", "CA001", 500, 1000);

        // Skapa ett lämpligt användargränssitt för att visa värdena
        savingsAccount.Deposit(500);
        ((SavingsAccount)savingsAccount).ApplyInterest();
        Console.WriteLine("Savings Account Balance: " + savingsAccount.GetBalance());

        creditAccount.Withdraw(800);
        Console.WriteLine("Credit Account Balance: " + creditAccount.GetBalance());
    }
}
