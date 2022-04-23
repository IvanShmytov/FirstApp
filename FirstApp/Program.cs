using System;
using System.Runtime.Serialization.Formatters.Binary;
class MainClass
{
    public static void Main(string[] args)
    {
        Exception exc = new Exception("My exception");
        exc.Data.Add("Дата создания исключения", DateTime.Now);
        exc.HelpLink = "www.google.com";
    }   
}

