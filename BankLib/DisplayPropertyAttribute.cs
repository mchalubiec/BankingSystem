using System;
using System.Collections.Generic;
using System.Text;

namespace BankLib
{
    public class DisplayPropertyAttribute : Attribute
    {
        public string DisplayName { get; set; }
        public DisplayPropertyAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }
}
