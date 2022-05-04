using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BankAccount account = new BankAccount();
            // account Deposit += 5.00m;
            account.Deposit(5.00);
           var newBalance= account.GetBalance();
            Console.WriteLine(newBalance);
            account.Deposit(10.00);
            Console.WriteLine(account.GetBalance());
            Console.WriteLine($"Enter amount you would like to deposit.");
            var answer = double.Parse(Console.ReadLine());
            account.Deposit(answer);
            Console.WriteLine(account.GetBalance());
           
                
            
        }
    }
}
