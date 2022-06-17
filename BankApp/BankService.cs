using BankLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class BankService
    {
        private Bank bank;
        private bool end { get; set; }
        private Stack<State> states;
        public BankService()
        {
            InitiateVariables();
            InitiateBank();
            InitiateStates();
        }
        private void InitiateVariables()
        {
            end = false;
        }
        private void InitiateBank()
        {
            Bank _bank = new Bank("OB. open bank");
            bank = _bank;
            _bank.Users = new List<User>();
        }
        private void InitiateStates()
        {
            states = new Stack<State>();
            states.Push(new WelcomeScreen(states, bank.Users));
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
