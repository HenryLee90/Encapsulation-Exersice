using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a new Console Application in your repos folder---done
//name it BankEncapsulation---done
//Create a new public class named BankAccount---done
//In your BankAccount class, create the following:
//A private field of type double named balance with a value of 0----done
//Define a method named Deposit that will accept a double and store that value in the balance field-----done
//Define a method named GetBalance that will return the amount stored in the balance field---done
//In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.---Done
//Once finished save, commit, and push back to Github

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
        public void  Deposit(double money)
        {
            balance += money;
            
        }
        public double GetBalance()
        {
            return balance;  

            
        }

    }   
}   
