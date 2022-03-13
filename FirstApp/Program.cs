using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Сортировка массива { 5, 6, 9, 1, 2, 3, 4}:");
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.Write("\nСумма элементов массива { 5, 6, 9, 1, 2, 3, 4 }: ");
        var arr2 = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int sum = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            sum += arr2[i];
        }
        Console.WriteLine(sum);
        Console.WriteLine("Отображение зубчатого массива:");
        int[][] arr3 = new int[3][];
        arr3[0] = new int[2] { 1, 2 };
        arr3[1] = new int[3] { 1, 2, 3 };
        arr3[2] = new int[5] { 1, 2, 3, 4, 5 };
        foreach (var item in arr3) 
        {
            foreach (var item2 in item) 
            {
                Console.Write(item2 + " ");
            }
            Console.WriteLine();
        }
    }
}
