using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Подсчитайте, 1сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
            var hSet = new HashSet<char>(text);
            Console.WriteLine("Символов всего " + hSet.Count);
            char[] symbols = new char[] {'.', ',', '!', '?', ' ' };
            hSet.ExceptWith(symbols);
            Console.WriteLine("Символов без знаков препинания " + hSet.Count);

            //foreach (var item in hSet)
            //{
            //    if (char.IsDigit(item)) 
            //    {
            //        Console.WriteLine("В тексте есть цифры");
            //        break;
            //    }
            //}

            string numbers = null;
            for (int i = 0; i < 10; i++)
            {
                numbers += i;
            }
            Console.WriteLine("В тексте есть цифры - " + hSet.Overlaps(numbers));
        }
    }
}

