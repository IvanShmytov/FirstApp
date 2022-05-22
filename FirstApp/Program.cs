using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
namespace CountWords
{
    class Program
    {
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };
        static void Main(string[] args)
        {
            WriteAllContacts();
            PhoneBook.Add("Иван", new Contact(79990000003, "ivan@example.com"));
            WriteAllContacts();
            if (PhoneBook.TryGetValue("Иван", out Contact contact))
            {
                contact.PhoneNumber = 123456789;
            }
            WriteAllContacts();
        }
        static void WriteAllContacts() 
        {
            Console.WriteLine("Список ваших контактов");
            foreach (var contact in PhoneBook)
            {
                Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
            }
            Console.WriteLine();
        }
    }
    public class Contact 
    {
        public Contact(long phoneNumber, String email) 
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public long PhoneNumber { get; set; }
        public String Email { get; }
    }
}

