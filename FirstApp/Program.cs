using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = {1, 5, 11, 1, 1 };
            Console.WriteLine(Average(numbers));
        }
        static double Average(int[] numbers)
        {
            var result = numbers.Sum();
            return (double)result / numbers.Length;
        }
    }
}

