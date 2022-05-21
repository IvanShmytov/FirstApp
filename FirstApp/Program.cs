using System;
using System.IO;
using System.Collections;
namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = new[]
            {
               "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            var numbers = new[]
            {
               1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
            };
            var ArrL = new ArrayList();
            foreach (var number in numbers)
            {
                ArrL.Add(months[number - 1]);
                ArrL.Add(number);
            }
            foreach (var item in ArrL)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var NewArrl = new ArrayList()
            {
                1,
                "Андрей ",
                "Сергей ",
                300,
            };
            var Result = ArrListConvert(NewArrl);
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }
        static ArrayList ArrListConvert( ArrayList Input) 
        {
            int numbers = 0;
            string text = "";
            foreach (var item in Input)
            {
                if (item is int) 
                {
                    numbers += (int) item;
                }
                if (item is string)
                {
                    text += item;
                }
            }
            ArrayList Output = new ArrayList() { numbers, text };
            return Output;
        }
    }
}

