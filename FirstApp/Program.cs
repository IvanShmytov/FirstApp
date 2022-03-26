using System;

class Program
{
    static void Main(string[] args)
    {
        var example = GetInfo();
        ShowInfo(example);
    }

    static (string Name, string Surname, int Age, string[] Pets, string[] FavColors) GetInfo()
    {
        (string Name, string Surname, int Age, string[] Pets, string[] FavColors) Info;
        Console.WriteLine("Введите имя");
        Info.Name = Console.ReadLine();
        Console.WriteLine("Введите фамилию");
        Info.Surname = Console.ReadLine();
        string age;
        int intage;
        do
        {
            Console.WriteLine("Введите возраст цифрами");
            age = Console.ReadLine();

        } while (CheckNum(age, out intage) == false || intage == 0);
        Info.Age = intage;

        Console.WriteLine("У вас есть питомцы? (да/нет)");
        string HavePets = Console.ReadLine();
        if (HavePets == "да" || HavePets == "Да")
        {
            string PetNum;
            int IntPetNum;
            do
            {
                Console.WriteLine("Сколько питомцев вы держите?\n(введите число)");
                PetNum = Console.ReadLine();

            } while (CheckNum(PetNum, out IntPetNum) == false || IntPetNum == 0);
            Info.Pets = new string[IntPetNum];
            Console.WriteLine("Введите клички ваших питомцев:");
            Info.Pets = CreateArray(IntPetNum);
        }
        else
        {
            Info.Pets = new string[1];
            Info.Pets[0] = "У пользователя нет питомцев";
        }

        string ColNum;
        int IntColNum;
        do
        {
            Console.WriteLine("Сколько у вас любимых цветов?\n(введите число)");
            ColNum = Console.ReadLine();

        } while (CheckNum(ColNum, out IntColNum) == false || IntColNum == 0);
        Console.WriteLine("Введите ваши любимые цвета:");
        Info.FavColors = CreateArray(IntColNum);
        return Info;
    }
    static void ShowInfo((string Name, string Surname, int Age, string[] Pets, string[] FavColors) Info) 
    {
        Console.WriteLine($"\tИнформация о пользователе\nИмя пользователя: {Info.Name}\nФамилия пользователя: {Info.Surname}\nВозраст пользователя: {Info.Age}\nКлички питомцев пользователя:");
        if (Info.Pets.Length > 1)
        {
            foreach (var item in Info.Pets)
            {
                Console.WriteLine(item);
            }
        }
        else 
        {
            Console.WriteLine(Info.Pets[0]);
        }
        Console.WriteLine("Любимые цвета пользователя:");
        foreach (var item in Info.FavColors)
        {
            Console.WriteLine(item);
        }
    }
    static bool CheckNum(string number, out int cornumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            cornumber = intnum;
            return true;
        }
        else
        {
            cornumber = 0;
            return false;
        }
    }
    static string[] CreateArray(int num)
    {
        string[] result = new string[num];
        for (int i = 0; i < num; i++)
        {
            result[i] = Console.ReadLine();
        }
        return result;
    }
}


