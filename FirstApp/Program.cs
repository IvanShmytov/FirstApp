using System;
using System.Runtime.Serialization.Formatters.Binary;
class MainClass
{
    public static void Main(string[] args)
    {
        Exception exc = new Exception("My exception");
        exc.Data.Add("Дата создания исключения", DateTime.Now);
        exc.HelpLink = "www.google.com";
        try
        {
            Console.WriteLine("Блок Try начал работу");
            throw new RankException();
            throw new ArgumentOutOfRangeException();
        }
        catch (RankException ex) 
        {
            Console.WriteLine($"Тип исключения {ex.GetType()}");
        }

        catch (Exception ex) when (ex is ArgumentOutOfRangeException)
        {
            Console.WriteLine(ex.Message);
        }

        finally
        {
            Console.WriteLine("Блок Finally сработал!");
        }

        Console.ReadKey();
    }
}

