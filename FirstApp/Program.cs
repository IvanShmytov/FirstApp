using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();
            phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
            phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));
            AddUnique(new Contact("Иван", 79990000003, "ivan@example.com"), phoneBook);
        }
        static void AddUnique(Contact contact, List<Contact> phoneBook) 
        {
            foreach (var item in phoneBook)
            {
                if (item.Name == contact.Name) 
                {
                    Console.WriteLine("В телефонной книге уже есть этот контакт");
                    return;
                }
            }
            phoneBook.Add(contact);
            phoneBook.Sort((x, y) => string.Compare(x.Name, y.Name));
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Name + item.PhoneNumber);
            }       
        }
    }
    public class Contact 
    {
        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; }
        public long PhoneNumber { get; }
        public string Email { get; }
    }
}

