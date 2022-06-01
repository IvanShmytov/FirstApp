using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 7999945005 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };
            while (true)
            {
                Console.WriteLine("Введите номер страницы Вашего списка контактов, которую Вы хотите увидеть");
                var keyChar = Console.ReadKey().KeyChar;
                if (!Char.IsDigit(keyChar))
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                }
                else
                {
                    Console.Clear();
                    switch (keyChar)
                    {
                        case '1':
                            var page1 = contacts.Take(2);
                            ShowPage(page1);
                            break;
                        case '2':
                            var page2 = contacts.Skip(2).Take(2);
                            ShowPage(page2);
                            break;
                        case '3':
                            var page3 = contacts.Take(2);
                            ShowPage(page3);
                            break;
                        default:
                            Console.WriteLine("Вы ввели несуществующий номер страницы");
                            break;
                    }
                }
            }
        }
        public class Contact 
        {
            public string Name { get; set; }
            public long Phone { get; set; }
        }
        static void ShowPage(IEnumerable<Contact> page) 
        {
            foreach (var item in page)
            {
                Console.WriteLine(item.Name + " " + item.Phone);
            }
        }
    }
}

