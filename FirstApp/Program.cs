﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] text = { "Раз два три",
                               "четыре пять шесть",
                               "семь восемь девять" };
            var words = from element in text
                        from word in element.Split(' ')
                        select word;
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }

     
    }
}

