using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };
            var newWords = words.Select(x => new
            {
                Name = x,
                NameLength = x.Length
            }).OrderBy(x => x.NameLength);
            foreach (var item in newWords)
            {
                Console.WriteLine($"\'{item.Name}\' - длина слова {item.NameLength}");
            }
        }

     
    }
}

