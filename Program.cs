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
            
           PhoneBook phoneBook = new PhoneBook();
            phoneBook.addnumber("heba", 32412);
            phoneBook.addnumber("seraj", 4975);
            phoneBook.addnumber("serajii", 4945);

            Console.WriteLine(phoneBook.search("seraj")) ;

        }
    }
}

