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
            var months = new List<string>()
            {
                "Jan", "Feb", "Mar", "Apr", "May"
            };
            var missing = new ArrayList()
            {
                1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            //InsertMonths(missing, months);
            GetMissing(months, missing);
        }
        static void InsertMonths(ArrayList mixed, List<string> result)
        {
            foreach (var item in mixed)
            {
                if (item is string)
                {
                    result.Add((string)item);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        private static void GetMissing(List<string> months, ArrayList missing)
        {
            var missedArray = new string[7];
            missing.GetRange(4, 7).CopyTo(missedArray);
            months.AddRange(missedArray);
            foreach (var month in months)
                Console.WriteLine(month);
        }
    }
}

