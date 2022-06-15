using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib
{
    public class Bank
    {
        public string Name { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public Bank()
        {
        }
        public void AddUser(string firstName, string secondName)
        {
            Users.Add(new User(firstName, secondName));
        }
        public void AddAccount()
        {
            //Users.Select(x => x.SetUpAccount());
        }
        public void ShowListUsers()
        {
            Console.WriteLine("Bank users list");
            foreach (var user in Users)
            {
                Console.WriteLine($"- {user.GetFullName()} (identification : {user.Id})");
            }
        }
        public void ShowListUserAccounts()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"# list accounts for {user.GetFullName()}");
                user.GetListAccounts();
                foreach (var account in user.Accounts)
                {
                    Console.WriteLine($"\t - account number: {account.AccountNumber}");
                }
                //user.ShowAccounts();
            }            
        }
    }
}
