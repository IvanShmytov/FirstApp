using System;
using System.Collections.Generic;

namespace StackTest
{
    class Program
    {
        public static Stack<string> words = new Stack<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();
            string key;
            while (true)
            {
                var input = Console.ReadLine();
                Console.WriteLine("Введите команду:\nPush\nPop\nPeek");
                key = Console.ReadLine();
                switch (key)
                {
                    case("Push"): 
                        words.Push(input);
                        break;
                    case ("Pop"):
                        words.TryPop(out string popresult);
                        break;
                    case ("Peek"):
                        Console.WriteLine(words.TryPeek(out string peekresult));
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }
    }
}
        

    