using System;
using System.Collections.Generic;
using System.Text;

namespace BankLib
{
    public class Card
    {
        public long CardNumber { get; set; }
        public int CardPin { get; set; }
        public Card(long cardNumber, int cardPin)
        {
            CardNumber = cardNumber;
            CardPin = cardPin;
        }
    }
}
