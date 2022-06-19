using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.UI
{
    class Utility
    {
        public static string GetUserInput(string prompt)
        {
            Console.Write($"\n\t\t{prompt,20} :  ");
            return Console.ReadLine();
        }
        public static void PressEnter()
        {
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }
    }
}
