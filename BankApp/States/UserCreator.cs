using BankLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class UserCreator : State
    {
        protected List<User> users;
        public UserCreator(Stack<State> states, List<User> _users) : base(states)
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
                    UserInterface.Announcement("User created");
                    users.Add(new User("Jan", "Kowalski"));
                    users.Add(new User("Robert", "Wolny"));
                    users.Add(new User("Anna", "Teraz"));
                    break;
                case 2:
                    foreach (var item in users)
                    {
                        Console.WriteLine(item.GetFullName());
                    }
                    UserInterface.PressEnter();
                    break;
                default:
                    break;
            }
        }
        public override void UpdateState()
        {
            UserInterface.MenuOption(1, "Add users");
            UserInterface.MenuOption(2, "Show list users");
            ProcessInput(UserInterface.GetInput("Enter number"));
        }
    }
}
