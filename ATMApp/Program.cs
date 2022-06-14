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
            bank.AddUser(1, "Jan", "Kowalski");
            bank.AddUser(2, "Robert", "Wolny");
            bank.AddUser(3, "Piotr", "Szybki");
            bank.ShowListUserAccounts();
            //bank.ShowListUserCards();
            Console.ReadKey();
        }
    }
}
