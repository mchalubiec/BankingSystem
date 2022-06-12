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
            bank.AddUser("Jan", "Kowalski");
            bank.AddUser("Robert", "Wolny");
            bank.AddUser("Piotr", "Szybki");
            bank.ShowListUsers();
            bank.AddAccount(1);
            bank.AddAccount(3);
            bank.ShowListAccounts();
            Console.ReadKey();
        }
    }
}
