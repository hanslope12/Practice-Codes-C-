using System;

namespace Permutations_and_Combinations
{
    class PermutationAndCombinations
    {
        static void Main(string[] args)
        {/* to find all the permutations
            for(int a = 1; a<=3; a++)
            {
                for (int b = 1; b <= 3; b++)
                {
                    for (int c = 1; c <= 3; c++)
                    {
                        Console.WriteLine(a.ToString() + b.ToString() + c.ToString());
                    }
                }
            }*/
            for (int a = 1; a <= 5; a++)

                /*{ this is for combinations
                    for(int b = 1; b<=5; b++)
                        if(b != a)
                        {
                            for(int c = 1; c<=5; c++)
                            if(c != b && c != a)
                                {
                                    if(a < b && b < c)
                                    Console.WriteLine(a.ToString() + b.ToString() + c.ToString());
                                }
                        }

                }*/
                Console.ReadKey();
        }
    }
}
