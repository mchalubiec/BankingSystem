using System;
using System.Collections.Generic;
using System.Text;

namespace BankLib
{
    public class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Account Account { get; set; }
        public Card Card { get; set; }
        public User(string firstName, string secondName, Account account, Card card)
        {
            FirstName = firstName;
            SecondName = secondName;
            Account = account;
            Card = card;
        }
    }
}
