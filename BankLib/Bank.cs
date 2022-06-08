using System;
using System.Collections.Generic;
using System.Text;

namespace BankLib
{
    public class Bank
    {
        public string Name { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public Bank (string name)
        {
            Name = name;
        }
    }
}
