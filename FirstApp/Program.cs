using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace FirstApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] {1, 8, 15, 23, 47 };
            Console.WriteLine(BinarySearch(23, arr, 0, arr.Length - 1));
        }
        static int BinarySearch(int value, int[] array, int left, int right)
        {

            while (left <= right)
            {
                var middle = (left + right) / 2;

                var midElement = array[middle];

                if (midElement == value)
                {
                    return middle;
                }
                else if (value < midElement)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }

            }
            return -1;
        }

    }
}

