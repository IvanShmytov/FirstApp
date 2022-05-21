using System;
using System.IO;
namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Users\ivans\Desktop\cdev_Text.txt";
            string Text = File.ReadAllText(Path);
            char[] Dividers = new char[] { ' ', '\r', '\n', '\t' };
            string[] NumbOfWords = Text.Split(Dividers, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(NumbOfWords.Length);
        }
    }
}

