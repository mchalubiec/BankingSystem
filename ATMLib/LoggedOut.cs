using System;
using System.Collections.Generic;
using System.Text;

namespace ATMLib
{
    internal class LoggedOut : IState
    {
        public ATM Context;
        public LoggedOut(ATM aTM)
        {
            Context = aTM;
        }
        public void Logout()
        {
            Console.WriteLine("musisz się zalogować najpierw!");
        }
        public void SignIn()
        {
            Console.WriteLine("zmieniłem stan z LoggedOut na Logged!");
            Context.SetState(new Logged(Context));
        }
    }
}
