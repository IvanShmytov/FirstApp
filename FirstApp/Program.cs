

class MainClass
{
	public static void Main(string[] args)
	{
        var arr = GetArrayFromConsole();
        int[] arrD;
        int[] arrAs;
        SortArray(in arr,out arrD, out arrAs);
	}
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
    static int[] SortArrayAsc(int[] arr)
    {
        int[] resasc;
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
        Console.WriteLine("\nСортировка по возрастанию");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        resasc = arr;
        return resasc;
    }
    static int[] SortArrayDesc(int[] arr)
    {
        int[] resdesc;
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > arr[i])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
        }
        Console.WriteLine("\nСортировка по убыванию");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        resdesc = arr;
        return resdesc;
    }
    static void SortArray(in int[] arr, out int[] sortdesc, out int[] sortasc) 
    {
        sortdesc = SortArrayDesc(arr);
        sortasc = SortArrayAsc(arr);
    
    }
}
