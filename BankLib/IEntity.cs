using System;
using System.Collections.Generic;
using System.Text;

namespace BankLib
{
    public interface IEntity
    {
        int Id { get; }
        int SetId();
    }
}
