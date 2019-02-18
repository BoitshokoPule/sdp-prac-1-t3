using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static bool CheckIfPrime(int a)
        {
            int x = 2;
            int y = 0;
            if (a == 1 || a == 0)
            {
                return false;
            }
            while (x < a)
            {
                y = a % x;
                if (y == 0)
                {
                    return false;
                }
                x++;
            }
            return true;
        }
        static void Main (string [] args)
        {
           
            double PrimePosition = 10001;
            int counter = 0;
            double j = 0;
            while (true)
            {
                if (CheckIfPrime(counter))
                {
                    j++;
                }
                if (j == PrimePosition)
                {
                    break;
                }
                counter++;
            }
           Console.WriteLine($"The answer is: {counter}");
        }

    }
}
    
