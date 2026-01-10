using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManageApp
{
    public class BankAccount //Class namely bankAcoount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public BankAccount(string owner) //Constructor is created
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;    

        }
    }
}
