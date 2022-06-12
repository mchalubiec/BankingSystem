using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib
{
    public class Bank : IBank
    {
        public string Name { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        private List<Account> accounts = new List<Account>();
        public List<Account> Accounts
        {
            get
            {
                if (!accounts.Any())
                {
                    Console.WriteLine("\tuser does not have an accounts created");
                }
                return accounts;
            }
            set { accounts = value; }
        }
        private List<Card> cards = new List<Card>();
        public List<Card> Cards
        {
            get
            {
                if (!cards.Any())
                {
                    Console.WriteLine("\tuser does not have any card in any account");
                }
                return cards;
            }
            set { cards = value; }
        }
        public Bank (string name)
        {
            Name = name;
        }
        public void AddUser(string firstName, string secondName)
        {
            Users.Add(new User(firstName, secondName));
        }
        public void ShowListUsers()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"{user.GetFullName()} - user id: {user.Id}");
            }
        }
        public void AddAccount(int currentUserId)
        {
            Accounts.Add(Users.First(x => x.Id == currentUserId).SetUpAccount());
        }
        public void ShowListAccounts()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"List accounts {user.GetFullName()}");
                foreach (var account in Accounts.Where(x => x.User == user))
                {
                    Console.WriteLine($"\taccount number: {account.AccountNumber}");
                    Console.WriteLine($"\taccount balance: {account.AccountBalance}");
                }
            }            
        }
        public void AddCard(int currentUserId)
        {
            Cards.Add(Accounts.First(x => x.Id == currentUserId).SetUpCard(1111));
        }
    }
}
