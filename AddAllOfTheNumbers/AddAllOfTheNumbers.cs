using System;

namespace AddAllOfTheNumbers
{
    class AddAllOfTheNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers you would like to add as you count by. \n");

            Console.WriteLine("Enter the smaller number");
            string firstNumb = Console.ReadLine();
            Console.WriteLine("Enter the bigger number");
            string secondNumb = Console.ReadLine();

            int a = int.Parse(firstNumb);
            int b = int.Parse(secondNumb);
            int sum=0;
            for (int i =a; i <= b; i++)
            {
                
                Console.WriteLine(($"Number is {i}"));
               
                Console.WriteLine(($" add{i} + {sum} = {sum+i}"));
                sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
