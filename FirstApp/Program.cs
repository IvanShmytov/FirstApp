using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };
            var coarses = new List<Coarse>
            {
               new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
               new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };
            var CsharpStuds = from s in students   
                           where s.Age < 29 && s.Languages.Contains("английский")
                           let birthYear = DateTime.Now.Year - s.Age
                           from c in coarses
                           where c.Name == "Язык программирования C#"
                           select new 
                           {
                               Name = s.Name,
                               YearOfBirth = birthYear,
                               CoarseName = c.Name
                           };
            foreach (var item in CsharpStuds)
            {
                Console.WriteLine($"Студент {item.Name} {item.YearOfBirth} г.р. зачислен на курс \'{item.CoarseName}\'");
            }
        }
        public class Student 
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<string> Languages { get; set; }
        }
        public class Coarse
        {
            public string Name { get; set; }
            public DateTime StartDate { get; set; }
        }
    }
}

