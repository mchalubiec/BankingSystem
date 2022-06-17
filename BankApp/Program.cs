using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankService = new BankService();
            bankService.Run();
        }
    }
}
