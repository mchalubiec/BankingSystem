using System;
using System.Collections.Generic;
using System.Text;

namespace BankLib
{
    public class Card
    {
        private static int lastId = 0;
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public int CardPin { get; set; }
        public Account Account { get; set; }
        public Card(int cardPin, Account account)
        {
            Id = lastId++;
            CardNumber = CreateCardNumber();
            CardPin = cardPin;
            Account = account;
        }
        private string CreateCardNumber()
        {
            string newCardNumber = "";
            for (int i = 0; i < 16; i++)
            {
                newCardNumber += new Random().Next(1, 10).ToString();
            }
            return newCardNumber;
        }
    }
}
