using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.ProtectedMembers
{
    internal class Account
    {
        protected double Balance { get; set; } //if we used private, constructor in class User can't accessed so we used protected or used public
    }

    class User : Account
    {
        public string AccNumber { get; set; }

        //complete the constructor
        public User(string accNumber, double balance)
        {
            AccNumber = accNumber;
            Balance = balance;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
