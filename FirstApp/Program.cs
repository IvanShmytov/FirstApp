class MainClass
{

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }

    static int[] SortArray(int[] arr) 
    {
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[i])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
        }
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        return arr;
    }

    public static void Main(string[] args)
    {
        int[] array = GetArrayFromConsole();
        SortArray(array);

    }
}
