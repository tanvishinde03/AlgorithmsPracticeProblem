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
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    InsertionSort sort = new InsertionSort();
                    sort.Sort();
                    break;





            }
        }
    }
}