using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int numtofizz = 3;
            int numtobuzz = 5;
            bool HasFizzedOrBuzzed = false;
            bool LastWasNum = false;
            for (int i = 1; i < 10000000; i++)
            {
                HasFizzedOrBuzzed = false;
                //Looks for fizz
                if (i % numtofizz == 0)
                {
                    Console.Write("Fizz");
                    HasFizzedOrBuzzed = true;
                    LastWasNum = false;
                }
                //Looks for buzz
                if (i % numtobuzz == 0)
                {
                    Console.Write("Buzz");
                    HasFizzedOrBuzzed = true;
                    LastWasNum = false;
                }
                //if has not fizzed or buzzed
                if (! HasFizzedOrBuzzed)
                {
                    if (! LastWasNum)
                    {
                        Console.Write("\n");
                    }
                    Console.WriteLine(i);
                    LastWasNum = true;
                }
            }
            Console.ReadKey();
        }
    }
}
