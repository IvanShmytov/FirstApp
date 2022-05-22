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
            string key;
            do
            {
                Console.WriteLine("Введите текст");
                string text = Console.ReadLine();
                var hSet = new HashSet<char>(text);
                Console.WriteLine("Символов всего " + hSet.Count);
                char[] symbols = new char[] { '.', ',', '!', '?', ' ' };
                hSet.ExceptWith(symbols);
                Console.WriteLine("Символов без знаков препинания " + hSet.Count);

                string numbers = null;
                for (int i = 0; i < 10; i++)
                {
                    numbers += i;
                }
                Console.WriteLine("В тексте есть цифры - " + hSet.Overlaps(numbers));
                Console.WriteLine("Желаете повторить?\nВведите \'Да\', чтобы продолжить");
                key = Console.ReadLine();
            } while (key == "Да");
        }
    }
}

