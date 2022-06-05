using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            //var groupedBook = phoneBook.GroupBy(c => c.Email.Split('@').Last());
            var groupedBook = (from c in phoneBook
                               let fake = c.Email.Contains("example")
                               select new
                               {
                                   Name = c.Name,
                                   Phone = c.Phone,
                                   Email = c.Email,
                                   Fake = fake
                               }).GroupBy(c => c.Fake);

            foreach (var group in groupedBook)
            {
                if (group.Key)
                {
                    Console.WriteLine("Фейковые емейлы:");
                    foreach (var item in group)
                    {
                        Console.WriteLine(item.Name + "  " + item.Email);
                    }
                }
                else
                {
                    Console.WriteLine("Реальные емейлы:");
                    foreach (var item in group)
                    {
                        Console.WriteLine(item.Name + "  " + item.Email);
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Contact
    {
        public Contact(string name, long phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        public string Name { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
    }
}

