using System;

class MainClass
{
	public static void Main(string[] args)
	{
		string MyName = "Jane";
		byte Age = 27;
		bool Pet = true;
		double FootSize = 37.5;
		Console.WriteLine("My name is " + MyName);
		Console.WriteLine("I am " + Age + " years old");
		Console.WriteLine("Do I have a pet? " + Pet);
		Console.WriteLine("My shoe size is " + FootSize);
		Console.WriteLine("Minimum int {0}", int.MinValue);
		Console.WriteLine("Maximum int {0}", int.MaxValue);
		Console.WriteLine(Semaphore.Red);
		Console.ReadKey();
	}
}
enum Semaphore : int
{
	Green = 100,
	Yellow = 200,
	Red = 300
}