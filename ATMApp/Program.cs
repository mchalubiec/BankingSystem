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
            Bank bank = new Bank();
            bank.AddUser("Jan", "Kowalski");
            bank.AddUser("Robert", "Wolny");
            bank.AddUser("Piotr", "Szybki");
            bank.ShowListUsers();
            bank.ShowListUserAccounts();
            //bank.ShowListUserCards();
            Console.ReadKey();
        }
    }
}
