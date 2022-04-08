﻿using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int num1 = 7;
        int num2 = -13;
        int num3 = 0;

        Console.WriteLine(num1.GetNegative()); //-7
        Console.WriteLine(num1.GetPositive()); //7
        Console.WriteLine(num2.GetNegative()); //-13
        Console.WriteLine(num2.GetPositive()); //13
        Console.WriteLine(num3.GetNegative()); //0
        Console.WriteLine(num3.GetPositive()); //0
    }
   
    
}
static class IntExtensions
{
    public static int GetNegative(this int source)
    {
        if (source > 0)
        {
            return -source;
        }
        else
        {
            return source;
        }
    }
    public static int GetPositive(this int source)
    {
        if (source < 0)
        {
            return -source;
        }
        else
        {
            return source;
        }
    }
}

