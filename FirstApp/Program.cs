using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
               new Department() {Id = 1, Name = "Программирование"},
               new Department() {Id = 2, Name = "Продажи"}
            };
            var employees = new List<Employee>()
            {
               new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
               new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
               new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
               new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var DepEmps = departments.GroupJoin(employees, d => d.Id, e => e.DepartmentId, (d, e) => new
            {
                Name = d.Name,
                Employees = e.Select(e => e.Name) 
            });
            foreach (var dep in DepEmps)
            {
                Console.WriteLine("Департамент " + dep.Name);
                foreach (var emp in dep.Employees)
                {
                    Console.WriteLine(emp);
                }
                Console.WriteLine();
            }
        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Завод - изготовитель
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }


}

