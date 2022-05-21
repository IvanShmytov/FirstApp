using System;
using System.Diagnostics;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

namespace FirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 16, 47, 51, 77, 65 };
            Console.WriteLine(IsSorted(arr));
        }
        public static bool IsSorted(int[] array) 
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
	}
}

