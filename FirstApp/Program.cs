using System;

class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string Type, double Age, int NameCount) Pet;
        Console.WriteLine("Введите имя питомца");
        Pet.Name = Console.ReadLine();
        Console.WriteLine("Введите тип питомца");
        Pet.Type = Console.ReadLine();
        Console.WriteLine("Введите возраст питомца");
        Pet.Age = Convert.ToInt32(Console.ReadLine());
        Pet.NameCount = Pet.Name.Length;
        Console.WriteLine("Имя питомца: {0}\nТип питомца: {1}\nВозраст питомца: {2}\nДлинна имени питомца {3}", Pet.Name, Pet.Type, Pet.Age, Pet.NameCount);
    }
}
