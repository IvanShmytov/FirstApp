using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[][] arr = new int[2][];
        arr[0] = new int []{ -5, 6, 9, 1, 2, -3 };
        arr[1] = new int[] { -8, 8, 1, 1, 2, -3 };
        int PosNum = 0;
        Console.WriteLine("Количество положительных чисел в двухмерном массиве: ");
        foreach (var item in arr)
        {
            foreach (var item2 in item)
            {
                Console.Write(item2 + " ");
                if (item2 > 0) 
                {
                    PosNum++;
                }
            }
            Console.WriteLine();
        }
        Console.Write("= " + PosNum);
    }
}
