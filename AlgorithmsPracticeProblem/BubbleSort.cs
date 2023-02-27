using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPracticeProblem
{
    public class BubbleSort
    {
        public void BubbleSorting()
        {
            int[] a = { 30, 10, 20, 50, 60, 40, 80 };
            int b =0;
            for (int t = 0; t <= a.Length - 2; t++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        b = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = b;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array is :");
            foreach (int obj in a)
            { 
            Console.Write(obj+ " ");
        }
            Console.ReadLine();



        }
    }
}
