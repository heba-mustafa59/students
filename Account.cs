using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1
{
    internal class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account()
        {
            Balance = 0;
            Name = " ";
        }
        public Account(string name , double balance)
        {
            Name = name;
            Balance = balance;
        }

        public static double operator +(Account a, Account b)
        {
            return a.Balance + b.Balance;
        }
        public static double operator -(Account a, Account b)
        {
            return a.Balance - b.Balance;
        }
        public static Account operator ++(Account a)
        {
            a.Balance++;
            return a;
        }

        public static bool operator >(Account a,Account b)
        { 
             return (a.Balance > b.Balance);
        }
        public static bool operator <(Account a, Account b)
        {
            return (a.Balance < b.Balance);
        }
        public static bool operator ==(Account a, Account b)
        {
            return (a.Balance == b.Balance);
        }
        public static bool operator !=(Account a, Account b)
        {
            return (a.Balance != b.Balance);
        }
    }
}
