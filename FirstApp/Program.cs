using System;

class Program
{
	static void Main(string[] args)
	{
		User user = new User();
		user.Age = 13;
		Console.WriteLine(user.Age);
		Console.ReadKey();
	}
	class Circle
	{
		public double radius;

		public double Square()
		{
			return 3.14 * Math.Pow(radius, 2);
		}

		public double Length()
		{
			return radius * 3.14 * 2;
		}
	}

	class Triangle
	{
		private int a;
		public int b;
		public int c;

		public int A
		{
			get
			{
				return a;
			}
			set
			{
				if (value < 0 || value > b + c)
				{
					Console.WriteLine("Incorrect value");
				}
				else
				{
					a = value;
				}

			}
		}
		public int C
		{
			get
			{
				return c;
			}
			set
			{
				if (value < 0 || value > b + a)
				{
					Console.WriteLine("Incorrect value");
				}
				else
				{
					c = value;
				}

			}
		}
		public double Square()
		{
			return 2 * a * b;
		}

		public double Perimeter()
		{
			return a + b + c;
		}
	}

	class Square
	{
		public int side;

		public double SquareOfSquare()
		{
			return side * side;
		}

		public double Perimeter()
		{
			return side * 4;
		}
	}
	class TrafficLight 
	{
		private string color;
		private void ChangeColor(string color) { }
		public string GetColor() 
		{
			return color;
		}
	}
	class User
	{
		private int age;
		private string login;
		private string mail;
		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if (value < 18)
				{
					Console.WriteLine("Возраст должен быть не меньше 18");
				}
				else
				{
					age = value;
				}
			}
		}
	
		public string Login { get; private set; }
		public string Mail
		{
			get
			{
				return mail;
			}
			set
			{
				if (!value.Contains('@'))
				{
					Console.WriteLine("адрес почты должен содержать символ '@'");
				}
				else
				{
					mail = value;
				}
			}
		}
	}
}


