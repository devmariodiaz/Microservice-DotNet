using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Domain
{
    public class Account
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public AccountType AccountType { get; set; }

    }
}
