using System;
using System.Runtime.Serialization.Formatters.Binary;
class MainClass
{
    delegate void ShowMessageDelegate(string _message);
    delegate int RandomNumberDelegate();
    public static void Main(string[] args)
    {
        ShowMessageDelegate showMessageDelegate = (string str) => Console.WriteLine(str);
        showMessageDelegate.Invoke("Hello World!");
        RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0,100);
        int result = randomNumberDelegate.Invoke();
        Console.WriteLine(result);
        Console.Read();
    }
 
}

