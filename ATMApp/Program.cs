using ATMLib;
using BankLib;
using System;
using System.Linq;

namespace ATMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("bank");
            bank.Users.Add(new User("Jan", "Kowalski", new Account("123456789", 0.0m, new Card(12345, 1234), bank.)));
            ATM atm = new ATM();
            atm.SignIn();
            atm.Logout();
            atm.Logout();
            atm.SignIn();
            atm.SignIn();
            Console.ReadKey();
        }
    }
}
