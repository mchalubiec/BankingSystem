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
            var user = new User("Jan", "Kowalski");
            var account = new Account(user);
            var card = new Card(1111, account);
            user.Accounts.Add(account);
            Display.DisplayProp(user);
            Display.DisplayProp(account);
            Display.DisplayProp(card);
            Console.ReadKey();
        }
    }
}
