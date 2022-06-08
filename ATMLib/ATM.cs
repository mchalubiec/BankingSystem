using System;
using System.Collections.Generic;
using System.Text;

namespace ATMLib
{
    public class ATM : IState
    {
        IState State;
        public ATM()
        {
            State = new LoggedOut(this);
        }
        internal void SetState(IState currentState)
        {
            State = currentState;
        }
        public void SignIn()
        {
            Console.WriteLine("zalogowałem się z klasy ATM");
            State.SignIn();
        }
        public void Logout()
        {
            Console.WriteLine("wylogowałem się z klasy ATM");
            State.Logout();
        }
    }

}
