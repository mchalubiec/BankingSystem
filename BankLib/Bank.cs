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
        public void AddUser(int id, string firstName, string secondName)
        {
            Users.Add(new User(id, firstName, secondName));
        }
        public void AddAccount()
        {
            Users.Select(x => x.SetUpAccount());
        }
        public void ShowUsers()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"# {user.Id}, full name {user.GetFullName()}");
            }
        }
        public void ShowListUserAccounts()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"# list accounts for {user.GetFullName()}");
                user.ShowAccounts();
            }            
        }
        public void ShowListUserCards()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"# list cards for {user.GetFullName()}");
                user.Accounts.First(x => x.User.Id == user.Id).ShowCards();
            }
        }
    }
}
