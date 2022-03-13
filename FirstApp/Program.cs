using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите свое имя");
        string name = Console.ReadLine();
        Console.WriteLine("Ваше имя по буквам:");
        foreach (var item in name) 
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);
    }
}
