using System;
using System.Collections.Generic;

namespace BankApp
{
    internal class State
    {
        protected Stack<State> states;
        protected bool end = false;
        public State(Stack<State> states)
        {
            this.states = states;
        }
        public virtual void UpdateState()
        {
        }
        public bool RequestEnd()
        {
            return end;
        }
    }
}