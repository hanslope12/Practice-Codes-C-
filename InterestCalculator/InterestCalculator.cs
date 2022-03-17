using System;

namespace InterestCalculator
{
    class InterestCalculator
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a principal");
            string principalInput = Console.ReadLine();
            Console.WriteLine("Enter a rate");
            string rateInput = Console.ReadLine();
            Console.WriteLine("Enter the number of years");
            string yearsInput = Console.ReadLine();
          
            double principal = double.Parse(principalInput);
            double rate = (double.Parse(rateInput)) / 100;
            double years = double.Parse(yearsInput);

            Console.WriteLine("Principal\tRate\tTime(Year)\tMoney");

            for (int i = 1; i <= years; i++)
            {
                Console.Write(principal);
                Console.Write("\t");
                Console.Write("\t");

                Console.Write(rate);
                Console.Write("\t");

                Console.Write(i);
                Console.Write("\t");
                Console.Write("\t");

                //CALCULATING THE NEW PRINCIPAL AFTER THE RATE
                double principalAdd = principal * rate;
                principal += principalAdd;

                Console.Write(principal);
                Console.Write("\t");
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
