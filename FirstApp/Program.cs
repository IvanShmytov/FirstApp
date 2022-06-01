using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            // Наш список студентов
            List<Student> students = new List<Student>
            {
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };
            var studApps = from s in students
                           where s.Age < 27
                           let yearOfBirth = DateTime.Now.Year - s.Age
                           select new Application
                           {
                               Name = s.Name,
                               YearOfBirth = yearOfBirth
                           };
            foreach (var item in studApps)
            {
                Console.WriteLine($"Студент \'{item.Name}\' - год рождения {item.YearOfBirth}");
            }
        }
        public class Application
        {
            public string Name { get; set; }
            public int YearOfBirth { get; set; }
        }
        public class Student 
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<string> Languages { get; set; }
        }
    }
}

