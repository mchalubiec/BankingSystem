using System;
using System.Collections.Generic;
using System.Text;

namespace ATMLib
{
    internal class Logged : IState
    {
        private ATM Context;
        public Logged(ATM aTM)
        {
            Context = aTM;
        }
        public void Logout()
        {
            Console.WriteLine("zmieniłem stan z Logged na LoggedOut");
            Context.SetState(new LoggedOut(Context));
        }
        public void SignIn()
        {

            Console.WriteLine("jesteś już zalogowany!"); ;
        }
    }
}
