using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите свое имя");
        string name = Console.ReadLine();
        Console.WriteLine("Ваше имя наоборот: ");
        for (int i = name.Length - 1; i >=0; i--) 
        {
            Console.Write(name[i]);
        }
    }
}
