using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1
{
    internal class Program
    {
        delegate void d1 (int number);
        static bool isodd(int number) => (number % 2 == 1 || number %2==-1);
        static void displyy(List<int> numbers)
        {
            foreach (int number in numbers)
                if (isodd(number)) 
                    Console.WriteLine(number);
        } 
       
        static bool isnegative(int number) => (number < 0); 
        static void displynegative (List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (isnegative(number)) Console.WriteLine(number); 
            } 
        }
        
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3,10,-9, 20, 30, 40, 50 ,-3};
            displynegative(numbers);
            Console.WriteLine("===========");
            displyy(numbers);



        }
    }
}

