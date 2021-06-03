using System;

namespace FebonacciExample
{
    public class FebonacciExample
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            int len = 7;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
    
}
