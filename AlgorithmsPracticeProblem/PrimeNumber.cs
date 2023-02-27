using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPracticeProblem
{
    public class PrimeNumber
    {
        public void PrimeNum(int min, int max)
        {
           
            Console.WriteLine("prime number is: ");
            for (int i = min; i <= max; i++)
            {
                bool IsPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }



    }
}
