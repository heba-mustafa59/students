using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          Account a1 = new Account();
            a1.Name = "Heba";
            a1.Balance= 100;

            Account a2 = new Account();
            a2.Name = "huda";
            a2.Balance= 100;
             
            
            Console.WriteLine(a1>a2);

        }
    }
}

