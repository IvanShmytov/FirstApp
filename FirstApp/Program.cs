using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> Numbs = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                Numbs.Add(i);
            }
            var result = Numbs.Where(n => n % 2 == 0).ToArray();
            Numbs.Add(10);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

