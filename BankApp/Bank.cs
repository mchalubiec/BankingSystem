using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Bank
    {
        private bool end { get; set; }
        private Stack<State> states;
        public Bank()
        {
            InitiateVariables();
            InitiateStates();
        }
        private void InitiateVariables()
        {
            end = false;
        }
        private void InitiateStates()
        {
            states = new Stack<State>();
            states.Push(new WelcomeScreen(states));
        }
        public void Run()
        {
            while (states.Count > 0)
            {
                UserInterface.ClearScreen();
                states.Peek().UpdateState();
                if (states.Peek().RequestEnd())
                {
                    states.Pop();
                }
            }
        }
    }
}
