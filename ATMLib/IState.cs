using System;
using System.Collections.Generic;
using System.Text;

namespace ATMLib
{
    internal interface IState
    {
        void SignIn();
        void Logout();
    }
}
