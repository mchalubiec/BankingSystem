using System;
using System.Collections.Generic;
using System.Text;

namespace BankLib
{
    public interface IBank
    {
        List<User> Users { get; set; }
        List<Account> Accounts { get; set; }
        List<Card> Cards { get; set; }
    }
}
