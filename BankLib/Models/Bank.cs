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
        private List<User> users;
        public Bank(string name)
        {
            Name = name;
        }
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }
        public void AddUser(string firstName, string secondName)
        {
            Users.Add(new User(firstName, secondName));
        }
    }
}
