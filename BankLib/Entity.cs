using System;
using System.Collections.Generic;
using System.Text;

namespace BankLib
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
        public abstract int SetId();
    }
}
