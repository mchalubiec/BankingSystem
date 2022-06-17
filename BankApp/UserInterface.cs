using System;

namespace BankApp
{
    internal class UserInterface
    {
        public static void Title(string title)
        {
            Console.WriteLine($"\n {title}");
        }
        public static void Description(string decs)
        {
            Console.WriteLine($"\n{decs}\n");
        }
        public static void MenuOption(int option, string content)
        {
            Console.WriteLine($"\t\t{content,20} : ({option})");
        }
        public static void Announcement(string content)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{content}");
            Console.ResetColor();
            PressEnter();
        }
        public static int GetInput(string prompt)
        {
            Console.Write($"\n\t\t{prompt, 20} :  ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void ClearScreen()
        {
            Console.Clear();
        }
        public static void PressEnter()
        {
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}