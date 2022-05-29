using System;
using System.Collections.Concurrent;
using System.Threading;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
            List<string> peopList = new List<string>();
            foreach (var item in people)
            {
                bool qwe = item.StartsWith('А');
                if (qwe)
                {
                    peopList.Add(item);
                }
            }
            peopList.Sort();
            foreach (var item in peopList)
            {
                Console.WriteLine(item);
            }

        }

    }
}

