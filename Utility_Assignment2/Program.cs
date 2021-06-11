using System;

namespace Utility_Assignment2
{
    class Utility
    {
        public void EvenOdd(int a)
        {
            if (a / 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number id Odd");
            }
        }

        public void Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
        }
        
    }
}
