using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {

            ShowCommonLetters();
            //ShowUnicSymbols();
        }
        static void ShowCommonLetters() 
        {
            Console.WriteLine("Введите 1 слово");
            string word1 = Console.ReadLine();
            Console.WriteLine("Введите 2 слово");
            string word2 = Console.ReadLine();
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
            {
                Console.WriteLine("Вы ввели пустой текст");
                return;
            }
            var comLetters = word1.Intersect(word2).ToArray();
            Console.WriteLine("Общие буквы");
            foreach (var item in comLetters)
            {
                Console.WriteLine(item);
            }
        }
        static void ShowUnicSymbols() 
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Вы ввели пустой текст");
                return;
            }
            string punct = ".,!?;: ";
            var result = text.Except(punct).ToArray();
            Console.WriteLine("Уникальные символы в тексте");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}

