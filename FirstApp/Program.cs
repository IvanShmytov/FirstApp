using System;

class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string Surname, string Login, int LoginLength, bool HavePet, string[] FavColors, int Age) User;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.Surname = Console.ReadLine();
            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;
            Console.WriteLine("Введите возраст пользователя");
            User.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            string answer = Console.ReadLine();
            if (answer == "Да")
            {
                User.HavePet = true;
            }
            else 
            {
                User.HavePet = false;
            }
            Console.WriteLine("Введите три любимых цвета пользователя");
            User.FavColors = new string[3];
            for (int j = 0; j < User.FavColors.Length; j++)
            {
                User.FavColors[j] = Console.ReadLine();
            }
        }
    }
}
