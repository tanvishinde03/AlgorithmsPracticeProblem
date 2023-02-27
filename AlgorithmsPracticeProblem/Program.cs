using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Option");
            Console.WriteLine("1.Insertion Sort");
            Console.WriteLine("2.Bubble Sort");
            Console.WriteLine("3.Prime Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    InsertionSort sort = new InsertionSort();
                    sort.Sort();
                    break;
                case 2:
                    BubbleSort obj = new BubbleSort();
                    obj.BubbleSorting();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.PrimeNum(0,1000);
                    break;



            }
        }
    }
}