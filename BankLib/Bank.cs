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
        public void AddUser(string firstName, string secondName)
        {
            Users.Add(new User(firstName, secondName));
        }
    }
}
