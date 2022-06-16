using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib
{
    public class User
    {
        private static int lastId = 0;
        public int Id { get; set; }
        private string FirstName { get; set; }
        private string SecondName { get; set; }
        private string email { get; set; }
        private string mobilePhone { get; set; }
        private Address addres { get; set; }
        private 
        private bool isLogged { get; set; }

        private List<Account> accounts = new List<Account>();
        public List<Account> Accounts
        {
            get
            {
                if (!accounts.Any())
                {
                    Console.WriteLine($"\t - no accounts created");
                }
                return accounts;
            }
            set { accounts = value; }
        }
        public User(string firstName, string secondName)
        {
            Id = lastId++;
            FirstName = firstName;
            SecondName = secondName;
        }
        public string GetFullName()
        {
            return $"{FirstName} {SecondName}";
        }
    }
}
