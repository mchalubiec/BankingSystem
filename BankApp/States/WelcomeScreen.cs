using BankLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class WelcomeScreen : State
    {
        protected List<User> users;
        public WelcomeScreen(Stack<State> states, List<User> _users) : base(states)
        {
            this.users = _users;
        }
        public void ProcessInput(int input)
        {
            switch (input)
            {
                case 0:
                    end = true;
                    break;
                case 1:
                    states.Push(new UserCreator(states, users));
                    break;
                case 2:

                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        public override void UpdateState()
        {
            UserInterface.Title("Electronic banking");
            UserInterface.Description(" Online banking is a form of services that banks offer.\n" +
                " It consists in allowing the customer to access his bank account via various electronic devices\n" +
                " and a telecommunications link.");
            UserInterface.MenuOption(1, "Create an user");
            UserInterface.MenuOption(2, "Sign In");
            UserInterface.Title("ATM");
            UserInterface.Description(" An ATM is a self-service, electronic telecommunications device that enables\n" +
                " the clients of a financial institution to make transactions, in particular cash withdrawals,\n" +
                " as well as deposits without the need for human service.");
            UserInterface.MenuOption(3, "Sign In");            
            ProcessInput(UserInterface.GetInput("Enter number"));
        }
    }
}
