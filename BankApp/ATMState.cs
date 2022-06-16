using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class ATMState : State
    {
        public ATMState(Stack<State> states) : base(states)
        {
        }
        public override void UpdateState()
        {
            Console.Write("Enter number: (ATM)");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput <= 0)
            {
                end = true;
            }
        }
    }
}
