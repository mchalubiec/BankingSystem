using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib
{
    public class Account
    {
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
        public void ShowCards()
        {
            foreach (var card in cards)
            {
                Console.WriteLine($"card number: {card.CardNumber}");
            }
        }
    }
}
