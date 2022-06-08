using System;
using System.Collections.Generic;
using System.Text;

namespace BankLib
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public Card Card { get; set; }
        public User User { get; set; }
        public Account (string accountNumber, decimal accountBalance, Card card, User user)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            Card = card;
            User = user;
        }
    }
}
