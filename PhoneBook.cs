using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1
{
    internal class PhoneBook
    {
        string[] names;
        int[] numbers;
        int counter;

        public PhoneBook()
        {
            names = new string[10000];
            numbers = new int[10000];
        }
        public void addnumber(string name, int num)
        {
            names[counter]=name ;
            numbers[counter] = num;
            counter++;
        }
        public int search(string name)
        {
            for (int i = 0; i < names.Length; i++)
                if (names[i] == name) return numbers[i];
            return -1;
        }
    }
}
