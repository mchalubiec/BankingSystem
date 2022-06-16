using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib
{
    public class Account
    {
        private static int lastId = 0;
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; } = 0.00m;
        private List<Card> cards = new List<Card>();
        public List<Card> Cards
        {
            get
            {
                if (!cards.Any())
                {
                    Console.WriteLine("\t - there is no card");
                }
                return cards;
            }
            set { cards = value; }
        }
        public User User { get; set; }
        public Account(User user)
        {
            Id = lastId++;
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
    }
}
