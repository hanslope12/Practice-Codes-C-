using System;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int fact = 1;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(fact);
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
