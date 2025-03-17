using PRG2_Bank;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        BankAccount savingsAccount = bank.CreateAccount("sparkonto", "SA001", 1000, 0.1m, 20000000);
        BankAccount creditAccount = bank.CreateAccount("kreditkonto", "CA001", 500, 16.30m, 1000);        bank.AccountsList.Add(savingsAccount); // glöm inte lägga till konton i listan
        
        savingsAccount.Deposit(500);
        ((SavingsAccount)savingsAccount).ApplyInterest();
        Console.WriteLine("Sparkonto kontoutdrag: " + savingsAccount.GetBalance());

        creditAccount.Withdraw(2800);
        Console.WriteLine("Kreditkonto kontoutdrag: " + creditAccount.GetBalance());
    }
}
