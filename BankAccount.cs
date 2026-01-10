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
        //public decimal Balance { get; set; }
        //Applying encapsulatrion for balance
        public decimal Balance { get; private set; }
        public BankAccount(string owner) //Constructor is created
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;    

        }
        //so to chnage balance there are some rule to be followed thats why encapsulation
        public string Deposit(decimal amount) {
            if (amount <= 0)
            {
                return "You can not deposit $" + amount;
            }
            if(amount> 2000)
            {
                return "Deposit limit reached";
            }
            Balance += amount;
            return "Deposit ompleted successfully"; 
        }
        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can not withdraw $" + amount;
            }
            if (amount > Balance)
            {
                return "You dont have enough money";
            }
            Balance -= amount;
            return "Withdraw ompleted successfully";
        }
    }
}
