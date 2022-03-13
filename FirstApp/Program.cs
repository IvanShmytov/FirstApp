using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        int temp;
        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
            {
                for (int k = j + 1; k < arr.GetUpperBound(1) + 1; k++)
                {
                    if (arr[i,j] > arr[i,k])
                    {
                        temp = arr[i,k];
                        arr[i,k] = arr[i,j];
                        arr[i,j] = temp;
                    }
                }
            }
        }
        Console.WriteLine("Отсортированный двухмерный массив { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } }:");
        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
            {
                Console.Write(arr[i,k] + " ");
            }
            Console.WriteLine();
        }
    }
}
