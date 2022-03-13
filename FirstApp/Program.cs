using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 100, 0, -1, 5, -100, 14 };
        int PosNum = 0;
        foreach (var item in arr) 
        {
            if (item > 0) 
            {
                PosNum++;
            }
        }
        Console.Write("Количество положительных чисел в массиве {");
        foreach (var item in arr) 
        {
            Console.Write(item + " ");
        }
        Console.Write("} - " + PosNum);
    }
}
