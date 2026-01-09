using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManageApp
{
    internal class BankAccount
    {
        public string Name { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
