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
            int[] arr = new int[] { 1, 16, 47, 51, 77, 105 };
            Console.WriteLine(GetIndex(45, arr));
        }
        public static int GetIndex(int numb, int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > numb)
                {
                    return i;
                }
            }
            return array.Length;
        }
	}
}

