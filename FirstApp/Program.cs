using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(PowerUp(2,5));

    }

    private static int PowerUp(int num, byte pow) 
    {
        if (pow == 0)
        {
            return 1;
        }
        else if (pow == 1)
        {
            return num;
        }
        else
        {
            return num * PowerUp(num, --pow);
        }
    
    }
}


