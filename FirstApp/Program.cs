using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.Write("Enter your name: ");
		var name = Console.ReadLine();
		Console.Write("Enter your age: ");
		var age = checked ((byte) int.Parse(Console.ReadLine()));
		Console.WriteLine("Your name is {0} and your age is {1}", name, age);
		Console.Write("What is your favourite day of week? ");
		var FavDay = checked((Week)int.Parse(Console.ReadLine()));
		Console.WriteLine($"Your favourite day of week is {FavDay}");
		Console.ReadKey();
	}
}
enum Week : byte
{
	Monday = 1,
	Tuesday = 2,
	Wednesday = 3,
	Thursday = 4,
	Friday = 5,
	Saturday = 6,
	Sunday = 7
}