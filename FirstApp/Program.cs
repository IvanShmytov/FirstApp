using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string filePath = @"C:\Users\ivans\source\repos\FirstApp\FirstApp\Program.cs"; // Укажем путь 
        FileInfo fileinfo = new FileInfo(filePath);

        using (StreamWriter sw = fileinfo.AppendText()) 
        {
            sw.WriteLine(DateTime.Now);
        }
        using (StreamReader sr = fileinfo.OpenText())
        {
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
        }
    }

   
}


//18.04.2022 15:52:58
