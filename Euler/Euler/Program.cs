using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1: Find the sum of all the multiples of 3 or 5 below 1000.
            int i = 0; //Counter
            int sum = 0;
            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0) //Checking if the current number is a multiple of 3 or 5
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine($"Problem 1: sum is {sum}");
        }
    }
}
