using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(7));
        }
        static long Factorial(int number)
        {
            List<int> numbs = new List<int>();
            for (int i = 1; i < number + 1; i++)
            {
                numbs.Add(i);
            }

            long result = numbs.Aggregate((x,y) => x * y);
            return result;
        }

    }
}

