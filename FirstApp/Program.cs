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
            while (true)
            {
                Console.WriteLine("Введите число для добавления");
                var input = Console.ReadLine();
                var parsed = Int32.TryParse(input.ToString(), out int numb);
                if (!parsed)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы ввели не число");
                }
                else
                {
                    Numbs.Add(numb);
                    Console.WriteLine("Количество чисeл в списке " + Numbs.Count());
                    Console.WriteLine("Сумма чисел в списке " + Numbs.Sum());
                    Console.WriteLine("Наибольшее число в списке " + Numbs.Max());
                    Console.WriteLine("Наименьшее число в списке " + Numbs.Min());
                    Console.WriteLine("Среднее арифметическое чисел в списке " + Numbs.Average());
                }
            }
        }
    }
}

