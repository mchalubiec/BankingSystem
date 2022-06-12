using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib
{
    public class Account : Entity
    {
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; } = 0.00m;
        public User User { get; set; }
        public Account(User user)
        {
            AccountNumber = CreateAccountNumber();
            AccountBalance = 0.00m;
            User = user;
        }
        private string CreateAccountNumber()
        {
            string newAccountNumber = "";
            for (int i = 0; i < 24; i++)
            {
                newAccountNumber += new Random().Next(1, 10).ToString();
            }
            return newAccountNumber;
        }
        public Card SetUpCard(int cardPin)
        {
            return new Card(cardPin, this);
        }
        public override int SetId()
        {
            throw new NotImplementedException();
        }
    }
}
