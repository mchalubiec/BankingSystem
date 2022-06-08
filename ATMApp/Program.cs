using ATMLib;
using System;

namespace ATMApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
