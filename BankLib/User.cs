using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLib
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public User(string firstName, string secondName)
        {
            Id = SetId();
            FirstName = firstName;
            SecondName = secondName;
        }
        public string GetFullName()
        {
            return $"{FirstName} {SecondName}";
        }
        public Account SetUpAccount()
        {
            return new Account(this);
        }
        public override int SetId()
        {
            if (!users.Any())
            {
                return 1;
            }
            return Users.Select(x => x.Id).Max() + 1;
        }
    }
}
